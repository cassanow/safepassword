using senhasegura.Interface;
using senhasegura.Models;

namespace senhasegura.Service
{
    public class SenhaService : ISenhaService
    {
        public Password VerifyPassword(string password)
        {
           int score = 0;

            Requirements requirements = new Requirements();

            if (requirements.temMinuscula = password.Any(c => char.IsLower(c)))
                score += 2;
            if(requirements.temMaiuscula = password.Any(c => char.IsUpper(c)))
                score += 2;
            if (requirements.temNumero = password.Any(c => char.IsDigit(c)))
                score += 2;
            if (requirements.temEspecial = password.Any(c => !char.IsLetterOrDigit(c)))
                score += 2;
            if (requirements.tamanhoMinimo = password.Length >= 10 )
                score += 2;
                

           var seguranca = Enum.Seguranca.Baixa;

            if (score == 10)
                seguranca = Enum.Seguranca.Alta;
            else if (score >= 5 && score < 10)
                seguranca = Enum.Seguranca.Media;
            else
                seguranca = Enum.Seguranca.Baixa;

            return new Password
           {
               Pontuacao = score,
               Seguranca = seguranca,
               Requisitos = requirements
           };
        }

    }
}
