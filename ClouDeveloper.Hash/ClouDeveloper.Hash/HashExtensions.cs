using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ClouDeveloper.Hash
{
    public static partial class HashExtensions
    {
        public static string ComputeHash<THashAlgorithm>(
            this Stream inputStream,
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            using (THashAlgorithm hashAlg = new THashAlgorithm())
            {
                return AltHashExtensions.ComputeHash<THashAlgorithm>(inputStream, hashAlg, isUpperCase);
            }
        }

        public static string ComputeHash<THashAlgorithm>(
            this byte[] buffer,
            int offset,
            int count,
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            using (THashAlgorithm hashAlg = new THashAlgorithm())
            {
                return AltHashExtensions.ComputeHash<THashAlgorithm>(buffer, offset, count, hashAlg, isUpperCase);
            }
        }

        public static string ComputeHash<THashAlgorithm>(
            this byte[] buffer,
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            return ComputeHash<THashAlgorithm>(buffer, 0, buffer.Length, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this IEnumerable<byte> buffer,
            int offset,
            int count,
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            return ComputeHash<THashAlgorithm>(buffer.ToArray(), offset, count, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this IEnumerable<byte> buffer,
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            return ComputeHash<THashAlgorithm>(buffer.ToArray(), isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this char[] text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            if (text == null || text.Length < 1)
                return String.Empty;

            if (targetEncoding == default(Encoding))
                targetEncoding = Encoding.UTF8;

            return ComputeHash<THashAlgorithm>(
                targetEncoding.GetBytes(text, index, count),
                isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this char[] text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            if (text == null || text.Length < 1)
                return String.Empty;

            if (targetEncoding == default(Encoding))
                targetEncoding = Encoding.UTF8;

            return ComputeHash<THashAlgorithm>(
                targetEncoding.GetBytes(text, 0, text.Length),
                isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this IEnumerable<char> text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            return ComputeHash<THashAlgorithm>(text.ToArray(), index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this IEnumerable<char> text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            return ComputeHash<THashAlgorithm>(text.ToArray(), targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this string text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            return ComputeHash<THashAlgorithm>(text.ToCharArray(), index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this string text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            return ComputeHash<THashAlgorithm>(text.ToCharArray(), targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this StringBuilder text,
            int index,
            int count,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            return ComputeHash<THashAlgorithm>(text.ToString(), index, count, targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this StringBuilder text,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            return ComputeHash<THashAlgorithm>(text.ToString(), targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this TextReader reader,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm, new()
        {
            return ComputeHash<THashAlgorithm>(reader.ReadToEnd(), targetEncoding, isUpperCase);
        }
    }
}
