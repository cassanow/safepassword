using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace senhasegura.test
{
    public class PasswordIntegrationTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly  HttpClient _client;

        public PasswordIntegrationTests(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task DeveMeRetornarStatus200OK()
        {
            var request = new
            {
                Password = "Senha@1234"
            };

            var response = await _client.PostAsJsonAsync("/v1/Password/verificar", request);

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }   
    }
}
