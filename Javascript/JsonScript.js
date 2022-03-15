let text = '{"employees":[' +
    '{"firstName":"John","lastName":"Doe" },' +
    '{"firstName":"Anna","lastName":"Smith" },' +
    '{"firstName":"Peter","lastName":"Jones" }]}';

const obj = JSON.parse(text); // json-u javascript formatina cevirmek
document.getElementById("demo").innerHTML = obj.employees[1].firstName



const arr = ["John", "Peter", "Sally", "Jane"];
const myJSON = JSON.stringify(arr); // javascript formatini jsona cevirmek

document.getElementById("demo2").innerHTML = myJSON