using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ClouDeveloper.Hash.RIPEMD160
{
    public static partial class RIPEMD160HashExtensions
    {
        public static string ComputeRIPEMD160(
            this Stream inputStream,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(inputStream, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this byte[] buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this byte[] buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(buffer, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this IEnumerable<byte> buffer,
            int offset,
            int count,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(buffer, offset, count, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this IEnumerable<byte> buffer,
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(buffer, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this char[] text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this char[] text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this IEnumerable<char> text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this IEnumerable<char> text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this string text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this string text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this StringBuilder text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(text, index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this StringBuilder text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(text, targetEncoding, isUpperCase);
        }

        public static string ComputeRIPEMD160(
            this TextReader reader,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
        {
            return HashExtensions.ComputeHash<RIPEMD160Managed>(reader, targetEncoding, isUpperCase);
        }
    }
}
