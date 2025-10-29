using senhasegura.Models;

namespace senhasegura.Interface
{
    public interface ISenhaService
    {
        Password VerifyPassword(string password, Requirements requirements);
     
    }
}
