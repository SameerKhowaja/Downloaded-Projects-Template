import java.util.Scanner;
import javax.swing.*;
public class Myclass{


public static void main (String args[]){
int j;
Scanner in= new Scanner(System.in);
String num[]={"a","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};

System.out.println("put number and find alphabate");
int s=in.nextInt();

for(int i=1; i<num.length;i++){

if(num[i]==num[s]){

System.out.println("Your Search the number is ===> "+s+"\nAnd find alpha bate is ===> "+num[i]);


}

}











}
}