using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Notatnik
{
    class Encrypt 
    {
        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}












//        public static byte[] alicePublicKey;


//        public static void Majn(string[] args)
//        {
//            using (ECDiffieHellmanCng alice = new ECDiffieHellmanCng())
//            {

//                alice.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
//                alice.HashAlgorithm = CngAlgorithm.Sha256;
//                alicePublicKey = alice.PublicKey.ToByteArray();
//                Bob bob = new Bob();
//                CngKey bobKey = CngKey.Import(bob.bobPublicKey, CngKeyBlobFormat.EccPublicBlob);
//                byte[] aliceKey = alice.DeriveKeyMaterial(bobKey);
//                byte[] encryptedMessage = null;
//                byte[] iv = null;
//                Send(aliceKey, "test", out encryptedMessage, out iv);
//                bob.Receive(encryptedMessage, iv);
//            }
//        }

//        private static void Send(byte[] key, string secretMessage, out byte[] encryptedMessage, out byte[] iv)
//        {
//            using (Aes aes = new AesCryptoServiceProvider())
//            {
//                aes.Key = key;
//                iv = aes.IV;

//                // Encrypt the message
//                using (MemoryStream ciphertext = new MemoryStream())
//                using (CryptoStream cs = new CryptoStream(ciphertext, aes.CreateEncryptor(), CryptoStreamMode.Write))
//                {
//                    byte[] plaintextMessage = Encoding.UTF8.GetBytes(secretMessage);
//                    cs.Write(plaintextMessage, 0, plaintextMessage.Length);
//                    cs.Close();
//                    encryptedMessage = ciphertext.ToArray();
//                }
//            }
//        }
//    }
//    public class Bob1
//    {
//        public byte[] bobPublicKey;
//        private byte[] bobKey;
//        public void Bob()
//        {
//            using (ECDiffieHellmanCng bob = new ECDiffieHellmanCng())
//            {

//                bob.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
//                bob.HashAlgorithm = CngAlgorithm.Sha256;
//                bobPublicKey = bob.PublicKey.ToByteArray();
//                bobKey = bob.DeriveKeyMaterial(CngKey.Import(Encrypt.alicePublicKey, CngKeyBlobFormat.EccPublicBlob));
//            }
//        }

//        public void Receive(byte[] encryptedMessage, byte[] iv)
//        {

//            using (Aes aes = new AesCryptoServiceProvider())
//            {
//                aes.Key = bobKey;
//                aes.IV = iv;
//                // Decrypt the message
//                using (MemoryStream plaintext = new MemoryStream())
//                {
//                    using (CryptoStream cs = new CryptoStream(plaintext, aes.CreateDecryptor(), CryptoStreamMode.Write))
//                    {
//                        cs.Write(encryptedMessage, 0, encryptedMessage.Length);
//                        cs.Close();
//                        string message = Encoding.UTF8.GetString(plaintext.ToArray());
//                        Console.WriteLine(message);
//                    }
//                }
//            }
//        }

//    }
//    public static class Encrypt1
//    {
//        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
//        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
//        private const string initVector = "test1234";
//        // This constant is used to determine the keysize of the encryption algorithm
//        private const int keysize = 256;
//        //Encrypt

//        public static string EncryptString(string plainText, string passPhrase)
//        {

//            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
//            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
//            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
//            byte[] keyBytes = password.GetBytes(keysize / 8);
//            RijndaelManaged symmetricKey = new RijndaelManaged();
//            symmetricKey.Mode = CipherMode.CBC;
//            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
//            MemoryStream memoryStream = new MemoryStream();
//            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
//            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
//            cryptoStream.FlushFinalBlock();
//            byte[] cipherTextBytes = memoryStream.ToArray();
//            memoryStream.Close();
//            cryptoStream.Close();
//            return Convert.ToBase64String(cipherTextBytes);
//        }

//        public static string DecryptString(string cipherText, string passPhrase)
//        {
//            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
//            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
//            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
//            byte[] keyBytes = password.GetBytes(keysize / 8);
//            RijndaelManaged symmetricKey = new RijndaelManaged();
//            symmetricKey.Mode = CipherMode.CBC;
//            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
//            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
//            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
//            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
//            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
//            memoryStream.Close();
//            cryptoStream.Close();
//            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);


//            //textBox.Text = Encrypt.EncryptString(textBox.Text, "test");
//            //textBox.Text = Encrypt.DecryptString(textBox.Text, "test");
//        }
//    }
//}
