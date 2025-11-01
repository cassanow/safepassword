document.getElementById("botao-verificar").addEventListener("click", async function() {
    var password = document.getElementById("senha").value;

    const response = await fetch("https://senhasegura.onrender.com/v1/password/verificar", {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ password })
    });
    console.log(response)

    const resultado = await response.json();
    if(resultado.seguranca == 1){
        var seguranca = "Baixa"
    }
     if(resultado.seguranca == 2){
        var seguranca = "Média"
    }
      if(resultado.seguranca == 3){
        var seguranca = "Alta"
    }
    document.getElementById("resultado").textContent = "Pontuacao: " + JSON.stringify(resultado.pontuacao) + " Segurança: " + seguranca
})