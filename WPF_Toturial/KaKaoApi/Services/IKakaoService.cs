using Microsoft.AspNetCore.Http;
using System;

namespace KaKaoApi.Service
{
    public interface IKakaoService
    {
        public String login();
        public String login(String scope);
        public String loginCallback(String code);
        public String getProfile();
    }
}