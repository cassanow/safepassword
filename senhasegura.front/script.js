document.getElementById("botao-verificar").addEventListener("click", async function() {
    var password = document.getElementById("senha").value;

    const response = await fetch("https://senhasegura.onrender.com/", {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ password })
    });
    console.log(response)

    const resultado = await response.json();
    document.getElementById("resultado").textContent = resultado.mensagem
})