using senhasegura.Models;

namespace senhasegura.Interface
{
    public interface ISenhaService
    {
        Password VerifyPassword(Requirements requirements);
        bool HasUppercase(string password);
        bool HasLowercase(string password);
        bool HasNumber(string password);
        bool HasSpecialCharacter(string password);
    }
}
