using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    class LoginManager
    {
        private static LoginManager instance = new LoginManager();
        //public bool loginON = false;  //로그인 유무

        public String ID { get; set; }
        public String PW { get; set; }
        public String Admin { get; set; }
        public String LoginTime { get; set; }

        public static LoginManager GetInstance() { return instance; }
        private LoginManager() { }
    }
}
