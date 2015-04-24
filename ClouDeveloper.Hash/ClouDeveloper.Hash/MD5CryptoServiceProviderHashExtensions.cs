using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ClouDeveloper.Hash.MD5.CryptoServiceProvider
{
    public static partial class MD5CryptoServiceProviderHashExtensions
    {
        public static string ComputeMD5CryptoServiceProvider(
            this Stream inputStream,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(inputStream, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this byte[] buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this byte[] buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(buffer, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this IEnumerable<byte> buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this IEnumerable<byte> buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(buffer, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this char[] text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this char[] text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this IEnumerable<char> text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this IEnumerable<char> text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this string text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this string text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this StringBuilder text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this StringBuilder text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5CryptoServiceProvider(
            this TextReader reader,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5CryptoServiceProvider>(reader, targetEncoding, isUpperCase);
        }
    }
}
