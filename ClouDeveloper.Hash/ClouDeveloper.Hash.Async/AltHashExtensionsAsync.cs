using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClouDeveloper.Hash.Async
{
    public static class AltHashExtensionsAsync
    {
        public static async Task<string> ComputeHashAsync<THashAlgorithm>(
            this Stream inputStream,
            THashAlgorithm hashAlg,
            bool isUpperCase = true,
            AsyncCallback asyncCallback = default(AsyncCallback),
            object asyncState = default(object),
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheudler = default(TaskScheduler))
            where THashAlgorithm : HashAlgorithm
        {
            if (inputStream == null)
                throw new ArgumentNullException("stream");
            if (!inputStream.CanRead)
                throw new ArgumentException("Cannot read the stream.", "stream");

            StringBuilder sb = new StringBuilder();
            string format = isUpperCase ? "X2" : "x2";
            byte[] buffer = new byte[65000];
            int read = 0;

            while ((read = await Task<int>.Factory.FromAsync(
                inputStream.BeginRead(buffer, 0, buffer.Length, asyncCallback, asyncState),
                inputStream.EndRead,
                taskCreationOptions,
                taskScheudler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false)) > 0)
            {
                foreach (byte eachByte in hashAlg.ComputeHash(buffer, 0, read))
                    sb.Append(eachByte.ToString(format));
            }

            return sb.ToString();
        }

        public static async Task<string> ComputeHashAsync<THashAlgorithm>(
            this TextReader reader,
            THashAlgorithm hashAlg,
            Encoding targetEncoding = default(Encoding),
            bool isUpperCase = true,
            AsyncCallback asyncCallback = default(AsyncCallback),
            object asyncState = default(object),
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = default(TaskScheduler))
            where THashAlgorithm : HashAlgorithm
        {
            return await ComputeHashAsync<THashAlgorithm>(
                await reader.ReadToEndAsync().ConfigureAwait(false),
                hashAlg,
                targetEncoding,
                isUpperCase,
                asyncCallback,
                asyncState,
                taskCreationOptions,
                taskScheduler)
                .ConfigureAwait(false);
        }
    }
}
