using RemObjects.DataAbstract.Server;
using RemObjects.SDK.Server;
using System;

namespace Rem_ARVU {
    [RemObjects.SDK.Server.Service]
    public class LoginService : RemObjects.DataAbstract.Server.BaseLoginService {
        public LoginService() {
            this.InitializeComponent();
        }

        // Required for designer support
        private void InitializeComponent() {
        }

        [ServiceMethod]
        public override bool LoginEx(String loginString) {
            // LoginEx infrastructure provides unified way to set additional login parameters
            // (like DomainName for Relativity)
            // Note how LoginEx string is parsed and actual login method is called
            var loginParameters = new LoginStringParser(loginString);

            var isLoginValid = loginParameters.Username == "admin" && loginParameters.Password == "admin"; // TODO Implement credentials check here 

            if (!isLoginValid) {
                this.DestroySession();
                return false;
            }

            this.Session["Username"] = loginParameters.Username; // Create a session

            // TODO Store additional data in the session if needed

            return true;
        }

        [ServiceMethod]
        public override void Logout() {
            // Perform actions needed for user logout

            this.DestroySession();
        }
    }
}