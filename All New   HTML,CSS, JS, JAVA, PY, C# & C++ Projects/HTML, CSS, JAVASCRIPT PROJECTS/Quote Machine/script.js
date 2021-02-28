function quotes(){
var aquote = new Array;
aquote[0]="Don't cry because it's over, smile because it happened Dr Seuss";
aquote[1]="“Be yourself; everyone else is already taken.”― Oscar Wilde";
aquote[2]="“Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.” Albert Einstein"
aquote[3]="“Be who you are and say what you feel, because those who mind don't matter, and those who matter don't mind.” Bernard M. Baruch"
aquote[4]="“A room without books is like a body without a soul.” Marcus Tullius Cicero"
aquote[5]="“So many books, so little time.”Frank Zappa"
aquote[6]="“Be the change that you wish to see in the world.”Mahatma Gandhi"
aquote[7]="“Winds blow counter to what the ship wants.” You don’t always get everything your way.Arabic Proverbs "
aquote[8]="“There is always something to learn from experimentation.”Arabic Proverbs"
aquote[9]="“Get together like brothers, but work together like strangers.”Arabic Proverbs"
aquote[10]="“The rope of lies is short.”Arabic Proverbs"
aquote[11]="“In haste there is regret, but in patience and care there is peace and safety.”Arabic Proverbs"
aquote[12]="“Eat less to sleep more.”Arabic Proverbs"
aquote[13]="“A tree begins with a seed.”Arabic Proverbs"
aquote[14]="“literal Translation: The rope man got mixed with the archerEnglish Equivalent or/and Meaning: Things got chaotic”Arabic Proverbs"
aquote[15]="“literal Translation: If you saw the fangs of lion, don't think the lion is smiling English:  That was from a famous poem by Almotanabbi”Arabic Proverbs"
aquote[16]="“literal Translation: When the reason is known, there will be no more shockEnglish Equivalent or/and Meaning: Said when you are wondering why something happened”Arabic Proverbs"
//Generate a random number then print the quote from that array index
rdmQuote = Math.floor(Math.random()*aquote.length);
document.getElementById("txtbox") .value=aquote[rdmQuote];
} 

!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0],p=/^http:/.test(d.location)?'http':'https';if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src=p+'://platform.twitter.com/widgets.js';fjs.parentNode.insertBefore(js,fjs);}}(document, 'script', 'twitter-wjs');
