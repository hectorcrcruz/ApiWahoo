using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using WahooApplication.Commons;

namespace WahooApplication.Services
{
    public class BlobStorageService
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string _containerName;

        public BlobStorageService(IOptions<AzureBlobStorageOptions> options)
        {
            var config = options.Value;
            _blobServiceClient = new BlobServiceClient(config.ConnectionString);
            _containerName = config.ContainerName;
        }

        private BlobContainerClient GetContainerClient()
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
            containerClient.CreateIfNotExists(PublicAccessType.Blob);
            return containerClient;
        }

        public async Task<string> UploadAsync(IFormFile file)
        {
            var containerClient = GetContainerClient();
            var blobClient = containerClient.GetBlobClient(file.FileName);

            using var stream = file.OpenReadStream();
            await blobClient.UploadAsync(stream, overwrite: true);

            return blobClient.Uri.ToString();
        }

        public async Task<Stream> DownloadAsync(string fileName)
        {
            var containerClient = GetContainerClient();
            var blobClient = containerClient.GetBlobClient(fileName);

            if (await blobClient.ExistsAsync())
            {
                var downloadInfo = await blobClient.DownloadAsync();
                return downloadInfo.Value.Content;
            }

            return null;
        }
        public async Task<IEnumerable<string>> ListAsync()
        {
            var containerClient = GetContainerClient();
            var blobNames = new List<string>();

            await foreach (var blobItem in containerClient.GetBlobsAsync())
            {
                blobNames.Add(blobItem.Name);
            }

            return blobNames;
        }
        public async Task<bool> DeleteAsync(string fileName)
        {
            var containerClient = GetContainerClient();
            var blobClient = containerClient.GetBlobClient(fileName);

            return await blobClient.DeleteIfExistsAsync();
        }
    }
}
