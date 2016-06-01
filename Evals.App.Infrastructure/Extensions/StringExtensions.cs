using Evals.App.Infrastructure.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Evals.App.Infrastructure
{
    public static class StringExtensions
    {
        public static string GetSha1(this string value)
        {
            return SHA1_Hash(value);
        }


        public static bool HasValue(this string value)
        {
            return !(string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value));
        }

        public static int TryToInt(this string value)
        {
            int result = 0;
            if (int.TryParse(value, out result))
            {
                return result;
            }
            throw new ArgumentException("传入值无法转换为 Int 类型");
        }

        #region Utilities

        internal static string SHA1_Hash(string str_sha1_in)
        {
            var sha1 = SHA1.Create();
            var encoding = System.Text.Encoding.UTF8;
            byte[] bytes_sha1_in = encoding.GetBytes(str_sha1_in);
            byte[] bytes_sha1_out = sha1.ComputeHash(bytes_sha1_in);
            string str_sha1_out = Convert.ToBase64String(bytes_sha1_out);
            return str_sha1_out;
        }
        #endregion
    }
}
