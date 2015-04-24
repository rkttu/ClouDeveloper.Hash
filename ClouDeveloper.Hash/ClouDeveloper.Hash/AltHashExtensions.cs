using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ClouDeveloper.Hash
{
    public static partial class AltHashExtensions
    {
        public static string ComputeHash<THashAlgorithm>(
            this Stream inputStream,
            THashAlgorithm hashAlg,
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            if (inputStream == null)
                throw new ArgumentNullException("stream");
            if (!inputStream.CanRead)
                throw new ArgumentException("Cannot read the stream.", "stream", new IOException("Read function not supported."));

            StringBuilder sb = new StringBuilder();
            string format = isUpperCase ? "X2" : "x2";

            foreach (byte eachByte in hashAlg.ComputeHash(inputStream))
                sb.Append(eachByte.ToString(format));

            return sb.ToString();
        }

        public static string ComputeHash<THashAlgorithm>(
            this byte[] buffer,
            int offset,
            int count,
            THashAlgorithm hashAlg,
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            if (buffer == null || buffer.Length < 1)
                return String.Empty;

            StringBuilder sb = new StringBuilder(buffer.Length * 2);
            string format = isUpperCase ? "X2" : "x2";

            foreach (byte eachByte in hashAlg.ComputeHash(buffer, offset, count))
                sb.Append(eachByte.ToString(format));

            return sb.ToString();
        }

        public static string ComputeHash<THashAlgorithm>(
            this byte[] buffer,
            THashAlgorithm hashAlg,
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            return ComputeHash<THashAlgorithm>(buffer, 0, buffer.Length, hashAlg, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this IEnumerable<byte> buffer,
            int offset,
            int count,
            THashAlgorithm hashAlg,
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            return ComputeHash<THashAlgorithm>(buffer.ToArray(), offset, count, hashAlg, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this IEnumerable<byte> buffer,
            THashAlgorithm hashAlg,
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            return ComputeHash<THashAlgorithm>(buffer.ToArray(), hashAlg, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this char[] text,
            int index,
            int count,
            THashAlgorithm hashAlg,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            if (text == null || text.Length < 1)
                return String.Empty;

            if (targetEncoding == default(Encoding))
                targetEncoding = Encoding.UTF8;

            return ComputeHash<THashAlgorithm>(
                targetEncoding.GetBytes(text, index, count),
                hashAlg,
                isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this char[] text,
            THashAlgorithm hashAlg,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            if (text == null || text.Length < 1)
                return String.Empty;

            if (targetEncoding == default(Encoding))
                targetEncoding = Encoding.UTF8;

            return ComputeHash<THashAlgorithm>(
                targetEncoding.GetBytes(text, 0, text.Length),
                hashAlg,
                isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this IEnumerable<char> text,
            int index,
            int count,
            THashAlgorithm hashAlg,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            return ComputeHash<THashAlgorithm>(text.ToArray(), index, count, hashAlg, targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this IEnumerable<char> text,
            THashAlgorithm hashAlg,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            return ComputeHash<THashAlgorithm>(text.ToArray(), hashAlg, targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this string text,
            int index,
            int count,
            THashAlgorithm hashAlg,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            return ComputeHash<THashAlgorithm>(text.ToCharArray(), index, count, hashAlg, targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this string text,
            THashAlgorithm hashAlg,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            return ComputeHash<THashAlgorithm>(text.ToCharArray(), hashAlg, targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this StringBuilder text,
            int index,
            int count,
            THashAlgorithm hashAlg,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            return ComputeHash<THashAlgorithm>(text.ToString(), index, count, hashAlg, targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this StringBuilder text,
            THashAlgorithm hashAlg,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            return ComputeHash<THashAlgorithm>(text.ToString(), hashAlg, targetEncoding, isUpperCase);
        }

        public static string ComputeHash<THashAlgorithm>(
            this TextReader reader,
            THashAlgorithm hashAlg,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true)
            where THashAlgorithm : HashAlgorithm
        {
            return ComputeHash<THashAlgorithm>(reader.ReadToEnd(), hashAlg, targetEncoding, isUpperCase);
        }
    }
}
