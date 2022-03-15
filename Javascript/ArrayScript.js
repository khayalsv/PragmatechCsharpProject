const cars = ["Saab", "Volvo", "BMW"];

document.getElementById("demo").innerHTML = cars; //Array list

document.getElementById("demo2").innerHTML = cars[0]; //Arraydaki elementi qaytarir
document.getElementById("demo2").innerHTML = cars[cars.length - 1]; // son elementi qaytarir

cars[3] = "Mercedes"; //Arraya element əlavə edir
cars.push("JEEP"); //əlavə 2
document.getElementById("demo3").innerHTML = cars;


cars[0] = "Opel"; //Arraydaki elementi dəyişir
document.getElementById("demo4").innerHTML = cars;

document.getElementById("demo5").innerHTML = cars.length; //Arrayin uzunluğu


const person = { name: "Khayal", surname: "Salimov", age: 22 }; //Object formasinda
document.getElementById("demo6").innerHTML = person.name;