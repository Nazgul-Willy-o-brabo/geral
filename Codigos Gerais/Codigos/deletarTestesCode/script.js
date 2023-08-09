const BorderUrls = {
    BTrap: "img/B.Armadilha.png",
    BMonster: "img/B.Monstro.png"
}
const InputValues = {
    
}

const typeValue = document.getElementById("cardType");
const nameCard = document.getElementById("name");
const descCard = document.getElementById("desc");
const canvas = document.getElementById("canvas");
const ctx = canvas.getContext("2d");

function SelectBorder(){
    const selectedVal = document.getElementById("model").value;

    const SelectedBorder = BorderUrls[selectedVal];
    if(SelectedBorder){
        const border = new Image();
        border.src = SelectedBorder;
        border.onload = () => {
            canvas.width = 500; 
            canvas.height = 750;
            ctx.drawImage(border, 0, 0, canvas.width, canvas.height);
        }
    }
}

function Draw(input){
    const FormInput = input.id;
    if(input.id === "name"){

    }else if(input.id === "desc"){

    }
}












