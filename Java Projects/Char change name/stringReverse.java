import javax.swing.*;
class stringReverse{
public static void main(String args[]){


String str=JOptionPane.showInputDialog("Enter Your Name");


String s="";
char c[]=str.toCharArray();

for(int i=0; i<c.length; i++){

if(c[i]=='s'){
s+="g";

}

else{
s+=" "+c[i];

}

}
JOptionPane.showMessageDialog(null,s);

}

}