# 🔐 senhasegura

> Uma API REST para gerenciamento seguro de senhas, construída com .NET 9.0 e boas práticas de desenvolvimento.

[![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Docker](https://img.shields.io/badge/Docker-Enabled-2496ED?logo=docker)](https://www.docker.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Deploy](https://img.shields.io/badge/Deploy-Render-46E3B7)](https://senhasegura.onrender.com)

## 📋 Sobre o Projeto

Este projeto foi desenvolvido como parte do meu aprendizado em desenvolvimento backend com .NET, focando em:

- ✅ **Arquitetura limpa e organizada**
- ✅ **Testes unitários e de integração**
- ✅ **Containerização com Docker**
- ✅ **CI/CD e Deploy automatizado**
- ✅ **Boas práticas de segurança**

## 🚀 Tecnologias Utilizadas

- **[.NET 9.0](https://dotnet.microsoft.com/)** - Framework principal
- **[ASP.NET Core](https://docs.microsoft.com/aspnet/core)** - Web API
- **[xUnit](https://xunit.net/)** - Testes unitários
- **[Docker](https://www.docker.com/)** - Containerização
- **[Docker Hub](https://hub.docker.com/)** - Registry de imagens
- **[Render](https://render.com/)** - Hospedagem e deploy

## 📦 Funcionalidades

- 🔒 Gerenciamento seguro de senhas
- 🔑 Autenticação e autorização
- 📝 CRUD completo de senhas
- 🛡️ Criptografia de dados sensíveis
- 📊 Rate limiting para segurança
- 📖 Documentação automática com Swagger

## 🏗️ Arquitetura

```
senhasegura/
├── Controllers/       # Endpoints da API
├── Models/           # Modelos de dados
├── Service/          # Lógica de negócio
├── Interface/        # Contratos e abstrações
├── Enum/             # Enumeradores
├── Properties/       # Configurações do projeto
└── Tests/            # Testes unitários e de integração
```

## 🐳 Docker

### Executar localmente com Docker

```bash
# Pull da imagem
docker pull arthurcassano/senhasegura:latest

# Executar container
docker run -d -p 5033:8080 --name safepassword cassanow/senhasegura:latest

# Acessar aplicação
curl http://localhost:5033
```

### Build da imagem

```bash
# Build
docker build -t senhasegura:latest .

# Run
docker run -d -p 8080:8080 --name safepassword senhasegura:latest
```

## 🧪 Testes

O projeto possui cobertura completa de testes:

### Testes Unitários
Validam a lógica de negócio de forma isolada.

### Testes de Integração
Validam o comportamento end-to-end da API.

```bash
# Executar todos os testes
dotnet test

# Executar com cobertura
dotnet test --collect:"XPlat Code Coverage"
```

## 🌐 Deploy

A API está disponível em produção:

**🔗 URL:** https://senhasegura.onrender.com

### Deploy Automático

O deploy é feito automaticamente via Docker Hub + Render:

1. Build local da imagem Docker
2. Push para Docker Hub
3. Render detecta nova versão
4. Deploy automático em produção

## 🚀 Como Usar

### Pré-requisitos

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (opcional)

### Instalação Local

```bash
# Clone o repositório
git clone https://github.com/cassanow/safepassword.git

# Entre na pasta
cd safepassword

# Restore dependências
dotnet restore

# Execute a aplicação
dotnet run
```

A API estará disponível em: `http://localhost:5033`

### Variáveis de Ambiente

```bash
ASPNETCORE_ENVIRONMENT=Production
ASPNETCORE_URLS=http://+:8080
```


### Exemplo de Endpoints

```http

# Verificar sua senha
POST /v1/password
Content-Type: application/json

{
  "password": "testesenha123"
}
```


