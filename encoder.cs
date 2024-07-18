using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;

namespace FinalProject
{
    class encoder
    {
        public string Encoder(string encode)
        {
            String encoded = WebUtility.UrlEncode(encode);

            return encoded;

        }
    }
}
