function last_character(){
    const text=String(document.getElementById("txt5").value);
    var res=text.charAt(text.length-1);
    if(res = Number){
        res+=1;
        var changed = text.substring(0, res);
    }else{
        res =1;
        changed = text + res;
    }
    document.getElementById('result5').innerHTML = changed;
}