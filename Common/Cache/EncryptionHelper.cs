using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Common.Security
{
    public static class EncryptionHelper
    {
        // Se define una clave y un IV como arrays de bytes.
        private static readonly byte[] Key = GenerateRandomKey();
        private static readonly byte[] IV = GenerateRandomIV();

        // Se define el tamaño en bytes de la clave y el IV.
        private const int KeySizeInBytes = 32; // 256 bits
        private const int IVSizeInBytes = 16;   // 128 bits

        // Método para encriptar un texto plano y devolver los datos encriptados como un array de bytes.
        public static byte[] Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create()) // Se crea una instancia del algoritmo de cifrado AES.
            {
                aesAlg.Key = Key; // Se establece la clave para el algoritmo AES.
                aesAlg.IV = IV; // Se establece el vector de inicialización (IV) para el algoritmo AES.

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV); // Se crea un transformador de cifrado.

                using (MemoryStream msEncrypt = new MemoryStream()) // Se crea un MemoryStream para almacenar los datos encriptados.
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) // Se crea un CryptoStream para escribir los datos encriptados.
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) // Se crea un StreamWriter para escribir datos en el CryptoStream.
                        {
                            swEncrypt.Write(plainText); // Se escribe el texto plano en el StreamWriter.
                        }
                        return msEncrypt.ToArray(); // Se devuelve el contenido del MemoryStream como un array de bytes.
                    }
                }
            }
        }

        // Método para desencriptar los datos encriptados y devolver el texto plano.
        public static string Decrypt(byte[] encryptedData)
        {
            using (Aes aesAlg = Aes.Create()) // Se crea una instancia del algoritmo de cifrado AES.
            {
                aesAlg.Key = Key; // Se establece la clave para el algoritmo AES.
                aesAlg.IV = IV; // Se establece el vector de inicialización (IV) para el algoritmo AES.

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV); // Se crea un transformador de descifrado.

                using (MemoryStream msDecrypt = new MemoryStream(encryptedData)) // Se crea un MemoryStream para almacenar los datos desencriptados.
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)) // Se crea un CryptoStream para leer los datos desencriptados.
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt)) // Se crea un StreamReader para leer datos del CryptoStream.
                        {
                            return srDecrypt.ReadToEnd(); // Se lee todo el contenido del StreamReader y se devuelve como texto plano.
                        }
                    }
                }
            }
        }

        // Método privado para generar una clave aleatoria.
        private static byte[] GenerateRandomKey()
        {
            using (var aes = Aes.Create()) // Se crea una instancia del algoritmo de cifrado AES.
            {
                aes.GenerateKey(); // Se genera una clave aleatoria para el algoritmo AES.
                return aes.Key; // Se devuelve la clave generada.
            }
        }

        // Método privado para generar un IV aleatorio.
        private static byte[] GenerateRandomIV()
        {
            using (var aes = Aes.Create()) // Se crea una instancia del algoritmo de cifrado AES.
            {
                aes.GenerateIV(); // Se genera un IV aleatorio para el algoritmo AES.
                return aes.IV; // Se devuelve el IV generado.
            }
        }
    }
}
