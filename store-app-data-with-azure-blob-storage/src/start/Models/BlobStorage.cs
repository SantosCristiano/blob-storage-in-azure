using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Linq;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace FileUploader.Models
{
    public class BlobStorage : IStorage
    {
        private readonly AzureStorageConfig storageConfig;

        public BlobStorage(IOptions<AzureStorageConfig> storageConfig)
        {
            this.storageConfig = storageConfig.Value;
        }

        public Task Initialize()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(storageConfig.ConnectionString);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference(storageConfig.FileContainerName);
            return container.CreateIfNotExistsAsync();
        }

        public Task Save(Stream fileStream, string name)
        {
            // Add Save code here
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetNames()
        {
            // Add GetNames code here
            throw new NotImplementedException();
        }

        public Task<Stream> Load(string name)
        {
            // Add Load code here
            throw new NotImplementedException();
        }
    }
}