using System;
using System.Collections.Generic;

namespace KaKaoApi.Services
{
    public interface IHttpCallService
    {
        public String Call(String method, String reqURL, String header, string param);
        public String CallwithToken(String method, String reqURL, String access_Token);
        public String CallwithToken(String method, String reqURL, String access_Token, string param);
    }
}