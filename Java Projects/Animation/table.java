import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


class table extends JPanel implements ActionListener{
Timer tm=new Timer(1,this);

int x=0,velX=2;

public void paintComponent(Graphics g){
super.paintComponent(g);

g.setColor(Color.red);

g.fillRect(x,130,50,30);
g.fillRect(440-x,130,50,30);
tm.start();

}

public void actionPerformed(ActionEvent e){

if(x<0 || x>200)
velX=-velX;

x=x+velX;

repaint();

}




public static void main(String []args){

table t=new table();

JFrame jf=new JFrame();

jf.setSize(500,500);

jf.setVisible(true);

jf.setDefaultCloseOperation(3);

jf.add(t);

}
}