using senhasegura.Service;

namespace senhasegura.test
{
    public class PasswordTests : IClassFixture<SenhaService>
    {
        private readonly SenhaService _service;
        public PasswordTests(SenhaService service)
        {
            _service = service;
        }

        [Fact]
        public void DeveMeRetornarAVerificacaoDaSenhaComSucesso()
        {
          
            var resultado = _service.VerifyPassword("Senha@1234");

            Assert.Equal(10, resultado.Pontuacao);
            Assert.Equal(Enum.Seguranca.Alta, resultado.Seguranca);
            Assert.True(resultado.Requisitos.temMinuscula);
        }

        [Fact]
        public void DeveMeRetornarAVerificacaoComSegurancaBaixa()
        {
                     
            var resultado = _service.VerifyPassword("senha");
            Assert.Equal(2, resultado.Pontuacao);
            Assert.Equal(Enum.Seguranca.Baixa, resultado.Seguranca);
        }

        [Fact]
        public void DeveMeRetornarAVerificacaoComSegurancaMedia()
        {
                     
            var resultado = _service.VerifyPassword("Senha123");
            Assert.Equal(6, resultado.Pontuacao);
            Assert.Equal(Enum.Seguranca.Media, resultado.Seguranca);
        }

        [Fact]
        public void DeveMeRetornarAVerificacaoComSegurancaAlta()
        {
                     
            var resultado = _service.VerifyPassword("Senh@12345");
            Assert.Equal(10, resultado.Pontuacao);
            Assert.Equal(Enum.Seguranca.Alta, resultado.Seguranca);
        }

    }
}
