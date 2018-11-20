using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace gitsync.Helper
{
  public static class FileCopyCryptHelper
  {
    private static CryptoMode _mode = CryptoMode.None;
    private static ICryptoTransform _enc;
    private static ICryptoTransform _dec;

    public enum CryptoMode
    {
      None,
      Encrypt,
      Decrypt
    }

    public static void SetCryptoMode(CryptoMode mode, string password)
    {
      _mode = mode;
      if (mode == CryptoMode.None)
        return;
      var rijndael = GenerateRijndael(password);
      _enc = rijndael.CreateEncryptor();
      _dec = rijndael.CreateDecryptor();
    }

    public static void Copy(string source, string destination)
    {
      switch (_mode)
      {
        case CryptoMode.None:
          CopyNormal(source, destination);
          break;
        case CryptoMode.Encrypt:
          if (Path.GetExtension(source).ToLower() == ".aes")
            CopyNormal(source, destination);
          else
            CopyEncrypt(source, destination);
          break;
        case CryptoMode.Decrypt:
          if (Path.GetExtension(source).ToLower() != ".aes")
            CopyNormal(source, destination);
          else
            CopyDecrypt(source, destination);
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    private static void CopyEncrypt(string source, string destination)
    {
      try
      {
        var data = File.ReadAllBytes(source);
        File.WriteAllBytes(destination, _enc.TransformFinalBlock(data, 0, data.Length));
      }
      catch
      {
        // ignore
      }
    }

    private static void CopyDecrypt(string source, string destination)
    {
      try
      {
        var data = File.ReadAllBytes(source);
        File.WriteAllBytes(destination, _dec.TransformFinalBlock(data, 0, data.Length));
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

    public static RijndaelManaged GenerateRijndael(string password)
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
  }
}
