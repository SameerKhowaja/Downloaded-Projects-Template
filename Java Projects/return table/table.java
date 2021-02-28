import javax.swing.JOptionPane;
class table{
public static void main(String agrs[]){

in();

}
public static int in(){


int a=0;


String str="";
try{
a=Integer.parseInt(JOptionPane.showInputDialog("Enter Your choice any number you want table print"));

for(int c=1; c<=10; c++){


str+="                      "+a+"        x        "+c+"        =        "+a*c;

str+="\n";
}
a=JOptionPane.showConfirmDialog(null,str+"Are you sure more tables click yes button otherwise or cancel");
if(a==0){
in();
}
else{

System.exit(0);


}

}catch(Exception e){

a=JOptionPane.showConfirmDialog(null,"You type wrong number continue press yes button no otherwise or cancel");

if(a==0){
in();

}
else{

System.exit(0);

}
}

return a;





}










}





