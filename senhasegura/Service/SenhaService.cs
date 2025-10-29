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
                score++;
            if(requirements.temMaiuscula = password.Any(c => char.IsUpper(c)))
                score++;
            if(requirements.temNumero = password.Any(c => char.IsDigit(c)))
                score++;
            if(requirements.temEspecial = password.Any(c => !char.IsLetterOrDigit(c)))
                score++;

            if(password.Length >= requirements.tamanhoMinimo)
                score++;
          

                var seguranca = Enum.Seguranca.Baixa;

            if (score > 4)
                seguranca = Enum.Seguranca.Alta;
            else if(score == 3)
                seguranca = Enum.Seguranca.Media;
            else if(score < 3)
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
