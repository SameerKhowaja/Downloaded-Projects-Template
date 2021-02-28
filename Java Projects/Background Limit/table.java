import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


class table extends JPanel implements ActionListener,KeyListener{
Timer tm=new Timer(1,this);

int x=0,y=0,velX=0,velY=0;

public table(){

addKeyListener(this);
setFocusable(true);
setFocusTraversalKeysEnabled(false);
tm.start();
}

public void paintComponent(Graphics g){
super.paintComponent(g);

g.setColor(Color.RED);

g.fillRect(x,y,50,30);


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

public void keyPressed(KeyEvent e){


int c=e.getKeyCode();

if(c==KeyEvent.VK_LEFT){

velX=-1;
velY=0;
}
if(c==KeyEvent.VK_UP){

velX=0;
velY=-1;
}
if(c==KeyEvent.VK_RIGHT){

velX=1;
velY=0;
}
if(c==KeyEvent.VK_DOWN){

velX=0;
velY=1;
}
}


public void keyReleased(KeyEvent e){

velX=0;
velY=0;

}
public void keyTyped(KeyEvent e){}





public static void main(String []args){

table t=new table();

JFrame jf=new JFrame();

jf.setSize(600,400);

jf.setVisible(true);

jf.setDefaultCloseOperation(3);

jf.add(t);

}
}