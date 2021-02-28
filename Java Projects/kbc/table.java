import java.awt.*;
import java.awt.event.*;
import java.util.Random;
import javax.swing.*;
import java.applet.*;
import java.net.*;
import java.applet.AudioClip;
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
import javax.swing.*;
import javax.swing.JLabel;
import java.awt.*;
import javax.swing.text.*;
import java.io.*;
import java.lang.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.text.html.*;
public class table extends JFrame implements ActionListener{
JLabel L1=new JLabel();
JLabel L2=new JLabel();
JLabel L3=new JLabel();
JLabel L4=new JLabel("Q    NO   1  :   What      is      Computer     ? ");
JLabel L5=new JLabel();
JLabel L6=new JLabel();
JLabel L7=new JLabel();
JLabel L8=new JLabel();
JLabel L9=new JLabel();
JButton b1;
JButton b2;
JButton b3;
JButton b4;
JFrame frm;
String str;
Thread th;
AudioClip a;
table()throws MalformedURLException, InterruptedException
  {
  
str=JOptionPane.showInputDialog("Enter Your Name");
  frm=new JFrame();
  frm.setBounds(1200,120,818,560);
  frm.setLayout(null);
  frm.setDefaultCloseOperation(3);
  frm.setVisible(true);
  frm.setTitle("KBC");
  frm.setResizable(false);
 File A = new File("e.wav");
 this.a = Applet.newAudioClip(A.toURL());
	
  
  
  for(int a=1; a<=1000; a++){
	try{
	frm.setBounds(1200-a,120,818,560);
	th.sleep(1);
	}catch(Exception e){}
	
	}
     L3=new JLabel("Welcome      To      :     "+str);
	 L3.setBounds(310,25,1000,20);
	 L3.setForeground(Color.blue);
	 frm.add(L3);
	 
	L3.setVisible(false);
	 
	 
	 b1=new JButton("Car");
	 b1.setBounds(170,442,200,30);
	 frm.add(b1);

	 b1.setVisible(false);
	 
	 b2=new JButton("Human");
	 b2.setBounds(470,442,200,30);
	 frm.add(b2);
	 b2.setVisible(false);
	 
	  b3=new JButton("Machine");
	  b3.setBounds(170,484,200,30);
	  frm.add(b3);
	 b3.setVisible(false);
	
	 
	 
	  b4=new JButton("Screen");
	  b4.setBounds(470,484,200,30);
	  frm.add(b4);
	  b4.setVisible(false);
	
		b1.addActionListener(this);
		b2.addActionListener(this);
		b3.addActionListener(this);
		b4.addActionListener(this);
	 
	 L1.setIcon(new ImageIcon("ar.jpg"));
	 L1.setBounds(0, 0, 24, 17);
	
	
	L4.setBounds(150,385,1400,30);
	L4.setForeground(Color.red);
	L4.setVisible(false);
	frm.add(L4);
	
	
	 frm.add(L1);
	 L2.setIcon(new ImageIcon("game.jpg"));
	 L2.setBounds(0, 0, 818, 538);
	
	 frm.add(L2);
	 
	 
	 
	for(int a=1; a<=900; a++){
	try{
	L2.setBounds(0, 900-a, 818, 538);
	th.sleep(2);
	}catch(Exception e){}
	
	}
	
L3.setVisible(true);
	for(int a=1; a<=900; a++){
	try{
	L3.setBounds(1200-a,25,1000,20);
	th.sleep(2);
	}catch(Exception e){}
	
	}
	
	for(int a=1; a<=308; a++){
	try{
	L1.setBounds(0, a, 24, 17);
	th.sleep(1);
	}catch(Exception e){}
	
	}
	for(int a=1; a<=620; a++){
	try{
	L1.setBounds(a, 308, 24, 17);
	th.sleep(2);
	}catch(Exception e){}
	
	}
	L4.setVisible(true);
	for(int a=1; a<=1050; a++){
	try{
	L4.setBounds(1200-a,385,1400,30);
	th.sleep(2);
	}catch(Exception e){}
	
	}
	
	
	b1.setVisible(true);
	for(int a=1; a<=442; a++){
	try{
	b1.setBounds(170,a,200,30);
	th.sleep(2);
	}catch(Exception e){}
	
	}
	
	
	b2.setVisible(true);
	for(int a=1; a<=735; a++){
	try{
	b2.setBounds(1200-a,442,200,30);
	th.sleep(2);
	}catch(Exception e){}
	
	}
	
	
	
	b3.setVisible(true);
	for(int a=1; a<=484; a++){
	try{
	b3.setBounds(170,a,200,30);
	th.sleep(2);
	}catch(Exception e){}
	
	}

	
	b4.setVisible(true);
	for(int a=1; a<=734; a++){
	try{
	b4.setBounds(1200-a,484,200,30);
	th.sleep(2);
	}catch(Exception e){}
	
	}
	
	
	
	}
	public void actionPerformed(ActionEvent e){
	
	Object ob=e.getSource();
	if(ob==b1){
	if(b1.getText().equals("Car")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	
	}
	else if(b1.getText().equals("26")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	
	}
	
	else if(b1.getText().equals("Unite Cellarer Bus")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	
	}
	else if(b1.getText().equals("Zibaan")){
	
	this.a.play();
	L4.setForeground(Color.gray);
	L4.setText("Q    NO   5  :   What      is      full      foam     of     T  .  V     ?");
	
	b1.setText("Telephone");
	b2.setText("Telenor");
	b3.setText("Television");
	b4.setText("Technology");
	L1.setBounds(620, 227, 24, 17);
	
	}
	else if(b1.getText().equals("Telephone")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	
	}
	else if(b1.getText().equals("322")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	
	}
	else if(b1.getText().equals("152")){
	
	this.a.play();
	L4.setForeground(Color.green);
	L4.setText("Q    NO   8  :  How       Many      Months      in     Year     ? ");
	
	b1.setText("10");
	b2.setText("11");
	b3.setText("12");
	b4.setText("8");
	L1.setBounds(620, 167, 24, 17);
	
	}
	else if(b1.getText().equals("10")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	
	}
	else if(b1.getText().equals("Carbon Natural Gas")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	
	}
	else if(b1.getText().equals("Counting")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	
	}
    else if(b1.getText().equals("Aavaaz")){
	this.a.play();
	L4.setForeground(Color.red);
	L4.setText("Q    NO   12  :   What      is      Physic       ?");
	
	b1.setText("Computer Science");
	b2.setText("Important Science");
	b3.setText("Lie Science");
	b4.setText("Branch of Science");
	L1.setBounds(620, 87, 24, 17);
	
	
	}
	else if(b1.getText().equals("Computer Science")){
	
	JOptionPane.showMessageDialog(null,"Gar Ja");
	System.exit(0);
	
	}
	}
	
	
	
	////////////b222222222222222222222
	
	if(ob==b2){
	if(b2.getText().equals("Human")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b2.getText().equals("27")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	
	else if(b2.getText().equals("Universal Cellar Bus")){
	
	this.a.play();
	
	L4.setForeground(Color.blue);
	L4.setText("Q    NO   4  :   What      is      Meaning      of     Language     ?");
	
	b1.setText("Zibaan");
	b2.setText("Latin");
	b3.setText("Arabic");
	b4.setText("Tarsi");
	L1.setBounds(620, 247, 24, 17);
	}
	else if(b2.getText().equals("Latin")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b2.getText().equals("Telenor")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b2.getText().equals("351")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b2.getText().equals("142")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b2.getText().equals("11")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b2.getText().equals("Compound Natural Gas")){
	
	this.a.play();
	
	L4.setForeground(Color.green);
	L4.setText("Q    NO   10  :   What      is      A      B     C        ?");
	
	b1.setText("Counting");
	b2.setText("Spelling");
	b3.setText("Alphabate");
	b4.setText("Numbering");
	L1.setBounds(620, 127, 24, 17);
	}
	else if(b2.getText().equals("Spelling")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b2.getText().equals("Rest")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	
	else if(b2.getText().equals("Important Science")){
	
	JOptionPane.showMessageDialog(null,"Gar ja");
	System.exit(0);
	}
	}
	
	
	
	
	
	
	/////////b333333333333333333333333
	if(ob==b3){
	if(b3.getText().equals("Machine")){
	
	this.a.play();
	L4.setForeground(Color.green);
	L4.setText("Q    NO   2  :   Solve      this      Question     9  +  19     ? ");
	
	b1.setText("26");
	b2.setText("27");
	b3.setText("25");
	b4.setText("28");
	L1.setBounds(620, 287, 24, 17);
	}
	else if(b3.getText().equals("25")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b3.getText().equals("Up Cellar Bus")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b3.getText().equals("Arabic")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b3.getText().equals("Television")){
	this.a.play();
	L4.setForeground(Color.magenta);
	L4.setText("Q    NO   6  :   How      many      days      in     Year    ?");
	
	b1.setText("322");
	b2.setText("351");
	b3.setText("357");
	b4.setText("353");
	L1.setBounds(620, 207, 24, 17);
	
	}
	else if(b3.getText().equals("357")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b3.getText().equals("163")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b3.getText().equals("12")){
	
	this.a.play();
	L4.setForeground(Color.red);
	L4.setText("Q    NO   9  :   What      is      full      foam     of     C  .  N  .  G    ?");
	
	b1.setText("Carbon Natural Gas");
	b2.setText("Compound Natural Gas");
	b3.setText("Solid Liquid Gas");
	b4.setText("Sodium Natural Gas");
	L1.setBounds(620, 147, 24, 17);
	}
	else if(b3.getText().equals("Solid Liquid Gas")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b3.getText().equals("Alphabate")){
	this.a.play();
	L4.setForeground(Color.red);
	L4.setText("Q    NO   11  :   What      is      Meaning      of     Sound        ?");
	
	b1.setText("Aavaaz");
	b2.setText("Rest");
	b3.setText("Avail");
	b4.setText("Jay");
	L1.setBounds(620, 107, 24, 17);
	
	}
	else if(b3.getText().equals("Avail")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b3.getText().equals("Lie Science")){
	
	JOptionPane.showMessageDialog(null,"Gar ja");
	System.exit(0);
	}
	}
	
	///////////////////b4
	if(ob==b4){
	if(b4.getText().equals("Screen")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b4.getText().equals("28")){
	
	this.a.play();
	L4.setForeground(Color.cyan);
	L4.setText("Q    NO   3  :   What      is      full      foam     of     U    S   B     ?");
	
	b1.setText("Unite Cellarer Bus");
	b2.setText("Universal Cellar Bus");
	b3.setText("Up Cellar Bus");
	b4.setText("Ur Cellar Bus");
	L1.setBounds(620, 268, 24, 17);
	
	}
	else if(b4.getText().equals("Ur Cellar Bus")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b4.getText().equals("Tarsi")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b4.getText().equals("Technology")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b4.getText().equals("353")){
	this.a.play();
	L4.setForeground(Color.red);
	L4.setText("Q    NO   7  :   Solve      this      Question     19  X  8     ? ");
	
	b1.setText("152");
	b2.setText("142");
	b3.setText("163");
	b4.setText("122");
	L1.setBounds(620, 187, 24, 17);
	}
	else if(b4.getText().equals("122")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b4.getText().equals("8")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b4.getText().equals("Sodium Natural Gas")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b4.getText().equals("Numbering")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b4.getText().equals("Jay")){
	
	JOptionPane.showMessageDialog(null,"Game Over");
	System.exit(0);
	}
	else if(b4.getText().equals("Branch of Science")){
	
	this.a.play();
	JOptionPane.showMessageDialog(null,"You Win 1 Crore  "+str+"\nYe Paisa app ko nai maly ga qkay ye game manay banie hay ais ka karcha hova hay hahahahaha");
	
	JOptionPane.showMessageDialog(null,"Made By Shadab Ali Khowaja");
	System.exit(0);
	
	}
	}
	}
	
	
	
  
  public static void main(String[] args)throws MalformedURLException, InterruptedException
  {
    table tb = new table();
  }
}
