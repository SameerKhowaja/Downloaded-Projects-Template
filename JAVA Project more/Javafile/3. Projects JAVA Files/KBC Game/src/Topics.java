import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.*;
import java.awt.event.ActionEvent;
import java.io.File;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;

public class Topics extends JFrame implements MouseListener, ActionListener{
    JFrame frm2;
    public JButton btnplay, about, exit;
    public JButton op1, op2, op3, op4;
    public JLabel label, question;
    
    public void playing(){
        frm2 = new JFrame();
        frm2.setBounds(200, 10, 500, 500);
        frm2.setDefaultCloseOperation(3);
        frm2.setLayout(null);
        frm2.setTitle("KAUN BANEGA CROREPATI");
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("main/topics.png")));
        pan.add(jlb);
        frm2.setContentPane(jlb);
        frm2.setResizable(true);
        frm2.pack();
      
        //more
        question = new JLabel(" Select one topic to start the game ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 30));
        question.setForeground(Color.WHITE);
        frm2.add(question);
        
        //option 1
        op1=new JButton("Computer Science Quiz");
        op1.setBounds(86,538,320,43);
        op1.setFont(new Font("Gill Sans", 5, 25));
        op1.setBackground(Color.BLACK);
        op1.setForeground(Color.WHITE);
        frm2.add(op1);
        
        //option 2
        op2=new JButton("JAVA Quiz");
        op2.setBounds(86,610,320,43);
        op2.setFont(new Font("Gill Sans", 5, 25));
        op2.setBackground(Color.BLACK);
        op2.setForeground(Color.WHITE);
        frm2.add(op2);
        
        //option 3
        op3=new JButton("C, C++ & C# Quiz");
        op3.setBounds(551,538,320,43);
        op3.setFont(new Font("Gill Sans", 5, 25));
        op3.setBackground(Color.BLACK);
        op3.setForeground(Color.WHITE);
        frm2.add(op3);
        
        //option 4
        op4=new JButton("Web Designing Quiz");
        op4.setBounds(551,610,320,43);
        op4.setFont(new Font("Gill Sans", 5, 25));
        op4.setBackground(Color.BLACK);
        op4.setForeground(Color.WHITE);
        frm2.add(op4);
        
      
        exit=new JButton("Quit!");
        exit.setBounds(720,368,180,50);
        exit.setFont(new Font("Gill Sans", 5, 28));
        exit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        exit.setBackground(Color.YELLOW);
        exit.setForeground(Color.BLACK);
        frm2.add(exit);
        
        op1.addMouseListener(this);
        op1.addActionListener(this);
        op2.addMouseListener(this);
        op2.addActionListener(this);
        op3.addMouseListener(this);
        op3.addActionListener(this);
        op4.addMouseListener(this);
        op4.addActionListener(this);
        exit.addMouseListener(this);
        exit.addActionListener(this);
        
        frm2.setVisible(true);
        frm2.setVisible(true);
    }
    
    
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
    public void mouseClicked(MouseEvent e) {}
    
    //In Use
    public void actionPerformed(ActionEvent e){
	Object ob = e.getSource();
	
        Random ra = new Random();
        int pick = ra.nextInt(10);
            
        /*if(ob==op1){ 
            playSound1();
            Thread thread1 = new Thread (){
            public void run () {
		for(int a=1; a<=4; a++){
                    try{
			op1.setBackground(Color.ORANGE);
                        op1.setForeground(Color.BLACK);
                        op1.setBorderPainted(false);
                        op1.setFocusPainted(false);
                        op2.setVisible(false);
                        op3.setVisible(false);
                        op4.setVisible(false);
                        question.setText("Loading Quiz Data...!");
                        question.setFont(new Font("Gill Sans", 2, 35));
                        question.setBounds(300,440,1000,60);
                        exit.setVisible(false);
			Thread.sleep(1000);
            if(a==1){ 
                Q16 sam = new Q16();
            if(pick==0){
                sam.q1();
                frm2.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm2.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm2.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm2.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm2.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm2.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm2.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm2.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm2.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm2.setVisible(false);
            }
            }
                    }catch(Exception e){}
		}
            }
            };
            thread1.start();
        }*/
        
        if(ob==op2){ 
            playSound1();
            Thread thread1 = new Thread (){
            public void run () {
		for(int a=1; a<=4; a++){
                    try{
			op2.setBackground(Color.ORANGE);
                        op2.setForeground(Color.BLACK);
                        op2.setBorderPainted(false);
                        op2.setFocusPainted(false);
                        op1.setVisible(false);
                        op3.setVisible(false);
                        op4.setVisible(false);
                        question.setText("Loading Quiz Data...!");
                        question.setFont(new Font("Gill Sans", 2, 35));
                        question.setBounds(300,440,1000,60);
                        exit.setVisible(false);
			Thread.sleep(1000);
            if(a==1){  
                Q1 sam = new Q1();
            if(pick==0){
                sam.q1();
                frm2.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm2.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm2.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm2.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm2.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm2.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm2.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm2.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm2.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm2.setVisible(false);
            }
            }
                    }catch(Exception e){}
		}
            }
            };
            thread1.start();
        }
        
        /*if(ob==op3){ 
            playSound1();
            Thread thread1 = new Thread (){
            public void run () {
		for(int a=1; a<=4; a++){
                    try{
			op3.setBackground(Color.ORANGE);
                        op3.setForeground(Color.BLACK);
                        op3.setBorderPainted(false);
                        op3.setFocusPainted(false);
                        op2.setVisible(false);
                        op1.setVisible(false);
                        op4.setVisible(false);
                        question.setText("Loading Quiz Data...!");
                        question.setFont(new Font("Gill Sans", 2, 35));
                        question.setBounds(300,440,1000,60);
                        exit.setVisible(false);
			Thread.sleep(1000);
            if(a==1){  
                Q31 sam = new Q31();
            if(pick==0){
                sam.q1();
                frm2.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm2.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm2.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm2.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm2.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm2.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm2.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm2.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm2.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm2.setVisible(false);
            }
            }
                    }catch(Exception e){}
		}
            }
            };
            thread1.start();
        }*/
        
        /*if(ob==op4){ 
            playSound1();
            Thread thread1 = new Thread (){
            public void run () {
		for(int a=1; a<=4; a++){
                    try{
			op4.setBackground(Color.ORANGE);
                        op4.setForeground(Color.BLACK);
                        op4.setBorderPainted(false);
                        op4.setFocusPainted(false);
                        op2.setVisible(false);
                        op3.setVisible(false);
                        op1.setVisible(false);
                        question.setText("Loading Quiz Data...!");
                        question.setFont(new Font("Gill Sans", 2, 35));
                        question.setBounds(300,440,1000,60);
                        exit.setVisible(false);
			Thread.sleep(1000);
            if(a==1){    
            if(pick==0){
                Q1 sam = new Q1();
                sam.q1();
                frm2.setVisible(false);
            }
            else if(pick==1){
                Q1 sam = new Q1();
                sam.q2();
                frm2.setVisible(false);
            }
            else if(pick==2){
                Q1 sam = new Q1();
                sam.q3();
                frm2.setVisible(false);
            }
            else if(pick==3){
                Q1 sam = new Q1();
                sam.q4();
                frm2.setVisible(false);
            }
            else if(pick==4){
                Q1 sam = new Q1();
                sam.q5();
                frm2.setVisible(false);
            }
            else if(pick==5){
                Q1 sam = new Q1();
                sam.q6();
                frm2.setVisible(false);
            }
            else if(pick==6){
                Q1 sam = new Q1();
                sam.q7();
                frm2.setVisible(false);
            }
            else if(pick==7){
                Q1 sam = new Q1();
                sam.q8();
                frm2.setVisible(false);
            }
            else if(pick==8){
                Q1 sam = new Q1();
                sam.q9();
                frm2.setVisible(false);
            }
            else if(pick==9){
                Q1 sam = new Q1();
                sam.q10();
                frm2.setVisible(false);
            }
            }
                    }catch(Exception e){}
		}
            }
            };
            thread1.start();
        }*/
        
        
        if(ob==exit){ 
            playSound2();
            Thread thread1 = new Thread (){
            public void run () {
		for(int a=1; a<=4; a++){
                    try{
			exit.setBackground(Color.RED);
                        exit.setForeground(Color.BLACK);
                        exit.setText("Exiting...!");
                        op1.setVisible(false);
                        op2.setVisible(false);
                        op3.setVisible(false);
                        op4.setVisible(false);
                        question.setText("Please Wait! Closing Your Game...!");
                        question.setBounds(255,440,1000,60);
                        btnplay.setVisible(false);  
			Thread.sleep(1000);
            if(a==1){
                System.exit(0);
            }
                    }catch(Exception e){}
		}
            }
            };
            thread1.start();
        }
    }
    
    
    public void playSound() {
        try {
            AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(new File("C:\\Users\\Sameer Khowaja\\Documents\\NetBeansProjects\\KBC Game\\src\\sounds\\Kbc.wav"));
            Clip clip = AudioSystem.getClip( );
            clip.open(audioInputStream);
            clip.start( );
        }
        catch(Exception e)  {
            e.printStackTrace( );
        }
    }
    
    public void playSound1() {
        try {
            AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(new File("C:\\Users\\Sameer Khowaja\\Documents\\NetBeansProjects\\KBC Game\\src\\sounds\\bc.wav"));
            Clip clip = AudioSystem.getClip( );
            clip.open(audioInputStream);
            clip.start( );
        }
        catch(Exception e)  {
            e.printStackTrace( );
        }
    }
    
    public void playSound2() {
        try {
            AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(new File("C:\\Users\\Sameer Khowaja\\Documents\\NetBeansProjects\\KBC Game\\src\\sounds\\close.wav"));
            Clip clip = AudioSystem.getClip( );
            clip.open(audioInputStream);
            clip.start( );
        }
        catch(Exception e)  {
            e.printStackTrace( );
        }
    }
    
}

