document.getElementById("submit").onclick = function(){
    var table = document.getElementById("tbCustomers");
    var row = table.insertRow(-1);
    var name = row.insertCell(0);
    var surname=row.insertCell(1);
    var age = row.insertCell(2);
    var gender = row.insertCell(3);
    name.innerHTML= document.getElementById("name").value;
    surname.innerHTML=document.getElementById("surname").value;
    age.innerHTML=document.getElementById("age").value;
    gender.innerHTML=document.getElementById("gender").value;
}