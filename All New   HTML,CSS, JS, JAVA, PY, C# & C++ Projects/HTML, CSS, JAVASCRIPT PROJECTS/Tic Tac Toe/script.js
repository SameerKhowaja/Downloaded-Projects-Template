		
			var playerturn = 0;
			var cputurn = 1;
			var playerscore = 0;
			var cpuscore = 0;
			var x = 0;
			window.onload = init;
			function init(){
				for(var i=1; i<=9; i++){
					document.getElementById('box'+i);
				}
			}
			function play(x){
				if(box1.value==" " && x==1 && playerturn== 0){
					box1.value="X";
					box1.style.color="#FF0000";
					playerturn=1;
					cputurn=0;
				}
				else if(box2.value==" " && x==2 && playerturn== 0){
					box2.value="X";
					box2.style.color="#FF0000";
					playerturn=1;
					cputurn=0;
				}
				else if(box3.value==" " && x==3 && playerturn== 0){
					box3.value="X";
					box3.style.color="#FF0000";
					playerturn=1;
					cputurn=0;
				}
				else if(box4.value==" " && x==4 && playerturn== 0){
					box4.value="X";
					box4.style.color="#FF0000";
					playerturn=1;
					cputurn=0;
				}
				else if(box5.value==" " && x==5 && playerturn== 0){
					box5.value="X";
					box5.style.color="#FF0000";
					playerturn=1;
					cputurn=0;
				}
				else if(box6.value==" " && x==6 && playerturn== 0){
					box6.value="X";
					box6.style.color="#FF0000";
					playerturn=1;
					cputurn=0;
				}
				else if(box7.value==" " && x==7 && playerturn== 0){
					box7.value="X";
					box7.style.color="#FF0000";
					playerturn=1;
					cputurn=0;
				}
				else if(box8.value==" " && x==8 && playerturn== 0){
					box8.value="X";
					box8.style.color="#FF0000";
					playerturn=1;
					cputurn=0;
				}
				else if(box9.value==" " && x==9 && playerturn== 0){
					box9.value="X";
					box9.style.color="#FF0000";
					playerturn=1;
					cputurn=0;
				}			
				check();				
				cpuplay1();	
			}
			function cpuplay1(){
				if(box1.value=="O" && box2.value=="O" && box3.value==" " && cputurn== 0){
					box3.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value=="O" && box3.value=="O" && box2.value==" " && cputurn== 0){
					box2.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box2.value=="O" && box3.value=="O" && box1.value==" " && cputurn== 0){
					box1.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box4.value=="O" && box5.value=="O" && box6.value==" " && cputurn== 0){
					box6.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box4.value=="O" && box6.value=="O" && box5.value==" " && cputurn== 0){
					box5.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box5.value=="O" && box6.value=="O" && box4.value==" " && cputurn== 0){
					box4.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box7.value=="O" && box8.value=="O" && box9.value==" " && cputurn== 0){
					box9.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box7.value=="O" && box9.value=="O" && box8.value==" " && cputurn== 0){
					box8.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box8.value=="O" && box9.value=="O" && box7.value==" " && cputurn== 0){
					box7.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value=="O" && box4.value=="O" && box7.value==" " && cputurn== 0){
					box7.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value=="O" && box7.value=="O" && box4.value==" " && cputurn== 0){
					box4.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box4.value=="O" && box7.value=="O" && box1.value==" " && cputurn== 0){
					box1.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box2.value=="O" && box5.value=="O" && box8.value==" " && cputurn== 0){
					box8.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box2.value=="O" && box8.value=="O" && box5.value==" " && cputurn== 0){
					box5.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box5.value=="O" && box8.value=="O" && box2.value==" " && cputurn== 0){
					box2.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box3.value=="O" && box6.value=="O" && box9.value==" " && cputurn== 0){
					box9.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box3.value=="O" && box9.value=="O" && box6.value==" " && cputurn== 0){
					box6.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box6.value=="O" && box9.value=="O" && box3.value==" " && cputurn== 0){
					box3.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value=="O" && box5.value=="O" && box9.value==" " && cputurn== 0){
					box9.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value=="O" && box9.value=="O" && box5.value==" " && cputurn== 0){
					box5.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box5.value=="O" && box9.value=="O" && box1.value==" " && cputurn== 0){
					box1.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box3.value=="O" && box5.value=="O" && box7.value==" " && cputurn== 0){
					box7.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box3.value=="O" && box7.value=="O" && box5.value==" " && cputurn== 0){
					box5.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box5.value=="O" && box7.value=="O" && box3.value==" " && cputurn== 0){
					box3.value="O";
					playerturn=0;
					cputurn=1;
				}
				else {
					cpuplay2();
				}
				check();
			
			}
			function cpuplay2(){
				if(box1.value=="X" && box2.value=="X" && box3.value==" " && cputurn== 0){
					box3.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value=="X" && box3.value=="X" && box2.value==" " && cputurn== 0){
					box2.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box2.value=="X" && box3.value=="X" && box1.value==" " && cputurn== 0){
					box1.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box4.value=="X" && box5.value=="X" && box6.value==" " && cputurn== 0){
					box6.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box4.value=="X" && box6.value=="X" && box5.value==" " && cputurn== 0){
					box5.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box5.value=="X" && box6.value=="X" && box4.value==" " && cputurn== 0){
					box4.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box7.value=="X" && box8.value=="X" && box9.value==" " && cputurn== 0){
					box9.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box7.value=="X" && box9.value=="X" && box8.value==" " && cputurn== 0){
					box8.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box8.value=="X" && box9.value=="X" && box7.value==" " && cputurn== 0){
					box7.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value=="X" && box4.value=="X" && box7.value==" " && cputurn== 0){
					box7.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value=="X" && box7.value=="X" && box4.value==" " && cputurn== 0){
					box4.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box4.value=="X" && box7.value=="X" && box1.value==" " && cputurn== 0){
					box1.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box2.value=="X" && box5.value=="X" && box8.value==" " && cputurn== 0){
					box8.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box2.value=="X" && box8.value=="X" && box5.value==" " && cputurn== 0){
					box5.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box5.value=="X" && box8.value=="X" && box2.value==" " && cputurn== 0){
					box2.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box3.value=="X" && box6.value=="X" && box9.value==" " && cputurn== 0){
					box9.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box3.value=="X" && box9.value=="X" && box6.value==" " && cputurn== 0){
					box6.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box6.value=="X" && box9.value=="X" && box3.value==" " && cputurn== 0){
					box3.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value=="X" && box5.value=="X" && box9.value==" " && cputurn== 0){
					box9.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value=="X" && box9.value=="X" && box5.value==" " && cputurn== 0){
					box5.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box5.value=="X" && box9.value=="X" && box1.value==" " && cputurn== 0){
					box1.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box3.value=="X" && box5.value=="X" && box7.value==" " && cputurn== 0){
					box7.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box3.value=="X" && box7.value=="X" && box5.value==" " && cputurn== 0){
					box5.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box5.value=="X" && box7.value=="X" && box3.value==" " && cputurn== 0){
					box3.value="O";
					playerturn=0;
					cputurn=1;
				}
				else {
					cpuplay3();
				}
				check();
			}
			function cpuplay3(){
				if(box5.value==" " && cputurn== 0){
					box5.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box1.value==" " && cputurn== 0){
					box1.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box2.value==" " && cputurn== 0){
					box2.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box3.value==" " && cputurn== 0){
					box3.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box4.value==" " && cputurn== 0){
					box4.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box6.value==" " && cputurn== 0){
					box6.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box7.value==" " && cputurn== 0){
					box7.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box8.value==" " && cputurn== 0){
					box8.value="O";
					playerturn=0;
					cputurn=1;
				}
				else if(box9.value==" " && cputurn== 0){
					box9.value="O";
					playerturn=0;
					cputurn=1;
				}
				check();		
			}
			function check(){
				if(box1.value=="X" && box2.value=="X" && box3.value=="X"){
					alert("You Win");
					playerscore += 1;
					document.getElementById('player').innerHTML = parseInt(playerscore);
					reset();
				}
				else if(box4.value=="X" && box5.value=="X" && box6.value=="X"){
					alert("You Win");
					playerscore += 1;
					document.getElementById('player').innerHTML = parseInt(playerscore);
					reset();
				}
				else if(box7.value=="X" && box8.value=="X" && box9.value=="X"){
					alert("You Win");
					playerscore += 1;
					document.getElementById('player').innerHTML = parseInt(playerscore);
					reset();
				}
				else if(box1.value=="X" && box4.value=="X" && box7.value=="X"){
					alert("You Win");
					playerscore += 1;
					document.getElementById('player').innerHTML = parseInt(playerscore);
					reset();
				}
				else if(box2.value=="X" && box5.value=="X" && box8.value=="X"){
					alert("You Win");
					playerscore += 1;
					document.getElementById('player').innerHTML = parseInt(playerscore);
					reset();
				}
				else if(box3.value=="X" && box6.value=="X" && box9.value=="X"){
					alert("You Win");
					playerscore+=1;
					document.getElementById('player').innerHTML = parseInt(playerscore);
					reset();
				}
				else if(box1.value=="X" && box5.value=="X" && box9.value=="X"){
					alert("You Win");
					playerscore += 1;
					document.getElementById('player').innerHTML = parseInt(playerscore);
					reset();
				}
				else if(box3.value=="X" && box5.value=="X" && box7.value=="X"){
					alert("You Win");
					playerscore += 1;
					document.getElementById('player').innerHTML = parseInt(playerscore);
					reset();
				}
				else if(box1.value=="O" && box2.value=="O" && box3.value=="O"){
					alert("Computer Win");
					cpuscore += 1;
					document.getElementById('computer').innerHTML = parseInt(cpuscore);
					reset();
				}
				else if(box4.value=="O" && box5.value=="O" && box6.value=="O"){
					alert("Computer Win");
					cpuscore += 1;
					document.getElementById('computer').innerHTML = parseInt(cpuscore);
					reset();
				}
				else if(box7.value=="O" && box8.value=="O" && box9.value=="O"){
					alert("Computer Win");
					cpuscore += 1;
					document.getElementById('computer').innerHTML = parseInt(cpuscore);
					reset();
				}
				else if(box1.value=="O" && box4.value=="O" && box7.value=="O"){
					alert("Computer Win");
					cpuscore += 1;
					document.getElementById('computer').innerHTML = parseInt(cpuscore);
					reset();
				}
				else if(box2.value=="O" && box5.value=="O" && box8.value=="O"){
					alert("Computer Win");
					cpuscore += 1;
					document.getElementById('computer').innerHTML = parseInt(cpuscore);
					reset();
				}
				else if(box3.value=="O" && box6.value=="O" && box9.value=="O"){
					alert("Computer Win");
					cpuscore += 1;
					document.getElementById('computer').innerHTML = parseInt(cpuscore);
					reset();
				}
				else if(box1.value=="O" && box5.value=="O" && box9.value=="O"){
					alert("Computer Win");
					cpuscore += 1;
					document.getElementById('computer').innerHTML = parseInt(cpuscore);
					reset();
				}
				else if(box3.value=="O" && box5.value=="O" && box7.value=="O"){
					alert("Computer Win");
					cpuscore += 1;
					document.getElementById('computer').innerHTML = parseInt(cpuscore);
					reset();
				}
				else if(box1.value!=" " && box2.value!=" " && box3.value!=" " && box4.value!=" " && box5.value!=" " && box6.value!=" " && box7.value!=" " && box8.value!=" " && box9.value!=" " && cputurn==0 && playerturn==1){
					alert("Draw");
					reset();
				}
			}
			function reset(){
				playerturn = 0;
				cputurn = 1;
				for(var i=1; i<=9; i++){
					document.getElementById('box'+i).value=" ";
					document.getElementById('box'+i).style.color="#0000FF";
				}
			}