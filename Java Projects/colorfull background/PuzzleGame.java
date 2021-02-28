
import java.util.Date;

import java.awt.event.*;
import java.awt.*;
import java.applet.*;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.net.MalformedURLException;
import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;
import java.applet.Applet;
import java.applet.AudioClip;
import java.awt.event.KeyEvent;
import java.awt.event.MouseEvent;
import java.io.File;
import java.net.MalformedURLException;
import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JFrame;

import javax.swing.*;


public class PuzzleGame
  extends JFrame 
  
{
   JButton b1 = new JButton();
  JButton b2 = new JButton();
  JButton b3 = new JButton();
  Thread th;

  JButton b4 = new JButton();
  JButton b5 = new JButton();
  JButton b6 = new JButton();
  JButton b7 = new JButton();
  JButton b8 = new JButton();
  JButton b9 = new JButton();
  JButton b10 = new JButton();
  JButton b11 = new JButton();
  JButton b12 = new JButton();
  JButton b13 = new JButton();
  JButton b15 = new JButton();
  JButton b14 = new JButton();
  JButton b16 = new JButton();
  JButton b17 = new JButton();
  JButton b18 = new JButton();
  JButton b19 = new JButton();
  JButton b20 = new JButton("Back");
  
  JButton b21 = new JButton();
  JButton b28 = new JButton();
  JButton b24 = new JButton();
  JButton b25 = new JButton();
  JButton b26 = new JButton();
  JButton b27 = new JButton();
  JButton b23=new JButton(new ImageIcon("8.png"));
 
  JButton b29 = new JButton(new ImageIcon("6.png"));
  JButton b30 = new JButton(new ImageIcon("2.png"));
  JButton b31 = new JButton(new ImageIcon("7.png"));
  JButton b32 = new JButton(new ImageIcon("1.png"));
  JButton b33 = new JButton(new ImageIcon("5.png"));
  JButton b34 = new JButton(new ImageIcon("9.png"));
  JButton b35 = new JButton(new ImageIcon("10.png"));
  JButton b36 = new JButton("Back");
  JButton b37 = new JButton("Yes");
  JButton b38 = new JButton("Back");
  JButton b39 = new JButton("No");
  
 JLabel LL2=new JLabel();
 JLabel LL=new JLabel();
 JLabel LL3=new JLabel();
 JLabel LL4=new JLabel();
 JLabel LL5=new JLabel();
 JLabel LL6=new JLabel();
 JLabel LL7=new JLabel();
 JLabel LL8=new JLabel();
 JLabel LL9=new JLabel();
 JLabel LL10=new JLabel();
 JLabel LL11=new JLabel();
 JLabel LL12=new JLabel();
 JLabel LL13=new JLabel();
 JLabel LL14=new JLabel();
 JLabel LL15=new JLabel();
 JLabel LL16=new JLabel();
 JLabel LL17=new JLabel();
 JLabel LL18=new JLabel();
 JLabel LL19=new JLabel();
 JLabel LL20=new JLabel();
  JLabel L1=new JLabel();
  JTextField fi2=new JTextField();
JLabel L2=new JLabel();
JTextField fi=new JTextField();
JPasswordField fp=new JPasswordField();
JButton login=new JButton();
  JFrame fe;
 JFrame f;
  JFrame fn;
  AudioClip a;
  JPanel n;
  JFrame fk;
  JFrame fg;
  JFrame ft;
  JFrame fmmm;
 
  PuzzleGame()throws MalformedURLException, InterruptedException
  {
   
    fe=new JFrame();
    fe.setVisible(true);
	
	fe.setSize(400,500);
	fe.setLocationRelativeTo(null);
	fe.setLayout(null);
fe.setDefaultCloseOperation(fe.EXIT_ON_CLOSE);





LL11=new JLabel("Email            :       s");
LL11.setBounds(120,300,200,20);
fe.add(LL11);



LL12=new JLabel("Password    :       1");
LL12.setBounds(120,350,200,20);
fe.add(LL12);



login=new JButton("Login");
login.setBounds(120,190,70,20);

fe.add(login);
    
	setDefaultCloseOperation(3);


  fi=new JTextField();
fi.setBounds(60,70,230,20);
fe.add(fi);

L1=new JLabel("Email");
L1.setBounds(60,50,70,20);
fe.add(L1);

fp=new JPasswordField();
fp.setBounds(60,130,230,20);
fe.add(fp);


L2=new JLabel("Password");
L2.setBounds(60,110,70,20);
fe.add(L2);

File A = new File("Sleep Away.wav");
this.a = Applet.newAudioClip(A.toURL());
this.a.loop();

login.addActionListener(new ActionListener(){

public void actionPerformed(ActionEvent ed){



if(fi.getText().equals("s")&&fp.getText().equals("1")){



	
f=new JFrame();
fe.dispose();
    f.setVisible(true);
	
	f.setSize(400,500);
	f.setLocationRelativeTo(null);
	f.setLayout(null);
f.setDefaultCloseOperation(f.EXIT_ON_CLOSE);

//this.a.loop();
 

   b1.setText("red");
   b1.setBounds(40,30,100,50);
   
   f.add(b1);
   
   
    b2.setText("Green");
   b2.setBounds(150,30,100,50);
   f.add(b2);
   
   b3.setText("Skyblue");
   b3.setBounds(260,30,100,50);
   f.add(b3);
  
    b4.setText("Yellow");
   b4.setBounds(40,100,100,50);
   f.add(b4);
   
    b5.setText("Blue");
   b5.setBounds(150,100,100,50);
   f.add(b5);
   
   b6.setText("Orange");
   b6.setBounds(260,100,100,50);
   f.add(b6);
   
    b7.setText("Black");
   b7.setBounds(40,170,100,50);
   f.add(b7);
    b8.setText("White");
   b8.setBounds(150,170,100,50);
   f.add(b8);
   b9.setText("Pink");
   b9.setBounds(260,170,100,50);
   f.add(b9); 
   b10.setText("No");
   b10.setBounds(260,405,100,50);
   f.add(b10);
   b11.setText("Yes");
   b11.setBounds(40,405,100,50);
   f.add(b11);
   LL.setText("Are you sure More apps press yes no other wise or cancel");
	
	LL.setBounds(40,350,350,20);
	f.add(LL);
	
	
	b1.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b1==b1){
	    
  
	f.getContentPane().setBackground(Color.red);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	b2.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent et){
	
	
	if(b2==b2){
	    
   
	f.getContentPane().setBackground(Color.green);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	b3.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent et){
	
	
	if(b3==b3){
	    
	f.getContentPane().setBackground(Color.cyan);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	b4.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent et){
	
	
	if(b4==b4){
	    
	f.getContentPane().setBackground(Color.yellow);
	
	}
	
	
	
	
	
	}
	
	
	
	});
   b5.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b5==b5){
	   
	f.getContentPane().setBackground(Color.blue);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	b6.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b6==b6){
	    
	f.getContentPane().setBackground(Color.orange);
	
	
	}
	
	
	
	
	
	}
	
	
	
	});
	b2.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent et){
	
	
	if(b2==b2){
	    
	f.getContentPane().setBackground(Color.green);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	b7.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent et){
	
	
	if(b7==b7){
	    
	f.getContentPane().setBackground(Color.black);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	b1.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b1==b1){
	    
	f.getContentPane().setBackground(Color.red);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	b8.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent et){
	
	
	if(b8==b8){
	    
	f.getContentPane().setBackground(Color.white);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	b1.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b1==b1){
	   
	f.getContentPane().setBackground(Color.red);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	b9.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent et){
	
	
	if(b9==b9){
	    
	f.getContentPane().setBackground(Color.pink);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	b10.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	Object ob = e.getSource();
	if(ob==b10){
	  System.exit(0);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	b11.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b11==b11){
	f.dispose();
	fn=new JFrame();
	fn.setSize(455,700);
	fn.setVisible(true);
	fn.setDefaultCloseOperation(fn.EXIT_ON_CLOSE);
	fe.dispose();
	f.setVisible(false);
	fn.setLayout(null);
	fn.setLocationRelativeTo(null);
	
	b12.setText("Yes");
   b12.setBounds(130,50,80,20);
   fn.add(b12);
   
	
	
	LL2.setText("Are you sure You Print Table press yes");
	LL2.setBounds(70,10,300,20);
	//LL2.setForeground(Color.red);
	fn.add(LL2);
	
	LL3.setText("Are you sure You Print Marks Sheet press yes");
	LL3.setBounds(70,120,350,20);
	//LL3.setForeground(Color.red);
	fn.add(LL3);
	b13.setText("Yes");
   b13.setBounds(130,160,80,20);
   fn.add(b13);
	
	LL4.setText("Are you sure You Print Calculator press yes");
	LL4.setBounds(70,230,350,20);
	//LL4.setForeground(Color.red);
	fn.add(LL4);
	b14.setText("Yes");
   b14.setBounds(130,270,80,20);
   fn.add(b14);
   
   
   LL5.setText("Are you sure You Print Date press yes");
	LL5.setBounds(70,330,400,20);
	//LL5.setForeground(Color.red);
	fn.add(LL5);
	b15.setText("Yes");
   b15.setBounds(130,370,80,20);
   fn.add(b15);
   
   
   
   LL6.setText("Are you sure You More Apps Continue press Continue No otherwise or cancel");
	LL6.setBounds(0,500,750,20);
	//LL6.setForeground(Color.red);
	fn.add(LL6);
   
	
	
	
	b16.setText("Back");
   b16.setBounds(170,550,90,70);
   fn.add(b16);
	
	b17.setText("NO");
   b17.setBounds(300,550,90,70);
   fn.add(b17);
	
	
	b20.setText("Continue");
   b20.setBounds(40,550,90,70);
   fn.add(b20);
	
	
	
	
	b12.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent ej){
	
	
	if(b12==b12){
	
	try{
	  String in=JOptionPane.showInputDialog("Enter Your Choice Any Number You Want Table Print");
	  
	  int table=Integer.parseInt(in);
		
	String str="";
	
	for(int count=1; count<=10; count++){
	
	str+=table+"        X        "+count+"        =        "+table*count;
	
	str+="\n";
	
	
	}
	JOptionPane.showMessageDialog(null,str);
	}catch(Exception sa){JOptionPane.showMessageDialog(null,"You Type Wrong Number try Please Again");}
	}
	
	
	
	
	
	}
	
	
	
	});
	
	b13.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b13==b13){
	  
	try{  
int eng=Integer.parseInt(JOptionPane.showInputDialog("Enter English Marks"));
int urd=Integer.parseInt(JOptionPane.showInputDialog("Enter Urdu Marks"));
int isl=Integer.parseInt(JOptionPane.showInputDialog("Enter Islamiyat Marks"));
int sst=Integer.parseInt(JOptionPane.showInputDialog("Enter SST Marks"));
int sin=Integer.parseInt(JOptionPane.showInputDialog("Enter Sindhi Marks"));
int mat=Integer.parseInt(JOptionPane.showInputDialog("Enter Math Marks"));    
int gra=Integer.parseInt(JOptionPane.showInputDialog("Enter Grammar Marks"));    
int sci=Integer.parseInt(JOptionPane.showInputDialog("Enter Science Marks"));    
int dra=Integer.parseInt(JOptionPane.showInputDialog("Enter Drawing Marks"));    
int com=Integer.parseInt(JOptionPane.showInputDialog("Enter Computer Marks"));        
int totalmarks=1000;
float obtainmarks=eng+urd+isl+sst+sin+mat+gra+sci+dra+com;
float per=(obtainmarks*100)/totalmarks;
if(per>=90){JOptionPane.showMessageDialog(null,"The English Marks : "+(eng)+"\nThe Urdu Marks : "+(urd)+"\nThe Islamiyat Marks : "+(isl)+"\nThe SST Marks : "+(sst)+"\nThe Sindhi Marks : "+(sin)+"\nThe Math Marks : "+(mat)+"\nThe Grammar Marks : "+(gra)+"\nThe Science Marks : "+(sci)+"\nThe Drawing Marks : "+(dra)+"\nThe Computer Marks : "+(com)+"\n\nThe Total Marks : 1000"+"\n\nObtain Marks : "+(obtainmarks)+"\n\nPercentage : "+(per+"%")+"\n\n                      A+\n              WAH WAH");}
else if(per>=80){JOptionPane.showMessageDialog(null,"The English Marks : "+(eng)+"\nThe Urdu Marks : "+(urd)+"\nThe Islamiyat Marks : "+(isl)+"\nThe SST Marks : "+(sst)+"\nThe Sindhi Marks : "+(sin)+"\nThe Math Marks : "+(mat)+"\nThe Grammar Marks : "+(gra)+"\nThe Science Marks : "+(sci)+"\nThe Drawing Marks : "+(dra)+"\nThe Computer Marks : "+(com)+"\n\nThe Total Marks : 1000"+"\n\nObtain Marks : "+(obtainmarks)+"\n\nPercentage : "+(per+"%")+"\n\n                B Grade\n                    BEST");}
else if(per>=70){JOptionPane.showMessageDialog(null,"The English Marks : "+(eng)+"\nThe Urdu Marks : "+(urd)+"\nThe Islamiyat Marks : "+(isl)+"\nThe SST Marks : "+(sst)+"\nThe Sindhi Marks : "+(sin)+"\nThe Math Marks : "+(mat)+"\nThe Grammar Marks : "+(gra)+"\nThe Science Marks : "+(sci)+"\nThe Drawing Marks : "+(dra)+"\nThe Computer Marks : "+(com)+"\n\nThe Total Marks : 1000"+"\n\nObtain Marks : "+(obtainmarks)+"\n\nPercentage : "+(per+"%")+"\n\n                C Grade\n             GOOD LUCK");}
else if(per>=60){JOptionPane.showMessageDialog(null,"The English Marks : "+(eng)+"\nThe Urdu Marks : "+(urd)+"\nThe Islamiyat Marks : "+(isl)+"\nThe SST Marks : "+(sst)+"\nThe Sindhi Marks : "+(sin)+"\nThe Math Marks : "+(mat)+"\nThe Grammar Marks : "+(gra)+"\nThe Science Marks : "+(sci)+"\nThe Drawing Marks : "+(dra)+"\nThe Computer Marks : "+(com)+"\n\nThe Total Marks : 1000"+"\n\nObtain Marks : "+(obtainmarks)+"\n\nPercentage : "+(per+"%")+"\n\n                D Grade\n              GOOD JOB");}
else if(per>=50){JOptionPane.showMessageDialog(null,"The English Marks : "+(eng)+"\nThe Urdu Marks : "+(urd)+"\nThe Islamiyat Marks : "+(isl)+"\nThe SST Marks : "+(sst)+"\nThe Sindhi Marks : "+(sin)+"\nThe Math Marks : "+(mat)+"\nThe Grammar Marks : "+(gra)+"\nThe Science Marks : "+(sci)+"\nThe Drawing Marks : "+(dra)+"\nThe Computer Marks : "+(com)+"\n\nThe Total Marks : 1000"+"\n\nObtain Marks : "+(obtainmarks)+"\n\nPercentage : "+(per+"%")+"\n\n                E Grade\n                BEAKAR");}
else{JOptionPane.showMessageDialog(null,"The English Marks : "+(eng)+"\nThe Urdu Marks : "+(urd)+"\nThe Islamiyat Marks : "+(isl)+"\nThe SST Marks : "+(sst)+"\nThe Sindhi Marks : "+(sin)+"\nThe Math Marks : "+(mat)+"\nThe Grammar Marks : "+(gra)+"\nThe Science Marks : "+(sci)+"\nThe Drawing Marks : "+(dra)+"\nThe Computer Marks : "+(com)+"\n\nThe Total Marks : 1000"+"\n\nObtain Marks : "+(obtainmarks)+"\n\nPercentage : "+(per+"%")+"\n\nSorry You are Fail         ");}

	}catch(Exception ewf){JOptionPane.showMessageDialog(null,"You Type Wrong Number Please Try Again");}  
	
	}
	
	
	
	
	
	}
	
	
	
	});
	b14.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b14==b14){
	  
	  try{
	  String n1=JOptionPane.showInputDialog("Enter First Number");
	  String n2=JOptionPane.showInputDialog("Enter Second Number");
	  
	  int a=Integer.parseInt(n1);
	  int b=Integer.parseInt(n2);
	  
	  String op=JOptionPane.showInputDialog("Enter Your Operator");
	  
	  
	  
	  
	  if(op.equals("+")){
	  JOptionPane.showMessageDialog(null,("ADD    :    "+(a+b)));
	  }
	  
	  if(op.equals("-")){
	  JOptionPane.showMessageDialog(null,("SUB    :    "+(a-b)));
	  }
	  
	  
	  if(op.equals("*")){
	  JOptionPane.showMessageDialog(null,("MUL    :    "+(a*b)));
	  }
	  
	  if(op.equals("/")){
	  JOptionPane.showMessageDialog(null,("DIV    :    "+(a/b)));
	  }
	  
	  if(op.equals("%")){
	  JOptionPane.showMessageDialog(null,("REM    :    "+(a%b)));
	  
	  }
	  
	  
	  
	
	
	}catch(Exception egggsd){JOptionPane.showMessageDialog(null,"You Type Wrong Number Please Try Again");}
	
	
	
	}
	}
	
	
	});
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	
	
	
	b17.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	Object ob=e.getSource();
	if(ob==b17){
	  System.exit(0);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	
	
	
	
	
	
}



