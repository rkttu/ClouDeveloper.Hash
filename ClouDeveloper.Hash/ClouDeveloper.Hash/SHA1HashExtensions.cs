using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ClouDeveloper.Hash.SHA1
{
    public static partial class SHA1HashExtensions
    {
        public static string ComputeSHA1(
            this Stream inputStream,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(inputStream, isUpperCase);
        }

        public static string ComputeSHA1(
            this byte[] buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeSHA1(
            this byte[] buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(buffer, isUpperCase);
        }

        public static string ComputeSHA1(
            this IEnumerable<byte> buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeSHA1(
            this IEnumerable<byte> buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(buffer, isUpperCase);
        }

        public static string ComputeSHA1(
            this char[] text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA1(
            this char[] text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA1(
            this IEnumerable<char> text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA1(
            this IEnumerable<char> text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA1(
            this string text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA1(
            this string text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA1(
            this StringBuilder text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA1(
            this StringBuilder text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA1(
            this TextReader reader,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA1Managed>(reader, targetEncoding, isUpperCase);
        }
    }
}
