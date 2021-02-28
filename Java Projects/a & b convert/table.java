import javax.swing.*;

class table{
public static void main(String args[]){

int a=Integer.parseInt(JOptionPane.showInputDialog("Enter a Value"));
int b=Integer.parseInt(JOptionPane.showInputDialog("Enter b Value"));

int c=10;


c=a;

a=b;

b=c;


System.out.println("Value is a ==> "+a+"\nThe Value is b ===> "+b);





}
}