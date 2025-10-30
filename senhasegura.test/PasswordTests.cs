using senhasegura.Service;

namespace senhasegura.test
{
    public class PasswordTests
    {
        [Fact]
        public void DeveMeRetornarAVerificacaoDaSenhaComSucesso()
        {
            SenhaService service = new SenhaService();

            var resultado = service.VerifyPassword("Senha@1234");

            Assert.Equal(10, resultado.Pontuacao);
            Assert.Equal(Enum.Seguranca.Alta, resultado.Seguranca);
            Assert.True(resultado.Requisitos.temMinuscula);
        }
    }
}
