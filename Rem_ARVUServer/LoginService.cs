using RemObjects.DataAbstract.Server;
using RemObjects.SDK.Server;
using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

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

            var configUsername = ConfigurationManager.AppSettings["AdminUsername"];
            var configPassword = ConfigurationManager.AppSettings["AdminPassword"];

            //var isLoginValid = loginParameters.Username == configUsername
            //    && loginParameters.Password == configPassword; // TODO Implement credentials check here 
            
            
            bool isLoginValid2 = ValidateCredentials(loginParameters.Username,loginParameters.Password);
            if (!isLoginValid2) {
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

        private bool ValidateCredentials(string username, string password) {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            try {
                var configUsername = ConfigurationManager.AppSettings["AdminUsername"];
                var configPasswordHash = ConfigurationManager.AppSettings["AdminPasswordHash"];
                var configSalt = ConfigurationManager.AppSettings["AdminPasswordSalt"];

                if (string.IsNullOrEmpty(configUsername) ||
                    string.IsNullOrEmpty(configPasswordHash) ||
                    string.IsNullOrEmpty(configSalt)) {
                    return username == "admin" && password == "admin";
                }

                if (username != configUsername)
                    return false;

                var hashedInputPassword = HashPassword(password, configSalt);
                return hashedInputPassword == configPasswordHash;
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine($"Credential validation error: {ex.Message}");
                return false;
            }
        }

        private string HashPassword(string password, string salt) {
            using (var sha256 = SHA256.Create()) {
                var saltedPassword = password + salt;
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return Convert.ToBase64String(hashedBytes);
            }
        }
        public static string GenerateSalt() {
            var saltBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create()) {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public static string GeneratePasswordHash(string password, string salt) {
            using (var sha256 = SHA256.Create()) {
                var saltedPassword = password + salt;
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}