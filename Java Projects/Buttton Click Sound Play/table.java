import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import java.io.File;
import java.net.*;

class table extends JFrame implements ActionListener{
JFrame frm;
AudioClip a;
int status=0;
JButton b1;
table()throws MalformedURLException, InterruptedException{

frm=new JFrame();
frm.setSize(500,500);
frm.setLocationRelativeTo(null);
frm.setLayout(null);
frm.setDefaultCloseOperation(3);

File A = new File("w0Hp0XU7wOO6.128.wav");
this.a = Applet.newAudioClip(A.toURL());


b1=new JButton("Play");
b1.setBounds(130,130,200,200);
frm.add(b1);
b1.addActionListener(this);
b1.setFocusable(true);
frm.setVisible(true);

}

public void actionPerformed(ActionEvent e){

Object ob=e.getSource();

if(ob==b1){

if(status==0){
status=1;
b1.setText("Stop");
this.a.play();
}
else if(status==1){
status=0;
b1.setText("Play");
this.a.stop();
}
}


}
public static void main(String args[])throws MalformedURLException, InterruptedException{


table tb=new table();
}
}