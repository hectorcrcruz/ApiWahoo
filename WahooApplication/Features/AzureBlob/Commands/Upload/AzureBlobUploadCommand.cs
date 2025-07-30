using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.AzureBlob.Commands.Upload
{
    public class AzureBlobUploadCommand : IRequest<AzureBlobModel>
    {
        public AzureBlobUploadCommand(IFormFile url)
        {
            Url = url;
        }
        public IFormFile Url { get; set; }
    }
}
