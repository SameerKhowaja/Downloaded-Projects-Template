import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class butttonMovingKey extends JFrame implements KeyListener,ActionListener{
JFrame frm;
JButton bn;
int x=0,y=0,velX=0,velY=0;
Timer tm=new Timer(1,this);
butttonMovingKey(){

frm=new JFrame();
frm.setSize(600,400);
frm.setLocationRelativeTo(null);
frm.setLayout(null);
frm.setTitle("butttonMovingKey");
frm.setDefaultCloseOperation(3);




bn=new JButton();
bn.setBounds(velX,velY,50,30);
frm.add(bn);

bn.addKeyListener(this);
bn.setFocusable(true);
bn.setFocusTraversalKeysEnabled(false);
frm.setVisible(true);
tm.start();
}

public void actionPerformed(ActionEvent e){


if(x<0){
velX=0;
x=0;
}
if(x>530){
velX=0;
x=530;

}
if(y<0){
velY=0;
y=0;
}
if(y>330){
velY=0;
y=330;
}
x=x+velX;
y=y+velY;

repaint();

}
public void keyTyped(KeyEvent e){}
public void keyPressed(KeyEvent e){

int c=e.getKeyCode();

if(c==KeyEvent.VK_LEFT){
bn.setBounds(x,y,50,30);
velX=-1;
velY=0;
}
if(c==KeyEvent.VK_UP){
bn.setBounds(x,y,50,30);
velX=0;
velY=-1;
}
if(c==KeyEvent.VK_RIGHT){
bn.setBounds(x,y,50,30);
velX=1;
velY=0;
}
if(c==KeyEvent.VK_DOWN){
bn.setBounds(x,y,50,30);
velX=0;
velY=1;
}



}
public void keyReleased(KeyEvent e){


velX=0;

velY=0;
}









public static void main(String args[]){



butttonMovingKey button=new butttonMovingKey();


}
}