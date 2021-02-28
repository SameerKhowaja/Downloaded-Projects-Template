import javax.swing.*;

import javax.imageio.ImageIO;
import java.awt.Image;
import java.util.*;
import java.awt.image.BufferedImage;
import java.net.*;
import java.io.*;
import java.awt.*;

class table extends JFrame{





JFrame frm;
table(){






frm=new JFrame();
frm.setSize(500,500);

frm.setVisible(true);
frm.setDefaultCloseOperation(3);

image=new ImageIcon("3.png");
frm.setIconImage(image.getImage());

frm.setResizable(false);

}
private ImageIcon image=null;

public static void main(String args[])throws Exception{

table tb=new table();
}

}