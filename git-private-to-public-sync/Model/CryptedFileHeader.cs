using System;

namespace gitsync.Model
{
  public class CryptedFileHeader
  {
    public string Salt { get; set; }
    public string Hash { get; set; }

    public CryptedFileHeader(ref byte[] data)
    {
      var salt = new byte[16];
      var hash = new byte[64];

      for (var i = 0; i < salt.Length; i++)
        salt[i] = data[i];

      for (var i = 16; i < 80; i++)
        hash[i - 16] = data[i];

      Salt = new Guid(salt).ToString("N");
      Hash = Convert.ToBase64String(hash);
    }
  }
}
