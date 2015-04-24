using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ClouDeveloper.Hash.SHA384
{
    public static partial class SHA384HashExtensions
    {
        public static string ComputeSHA384(
            this Stream inputStream,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(inputStream, isUpperCase);
        }

        public static string ComputeSHA384(
            this byte[] buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeSHA384(
            this byte[] buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(buffer, isUpperCase);
        }

        public static string ComputeSHA384(
            this IEnumerable<byte> buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeSHA384(
            this IEnumerable<byte> buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(buffer, isUpperCase);
        }

        public static string ComputeSHA384(
            this char[] text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA384(
            this char[] text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA384(
            this IEnumerable<char> text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA384(
            this IEnumerable<char> text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA384(
            this string text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA384(
            this string text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA384(
            this StringBuilder text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA384(
            this StringBuilder text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeSHA384(
            this TextReader reader,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<SHA384Managed>(reader, targetEncoding, isUpperCase);
        }
    }
}
