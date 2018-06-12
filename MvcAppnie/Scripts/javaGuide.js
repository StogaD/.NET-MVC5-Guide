
    /*typy proste*/
    var sVar = "MyText";

var iVar = 230;
var dVar = Number.MAX_VALUE;

var arr1 = [1, 2, 3, 4];

    
/*typy referencyjne */
var arr2 = arr1;
arr2.push(9);
var t = new Number(3);
var result = "";
var result2 = "";
if (t == "3")
{
    result = "true";
}
else
{
    result = "false";
}
if (t === "3") {
    result2 = "false";
}
else
{
    result2 = "false";
} document.getElementById("equal").innerHTML = "3=='3' : " + result + " 3==='3' :  " + result2;

document.getElementById("title").innerHTML = sVar + sVar.length
document.getElementById("typeVar").innerHTML = typeof (t);

function ShowMe() {
    document.getElementById("demo").style.display = 'block';
    document.getElementById("demo").innerHTML = ShowObject()
}

var car = {
    type: "Fiat",
    model: "50",
    color: "white",
    fullName: function () {
        return this.type + " " + this.model;
    }
};
function ShowObject()
{
    return car.color + car.fullName();
    car["color"];
}