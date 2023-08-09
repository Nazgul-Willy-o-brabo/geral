const cardTypeSelect = document.getElementById("cardType");
const nameInput = document.getElementById("name");
const descriptionInput = document.getElementById("description");
const canvas = document.getElementById("cardCanvas");
const ctx = canvas.getContext("2d");


cardTypeSelect.addEventListener("change", updateCanvas);
nameInput.addEventListener("input", updateCanvas);
descriptionInput.addEventListener("input", updateCanvas);
// Adicione mais ouvintes para outros campos, se necessário


function updateCanvas() {
    // Limpar o canvas
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    // Obter os valores selecionados e preenchidos
    const selectedType = cardTypeSelect.value;
    const name = nameInput.value;
    const description = descriptionInput.value;

    // Lógica para desenhar no canvas com base nos valores selecionados e preenchidos
    // Exemplo: desenhar texto no canvas
    ctx.fillStyle = "black";
    ctx.font = "20px Arial";
    ctx.fillText(`Tipo: ${selectedType}`, 20, 40);
    ctx.fillText(`Nome: ${name}`, 20, 80);
    ctx.fillText(`Descrição: ${description}`, 20, 120);
}
