using System;
using System.Text;

namespace Tailorit.UserTools.MVC.Utils
{
    public static class EncryptionPassword
    {
        public static string Encrypt(string password)
        {
            var cript = Encoding.ASCII.GetBytes(password);
            var keyCripto = Convert.ToBase64String(cript);
            return keyCripto;
        }

        public static string Decrypt(string password)
        {
            var cript = Convert.FromBase64String(password);
            var keyDesCripto = Encoding.ASCII.GetString(cript);
            return keyDesCripto;
        }
    }
}
