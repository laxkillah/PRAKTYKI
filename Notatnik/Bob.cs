﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Notatnik { }
//{
//    class Bob 
//    {
//        public byte[] bobPublicKey;
//        private byte[] bobKey;
//        public Bob()
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
                        
//                    }
//                }
//            }
//        }
//    }
//}
