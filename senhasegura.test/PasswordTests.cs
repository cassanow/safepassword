using senhasegura.Interface;
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

    }
}
