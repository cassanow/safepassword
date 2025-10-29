using senhasegura.Interface;
using senhasegura.Models;

namespace senhasegura.Service
{
    public class SenhaService : ISenhaService
    {
        public Password VerifyPassword(Requirements requirements)
        {
           return new Password();
        }

        public  bool HasLowercase(string password)
        {
            bool temMinuscula = password.Any(c => char.IsLower(c));
            return temMinuscula;
        }

        public bool HasNumber(string password)
        {
            bool temNumero = password.Any(c => char.IsDigit(c));
            return temNumero;
        }

        public bool HasSpecialCharacter(string password)
        {
            bool temEspecial = password.Any(c => !char.IsLetterOrDigit(c));
            return temEspecial;
        }

        public bool HasUppercase(string password)
        {
            bool temMaiuscula = password.Any(c => char.IsUpper(c)); 
            return temMaiuscula;
        }
    }
}
