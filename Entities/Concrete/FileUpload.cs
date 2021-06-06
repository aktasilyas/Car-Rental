using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FileUpload
    {
        public IFormFile files { get; set; }
    }
}
