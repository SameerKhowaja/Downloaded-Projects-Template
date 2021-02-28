import java.awt.*;

import java.awt.event.*;

import java.util.Random;
import javax.swing.*;


public class table  extends JFrame  implements ActionListener{
 
 

  JLabel label = new JLabel();
  JLabel L1 = new JLabel();
  JLabel L2 = new JLabel();
  JButton p1 = new JButton();
  JButton p2 = new JButton();
  JLabel D1 = new JLabel();
  JLabel D2 = new JLabel();
  JLabel D3 = new JLabel();
  JLabel D4 = new JLabel();
  JLabel D5 = new JLabel();
  JLabel D6 = new JLabel();
  
  
  table()
  {
    setBounds(0, 0, 710, 740);
    setResizable(false);
    

    Container c = getContentPane();
    c.setLayout(null);
    c.setBackground(Color.white);
     setLocationRelativeTo(null);
	 
	 this.L1.setBackground(null);
    this.L1.setIcon(new ImageIcon("ye.png"));
    this.L1.setBounds(45, 475, 33, 33);
    c.add(this.L1);
	
	this.L2.setBackground(null);
    this.L2.setIcon(new ImageIcon("re.png"));
    this.L2.setBounds(76, 475, 33, 33);
    c.add(this.L2);

label.setIcon(new ImageIcon("snake.png"));

label.setBounds(0,0,710,565);

c.add(label);
    
    
	
    this.p1.setBackground(null);
    this.p1.setIcon(new ImageIcon("s.jpg"));
    this.p1.setBounds(20, 570, 81, 147);
    c.add(this.p1);
    

    this.p2.setBackground(null);
    this.p2.setIcon(new ImageIcon("g.jpg"));
    this.p2.setBounds(600, 570, 81, 147);
    c.add(this.p2);
    
    this.D1.setBounds(350, 570, 114, 127);
    this.D2.setBounds(350, 570, 104, 91);
	this.D3.setBounds(350, 570, 69, 150);
	this.D4.setBounds(350, 570, 105, 108);
	this.D5.setBounds(350, 570, 122, 101);
	this.D6.setBounds(350, 570, 131, 129);

    show();
    setDefaultCloseOperation(3);
    this.p1.addActionListener(this);
    this.p2.addActionListener(this);
  }
  
  public void actionPerformed(ActionEvent e)
  {
    Object ob = e.getSource();
    Random rand = new Random();
    int pick = rand.nextInt(7);
    
    int j = 0;
    if (pick == 0) {
      j = pick + 1;
    } else if (pick == 7) {
      j = pick - 1;
    } else {
      j = pick;
    }
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
    if (ob==p1 && j <= 5)
      
    {
      p1.setVisible(false);
      p2.setVisible(true);
    }
    if (ob ==p2) {
      if (j <= 5)
      {
        p2.setVisible(false);
        p1.setVisible(true);
      }
    }
    if (pick == 1)
    {
      this.D1.setIcon(new ImageIcon("1.png"));
      add(this.D1);
	  D2.setVisible(false);
	  D3.setVisible(false);
	  D4.setVisible(false);
	  D5.setVisible(false);
	  D6.setVisible(false);
	  D1.setVisible(true);
	  
    }
    if (pick == 2)
    {
      this.D2.setIcon(new ImageIcon("2.png"));
      add(this.D2);
	  D1.setVisible(false);
	  D3.setVisible(false);
	  D4.setVisible(false);
	  D5.setVisible(false);
	  D6.setVisible(false);
	  D2.setVisible(true);
    }
    if (pick == 3)
    {
      this.D3.setIcon(new ImageIcon("3.png"));
      add(this.D3);
	  
	  D1.setVisible(false);
	  D2.setVisible(false);
	  D4.setVisible(false);
	  D5.setVisible(false);
	  D6.setVisible(false);
	  D3.setVisible(true);
    }
    if (pick == 4)
    {
      this.D4.setIcon(new ImageIcon("4.png"));
      add(this.D4);
	  D1.setVisible(false);
	  D2.setVisible(false);
	  D3.setVisible(false);
	  D5.setVisible(false);
	  D6.setVisible(false);
	  D4.setVisible(true);
    }
    if (pick == 5)
    {
      this.D5.setIcon(new ImageIcon("5.png"));
      add(this.D5);
	  D1.setVisible(false);
	  D2.setVisible(false);
	  D3.setVisible(false);
	  D4.setVisible(false);
	  D6.setVisible(false);
	  D5.setVisible(true);
    }
    if (pick == 6)
    {
	
	  D1.setVisible(false);
	  D2.setVisible(false);
	  D3.setVisible(false);
	  D4.setVisible(false);
	  D5.setVisible(false);
	  D6.setVisible(true);
      this.D6.setIcon(new ImageIcon("6.png"));
      add(this.D6);
    }
  }
  
  public static void main(String[] args)
  {
    table L = new table();
  }
}
