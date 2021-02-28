import java.util.Scanner;
public class Myclass{


public static void main (String args[]){
int j;
Scanner in= new Scanner(System.in);
int num[]=new int[6];
//int find[]=new int[3];
for(int i=1; i<6;i++){

System.out.println("\nEnter "+(i)+" number");
num[i]=in.nextInt();

}

for( j=1; j<6;j++){
System.out.println("\n\n"+(j)+" number "+num[j]);

}
System.out.println("\n\n\nFind the Number");
int find=in.nextInt();

for(int z=1; z<6;z++){
if(num[z]==num[find]){
System.out.println("Your Search Number is ==>  "+find+"  And find value is ==>  "+num[z]);

}


}















}
}