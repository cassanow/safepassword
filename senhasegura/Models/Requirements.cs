using System.ComponentModel.DataAnnotations;

namespace senhasegura.Models
{
    public class Requirements
    {
        [MinLength(10)]
        public int tamanhoMinimo { get; set; }

        public bool temMaiuscula { get; set; } = true;

        public bool temMinuscula { get; set; } = true;

        public bool temNumero { get; set; } = true;

        public bool temEspecial { get; set; } = true;
    }
}
