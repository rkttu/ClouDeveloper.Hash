using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ClouDeveloper.Hash.SHA256
{
    public static partial class SHA256HashExtensions
    {
        public static string ComputeSHA256(
            this Stream inputStream,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(inputStream, isUpperCase);
        }

        public static string ComputeSHA256(
            this byte[] buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeSHA256(
            this byte[] buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(buffer, isUpperCase);
        }

        public static string ComputeSHA256(
            this IEnumerable<byte> buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeSHA256(
            this IEnumerable<byte> buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(buffer, isUpperCase);
        }

        public static string ComputeSHA256(
            this char[] text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA256(
            this char[] text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA256(
            this IEnumerable<char> text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA256(
            this IEnumerable<char> text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA256(
            this string text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA256(
            this string text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA256(
            this StringBuilder text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA256(
            this StringBuilder text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA256(
            this TextReader reader,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA256Managed>(reader, targetEncoding, isUpperCase);
        }
    }
}
