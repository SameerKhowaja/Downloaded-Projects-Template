$(document).ready(function() {
    
    $('#ninjaNameP').hide();
    $('#ninjaName').slideUp();
    
    //Each 2.5 sec I'm running animateLogo function
    setInterval(function(){ animateLogo(); }, 2500);
    
    var n = 1;
    var ninjaLetter = "";
    
    var ninjaName = "";
    
    //It's just storage of my logo images to quick access later
    var logo1 = 'url("http://i.imgur.com/j4odU3v.png")';
    var logo2 = 'url("http://i.imgur.com/NmtMlcu.png")';
    var logo3 = 'url("http://i.imgur.com/YVEbMrM.png")';
    var logo4 = 'url("http://i.imgur.com/WHKbh1k.png")';
    var logo5 = 'url("http://i.imgur.com/jaAxzGq.png")';
    
    //It's "controller" for looping logo animation
    function animateLogo()
    {
        n++;
        
        if(n <= 5)
        {
            changeLogo();
        }
        else
        {
            n = 1;
            changeLogo();
        }
    }
    
    //It's function which is changing little ninja position in logo (just loading another image) ;)
    function changeLogo()
    {
        switch(n) 
        {
            case 1:
                $('#logoIMG').fadeIn(200).css({content: logo1}).delay(1000).fadeOut(200);
            break;
            
            case 2:
                $('#logoIMG').fadeIn(200).css({content: logo2}).delay(1000).fadeOut(200);
            break;
            
            case 3:
                $('#logoIMG').fadeIn(200).css({content: logo3}).delay(1000).fadeOut(200);
            break;
            
            case 4:
                $('#logoIMG').fadeIn(200).css({content: logo4}).delay(1000).fadeOut(200);
            break;
            
            case 5:
                $('#logoIMG').fadeIn(200).css({content: logo5}).delay(1000).fadeOut(200);
            break;
        }
    }
   
   //Listener for button click which is firing function with whole generating process
   $('#submitBtn').click(function(){ generating(); });
   
   function generating()
   {
       // I need to empty "ninjaName" div before every new generating
       $('#ninjaName').empty();
       
       // Getting name from text input field and changing all letters to upper case
        var name = $('#nameInput').val();
        name = name.toUpperCase();
        
        // Here I'm checking if name was generated before, if true - I'm giving it "hiding" effect on each button click
        if(ninjaName !== "")
        {
            $('#ninjaNameP').slideUp(300);
            $('#ninjaName').fadeOut(200);
        }
        
        ninjaName = "";
        
        // If name input is empty, I'm just alerting for name input by user ;)
        if(name === "")
        {
            alert("Please enter your name! \nProszę podać swoje imię!")    
        }
        // If it's not empty, let's begin whole process :)
        else
        {
            // Getting length of inputed name
            var nameLen = name.length;
            
            // For loop going as many times as length of name is
            for(var i = 0; i < nameLen; i++)
            {
                // Taking every letter of name into 'toCheck' variable
                var toCheck = name.charAt(i);
                
                //Just checking for latin extended letters, it's prohibited in my generator ;)
                if(
                toCheck === 'Ą' || 
                toCheck === 'Ć' || 
                toCheck === 'Ę' || 
                toCheck === 'Ł' || 
                toCheck === 'Ń' || 
                toCheck === 'Ó' || 
                toCheck === 'Ś' || 
                toCheck === 'Ź' || 
                toCheck === 'Ż' )
                {
                    // If we have some of these here, just I'm alerting this to user and breaking whole function
                  alert("Please don't use latin extended letters! \nProszę nie używać znaków diaktrycznych! (polskich liter)");
                  return;
                }
                
                // Saving result of changeLetter function into "checked" variable :) + I'm sending letter from inputed name to the function as parameter
                var checked = changeLetter(toCheck);
                
                // Adding every new "ninja letter" into ninjaName variable
                ninjaName += checked;
            }
            
            // When for loop is ended and it make new ninja name for me and saved it into 'ninjaName' variable, I can show it :)
            $('#ninjaNameP').slideDown(500);
            
            setTimeout(function(){ 
                $('#ninjaName').append(ninjaName + " !").slideDown(700);
            }, 200);
        }
        
        // This function is getting every letter from inputed name, and changing it for "ninja" one ;)
        function changeLetter(letter)
        {
            switch(letter)
            {
                case 'A':
                    ninjaLetter = 'KA';  
                break;
                
                case 'B':
                    ninjaLetter = 'ZU';  
                break;
                
                case 'C':
                    ninjaLetter = 'MI';  
                break;
                
                case 'D':
                    ninjaLetter = 'TE';  
                break;
                
                case 'E':
                    ninjaLetter = 'KU';  
                break;
                
                case 'F':
                    ninjaLetter = 'LU';  
                break;
                
                case 'G':
                    ninjaLetter = 'JI';  
                break;
                
                case 'H':
                    ninjaLetter = 'RI';  
                break;
                
                case 'I':
                    ninjaLetter = 'KI';  
                break;
                
                
                case 'J':
                    ninjaLetter = 'ZU';  
                break;
                
                
                case 'K':
                    ninjaLetter = 'ME';  
                break;
                
                
                case 'L':
                    ninjaLetter = 'TA';  
                break;
                
                
                case 'M':
                    ninjaLetter = 'RIN';  
                break;
                
                
                case 'N':
                    ninjaLetter = 'TO';  
                break;
                
                
                case 'O':
                    ninjaLetter = 'MO';  
                break;
                
                
                case 'P':
                    ninjaLetter = 'NO';  
                break;
                
                
                case 'Q':
                    ninjaLetter = 'KE';  
                break;
                
                
                case 'R':
                    ninjaLetter = 'SHI';  
                break;
                
                case 'S':
                    ninjaLetter = 'ARI';  
                break;
                
                case 'T':
                    ninjaLetter = 'CHI';  
                break;
                
                case 'U':
                    ninjaLetter = 'DO';  
                break;
                
                case 'V':
                    ninjaLetter = 'RU';  
                break;
                
                case 'W':
                    ninjaLetter = 'MEI';  
                break;
                
                case 'X':
                    ninjaLetter = 'NA';  
                break;
                
                case 'Y':
                    ninjaLetter = 'FU';  
                break;
                
                case 'Z':
                    ninjaLetter = 'ZI';  
                break;
                
                default: "";
                break;
            }
            
            // Function is returning new "ninja" letter which is saved info "checked" variable above ;)
            return ninjaLetter;
        }
        
        
   }
   
});









