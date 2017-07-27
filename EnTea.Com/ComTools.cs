using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EnTea.Com
{
    public static class ComTools
    {
        /// <summary>
        /// MD5转码
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToMd5(string source)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            var fromData = Encoding.Unicode.GetBytes(source);
            var targetData = md5.ComputeHash(fromData);

            return targetData.Aggregate<byte, string>(null, (current, t) => current + t.ToString("x"));
        }
    }
}
