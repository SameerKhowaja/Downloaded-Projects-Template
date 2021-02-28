import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import java.io.File;
import java.net.*;

class table extends JFrame implements MouseMotionListener{
JFrame frm;
AudioClip a;
int status=0;
JButton b1;
JLabel label,label2;
table()throws MalformedURLException, InterruptedException{

frm=new JFrame();
frm.setSize(500,500);
frm.setLocationRelativeTo(null);
frm.setLayout(null);
frm.setDefaultCloseOperation(3);
frm.setVisible(true);



label=new JLabel("Click Me");
label.setBounds(100,100,48,9);
frm.add(label);
label.setForeground(Color.black);
label2=new JLabel("_______");
label2.setBounds(100,97,100,15);
label2.setForeground(Color.red);
frm.add(label2);
label2.setVisible(false);
frm.addMouseMotionListener(this);
label.addMouseMotionListener(this);
label2.addMouseMotionListener(this);
label.setBackground(Color.red);

label.addMouseListener(new MouseAdapter(){





public void mouseClicked(MouseEvent e){


int count=e.getClickCount();

if(count==1){
JOptionPane.showMessageDialog(null,"Label is ActionPerformed");

}


}


});
}
public void mouseDragged(MouseEvent e){}
  public void mouseMoved(MouseEvent e){
  
  Object ob=e.getSource();
  
  if(ob==label){
  
  label2.setVisible(true);
  
  }
  
  else{
  
  label2.setVisible(false);
  }
  
  
  
  }

public static void main(String args[])throws MalformedURLException, InterruptedException{


table tb=new table();
}
}