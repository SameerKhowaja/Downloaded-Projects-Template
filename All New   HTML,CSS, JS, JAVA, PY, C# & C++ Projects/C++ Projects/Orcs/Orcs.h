#include <iostream>
#include <string>

//so i don't have to type std::cout
using namespace std;


//sneak_num used in cbp for sneak attack
int sneak_num;

//string answer which gets reused over and over again
string answer;
string scbp;

void all_tribes();
void threelead();
void feast();
void s_poison();
void desertt();
void fmlead();
void cbpon();
void f_sneak();
void a_sneak();
void a_plan();
void fsa();
void fao();
void cbp();
void o_charge();
void o_dip();
void forest_war();
void ocean_war();
void desert_war();
void war_tribe();
void dip_tribe();
void clan_chief();
void slow();
void push();
void dart();
void mt();
void dsrt();
void orc_sadness();
void orc();
void torture();
void orc_sanctum();
void destroy();
void pray();
void forestwalk();
void orcvillage();

void all_tribes() {
	cout << "As the leader of so many people, you send them back to their villages to conserve space. 2 months pass and you get attacked by the gremlins. The gremlins are evil creatures that aren't strong but have numbers. They slaughter the forest tribe to death. You were visiting the forest tribe when this happened. You die. Please play again.";
	//pauses the console
    cin.get();
//returns to the previous function
return;
}
void threelead() {
	cout <<"As the leader of three tribes, but not four tribes you decide to go after the ocean tribe in war. You march your troops to the ocean tribe's turf. Ready to attack?(Y/N)";
	getline(cin, answer);
	//while: says while this condition is met do this
    while (answer != "Y") {
		cout << "Now?";
		getline(cin, answer);
	}
	cout << "You attack and storm their walls. Your numbers overwhelm them. You slaugher yet another tribe leader and become leader of all the tribes.";
	all_tribes();
cin.get();
	return;
}
void feast() {
	cout << "You go to the feast and see a grand meal. Everyone stars digging in. Talk to the person next to you? (Y/N)";
	getline(cin, answer);
	if (answer == "Y") {
    //brackets can also be placed on the next line just so you know, brackets run the code between them if the condition is met or if it is a function
		cout << "You start talking to the person next to you. They start talking to you at the same time. By doing your action you insult the person causing them to go into a rage. The tribe now shuns oyou and kicks you out of thier village. You are now alone. You live as a hermit in the desert from now on. You end up dying of old age. Please play again.";
	}
	if (answer == "N") {
		cout << "You don't talk to the person next to you and they think you are weird for not talking. They shun you. You end up as a lonely hermit. Please play again.";	
		}
cin.get();
return;
}
void s_poison() {
	cout << "As soon as you bite into the plant and swallow you start to gag. Your face breaks into hives and they somehow burst spraying a wierd liquid to death. Sand get all over your raw flesh making it itchy, making you scratch it and tearing your raw flesh off. You end up dying. Please play again.";
	cin.get();
	return;
}
void desertt() {
	cout << "The desert tribe runs out to welcome you as a fellow orc. They carry you in to thier heavily fortified village seeing that you are unarmed. You tell them that you would like to join their tribe. They accept you in and they throw a feast in your honor.";
	feast();
	cin.get();
	return;
}
void fmlead() {
	cout << "As the ruler of two clans you must decide on one location to live. You decide to live in the forest because all your forces are here. You get everything organized for the next war. Declare war on the desert or ocean tribe? (D/O)";
	cin >> answer;
	//multiple choice: choice 1
	if (answer == "O") {
		cout << "You march your troops to the ocean and yell charge.";
		o_charge();
	}
	//choice 2
	if (answer == "D") {
	desert_war(); 
	threelead(); }
cin.get();
	return;
}
void cbpon() {
     //says if scbp (string custom battle plan) = whatever do this
	if (scbp == "sneak=N FOA=N") {
             //adds another condition here. The ors work :)
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the North side. They have the objective of raising the gate. Your other troops attack from the same side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
		
        if (scbp == "sneak=N FOA=N") {
			if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the same side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please play again."; 
		return; } }
		
        if (scbp == "sneak=S FOA=S") {
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the South side. They have the objective of raising the gate. Your other troops attack from the same side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } 
		}
		
        if (scbp == "sneak=S FOA=S") {
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the same side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again."; 
		return; } }
	
    if (scbp == "sneak=W FOA=W") { 
	if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the West side. They have the objective of raising the gate. Your other troops attack from the same side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
	
    	if (scbp == "sneak=W FOA=W") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the same side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again."; 
		return; } }
	
    	if (scbp == "sneak=E FOA=E") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the East side. They have the objective of raising the gate. Your other troops attack from the same side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
	
    	if (scbp == "sneak=E FOA=E") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the same side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again."; 
		return; } }
	
    if (scbp == "sneak=N FOA=S") { 
	if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the North side. They have the objective of raising the gate. Your other troops attack from the south side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
	
    	if (scbp == "sneak=N FOA=S") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the south side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again.";
		return;  } }
	
    	if (scbp == "sneak=N FOA=E") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the North side. They have the objective of raising the gate. Your other troops attack from the east side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
	
    	if (scbp == "sneak=N FOA=E") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the east side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again.";
		return;  } }
	
    	if (scbp == "sneak=N FOA=W") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the North side. They have the objective of raising the gate. Your other troops attack from the west side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
	
    	if (scbp == "sneak=N FOA=W") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the west side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again.";
		return;  } }
	
    	if (scbp == "sneak=S FOA=E") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the South side. They have the objective of raising the gate. Your other troops attack from the east side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
	
    	if (scbp == "sneak=S FOA=E") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the east side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again."; 
		return; } }
	
    	if (scbp == "sneak=S FOA=W") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the south side. They have the objective of raising the gate. Your other troops attack from the east side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
	
    	if (scbp == "sneak=S FOA=W") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the west side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again."; 
		return; } }
	
    	if (scbp == "sneak=S FOA=N") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the south side. They have the objective of raising the gate. Your other troops attack from the north side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
	
    	if (scbp == "sneak=S FOA=N") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the north side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again."; 
		return; } }
	
    	if (scbp == "sneak=W FOA=E") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the West side. They have the objective of raising the gate. Your other troops attack from the east side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
		
        if (scbp == "sneak=W FOA=E") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the east side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again.";
		return;  } }
		
        if (scbp == "sneak=W FOA=S") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the west side. They have the objective of raising the gate. Your other troops attack from the south side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
		
        if (scbp == "sneak=W FOA=S") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the south side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again."; 
		return; } }
	
    	if (scbp == "sneak=W FOA=N") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the west side. They have the objective of raising the gate. Your other troops attack from the north side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
	
    	if (scbp == "sneak=W FOA=N") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the north side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again."; 
		return; } }
	
    	if (scbp == "sneak=E FOA=S") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the East side. They have the objective of raising the gate. Your other troops attack from the south side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();}
		return; }
	
    	if (scbp == "sneak=E FOA=S") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the east side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again."; 
		return; } }
	
    	if (scbp == "sneak=E FOA=W") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the east side. They have the objective of raising the gate. Your other troops attack from the west side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();
		return; } }
	
    	if (scbp == "sneak=E FOA=W") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the west side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again."; 
		return; } }
	
    
    	if (scbp == "sneak=E FOA=N") { 
		if (sneak_num == 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack succeeds at getting into the village from the east side. They have the objective of raising the gate. Your other troops attack from the north side after the sneak attack and allow the sneak attack to enter unnoticed. The sneak attack raises the gate and you get in. You immediatly go after the leader and kill him. By killing the leader you became the new leader and all the other troops surrender."; 
		fmlead();}
		return;  }
	
    	if (scbp == "sneak=E FOA=N") { 
		if (sneak_num != 1 or 2 or 3 or 4 or 5) {
		cout << "Your sneak attack gets shot at and dies. Your other troops attack from the north side after the sneak attack. Your soldiers can't break down the gate and die. You also die. Please try again.";
		return; }}
	//this is a little confusing. just spend a minute with it
        if (scbp == " FOA=S" or  " FOA=W" or " FOA=E" or " FOA=N") {
	    	cout << " You skip doing a sneak attack and do a full out assault. Your soldiers can't break through the walls annd die. You also die. Please try again.";
	    return; }
	    
        if (scbp == "sneak=N" or "sneak=S" or "sneak=W" "sneak=E") {
	    	cout << "You do a sneak attack with the purpose of sabatoging the tribe's leader's food. Your sneak attack gets discovered and they die. The forest tribe then attacks you and slaughters you. Please try again.";
cin.get();
		return; 
	    }
}

