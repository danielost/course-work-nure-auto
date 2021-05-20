using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace CourseWork
{
    public class BaseImageConverter
    {
        public Image FromBase64(string base64pic)
        {
            byte[] bytes = Convert.FromBase64String(base64pic);

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        public string ToBase64(string path)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(path);
            return Convert.ToBase64String(imageArray);
        }
    }
}
