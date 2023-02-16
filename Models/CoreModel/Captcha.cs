using System;
using System.Collections.Generic;
using System.Text;
using DataModels.Helpers;

namespace CoreModel
{
    public static class Captcha
    {
        public static (string HashCode, byte[] Image) GenerateCaptchaInfo()
        {
            var code = (new Random()).Next(100000, 1000000).ToString();
            var hash = HashHundle.GetHashString(code);
            var image = (new CaptchaGen.SkiaSharp.CaptchaGenerator()).GenerateImageAsByteArray(code);
            return (hash, image);
        }
    }
}
