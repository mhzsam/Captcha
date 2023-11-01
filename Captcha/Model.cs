using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross_Platform_Captcha____linux_container_mac_windows_
{
    public class Model
    {
        public class GetCaptchaModel
        {
            public string? CaptchaToken { get; set; }
            public string? Base64Image { get; set; }
        }

        public class ValidateCaptchaModel
        {
            public string? CaptchaToken { get; set; }
            public string? Key { get; set; }

        }
    }
}
