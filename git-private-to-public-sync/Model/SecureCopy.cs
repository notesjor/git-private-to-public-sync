using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace gitsync.Model
{
  public static class SecureCopy
  {
    public static string Password { get; private set; } = "";
    public static CryptoMode Mode { get; private set; } = CryptoMode.None;

    public static void SaveCryptoStatus(string directory, CryptoMode mode, string password)
    {
      Mode = mode;
      Password = password;

      try
      {
        EnsureGitRepository(directory);
        var path = Path.Combine(directory, ".git/password.sync");
        switch (mode)
        {
          case CryptoMode.None:
            File.Delete(path);
            break;
          case CryptoMode.Encrypt:
            File.WriteAllLines(path, new[] { "ENC", password }, Encoding.UTF8);
            break;
          case CryptoMode.Decrypt:
            File.WriteAllLines(path, new[] { "DEC", password }, Encoding.UTF8);
            break;
          default:
            throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
        }
      }
      catch
      {
        // ignore
      }
    }

    public static void LoadCryptoStatus(string directory)
    {
      Mode = CryptoMode.None;
      Password = "";

      try
      {
        EnsureGitRepository(directory);
        var path = Path.Combine(directory, ".git/password.sync");
        if (!File.Exists(path))
          return;

        var lines = File.ReadLines(path, Encoding.UTF8).ToArray();
        if (lines.Length < 2)
          return;
        if (lines[0] == "ENC")
        {
          Mode = CryptoMode.Encrypt;
          Password = lines[1];
          return;
        }

        if (lines[0] == "DEC")
        {
          Mode = CryptoMode.Decrypt;
          Password = lines[1];
        }
      }
      catch
      {
        // ignore
      }
    }

    private static void EnsureGitRepository(string directory)
    {
      var dir = Path.Combine(directory, ".git/");
      if (!Directory.Exists(dir))
        Directory.CreateDirectory(dir);
    }

    public static void Copy(string source, string destination)
    {
      try
      {
        switch (Mode)
        {
          case CryptoMode.None:
            CopyNormal(source, destination);
            break;
          case CryptoMode.Encrypt:
            if (new FileInfo(source).Length < 1)
              return;
            else if (Path.GetExtension(source).ToLower() == ".aes")
              CopyNormal(source, destination);
            else
              CopyEncrypt(source, destination + ".aes");
            break;
          case CryptoMode.Decrypt:
            if (Path.GetExtension(source).ToLower() != ".aes")
              CopyNormal(source, destination);
            else
              CopyDecrypt(source, destination.Substring(0, destination.Length - 4));
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
      }
      catch
      {
        // ignore
      }
    }

    private static void CopyNormal(string source, string destination)
    {
      try
      {
        File.Copy(source, destination, true);
      }
      catch (IOException)
      {
        // ignore
      }
    }

    private static void CopyEncrypt(string source, string destination)
    {
      var data = File.ReadAllBytes(source);
      var hash = CalculateHash(ref data);
      if (File.Exists(destination))
      {
        var dest = new byte[80];
        using (var fs = new FileStream(destination, FileMode.Open, FileAccess.Read))
          fs.Read(dest, 0, dest.Length);
        var head = new CryptedFileHeader(ref dest);

        if (head.Hash == Convert.ToBase64String(hash))
          return;
      }

      using (var fs = new FileStream(destination, FileMode.Create, FileAccess.Write))
      {
        var salt = Guid.NewGuid();
        var buffer = salt.ToByteArray();

        fs.Write(buffer, 0, buffer.Length);
        fs.Write(hash, 0, hash.Length);

        using (var crypter = GenerateRijndael($"{salt:N}{Password}").CreateEncryptor())
          buffer = crypter.TransformFinalBlock(data, 0, data.Length);

        fs.Write(buffer, 0, buffer.Length);
      }
    }

    private static void CopyDecrypt(string source, string destination)
    {
      var data = File.ReadAllBytes(source);
      var head = new CryptedFileHeader(ref data);
      if (File.Exists(destination))
      {
        var dest = File.ReadAllBytes(destination);
        if (head.Hash == Convert.ToBase64String(CalculateHash(ref dest)))
          return;
      }

      using (var crypter = GenerateRijndael($"{head.Salt}{Password}").CreateDecryptor())
        File.WriteAllBytes(destination, crypter.TransformFinalBlock(data, 80, data.Length - 80));
    }

    private static RijndaelManaged GenerateRijndael(string password)
    {
      byte[] hash;
      var res = new RijndaelManaged();
      using (var sha = SHA512.Create())
      {
        hash = sha.ComputeHash(Encoding.ASCII.GetBytes(password));
      }

      var buffer = new byte[32];
      for (var i = 0; i < 32; i++)
        buffer[i] = hash[i];

      res.Key = buffer;
      buffer = new byte[16];
      for (var i = 32; i < 48; i++)
        buffer[i - 32] = hash[i];

      res.IV = buffer;
      return res;
    }

    private static byte[] CalculateHash(ref byte[] data)
    {
      using (var sha = SHA512.Create())
        return sha.ComputeHash(data);
    }
  }
}