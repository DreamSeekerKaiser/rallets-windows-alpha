using Shadowsocks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shadowsocks.Extensions;
using System.Diagnostics;

namespace Shadowsocks.Util
{
    class Url
    {
        public const string ACCOUNT_BASE = "https://account.rallets.com/#/";
        public const string PAYMENT_URL = ACCOUNT_BASE + "payment";
        public const string PROFILE_URL = ACCOUNT_BASE + "profile";
        public const string SIGNUP_URL = ACCOUNT_BASE + "signup";
        public const string MANUAL_URL = "https://rallets.com/manuals/windows";
        public const string FIND_PASSWORD_URL = ACCOUNT_BASE + "find_password";
        public static string loginSuffix()
        {
            return $"?username_or_email={User.one().username.ToUrlEncodeBase64()}&login_password={User.one().password.ToUrlEncodeBase64()}";
        }
        public static void GotoPayment()
        {
            Process.Start(PAYMENT_URL + loginSuffix());
        }
        public static void GotoMyProfile()
        {
            Process.Start(PROFILE_URL + loginSuffix());
        }
        public static void Goto(string url)
        {
            Process.Start(url);
        }
    }
}