else{JOptionPane.showMessageDialog(null,"Invalid");}


}



});
	
	b15.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b15==b15){
	
	Date date=new Date();


JOptionPane.showMessageDialog(null,(date));
	
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	
	
	
	
	
	b16.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent et){
	
	
	if(b16==b16){
	    
   fn.dispose();
	f.setVisible(true);
	
	f.getContentPane().setBackground(Color.white);
	}
	
	
	
	
	
	}
	
	
	
	});
	
	b20.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b20==b20){
	
	fn.dispose();
    fk=new JFrame();
    fk.setVisible(true);
	
	fk.setSize(540,600);
	fk.setLocationRelativeTo(null);
	fk.setLayout(null);
    fk.setDefaultCloseOperation(fe.EXIT_ON_CLOSE);
	
	
	b23.setBounds(10,10,235,113);
	fk.add(b23);
	
	
	b30.setBounds(10,140,235,113);
	fk.add(b30);
	
	b31.setBounds(10,270,235,113);
	fk.add(b31);
	b32.setBounds(270,10,235,113);
	fk.add(b32);
	
	b33.setBounds(270,140,235,113);
	fk.add(b33);
	
	
	b34.setBounds(270,270,235,113);
	fk.add(b34);
	
	
	b37.setBounds(80,500,66,25);
	fk.add(b37);
	
	b38.setBounds(190,500,66,25);
	fk.add(b38);
	
	b37.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b37==b37){
	    
  
	fk.dispose();
	ft=new JFrame();
    ft.setVisible(true);
	
	ft.setSize(300,200);
	ft.setLocationRelativeTo(null);
	ft.setLayout(null);
    ft.setDefaultCloseOperation(ft.EXIT_ON_CLOSE);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	b38.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b38==b38){
	    
  
	fn.setVisible(true);
	fk.setVisible(false);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	
	
	
	}
	
	
	
	
	
	}
	
	
	
	});
	b23.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent et){
	
	
	if(b23==b23){
	    
		fk.dispose();
		
   
	  fg=new JFrame();
    fg.setVisible(true);
	
	fg.setSize(1024,800);
	fg.setLocationRelativeTo(null);
	fg.setLayout(null);
    fg.setDefaultCloseOperation(fe.EXIT_ON_CLOSE);
	b29.setBounds(0,0,58,63);
	fg.add(b29);
	
	
	b35.setBounds(5,600,66,62);
	fg.add(b35);
	
    LL13.setIcon(new ImageIcon("4.png"));
    
    LL13.setSize(1024,768);
    fg.add(LL13);
    
	
	
	
	
	}
	
	
	
	
	
	}
	
	
	
	});
	b21.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b21==b21){
	    
  
	f.dispose();
	fe.setVisible(true);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	b35.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b35==b35){
	
	fg.dispose();
	fk.setVisible(true);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	b32.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b32==b32){
	
	fk.dispose();
	
	fmmm=new JFrame();
    fmmm.setVisible(true);
	
	fmmm.setSize(300,200);
	fmmm.setLocationRelativeTo(null);
	fmmm.setLayout(null);
    fmmm.setDefaultCloseOperation(fmmm.EXIT_ON_CLOSE);
	
	
	LL14=new JLabel("Pakistan Won WorldCup Ab bargar kila hahahha");
	
	LL14.setBounds(5,20,500,100);
	fmmm.add(LL14);
	
	
	
	b36.setBounds(80,100,100,25);
	fmmm.add(b36);
	
	b36.addActionListener(new ActionListener(){
	
	public void actionPerformed(ActionEvent e){
	
	
	if(b36==b36){
	    
  
	fmmm.dispose();
	fk.setVisible(true);
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	}
	
	
	
	
	
	}
	
	
	
	});
	
	
	
	
	
	
	
  }
  
  
  
 
  
  public static void main(String[] args)throws MalformedURLException, InterruptedException
  {
    PuzzleGame pg = new PuzzleGame();
  }
}
