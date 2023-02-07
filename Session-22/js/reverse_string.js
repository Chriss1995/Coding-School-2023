function ReverseString(){
    const text=String(document.getElementById("txt").value);
    const revArray=[];
    const length = text.length -1;
    for(let i= length; i>=0; i--){
        revArray.push(text[i]);
    }
    var result= revArray.join('');
    document.getElementById('result').innerHTML="Reversion: "+ result;
}