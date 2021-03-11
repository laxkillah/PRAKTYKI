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
        
        public RichTextBox textBox;
        public TextBox passwordBox;
        public byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public int BlockSize = 128;
        


        public void Encrypt(RichTextBox textBox)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(textBox.Text);
            //Encrypt
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.BlockSize = BlockSize;
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(passwordBox.Text));
            crypt.IV = IV;
            


            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }
                Form1 f1 = new Form1();
                textBox.Text = Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        public void Decrypt(RichTextBox textBox)
        {
            if (passwordBox.Text == "") return;
            byte[] bytes = Convert.FromBase64String(textBox.Text);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(passwordBox.Text));
            crypt.IV = IV;

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
