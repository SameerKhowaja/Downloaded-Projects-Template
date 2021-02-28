document.onreadystatechange = function () {
    if (document.readyState == 'complete') {
        var str  = 'Welcome to the Development\'s World, the young coder, Follow me, I\'ll show you this amazing place.';
        var msg  = document.getElementById('message');
        var itr  = 0, timer;
        setTimeout(function(){
            timer = setInterval(printMsg, 70);
        },2000);
    }
    function printMsg(){
        msg.innerHTML += str.charAt(itr);
        if(itr == str.length){
            
            clearInterval(timer);
            var lbl = document.getElementById('label');
            lbl.className += ' attention';
        }
        itr++;
    }
}
