using System.ComponentModel.DataAnnotations;

namespace senhasegura.Models
{
    public class Requirements
    {
        public bool tamanhoMinimo { get; set; } = true;

        public bool temMaiuscula { get; set; } = true;

        public bool temMinuscula { get; set; } = true;

        public bool temNumero { get; set; } = true;

        public bool temEspecial { get; set; } = true;
    }
}
