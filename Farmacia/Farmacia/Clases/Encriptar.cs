﻿using System.Text;
using System.Security.Cryptography;

namespace Farmacia
{
    public abstract class Encriptar
    {
        public Encriptar()
        {

        }

        public static string GetSHA1(string str)
        {
            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] stream = null;
            StringBuilder sb = new StringBuilder();

            stream = sha1.ComputeHash(encoding.GetBytes(str));

            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
                            
            return sb.ToString();
        }
    }
}
