using senhasegura.Enum;

namespace senhasegura.Models
{
    public class Password
    {
        public Seguranca Seguranca { get; set; }

        public int Pontuacao { get; set; }

        public Requirements Requisitos { get; set; } = new Requirements();
    }
}
