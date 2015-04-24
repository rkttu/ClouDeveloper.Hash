using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ClouDeveloper.Hash.MD5.Cng
{
    public static partial class MD5CngHashExtensions
    {
        public static string ComputeMD5Cng(
            this Stream inputStream,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(inputStream, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this byte[] buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this byte[] buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(buffer, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this IEnumerable<byte> buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this IEnumerable<byte> buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(buffer, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this char[] text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this char[] text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this IEnumerable<char> text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this IEnumerable<char> text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this string text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this string text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this StringBuilder text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this StringBuilder text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeMD5Cng(
            this TextReader reader,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<MD5Cng>(reader, targetEncoding, isUpperCase);
        }
    }
}
