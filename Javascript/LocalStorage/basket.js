let basketSale = document.getElementById("basketCountType");
let table = document.getElementById("table");
let newArray = JSON.parse(localStorage.getItem("basket")); //locatstorage-de datami goturdum

function addBasketDetail() {
    basketSale.innerText = (JSON.parse(localStorage.getItem("basket"))).length;
}

addBasketDetail();

newArray.forEach(element => {
    let tr = document.createElement("tr");
    let tdImage = document.createElement("td");
    let img = document.createElement("img");
    img.setAttribute("src", element.src);
    tdImage.append(img);

    let tdName = document.createElement("td");
    tdName.innerText = element.name;


    let tdPrice = document.createElement("td");
    tdPrice.innerText = element.price;

    let tdCount = document.createElement("td");
    tdCount.innerText = element.count;

    let totalPrice = document.createElement("td");
    totalPrice.innerText = (parseInt(tdCount.innerText) * parseInt(tdPrice.innerText)) + "azn";




    let tdRemove = document.createElement("td");
    tdRemove.innerHTML = "<i class=\"fa-solid fa-trash\"></i>"
    tdRemove.onclick = function() {
        alert();

    }
    tr.append(tdImage, tdName, tdCount, tdPrice, totalPrice, tdRemove);
    table.lastElementChild.append(tr);

});