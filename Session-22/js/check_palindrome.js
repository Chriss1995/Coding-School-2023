function check_palindrome(){
    const text=String(document.getElementById("txt2").value);
    let j =text.length -1;
    for(let i=0; i< j/2; i++){
        let x = text[i];
        let y = text[j-i];
        if(x != y){
          let ans= false;
        }
    }let ans= true;
    
    if(ans= true){
        document.getElementById('result2').innerHTML="string is a palindrome";
    }else{
        document.getElementById('result2').innerHTML="string is not a palindrome";
    }
}
