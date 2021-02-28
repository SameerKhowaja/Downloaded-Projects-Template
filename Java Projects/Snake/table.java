import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


class table extends JPanel implements ActionListener,KeyListener{
Timer tm=new Timer(1,this);

int x=0,y=0,velX=0,velY=0;

public table(){
tm.start();
addKeyListener(this);
setFocusable(true);
setFocusTraversalKeysEnabled(false);

}

public void paintComponent(Graphics g){
super.paintComponent(g);

g.setColor(Color.red);

g.fillRect(x,y,50,30);


}


public void actionPerformed(ActionEvent e){

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


public void keyReleased(KeyEvent e){}
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