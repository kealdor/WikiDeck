using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WikiaClientLibrary
{
    class LoginResponseRoot
    {
        [JsonProperty("login")]
        public LoginResponse Login { get; set; }
    }

    class LoginResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
