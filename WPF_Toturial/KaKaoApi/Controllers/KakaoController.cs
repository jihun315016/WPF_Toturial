using KaKaoApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace KaKaoApi.Controllers
{
    [Route("[controller]/[action]")]
    public class KakaoController : Controller
    {
        private readonly IKakaoService _kakaoService;
        private readonly IConfiguration _configuration;

        public KakaoController(IKakaoService kakaoService)
        {
            //_configuration = configuration;
            _kakaoService = kakaoService;
        }

        [Route("~/Kakao/login")]
        public RedirectResult login()
        {
            return Redirect(_kakaoService.login());
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("~/Kakao/login-callback")]
        public RedirectResult loginCallback(String code)
        {            
            return Redirect(_kakaoService.loginCallback(code));
        }
    }
}
