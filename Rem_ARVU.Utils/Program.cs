using System;
using System.Security.Cryptography;
using System.Text;

namespace Rem_ARVU.Utils {
    public class PasswordHashGenerator {
        public static void Main(string[] args) {
            Console.WriteLine("Password Hash Generator");
            
            string salt = GenerateSalt();
            Console.WriteLine($"Generated Salt: {salt}");
           
            Console.Write("Enter password to hash: ");
            string password = Console.ReadLine();

            string hash = GeneratePasswordHash(password, salt);
            Console.WriteLine($"Generated Hash: {hash}");
          
            Console.WriteLine("App.config settings");
            Console.WriteLine($"<add key=\"AdminPasswordHash\" value=\"{hash}\" />");
            Console.WriteLine($"<add key=\"AdminPasswordSalt\" value=\"{salt}\" />");

            Console.WriteLine("Verification");
            Console.Write("Enter password to verify: ");
            string verifyPassword = Console.ReadLine();

            string verifyHash = GeneratePasswordHash(verifyPassword, salt);
            bool isValid = verifyHash == hash;

            Console.WriteLine($"Verification result: {(isValid ? "SUCCESS" : "FAILED")}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
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