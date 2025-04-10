using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    // Represents a media file with a name and content
    public class MediaFile
    {
        public string FileName { get; set; }
        public byte[] Content { get; set; }

        public MediaFile(string fileName, byte[] content)
        {
            FileName = fileName;
            Content = content;
        }
    }
}
