import javax.swing.*;
class stringReverse{
public static void main(String args[]){


String str=JOptionPane.showInputDialog("Enter Your Name");


String s="";
char c[]=str.toCharArray();

for(int i=c.length-1; i>=0; i--){

s+=" "+c[i];

}
JOptionPane.showMessageDialog(null,s);

}

}