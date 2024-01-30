using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaging
{
    public class ImageFile
    {
        private readonly byte[] _imageContent;

        public ImageFile(byte[] imageContent)
        {
            if (imageContent is null)
            {
                throw new ArgumentNullException(nameof(imageContent));
            }

            _imageContent = imageContent;
        }

        public bool IsValid()
        {
            using (var imgMemoryStream = new MemoryStream(_imageContent))
            {
                // Validate image is not corrupted
                using (var image = SKImage.FromEncodedData(imgMemoryStream))
                {
                    if (image == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
