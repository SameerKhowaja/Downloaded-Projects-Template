import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.*;
import java.net.*;

class table{

public static void main(String args[]){


String str1=JOptionPane.showInputDialog("Enter the number");

String str2=JOptionPane.showInputDialog("Enter the power");

int num1=Integer.parseInt(str1);
int num2=Integer.parseInt(str2);
int power=1;


for(int count=1; count<=num2; count++){

power=power*num1;



}
JOptionPane.showMessageDialog(null,"The Answer is ===> "+power);










}

}