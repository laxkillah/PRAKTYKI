using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public class Crypto
    {
        Aes aes = new AesCryptoServiceProvider();

        private int BlockSize = 128;
        public void Encrypt(RichTextBox textBox, TextBox passwordBox)
        {
            
            if (passwordBox.Text == "") return;
            byte[] bytes = Encoding.Unicode.GetBytes(textBox.Text);
            //Encrypt
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm sha256Hash = SHA256.Create();
            crypt.BlockSize = BlockSize;
            crypt.Key = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(passwordBox.Text));
            aes.GenerateIV();
            crypt.IV = aes.IV;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream =
                    new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                        cryptoStream.Write(bytes, 0, bytes.Length);
                }
                textBox.Text = Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        public void Decrypt(RichTextBox textBox, TextBox passwordBox)
        {

            byte[] bytes = Convert.FromBase64String(textBox.Text);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm sha256Hash = SHA256.Create();
            crypt.Key = sha256Hash.ComputeHash(Encoding.Unicode.GetBytes(passwordBox.Text));
            crypt.IV = aes.IV;

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    textBox.Text = Encoding.Unicode.GetString(decryptedBytes);
                }
            }
        }


    }
    
}
