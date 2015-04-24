using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ClouDeveloper.Hash.SHA512
{
    public static partial class SHA512HashExtensions
    {
        public static string ComputeSHA512(
            this Stream inputStream,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(inputStream, isUpperCase);
        }

        public static string ComputeSHA512(
            this byte[] buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeSHA512(
            this byte[] buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(buffer, isUpperCase);
        }

        public static string ComputeSHA512(
            this IEnumerable<byte> buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeSHA512(
            this IEnumerable<byte> buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(buffer, isUpperCase);
        }

        public static string ComputeSHA512(
            this char[] text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA512(
            this char[] text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA512(
            this IEnumerable<char> text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA512(
            this IEnumerable<char> text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA512(
            this string text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA512(
            this string text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA512(
            this StringBuilder text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA512(
            this StringBuilder text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA512(
            this TextReader reader,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA512Managed>(reader, targetEncoding, isUpperCase);
        }
    }
}
