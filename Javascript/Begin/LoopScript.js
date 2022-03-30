const person = { name: "Khayal", surname: "Salimov", age: 22 };

let txt = "";
for (let x in person) // for in -> indeks qaytarir
{
    txt += x + " ";
}

document.getElementById("demo").innerHTML = txt;


const cars = ["BMW", "Volvo", "Mini"];

let text = "";
for (let x of cars) // datalari qaytarir (c# foreach)
{
    text += x + " ";
}

document.getElementById("demo2").innerHTML = text;