import javax.swing.JOptionPane;
class middle{
public static void main(String args[]){



int num1=Integer.parseInt(JOptionPane.showInputDialog("Enter First Number"));
int num2=Integer.parseInt(JOptionPane.showInputDialog("Enter Second Number"));
int num3=Integer.parseInt(JOptionPane.showInputDialog("Enter Third Number"));




if((num1<num2 || num1<num3) && (num1>num2 || num1>num3)){

JOptionPane.showMessageDialog(null,"The Middle Value is ===>  "+num1);

}

else if((num2<num1 || num2<num3) && (num2>num1 || num2>num3)){

JOptionPane.showMessageDialog(null,"The Middle Value is ===>  "+num2);

}

else if((num3<num1 || num3<num2) && (num3>num1 || num3>num2)){

JOptionPane.showMessageDialog(null,"The Middle Value is ===>  "+num3);

}
else{

JOptionPane.showMessageDialog(null,"The Values is same");

}




}

}