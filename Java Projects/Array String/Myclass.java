import java.util.Scanner;
import javax.swing.*;
public class Myclass{


public static void main (String args[]){
int j;
Scanner in= new Scanner(System.in);
String num[]=new String[6];

for(int i=1; i<6;i++){

System.out.println("\n\n"+i+" name ");
num[i]=in.nextLine();

}

for( j=1; j<6;j++){

System.out.println("\n\n"+(j)+" name "+num[j]);
}


for(int n=1; n<6;n++){
System.out.println(n+" number "+num[n]);
}




System.out.println("Find the Number");
int s=in.nextInt();

for(int i=1; i<6;i++){

if(num[i]==num[s]){

System.out.println("Your Search the number is ===> "+s+"\nAnd find Name is ===> "+num[i]);


}

}











}
}