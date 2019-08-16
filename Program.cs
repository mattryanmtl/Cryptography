using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "123456reporter$";
            Console.WriteLine("Plain:" + plainText);
            //Encrypt
            string encrypted_text = CryptographyHelper.Encrypt(plainText);
            Console.WriteLine("Encrypted:"+encrypted_text);
            //Decrypt
            string decrypted_text = CryptographyHelper.Decrypt(encrypted_text);
            Console.WriteLine("Decrypted:" + decrypted_text);

            //MD5
            string md5_hash = CryptographyHelper.MD5Hash("PlainText");
            Console.WriteLine("Md5:" + md5_hash);


            Console.ReadLine();
        }


    }
}
