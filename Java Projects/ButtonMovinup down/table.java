import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


class table extends JFrame implements ActionListener{
Timer tm=new Timer(1,this);
JButton b1=new JButton();
JButton b2=new JButton();
int x=0,y=2;
int x2=0,y2=2;
table(){
JFrame jf=new JFrame();

jf.setSize(500,300);

jf.setVisible(true);
jf.setLayout(null);
jf.setDefaultCloseOperation(3);
jf.add(b1);


b1.setBounds(0,150+x,80,40);





tm.start();

}

public void actionPerformed(ActionEvent e){

if(x<0 || x>225)

y=-y;

b1.setBounds(200,x,80,40);

x=x+y;










}




public static void main(String []args){

table t=new table();





}
}