void f_sneak() {
	cout << "You assault the village and the other orcs hear your sneak attack coming and kill your sneak attack. The rest of you soldiers die due too swords and arrows. They publicly execute you. You die. Please play again.";
cin.get();
	return;
}

void s_sneak() {
	cout << "You succesfully get your sneak attack into the forest village. They can't do any real damage and try to return. They get spotted on the way back and your presence is detected. You die. Please play again.";
cin.get();
	return;
}

void a_plan() {
	cout << "How many soldiers do you want to send in the sneak attack?";
	cin >> sneak_num;
	if (sneak_num <= 5) {
	s_sneak(); }
	if (sneak_num >> 5) {
	f_sneak(); }
cin.get();
	return; 
}
void fao () {
	cout << "You do a full out assault and break down their wall and win the battle.";
	fmlead();
cin.get();
	return;
}
void fsa() {
	cout<<"You do a sneak attack and your troops get seen, alerting them to your presence and thereby getting attacked and dying. Please play again.";
cin.get();
	return;
}
void cbp() {
     // gives a quick way of doing this
	cout << "Your advisor comes up and advises you to do a sneak attack while going all out on the other side of the village. Approve this plan and discuss the details?(Y/N)";
	cin >> answer;
	if (answer == "Y")
	a_plan();
	if (answer == "N") {
               //sets sneak number
	cout << "Do a sneak attack? (Y/N)";
	cin >> answer;
	if (answer == "Y") {
               //adds sneak= to scbp
	scbp = scbp + "sneak=";
	cout << "How many soldiers should participate in the sneak attack?";
	cin >> sneak_num;
	cout << "On the east, west, north or south side? (E/S/W/N)";
	getline (cin, answer);
	getline(cin, answer);
	if (answer == "E")
	scbp = scbp + "E";
	if (answer == "W")
	scbp = scbp + "W";
	if (answer == "S")
	scbp = scbp + "S";
	if (answer == "N")
	scbp = scbp + "N";
}
    cout << "Do a full out assualt with your troops?(Y/N)";
    getline (cin, answer);
	if (answer == "Y"){
	scbp = scbp + " FOA=";
	cout << "On what side of the village? (E/S/W/N)";
	cin >> answer;
	if (answer == "E")
	scbp = scbp + "E";
	if (answer == "W")
	scbp = scbp + "W";
	if (answer == "S")
	scbp = scbp + "S";
	if (answer == "N")
	scbp = scbp + "N";
	cbpon();
	return; }
	if (scbp == "") {
		cout << "Nothing was selected. You die as you decide what to do. Please play again.";
cin.get();
	    return;	
	}
}
}
void o_dip() {
	cout << "You send a diplomat to work things out. The diplomat starts swimming over when an arrow strikes his head. He dies. You take the only option left and charge.";
	cout << "All your warriors swim and arrows fly. Half your warriors die. The rest storm your walls as hot tar gets poured on them. The rest of your soldiers die. The orcs send thier soldiers and they mince you. Please play again.";
cin.get();
	return;
}
void o_charge() {
	cout << "You charge the ocean tribe.All your warriors swim and arrows fly. Half your warriors die. The rest storm your walls as hot tar gets poured on them. The rest of your soldiers die. The orcs send thier soldiers and they mince you. Please play again.";
cin.get();
	return;
}
void ocean_war() {
	cout << "You march your troops to the edge of the sea and see a huge island in the middle of the sea. You see a heavily fortified village. Yell charge and storm them or be diplomatic? (Charge/Dip)";
	getline(cin, answer);
	if (answer == "Charge") {
		o_charge();
	}
	if (answer == "Dip") {
		o_dip();
	}
cin.get();
	return;
}
void forest_war() {
	cout << "You enter a large forest with huge trees and cities built on the treetops. Through the foliage it is perfect to do a stealth attack. Crete your own custom battle plan, go all out, or do a sneak attack?(SA/CBP/AO)";
	getline (cin, answer);
    if (answer == "CBP")
	cbp();
	if (answer == "AO")
	fao();
	if (answer == "SA")	
	fsa();
cin.get();
	return;
}
void desert_war() {
	cout << "You march your troops to the desert. They don't see you through the flying sand.";
	cout << "You charge foward and storm the desert tribe's village. You kill their soldiers and their leader. You have taken over the desert tribe.";
cin.get();
	return;
}
void war_tribe() {
	cout << "A few months pass and your tribe becomes bloodthirsty due to your pep talks. Declare war on the desert, forest, or ocean tribe?(D/F/O)";
	getline(cin, answer);
	if (answer == "D") {
	desert_war();
	cout << "Immediatly after you conquer the desert tribe. You get attacked and you die. Please play again.";
	}
	if (answer == "O") {
	ocean_war();
	}
	if (answer == "F") {
	forest_war();
	}
cin.get();
	return;
}
void dip_tribe() {
     cout << " You turn your tribe into a diplomatic one and in your second month as tribe leader you get attacked. Your soldier's are rusty due to no practice. You die in the attack. Please play again.";
cin.get();
return;
}
void push () {
	cout << "You push yourself through the desert, the heat bears down on you. You start to get dehydrated after drinking all your water and die of dehydration. Please try again.";
cin.get();
	return;
}
void slow () {
	cout << " You go slowly across the desert. You try to conserve your food. AS you cross the desert you see shrubs everywhere. Try one?(Y/N)";
	getline(cin,answer);
	if (answer == "Y") {
		s_poison();
	}
	if (answer == "N") {
		cout << " You decide not to eat the plant. You trudge on eating regularly. Finally, you safely reach where the desert tribe lives.";
		desertt();
	}
cin.get();
	return;
}
void dart () {
	cout << " "<<endl<<endl<<"You start to wake up after a long sleep. You are resting in front of scarred feet. You look up to see a clan chief.Kill or talk to him?(K/T)";
	getline(cin, answer);
	if (answer == "K") {
		cout << "You go into a rage and wreck everything around you. The clan chief dies and soldiers pour into the room. They obviously think a leader ship battle happened and that you won. You are crowned clan chief.";
	clan_chief();
	return;
	} 
	if (answer == "T") {
	cout << "As you try to talk to the clan chief, you insult him by talking first and he rips off your head and eats it. Please try again.";
}
cin.get();
	return;
}
void dsrt () {
	cout << "You walk into the desert with 2 days of food and water. You can either a) Push yourself to make it with the risk of dying of exhaustion or b) go slowly and maybe not make it through in 2 days. Which one? (A/B)?";
	getline(cin, answer);
	if (answer == "A")
	push();
	if (answer == "B")
	slow();
cin.get();
return;
}
void mt () {
	cout << "You enter the mountains looking for the mountain clan. Immedaiatly as you enter the mountains a dart sinks into your neck. You start to feel drowsy and" <<endl <<"... drowse"<<endl <<"... off...";
	dart();
cin.get();
	return;
}
int main () {
          cout << " "<<endl<<"This is Orcs.This game does not save.";
          cout << "You must type everything as shown (with no puntuation)or your " <<endl<< "game will close.";
              cout << " "<<endl<<endl<< "Welcome to the world Orc.";
              orc();
              cin.get();
              return 0;
}
void orc_sadness() {
	cout << "You see ashes and relize a wildfire killed your people. Find another tribe to join or rebuild your village?(Rebuild/Leave)";
    getline(cin, answer);
    getline (cin, answer);
    if (answer == "Rebuild") {
    cout << "You rebuild your village and work on it till you die. You lead a semi-nice life. You go to heaven for your acts, unlike any other orcs before you. The end."; }
    if (answer == "Leave") {
    cout << " You can either go try to find a mountain tribe or a desert tribe. Which one? (Dsrt/Mnt)";
    getline(cin, answer);
	if (answer == "Dsrt")
	dsrt();
	if (answer == "Mnt")
	mt(); }
cin.get();
	return; 
}
void orcvillage() {
     cout  << "You find your village ransacked and everyone there dead."<<endl<<"Commit suicide?(Y/N)";
	 cin >> answer;
	 if (answer == "Y") {
	 cout << "You commit suicide and die. As an Orc you have sinned because of your violent acts. You go to hell. Please try again.";
}
     if (answer == "N")
     orc_sadness();
cin.get();
     return;
}
void forestwalk() {
    cout << "You walk around the forest and find nothing of interest. You decide to return to your village.";
    orcvillage();
cin.get();
	return;
}
void pray() {
    cout << "You pray to the spirits and they bless you and lift you to the heavens. You lead"<<endl<<" a peaceful life up there.";
cin.get();
	return;
}
void torture () {
    cout << " "<<endl<<"You start to torture the prisoner by dipping their legs into fire. The prisoner"<<endl<<" dies.";
    cout  << "You now go to the sacred grounds alone. Destroy them or leave them be?     (D/L)";
    getline(cin, answer);
    if (answer == "D") {
       destroy() ; }
    if (answer == "P") {
       pray() ;  }
    if (answer == "L")
    forestwalk() ;
cin.get();
    return;
}
void orc () {
    cout << "You are in a forest."<<endl<<"You have just achieved manhood. You must go and lead a group of orcs"<<endl<<" to the forest's sacred grounds. You find the other orcs. Once you get to the "<<endl<<"sacred grounds, You find someone on them and kidnap them.";
    orc_sanctum() ;
cin.get();
    return;
    
}
void orc_sanctum () {
    cout << "Toture the captured "<<endl<<"prisoner or talk to the magic user? (TO/TA)";
    getline(cin, answer); 
if (answer == "TO")
       torture() ;
    if (answer == "TA") {
       cout << "The prisoner talks about how he didn't know he was on your sacred grounds. You forgive him. The prisoner leaves. You go to the sacred grounds alone.";
       cout  << "You reach the sacred grounds. Destroy them or leave them be?(D/L)";
    getline(cin, answer) ;
    if (answer == "D") {
       destroy(); }
    if (answer == "P") {
       pray();  }
    if (answer == "L")
    forestwalk();
cin.get();
    return;
}
}
void destroy() {
      cout << "You go into a rage and destroy your holy grounds." ;
      cout << "All the other orcs storm at you and eat you"<<endl<<" alive. You die. Please try again.";
cin.get();
      return;
}
void clan_chief() {
	cout << "You can do 2 things as a clan chief. Turn your tribe into a bloodthirsty one or make it a diplomatic tribe. Which one? (War/Dip)";
	getline(cin, answer);
	if (answer == "War") 
	war_tribe();
	if (answer == "Dip")
	dip_tribe();
cin.get();
	return;
}