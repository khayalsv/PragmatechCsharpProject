let addBasket = document.querySelectorAll(".btn-primary");
let basketSale = document.getElementById("basketCountType");

if (localStorage.getItem("basket") == null) {
    localStorage.setItem("basket", JSON.stringify([]));
}

function addBasketDetail() {
    basketSale.innerText = (JSON.parse(localStorage.getItem("basket"))).length;
}

addBasketDetail();

addBasket.forEach(btn => {
    btn.onclick = function(e) {
        e.preventDefault();
        let id = (this.parentElement.parentElement.getAttribute("data-id"))
        let prodName = this.parentElement.firstElementChild.innerText;
        let prodImage = this.parentElement.previousElementSibling.getAttribute("src");
        let price = this.previousElementSibling.innerText;

        if (localStorage.getItem("basket") == null) {
            localStorage.setItem("basket", JSON.stringify([]));
        }

        let basket = JSON.parse(localStorage.getItem("basket"));
        let existPro = basket.find(x => x.id == id);

        if (existPro == undefined) {
            basket.push({
                id: id,
                name: prodName,
                src: prodImage,
                price: price,
                count: 1
            })
        } else {
            existPro.count += 1;
        }


        localStorage.setItem("basket", JSON.stringify(basket));
        addBasketDetail();

    }
});