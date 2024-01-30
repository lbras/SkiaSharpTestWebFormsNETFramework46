using Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SkiaSharpTestWebFormsNETFramework46
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack && FileUpload1.HasFile)
            {
                var fileContent = new byte[FileUpload1.PostedFile.ContentLength];
                FileUpload1.FileContent.Read(fileContent, 0, fileContent.Length);

                var imageFile = new ImageFile(fileContent);
                LblResult.Text = imageFile.IsValid()
                    ? "File is valid image"
                    : "File is not an image file or it is corrupted";
            }
        }
    }
}