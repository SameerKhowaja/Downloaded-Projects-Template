import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.File;
import java.util.*;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;

public class Q23 extends JFrame implements MouseListener, ActionListener{
    JFrame frm3;
    public JButton quit1, quit2, quit3, quit4, quit5;
    public JButton quit6, quit7, quit8, quit9, quit10;
    public JButton op1, op2, op3, op4;
    public JButton op5, op6, op7, op8;
    public JButton op9, op10, op11, op12;
    public JButton op13, op14, op15, op16;
    public JButton op17, op18, op19, op20;
    public JButton op21, op22, op23, op24;
    public JButton op25, op26, op27, op28;
    public JButton op29, op30, op31, op32;
    public JButton op33, op34, op35, op36;
    public JButton op37, op38, op39, op40;
    public JButton b1,b2,b3,b4,b5,b6,b7,b8,b9,b10;
    public JLabel label, question, question2;
    
    public void q1(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:08");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eight.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        //Question
        question = new JLabel(" How many ports of TCP/IP are reserved for specific protocols ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 25));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op1=new JButton("1024");
        op1.setBounds(86,538,320,43);
        op1.setFont(new Font("Gill Sans", 5, 25));
        op1.setBackground(Color.BLACK);
        op1.setForeground(Color.WHITE);
        frm3.add(op1);
        
        //option 2
        op2=new JButton("100");
        op2.setBounds(86,610,320,43);
        op2.setFont(new Font("Gill Sans", 5, 25));
        op2.setBackground(Color.BLACK);
        op2.setForeground(Color.WHITE);
        frm3.add(op2);
        
        //option 3
        op3=new JButton("2048");
        op3.setBounds(551,538,320,43);
        op3.setFont(new Font("Gill Sans", 5, 25));
        op3.setBackground(Color.BLACK);
        op3.setForeground(Color.WHITE);
        frm3.add(op3);
        
        //option 4
        op4=new JButton("512");
        op4.setBounds(551,610,320,43);
        op4.setFont(new Font("Gill Sans", 5, 25));
        op4.setBackground(Color.BLACK);
        op4.setForeground(Color.WHITE);
        frm3.add(op4);
        
      
        quit1=new JButton("Quit!");
        quit1.setBounds(720,368,180,50);
        quit1.setFont(new Font("Gill Sans", 5, 28));
        quit1.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit1.setBackground(Color.YELLOW);
        quit1.setForeground(Color.BLACK);
        frm3.add(quit1);

        op1.addMouseListener(this);
        op1.addActionListener(this);
        op2.addMouseListener(this);
        op2.addActionListener(this);
        op3.addMouseListener(this);
        op3.addActionListener(this);
        op4.addMouseListener(this);
        op4.addActionListener(this);
        quit1.addMouseListener(this);
        quit1.addActionListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q2(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:08");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eight.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        //Question
        question = new JLabel(" Which of these is an instance variable of httpd that is a Hashtable ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 25));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op5=new JButton("port");
        op5.setBounds(86,538,320,43);
        op5.setFont(new Font("Gill Sans", 5, 25));
        op5.setBackground(Color.BLACK);
        op5.setForeground(Color.WHITE);
        frm3.add(op5);
        
        //option 2
        op6=new JButton("log");
        op6.setBounds(86,610,320,43);
        op6.setFont(new Font("Gill Sans", 5, 25));
        op6.setBackground(Color.BLACK);
        op6.setForeground(Color.WHITE);
        frm3.add(op6);
        
        //option 3
        op7=new JButton("cache");
        op7.setBounds(551,538,320,43);
        op7.setFont(new Font("Gill Sans", 5, 25));
        op7.setBackground(Color.BLACK);
        op7.setForeground(Color.WHITE);
        frm3.add(op7);
        
        //option 4
        op8=new JButton("stopFlag");
        op8.setBounds(551,610,320,43);
        op8.setFont(new Font("Gill Sans", 5, 25));
        op8.setBackground(Color.BLACK);
        op8.setForeground(Color.WHITE);
        frm3.add(op8);
        
    
        quit2=new JButton("Quit!");
        quit2.setBounds(720,368,180,50);
        quit2.setFont(new Font("Gill Sans", 5, 28));
        quit2.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit2.setBackground(Color.YELLOW);
        quit2.setForeground(Color.BLACK);
        frm3.add(quit2);

        op5.addMouseListener(this);
        op5.addActionListener(this);
        op6.addMouseListener(this);
        op6.addActionListener(this);
        op7.addMouseListener(this);
        op7.addActionListener(this);
        op8.addMouseListener(this);
        op8.addActionListener(this);
        quit2.addMouseListener(this);
        quit2.addActionListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q3(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:08");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eight.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        //Question
        question = new JLabel(" Which of these package contains classes and interfaces for networking ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 24));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op9=new JButton("java.io");
        op9.setBounds(86,538,320,43);
        op9.setFont(new Font("Gill Sans", 5, 22));
        op9.setBackground(Color.BLACK);
        op9.setForeground(Color.WHITE);
        frm3.add(op9);
        
        //option 2
        op10=new JButton("java.util");
        op10.setBounds(86,610,320,43);
        op10.setFont(new Font("Gill Sans", 5, 22));
        op10.setBackground(Color.BLACK);
        op10.setForeground(Color.WHITE);
        frm3.add(op10);
        
        //option 3
        op11=new JButton("java.net");
        op11.setBounds(551,538,320,43);
        op11.setFont(new Font("Gill Sans", 5, 22));
        op11.setBackground(Color.BLACK);
        op11.setForeground(Color.WHITE);
        frm3.add(op11);
        
        //option 4
        op12=new JButton("java.network");
        op12.setBounds(551,610,320,43);
        op12.setFont(new Font("Gill Sans", 5, 22));
        op12.setBackground(Color.BLACK);
        op12.setForeground(Color.WHITE);
        frm3.add(op12);
        
       
        quit3=new JButton("Quit!");
        quit3.setBounds(720,368,180,50);
        quit3.setFont(new Font("Gill Sans", 5, 28));
        quit3.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit3.setBackground(Color.YELLOW);
        quit3.setForeground(Color.BLACK);
        frm3.add(quit3);

        op9.addMouseListener(this);
        op9.addActionListener(this);
        op10.addMouseListener(this);
        op10.addActionListener(this);
        op11.addMouseListener(this);
        op11.addActionListener(this);
        op12.addMouseListener(this);
        op12.addActionListener(this);
        quit3.addMouseListener(this);
        quit3.addActionListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q4(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:08");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eight.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        //Question
        question = new JLabel(" Which of these is an instance variable of class httpd ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 25));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op13=new JButton("port");
        op13.setBounds(86,538,320,43);
        op13.setFont(new Font("Gill Sans", 5, 25));
        op13.setBackground(Color.BLACK);
        op13.setForeground(Color.WHITE);
        frm3.add(op13);
        
        //option 2
        op14=new JButton("cache");
        op14.setBounds(86,610,320,43);
        op14.setFont(new Font("Gill Sans", 5, 25));
        op14.setBackground(Color.BLACK);
        op14.setForeground(Color.WHITE);
        frm3.add(op14);
        
        //option 3
        op15=new JButton("log");
        op15.setBounds(551,538,320,43);
        op15.setFont(new Font("Gill Sans", 5, 25));
        op15.setBackground(Color.BLACK);
        op15.setForeground(Color.WHITE);
        frm3.add(op15);
        
        //option 4
        op16=new JButton("All of these");
        op16.setBounds(551,610,320,43);
        op16.setFont(new Font("Gill Sans", 5, 25));
        op16.setBackground(Color.BLACK);
        op16.setForeground(Color.WHITE);
        frm3.add(op16);
        
  
        quit4=new JButton("Quit!");
        quit4.setBounds(720,368,180,50);
        quit4.setFont(new Font("Gill Sans", 5, 28));
        quit4.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit4.setBackground(Color.YELLOW);
        quit4.setForeground(Color.BLACK);
        frm3.add(quit4);

        op13.addMouseListener(this);
        op13.addActionListener(this);
        op14.addMouseListener(this);
        op14.addActionListener(this);
        op15.addMouseListener(this);
        op15.addActionListener(this);
        op16.addMouseListener(this);
        op16.addActionListener(this);
        quit4.addMouseListener(this);
        quit4.addActionListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q5(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:08");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eight.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        //Question
        question = new JLabel(" How many bits are in a single IP address ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 29));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op17=new JButton("32");
        op17.setBounds(86,538,320,43);
        op17.setFont(new Font("Gill Sans", 5, 22));
        op17.setBackground(Color.BLACK);
        op17.setForeground(Color.WHITE);
        frm3.add(op17);
        
        //option 2
        op18=new JButton("16");
        op18.setBounds(86,610,320,43);
        op18.setFont(new Font("Gill Sans", 5, 22));
        op18.setBackground(Color.BLACK);
        op18.setForeground(Color.WHITE);
        frm3.add(op18);
        
        //option 3
        op19=new JButton("8");
        op19.setBounds(551,538,320,43);
        op19.setFont(new Font("Gill Sans", 5, 22));
        op19.setBackground(Color.BLACK);
        op19.setForeground(Color.WHITE);
        frm3.add(op19);
        
        //option 4
        op20=new JButton("128");
        op20.setBounds(551,610,320,43);
        op20.setFont(new Font("Gill Sans", 5, 22));
        op20.setBackground(Color.BLACK);
        op20.setForeground(Color.WHITE);
        frm3.add(op20);
        
    
        quit5=new JButton("Quit!");
        quit5.setBounds(720,368,180,50);
        quit5.setFont(new Font("Gill Sans", 5, 28));
        quit5.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit5.setBackground(Color.YELLOW);
        quit5.setForeground(Color.BLACK);
        frm3.add(quit5);

        op17.addMouseListener(this);
        op17.addActionListener(this);
        op18.addMouseListener(this);
        op18.addActionListener(this);
        op19.addMouseListener(this);
        op19.addActionListener(this);
        op20.addMouseListener(this);
        op20.addActionListener(this);
        quit5.addMouseListener(this);
        quit5.addActionListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q6(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:08");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eight.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        //Question
        question = new JLabel(" Which of the following class is not included in java.lang ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 25));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op21=new JButton("Byte");
        op21.setBounds(86,538,320,43);
        op21.setFont(new Font("Gill Sans", 5, 25));
        op21.setBackground(Color.BLACK);
        op21.setForeground(Color.WHITE);
        frm3.add(op21);
        
        //option 2
        op22=new JButton("Array");
        op22.setBounds(86,610,320,43);
        op22.setFont(new Font("Gill Sans", 5, 25));
        op22.setBackground(Color.BLACK);
        op22.setForeground(Color.WHITE);
        frm3.add(op22);
        
        //option 3
        op23=new JButton("Integer");
        op23.setBounds(551,538,320,43);
        op23.setFont(new Font("Gill Sans", 5, 25));
        op23.setBackground(Color.BLACK);
        op23.setForeground(Color.WHITE);
        frm3.add(op23);
        
        //option 4
        op24=new JButton("Class");
        op24.setBounds(551,610,320,43);
        op24.setFont(new Font("Gill Sans", 5, 25));
        op24.setBackground(Color.BLACK);
        op24.setForeground(Color.WHITE);
        frm3.add(op24);
        
    
        quit6=new JButton("Quit!");
        quit6.setBounds(720,368,180,50);
        quit6.setFont(new Font("Gill Sans", 5, 28));
        quit6.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit6.setBackground(Color.YELLOW);
        quit6.setForeground(Color.BLACK);
        frm3.add(quit6);

        op21.addMouseListener(this);
        op21.addActionListener(this);
        op22.addMouseListener(this);
        op22.addActionListener(this);
        op23.addMouseListener(this);
        op23.addActionListener(this);
        op24.addMouseListener(this);
        op24.addActionListener(this);
        quit6.addMouseListener(this);
        quit6.addActionListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q7(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:08");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eight.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        //Question
        question = new JLabel(" Which of these is a super class of wrappers Double & Integer ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 24));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op25=new JButton("Long");
        op25.setBounds(86,538,320,43);
        op25.setFont(new Font("Gill Sans", 5, 20));
        op25.setBackground(Color.BLACK);
        op25.setForeground(Color.WHITE);
        frm3.add(op25);
        
        //option 2
        op26=new JButton("Digits");
        op26.setBounds(86,610,320,43);
        op26.setFont(new Font("Gill Sans", 5, 20));
        op26.setBackground(Color.BLACK);
        op26.setForeground(Color.WHITE);
        frm3.add(op26);
        
        //option 3
        op27=new JButton("Number");
        op27.setBounds(551,538,320,43);
        op27.setFont(new Font("Gill Sans", 5, 20));
        op27.setBackground(Color.BLACK);
        op27.setForeground(Color.WHITE);
        frm3.add(op27);
        
        //option 4
        op28=new JButton("Float");
        op28.setBounds(551,610,320,43);
        op28.setFont(new Font("Gill Sans", 5, 20));
        op28.setBackground(Color.BLACK);
        op28.setForeground(Color.WHITE);
        frm3.add(op28);
        
        
        quit7=new JButton("Quit!");
        quit7.setBounds(720,368,180,50);
        quit7.setFont(new Font("Gill Sans", 5, 28));
        quit7.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit7.setBackground(Color.YELLOW);
        quit7.setForeground(Color.BLACK);
        frm3.add(quit7);
        
        op25.addMouseListener(this);
        op25.addActionListener(this);
        op26.addMouseListener(this);
        op26.addActionListener(this);
        op27.addMouseListener(this);
        op27.addActionListener(this);
        op28.addMouseListener(this);
        op28.addActionListener(this);
        quit7.addMouseListener(this);
        quit7.addActionListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q8(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:08");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eight.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        //Question
        question = new JLabel(" Which of these is wrapper for simple data type float ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 25));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op29=new JButton("float");
        op29.setBounds(86,538,320,43);
        op29.setFont(new Font("Gill Sans", 5, 20));
        op29.setBackground(Color.BLACK);
        op29.setForeground(Color.WHITE);
        frm3.add(op29);
        
        //option 2
        op30=new JButton("double");
        op30.setBounds(86,610,320,43);
        op30.setFont(new Font("Gill Sans", 5, 20));
        op30.setBackground(Color.BLACK);
        op30.setForeground(Color.WHITE);
        frm3.add(op30);
        
        //option 3
        op31=new JButton("Double");
        op31.setBounds(551,538,320,43);
        op31.setFont(new Font("Gill Sans", 5, 20));
        op31.setBackground(Color.BLACK);
        op31.setForeground(Color.WHITE);
        frm3.add(op31);
        
        //option 4
        op32=new JButton("Float");
        op32.setBounds(551,610,320,43);
        op32.setFont(new Font("Gill Sans", 5, 20));
        op32.setBackground(Color.BLACK);
        op32.setForeground(Color.WHITE);
        frm3.add(op32);
        
     
        quit8=new JButton("Quit!");
        quit8.setBounds(720,368,180,50);
        quit8.setFont(new Font("Gill Sans", 5, 28));
        quit8.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit8.setBackground(Color.YELLOW);
        quit8.setForeground(Color.BLACK);
        frm3.add(quit8);

        op29.addMouseListener(this);
        op29.addActionListener(this);
        op30.addMouseListener(this);
        op30.addActionListener(this);
        op31.addMouseListener(this);
        op31.addActionListener(this);
        op32.addMouseListener(this);
        op32.addActionListener(this);
        quit8.addMouseListener(this);
        quit8.addActionListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q9(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:08");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eight.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        //Question
        question = new JLabel(" Which of these operators can be used to concatenate two or more String objects ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 22));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op33=new JButton("+=");
        op33.setBounds(86,538,320,43);
        op33.setFont(new Font("Gill Sans", 5, 25));
        op33.setBackground(Color.BLACK);
        op33.setForeground(Color.WHITE);
        frm3.add(op33);
        
        //option 2
        op34=new JButton("+");
        op34.setBounds(86,610,320,43);
        op34.setFont(new Font("Gill Sans", 5, 25));
        op34.setBackground(Color.BLACK);
        op34.setForeground(Color.WHITE);
        frm3.add(op34);
        
        //option 3
        op35=new JButton("&");
        op35.setBounds(551,538,320,43);
        op35.setFont(new Font("Gill Sans", 5, 25));
        op35.setBackground(Color.BLACK);
        op35.setForeground(Color.WHITE);
        frm3.add(op35);
        
        //option 4
        op36=new JButton("||");
        op36.setBounds(551,610,320,43);
        op36.setFont(new Font("Gill Sans", 5, 25));
        op36.setBackground(Color.BLACK);
        op36.setForeground(Color.WHITE);
        frm3.add(op36);
        
        
        quit9=new JButton("Quit!");
        quit9.setBounds(720,368,180,50);
        quit9.setFont(new Font("Gill Sans", 5, 28));
        quit9.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit9.setBackground(Color.YELLOW);
        quit9.setForeground(Color.BLACK);
        frm3.add(quit9);

        op33.addMouseListener(this);
        op33.addActionListener(this);
        op34.addMouseListener(this);
        op34.addActionListener(this);
        op35.addMouseListener(this);
        op35.addActionListener(this);
        op36.addMouseListener(this);
        op36.addActionListener(this);
        quit9.addMouseListener(this);
        quit9.addActionListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q10(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:08");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eight.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        //Question
        question = new JLabel(" Which of these method of class String is used to obtain length of String object ? ");
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 20));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op37=new JButton("get()");
        op37.setBounds(86,538,320,43);
        op37.setFont(new Font("Gill Sans", 5, 25));
        op37.setBackground(Color.BLACK);
        op37.setForeground(Color.WHITE);
        frm3.add(op37);
        
        //option 2
        op38=new JButton("Sizeof()");
        op38.setBounds(86,610,320,43);
        op38.setFont(new Font("Gill Sans", 5, 25));
        op38.setBackground(Color.BLACK);
        op38.setForeground(Color.WHITE);
        frm3.add(op38);
        
        //option 3
        op39=new JButton("length()");
        op39.setBounds(551,538,320,43);
        op39.setFont(new Font("Gill Sans", 5, 25));
        op39.setBackground(Color.BLACK);
        op39.setForeground(Color.WHITE);
        frm3.add(op39);
        
        //option 4
        op40=new JButton("lengthof()");
        op40.setBounds(551,610,320,43);
        op40.setFont(new Font("Gill Sans", 5, 25));
        op40.setBackground(Color.BLACK);
        op40.setForeground(Color.WHITE);
        frm3.add(op40);
        
        
        quit10=new JButton("Quit!");
        quit10.setBounds(720,368,180,50);
        quit10.setFont(new Font("Gill Sans", 5, 28));
        quit10.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit10.setBackground(Color.YELLOW);
        quit10.setForeground(Color.BLACK);
        frm3.add(quit10);
        
        op37.addMouseListener(this);
        op37.addActionListener(this);
        op38.addMouseListener(this);
        op38.addActionListener(this);
        op39.addMouseListener(this);
        op39.addActionListener(this);
        op40.addMouseListener(this);
        op40.addActionListener(this);
        quit10.addMouseListener(this);
        quit10.addActionListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
    public void actionPerformed(ActionEvent e){
        Object ob=e.getSource();
        
        Random ra = new Random();
        int pick = ra.nextInt(10);
        
        Q24 sam = new Q24();
        
        //question 1
        if(ob==op1){
            playSound();
            Thread thread1 = new Thread (){
            public void run (){
                for(int a=1; a<=4; a++){        
        try{
            op1.setBackground(Color.green);
            op1.setForeground(Color.BLACK);
            op2.setVisible(false);
            op3.setVisible(false);
            op4.setVisible(false);
            quit1.setVisible(false);
            Thread.sleep(2000);
                        
        if(a==2){
            if(pick==0){
                sam.q1();
                frm3.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm3.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm3.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm3.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm3.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm3.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm3.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm3.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm3.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm3.setVisible(false);
            }
        }
            }catch(Exception e){}
          }
        }
      };  
        thread1.start();
        
    }
        
        
        
        //question 2
        if(ob==op6){
            playSound();
            Thread thread1 = new Thread (){
            public void run (){
                for(int a=1; a<=4; a++){        
        try{
            op5.setVisible(false);
            op6.setBackground(Color.green);
            op6.setForeground(Color.BLACK);
            op7.setVisible(false);
            op8.setVisible(false);
            quit2.setVisible(false);
            Thread.sleep(2000);
                        
        if(a==2){
            if(pick==0){
                sam.q1();
                frm3.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm3.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm3.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm3.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm3.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm3.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm3.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm3.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm3.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm3.setVisible(false);
            }
        }
            }catch(Exception e){}
          }
        }
      };  
        thread1.start();
        
    }
        
        
        
        //question 3
        if(ob==op11){
            playSound();
            Thread thread1 = new Thread (){
            public void run (){
                for(int a=1; a<=4; a++){        
        try{
            op9.setVisible(false);
            op10.setVisible(false);
            op11.setBackground(Color.green);
            op11.setForeground(Color.BLACK);
            op12.setVisible(false);
            quit3.setVisible(false);
            Thread.sleep(2000);
                        
        if(a==2){
            if(pick==0){
                sam.q1();
                frm3.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm3.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm3.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm3.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm3.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm3.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm3.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm3.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm3.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm3.setVisible(false);
            }
        }
            }catch(Exception e){}
          }
        }
      };  
        thread1.start();
        
    }
        
        
        
        //question 4
        if(ob==op16){
            playSound();
            Thread thread1 = new Thread (){
            public void run (){
                for(int a=1; a<=4; a++){        
        try{
            op16.setBackground(Color.green);
            op16.setForeground(Color.BLACK);
            op14.setVisible(false);
            op15.setVisible(false);
            op13.setVisible(false);
            quit4.setVisible(false);
            Thread.sleep(2000);
                        
        if(a==2){
            if(pick==0){
                sam.q1();
                frm3.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm3.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm3.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm3.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm3.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm3.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm3.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm3.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm3.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm3.setVisible(false);
            }
        }
            }catch(Exception e){}
          }
        }
      };  
        thread1.start();
        
    }
        
        
        
        //question 5
        if(ob==op17){
            playSound();
            Thread thread1 = new Thread (){
            public void run (){
                for(int a=1; a<=4; a++){        
        try{
            op19.setVisible(false);
            op18.setVisible(false);
            op17.setBackground(Color.green);
            op17.setForeground(Color.BLACK);
            op20.setVisible(false);
            quit5.setVisible(false);
            Thread.sleep(2000);
                        
        if(a==2){
            if(pick==0){
                sam.q1();
                frm3.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm3.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm3.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm3.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm3.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm3.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm3.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm3.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm3.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm3.setVisible(false);
            }
        }
            }catch(Exception e){}
          }
        }
      };  
        thread1.start();
        
    }
        
        
        
        //question 6
        if(ob==op22){
            playSound();
            Thread thread1 = new Thread (){
            public void run (){
                for(int a=1; a<=4; a++){        
        try{
            op22.setBackground(Color.green);
            op22.setForeground(Color.BLACK);
            op21.setVisible(false);
            op23.setVisible(false);
            op24.setVisible(false);
            quit6.setVisible(false);
            Thread.sleep(2000);
                        
        if(a==2){
            if(pick==0){
                sam.q1();
                frm3.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm3.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm3.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm3.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm3.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm3.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm3.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm3.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm3.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm3.setVisible(false);
            }
        }
            }catch(Exception e){}
          }
        }
      };  
        thread1.start();
        
    }
        
        
        
        //question 7
        if(ob==op27){
            playSound();
            Thread thread1 = new Thread (){
            public void run (){
                for(int a=1; a<=4; a++){        
        try{
            op27.setBackground(Color.green);
            op27.setForeground(Color.BLACK);
            op26.setVisible(false);
            op25.setVisible(false);
            op28.setVisible(false);
            quit7.setVisible(false);
            Thread.sleep(2000);
                        
        if(a==2){
            if(pick==0){
                sam.q1();
                frm3.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm3.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm3.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm3.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm3.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm3.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm3.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm3.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm3.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm3.setVisible(false);
            }
        }
            }catch(Exception e){}
          }
        }
      };  
        thread1.start();
        
    }
        
        
        
        //question 8
        if(ob==op32){
            playSound();
            Thread thread1 = new Thread (){
            public void run (){
                for(int a=1; a<=4; a++){        
        try{
            op32.setBackground(Color.green);
            op32.setForeground(Color.BLACK);
            op30.setVisible(false);
            op31.setVisible(false);
            op29.setVisible(false);
            quit8.setVisible(false);
            Thread.sleep(2000);
                        
        if(a==2){
            if(pick==0){
                sam.q1();
                frm3.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm3.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm3.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm3.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm3.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm3.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm3.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm3.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm3.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm3.setVisible(false);
            }
        }
            }catch(Exception e){}
          }
        }
      };  
        thread1.start();
        
    }
        
        
        
        //question 9
        if(ob==op34){
            playSound();
            Thread thread1 = new Thread (){
            public void run (){
                for(int a=1; a<=4; a++){        
        try{
            op34.setBackground(Color.green);
            op34.setForeground(Color.BLACK);
            op33.setVisible(false);
            op35.setVisible(false);
            op36.setVisible(false);
            quit9.setVisible(false);
            Thread.sleep(2000);
                        
        if(a==2){
            if(pick==0){
                sam.q1();
                frm3.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm3.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm3.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm3.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm3.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm3.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm3.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm3.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm3.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm3.setVisible(false);
            }
        }
            }catch(Exception e){}
          }
        }
      };  
        thread1.start();
        
    }
        
        
        
        //question 10
        if(ob==op39){
            playSound();
            Thread thread1 = new Thread (){
            public void run (){
                for(int a=1; a<=4; a++){        
        try{
            op37.setVisible(false);
            op39.setBackground(Color.green);
            op39.setForeground(Color.BLACK);
            op38.setVisible(false);
            op40.setVisible(false);
            quit10.setVisible(false);
            Thread.sleep(2000);
                        
        if(a==2){
            if(pick==0){
                sam.q1();
                frm3.setVisible(false);
            }
            else if(pick==1){
                sam.q2();
                frm3.setVisible(false);
            }
            else if(pick==2){
                sam.q3();
                frm3.setVisible(false);
            }
            else if(pick==3){
                sam.q4();
                frm3.setVisible(false);
            }
            else if(pick==4){
                sam.q5();
                frm3.setVisible(false);
            }
            else if(pick==5){
                sam.q6();
                frm3.setVisible(false);
            }
            else if(pick==6){
                sam.q7();
                frm3.setVisible(false);
            }
            else if(pick==7){
                sam.q8();
                frm3.setVisible(false);
            }
            else if(pick==8){
                sam.q9();
                frm3.setVisible(false);
            }
            else if(pick==9){
                sam.q10();
                frm3.setVisible(false);
            }
        }
            }catch(Exception e){}
          }
        }
      };  
        thread1.start();
        
    }
        
        
        
        //quit button   
        if(ob==quit1){
            playSound1();
            Thread thread1 = new Thread (){
                public void run (){
                    for(int a=1; a<=4; a++){
                        try{
                            quit1.setBackground(Color.RED);
                            quit1.setForeground(Color.BLACK);
                            op1.setVisible(false);
                            op2.setVisible(false);
                            op3.setVisible(false);
                            op4.setVisible(false);
                            question.setText("Please Wait! Closing Your Game...!");
                            question.setBounds(255,440,1000,60);
                            Thread.sleep(1000);  
                        if(a==1){
                            frm3.setVisible(false);
                            frm3.dispose();
                            quit();
                        }
                        }catch(Exception e){}
                        
                    }
                }
            };
            thread1.start();
        }
        if(ob==quit2){
            playSound1();
            Thread thread1 = new Thread (){
                public void run (){
                    for(int a=1; a<=4; a++){
                        try{
                            quit2.setBackground(Color.RED);
                            quit2.setForeground(Color.BLACK);
                            op5.setVisible(false);
                            op6.setVisible(false);
                            op7.setVisible(false);
                            op8.setVisible(false);
                            question.setText("Please Wait! Closing Your Game...!");
                            question.setBounds(255,440,1000,60);
                            Thread.sleep(1000);  
                        if(a==1){
                            frm3.setVisible(false);
                            frm3.dispose();
                            quit();
                        }
                        }catch(Exception e){}
                        
                    }
                }
            };
            thread1.start();
        }
        if(ob==quit3){
            playSound1();
            Thread thread1 = new Thread (){
                public void run (){
                    for(int a=1; a<=4; a++){
                        try{
                            quit3.setBackground(Color.RED);
                            quit3.setForeground(Color.BLACK);
                            op9.setVisible(false);
                            op10.setVisible(false);
                            op11.setVisible(false);
                            op12.setVisible(false);
                            question.setText("Please Wait! Closing Your Game...!");
                            question.setBounds(255,440,1000,60);
                            Thread.sleep(1000);  
                        if(a==1){
                            frm3.setVisible(false);
                            frm3.dispose();
                            quit();
                        }
                        }catch(Exception e){}
                        
                    }
                }
            };
            thread1.start();
        }
        if(ob==quit4){
            playSound1();
            Thread thread1 = new Thread (){
                public void run (){
                    for(int a=1; a<=4; a++){
                        try{
                            quit4.setBackground(Color.RED);
                            quit4.setForeground(Color.BLACK);
                            op13.setVisible(false);
                            op14.setVisible(false);
                            op15.setVisible(false);
                            op16.setVisible(false);
                            question.setText("Please Wait! Closing Your Game...!");
                            question.setBounds(255,440,1000,60);
                            Thread.sleep(1000);  
                        if(a==1){
                            frm3.setVisible(false);
                            frm3.dispose();
                            quit();
                        }
                        }catch(Exception e){}
                        
                    }
                }
            };
            thread1.start();
        }
        if(ob==quit5){
            playSound1();
            Thread thread1 = new Thread (){
                public void run (){
                    for(int a=1; a<=4; a++){
                        try{
                            quit5.setBackground(Color.RED);
                            quit5.setForeground(Color.BLACK);
                            op17.setVisible(false);
                            op18.setVisible(false);
                            op19.setVisible(false);
                            op20.setVisible(false);
                            question.setText("Please Wait! Closing Your Game...!");
                            question.setBounds(255,440,1000,60);
                            Thread.sleep(1000);  
                        if(a==1){
                            frm3.setVisible(false);
                            frm3.dispose();
                            quit();
                        }
                        }catch(Exception e){}
                        
                    }
                }
            };
            thread1.start();
        }
        if(ob==quit6){
            playSound1();
            Thread thread1 = new Thread (){
                public void run (){
                    for(int a=1; a<=4; a++){
                        try{
                            quit6.setBackground(Color.RED);
                            quit6.setForeground(Color.BLACK);
                            op21.setVisible(false);
                            op22.setVisible(false);
                            op23.setVisible(false);
                            op24.setVisible(false);
                            question.setText("Please Wait! Closing Your Game...!");
                            question.setBounds(255,440,1000,60);
                            Thread.sleep(1000);  
                        if(a==1){
                            frm3.setVisible(false);
                            frm3.dispose();
                            quit();
                        }
                        }catch(Exception e){}
                        
                    }
                }
            };
            thread1.start();
        }
        if(ob==quit7){
            playSound1();
            Thread thread1 = new Thread (){
                public void run (){
                    for(int a=1; a<=4; a++){
                        try{
                            quit7.setBackground(Color.RED);
                            quit7.setForeground(Color.BLACK);
                            op25.setVisible(false);
                            op26.setVisible(false);
                            op27.setVisible(false);
                            op28.setVisible(false);
                            question.setText("Please Wait! Closing Your Game...!");
                            question.setBounds(255,440,1000,60);
                            Thread.sleep(1000);  
                        if(a==1){
                            frm3.setVisible(false);
                            frm3.dispose();
                            quit();
                        }
                        }catch(Exception e){}
                        
                    }
                }
            };
            thread1.start();
        }
        if(ob==quit8){
            playSound1();
            Thread thread1 = new Thread (){
                public void run (){
                    for(int a=1; a<=4; a++){
                        try{
                            quit8.setBackground(Color.RED);
                            quit8.setForeground(Color.BLACK);
                            op29.setVisible(false);
                            op30.setVisible(false);
                            op31.setVisible(false);
                            op32.setVisible(false);
                            question.setText("Please Wait! Closing Your Game...!");
                            question.setBounds(255,440,1000,60);
                            Thread.sleep(1000);  
                        if(a==1){
                            frm3.setVisible(false);
                            frm3.dispose();
                            quit();
                        }
                        }catch(Exception e){}
                        
                    }
                }
            };
            thread1.start();
        }
        if(ob==quit9){
            playSound1();
            Thread thread1 = new Thread (){
                public void run (){
                    for(int a=1; a<=4; a++){
                        try{
                            quit9.setBackground(Color.RED);
                            quit9.setForeground(Color.BLACK);
                            op35.setVisible(false);
                            op33.setVisible(false);
                            op34.setVisible(false);
                            op36.setVisible(false);
                            question.setText("Please Wait! Closing Your Game...!");
                            question.setBounds(255,440,1000,60);
                            Thread.sleep(1000);  
                        if(a==1){
                            frm3.setVisible(false);
                            frm3.dispose();
                            quit();
                        }
                        }catch(Exception e){}
                        
                    }
                }
            };
            thread1.start();
        }
        if(ob==quit10){
            playSound1();
            Thread thread1 = new Thread (){
                public void run (){
                    for(int a=1; a<=4; a++){
                        try{
                            quit10.setBackground(Color.RED);
                            quit10.setForeground(Color.BLACK);
                            op37.setVisible(false);
                            op38.setVisible(false);
                            op39.setVisible(false);
                            op40.setVisible(false);
                            question.setText("Please Wait! Closing Your Game...!");
                            question.setBounds(255,440,1000,60);
                            Thread.sleep(1000);  
                        if(a==1){
                            frm3.setVisible(false);
                            frm3.dispose();
                            quit();
                        }
                        }catch(Exception e){}
                        
                    }
                }
            };
            thread1.start();
        }
        
        
        
        
    }
    
    //In Use
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();
        
        //q1
        if(ob==op2){
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==op3){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op4){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }

        
        //q2
        if(ob==op5){ 
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==op7){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op8){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        
        //q3
        if(ob==op9){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==op10){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op12){ 
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        
        //q4
        if(ob==op14){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==op15){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op13){ 
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        

        
        //q5
        if(ob==op19){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==op18){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op20){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        

        
        //q6
        if(ob==op21){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==op23){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op24){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
      
        
        //q7
        if(ob==op26){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==op25){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op28){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
      
        
        //q8
        if(ob==op30){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==op31){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op29){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
    
        
        //q9
        if(ob==op33){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==op35){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op36){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
  
        
        //q10
        if(ob==op37){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==op38){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op40){  
            playSound2();
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
   
    }
    
    
    //Connect with Quit Button
    public void quit(){
    this.setBounds(200,20,40,40);
    this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/6-10/quit7.jpg")));
    pan.add(jlb);
    this.setTitle("I Quit...!");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
    
    //Connect with Wrong Button
    public void wrong(){
    this.setBounds(310,50,40,40);
    this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/incorrect/incorrect7.png"))); 
    pan.add(jlb);
    this.setTitle("Wrong Answer...!");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
    
    public void playSound() {
        try {
            AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(new File("C:\\Users\\Sameer Khowaja\\Documents\\NetBeansProjects\\KBC Game\\src\\sounds\\clap.wav"));
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