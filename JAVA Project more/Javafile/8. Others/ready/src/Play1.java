import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.*;

public class Q1 extends Name{
    JFrame frm3;
    JLabel[] ques;
    
    public Q1(){
        // Question are of Introduction in q1-q10 of JAVA
    }
    
    public void q1(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:01)");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/one.png")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //Question
        question = new JLabel(" Java was first developed in ? ");
        question.setBounds(65,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 35));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op1=new JButton("1990");
        op1.setBounds(86,538,320,43);
        op1.setFont(new Font("Gill Sans", 5, 25));
        op1.setBackground(Color.BLACK);
        op1.setForeground(Color.WHITE);
        frm3.add(op1);
        
        //option 2
        op2=new JButton("1991");
        op2.setBounds(86,610,320,43);
        op2.setFont(new Font("Gill Sans", 5, 25));
        op2.setBackground(Color.BLACK);
        op2.setForeground(Color.WHITE);
        frm3.add(op2);
        
        //option 3
        op3=new JButton("1993");
        op3.setBounds(551,538,320,43);
        op3.setFont(new Font("Gill Sans", 5, 25));
        op3.setBackground(Color.BLACK);
        op3.setForeground(Color.WHITE);
        frm3.add(op3);
        
        //option 4
        op4=new JButton("1996");
        op4.setBounds(551,610,320,43);
        op4.setFont(new Font("Gill Sans", 5, 25));
        op4.setBackground(Color.BLACK);
        op4.setForeground(Color.WHITE);
        frm3.add(op4);
        
      
        quit=new JButton("Quit!");
        quit.setBounds(720,368,180,50);
        quit.setFont(new Font("Gill Sans", 5, 28));
        quit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit.setBackground(Color.YELLOW);
        quit.setForeground(Color.BLACK);
        frm3.add(quit);

        frm3.setVisible(true);
        frm.setVisible(false);
        op1.addMouseListener(this);
        op2.addMouseListener(this);
        op3.addMouseListener(this);
        op4.addMouseListener(this);
        quit.addMouseListener(this);
    
    }
    
    public void q2(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:01)");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/one.png")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //Question
        question = new JLabel(" The old name of Java was ? ");
        question.setBounds(65,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 35));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op5=new JButton("J language");
        op5.setBounds(86,538,320,43);
        op5.setFont(new Font("Gill Sans", 5, 25));
        op5.setBackground(Color.BLACK);
        op5.setForeground(Color.WHITE);
        frm3.add(op5);
        
        //option 2
        op6=new JButton("oak");
        op6.setBounds(86,610,320,43);
        op6.setFont(new Font("Gill Sans", 5, 25));
        op6.setBackground(Color.BLACK);
        op6.setForeground(Color.WHITE);
        frm3.add(op6);
        
        //option 3
        op7=new JButton("oct");
        op7.setBounds(551,538,320,43);
        op7.setFont(new Font("Gill Sans", 5, 25));
        op7.setBackground(Color.BLACK);
        op7.setForeground(Color.WHITE);
        frm3.add(op7);
        
        //option 4
        op8=new JButton("None of above");
        op8.setBounds(551,610,320,43);
        op8.setFont(new Font("Gill Sans", 5, 25));
        op8.setBackground(Color.BLACK);
        op8.setForeground(Color.WHITE);
        frm3.add(op8);
        
    
        quit=new JButton("Quit!");
        quit.setBounds(720,368,180,50);
        quit.setFont(new Font("Gill Sans", 5, 28));
        quit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit.setBackground(Color.YELLOW);
        quit.setForeground(Color.BLACK);
        frm3.add(quit);

        frm3.setVisible(true);
        frm.setVisible(false);
        op5.addMouseListener(this);
        op6.addMouseListener(this);
        op7.addMouseListener(this);
        op8.addMouseListener(this);
        quit.addMouseListener(this);
    
    }
    
    public void q3(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:01)");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/one.png")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //Question
        question = new JLabel(" Which of the following feature is not supported by java ? ");
        question.setBounds(65,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 32));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op9=new JButton("Multithreading");
        op9.setBounds(86,538,320,43);
        op9.setFont(new Font("Gill Sans", 5, 22));
        op9.setBackground(Color.BLACK);
        op9.setForeground(Color.WHITE);
        frm3.add(op9);
        
        //option 2
        op10=new JButton("Reflection");
        op10.setBounds(86,610,320,43);
        op10.setFont(new Font("Gill Sans", 5, 22));
        op10.setBackground(Color.BLACK);
        op10.setForeground(Color.WHITE);
        frm3.add(op10);
        
        //option 3
        op11=new JButton("Operator Overloading");
        op11.setBounds(551,538,320,43);
        op11.setFont(new Font("Gill Sans", 5, 22));
        op11.setBackground(Color.BLACK);
        op11.setForeground(Color.WHITE);
        frm3.add(op11);
        
        //option 4
        op12=new JButton("Garbage Collection");
        op12.setBounds(551,610,320,43);
        op12.setFont(new Font("Gill Sans", 5, 22));
        op12.setBackground(Color.BLACK);
        op12.setForeground(Color.WHITE);
        frm3.add(op12);
        
       
        quit=new JButton("Quit!");
        quit.setBounds(720,368,180,50);
        quit.setFont(new Font("Gill Sans", 5, 28));
        quit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit.setBackground(Color.YELLOW);
        quit.setForeground(Color.BLACK);
        frm3.add(quit);

        frm3.setVisible(true);
        frm.setVisible(false);
        op9.addMouseListener(this);
        op10.addMouseListener(this);
        op11.addMouseListener(this);
        op12.addMouseListener(this);
        quit.addMouseListener(this);
    
    }
    
    public void q4(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:01)");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/one.png")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //Question
        question = new JLabel(" Which of the following is not keyword in java ? ");
        question.setBounds(65,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 32));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op13=new JButton("null");
        op13.setBounds(86,538,320,43);
        op13.setFont(new Font("Gill Sans", 5, 25));
        op13.setBackground(Color.BLACK);
        op13.setForeground(Color.WHITE);
        frm3.add(op13);
        
        //option 2
        op14=new JButton("import");
        op14.setBounds(86,610,320,43);
        op14.setFont(new Font("Gill Sans", 5, 25));
        op14.setBackground(Color.BLACK);
        op14.setForeground(Color.WHITE);
        frm3.add(op14);
        
        //option 3
        op15=new JButton("volatile");
        op15.setBounds(551,538,320,43);
        op15.setFont(new Font("Gill Sans", 5, 25));
        op15.setBackground(Color.BLACK);
        op15.setForeground(Color.WHITE);
        frm3.add(op15);
        
        //option 4
        op16=new JButton("package");
        op16.setBounds(551,610,320,43);
        op16.setFont(new Font("Gill Sans", 5, 25));
        op16.setBackground(Color.BLACK);
        op16.setForeground(Color.WHITE);
        frm3.add(op16);
        
  
        quit=new JButton("Quit!");
        quit.setBounds(720,368,180,50);
        quit.setFont(new Font("Gill Sans", 5, 28));
        quit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit.setBackground(Color.YELLOW);
        quit.setForeground(Color.BLACK);
        frm3.add(quit);

        frm3.setVisible(true);
        frm.setVisible(false);
        op13.addMouseListener(this);
        op14.addMouseListener(this);
        op15.addMouseListener(this);
        op16.addMouseListener(this);
        quit.addMouseListener(this);
    
    }
    
    public void q5(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:01)");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/one.png")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //Question
        question = new JLabel(" What is the full form of JDK ? ");
        question.setBounds(65,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 35));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op17=new JButton("Java Data Kit");
        op17.setBounds(86,538,320,43);
        op17.setFont(new Font("Gill Sans", 5, 23));
        op17.setBackground(Color.BLACK);
        op17.setForeground(Color.WHITE);
        frm3.add(op17);
        
        //option 2
        op18=new JButton("Java Defination Kit");
        op18.setBounds(86,610,320,43);
        op18.setFont(new Font("Gill Sans", 5, 22));
        op18.setBackground(Color.BLACK);
        op18.setForeground(Color.WHITE);
        frm3.add(op18);
        
        //option 3
        op19=new JButton("Java Development Kit");
        op19.setBounds(551,538,320,43);
        op19.setFont(new Font("Gill Sans", 5, 22));
        op19.setBackground(Color.BLACK);
        op19.setForeground(Color.WHITE);
        frm3.add(op19);
        
        //option 4
        op20=new JButton("Java Design Kit");
        op20.setBounds(551,610,320,43);
        op20.setFont(new Font("Gill Sans", 5, 23));
        op20.setBackground(Color.BLACK);
        op20.setForeground(Color.WHITE);
        frm3.add(op20);
        
    
        quit=new JButton("Quit!");
        quit.setBounds(720,368,180,50);
        quit.setFont(new Font("Gill Sans", 5, 28));
        quit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit.setBackground(Color.YELLOW);
        quit.setForeground(Color.BLACK);
        frm3.add(quit);

        frm3.setVisible(true);
        frm.setVisible(false);
        op17.addMouseListener(this);
        op18.addMouseListener(this);
        op19.addMouseListener(this);
        op20.addMouseListener(this);
        quit.addMouseListener(this);
    
    }
    
    public void q6(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:01)");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/one.png")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //Question
        question = new JLabel(" Which command is used to compile a java program ? ");
        question.setBounds(65,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 32));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op21=new JButton("javac");
        op21.setBounds(86,538,320,43);
        op21.setFont(new Font("Gill Sans", 5, 25));
        op21.setBackground(Color.BLACK);
        op21.setForeground(Color.WHITE);
        frm3.add(op21);
        
        //option 2
        op22=new JButton("java");
        op22.setBounds(86,610,320,43);
        op22.setFont(new Font("Gill Sans", 5, 25));
        op22.setBackground(Color.BLACK);
        op22.setForeground(Color.WHITE);
        frm3.add(op22);
        
        //option 3
        op23=new JButton("javad");
        op23.setBounds(551,538,320,43);
        op23.setFont(new Font("Gill Sans", 5, 25));
        op23.setBackground(Color.BLACK);
        op23.setForeground(Color.WHITE);
        frm3.add(op23);
        
        //option 4
        op24=new JButton(".javadoc");
        op24.setBounds(551,610,320,43);
        op24.setFont(new Font("Gill Sans", 5, 25));
        op24.setBackground(Color.BLACK);
        op24.setForeground(Color.WHITE);
        frm3.add(op24);
        
    
        quit=new JButton("Quit!");
        quit.setBounds(720,368,180,50);
        quit.setFont(new Font("Gill Sans", 5, 28));
        quit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit.setBackground(Color.YELLOW);
        quit.setForeground(Color.BLACK);
        frm3.add(quit);

        frm3.setVisible(true);
        frm.setVisible(false);
        op21.addMouseListener(this);
        op22.addMouseListener(this);
        op23.addMouseListener(this);
        op24.addMouseListener(this);
        quit.addMouseListener(this);
    
    }
    
    public void q7(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:01)");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/one.png")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //Question
        question = new JLabel(" What is the full form of JVM ? ");
        question.setBounds(65,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 35));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op25=new JButton("Java Virtual Machine");
        op25.setBounds(86,538,320,43);
        op25.setFont(new Font("Gill Sans", 5, 20));
        op25.setBackground(Color.BLACK);
        op25.setForeground(Color.WHITE);
        frm3.add(op25);
        
        //option 2
        op26=new JButton("Java Variable Machine");
        op26.setBounds(86,610,320,43);
        op26.setFont(new Font("Gill Sans", 5, 20));
        op26.setBackground(Color.BLACK);
        op26.setForeground(Color.WHITE);
        frm3.add(op26);
        
        //option 3
        op27=new JButton("Java Virtual Mechanism");
        op27.setBounds(551,538,320,43);
        op27.setFont(new Font("Gill Sans", 5, 20));
        op27.setBackground(Color.BLACK);
        op27.setForeground(Color.WHITE);
        frm3.add(op27);
        
        //option 4
        op28=new JButton("Java Variable Mechanism");
        op28.setBounds(551,610,320,43);
        op28.setFont(new Font("Gill Sans", 5, 20));
        op28.setBackground(Color.BLACK);
        op28.setForeground(Color.WHITE);
        frm3.add(op28);
        
        
        quit=new JButton("Quit!");
        quit.setBounds(720,368,180,50);
        quit.setFont(new Font("Gill Sans", 5, 28));
        quit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit.setBackground(Color.YELLOW);
        quit.setForeground(Color.BLACK);
        frm3.add(quit);

        frm3.setVisible(true);
        frm.setVisible(false);
        op25.addMouseListener(this);
        op26.addMouseListener(this);
        op27.addMouseListener(this);
        op28.addMouseListener(this);
        quit.addMouseListener(this);
    
    }
    
    public void q8(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:01)");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/one.png")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //Question
        question = new JLabel(" What is the full form of ADT ? ");
        question.setBounds(65,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 35));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op29=new JButton("Abstract Data Type");
        op29.setBounds(86,538,320,43);
        op29.setFont(new Font("Gill Sans", 5, 20));
        op29.setBackground(Color.BLACK);
        op29.setForeground(Color.WHITE);
        frm3.add(op29);
        
        //option 2
        op30=new JButton("Abstract Development tool");
        op30.setBounds(86,610,320,43);
        op30.setFont(new Font("Gill Sans", 5, 20));
        op30.setBackground(Color.BLACK);
        op30.setForeground(Color.WHITE);
        frm3.add(op30);
        
        //option 3
        op31=new JButton("Abstract Design Tool");
        op31.setBounds(551,538,320,43);
        op31.setFont(new Font("Gill Sans", 5, 20));
        op31.setBackground(Color.BLACK);
        op31.setForeground(Color.WHITE);
        frm3.add(op31);
        
        //option 4
        op32=new JButton("Advance Development Tool");
        op32.setBounds(551,610,320,43);
        op32.setFont(new Font("Gill Sans", 5, 20));
        op32.setBackground(Color.BLACK);
        op32.setForeground(Color.WHITE);
        frm3.add(op32);
        
     
        quit=new JButton("Quit!");
        quit.setBounds(720,368,180,50);
        quit.setFont(new Font("Gill Sans", 5, 28));
        quit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit.setBackground(Color.YELLOW);
        quit.setForeground(Color.BLACK);
        frm3.add(quit);

        frm3.setVisible(true);
        frm.setVisible(false);
        op29.addMouseListener(this);
        op30.addMouseListener(this);
        op31.addMouseListener(this);
        op32.addMouseListener(this);
        quit.addMouseListener(this);
    
    }
    
    public void q9(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:01)");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/one.png")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //Question
        question = new JLabel(" Sharing of common information is achieved by the concept of ? ");
        question.setBounds(63,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 29));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op33=new JButton("polymorphism");
        op33.setBounds(86,538,320,43);
        op33.setFont(new Font("Gill Sans", 5, 25));
        op33.setBackground(Color.BLACK);
        op33.setForeground(Color.WHITE);
        frm3.add(op33);
        
        //option 2
        op34=new JButton("encapsulation");
        op34.setBounds(86,610,320,43);
        op34.setFont(new Font("Gill Sans", 5, 25));
        op34.setBackground(Color.BLACK);
        op34.setForeground(Color.WHITE);
        frm3.add(op34);
        
        //option 3
        op35=new JButton("inheritance");
        op35.setBounds(551,538,320,43);
        op35.setFont(new Font("Gill Sans", 5, 25));
        op35.setBackground(Color.BLACK);
        op35.setForeground(Color.WHITE);
        frm3.add(op35);
        
        //option 4
        op36=new JButton("none of above");
        op36.setBounds(551,610,320,43);
        op36.setFont(new Font("Gill Sans", 5, 25));
        op36.setBackground(Color.BLACK);
        op36.setForeground(Color.WHITE);
        frm3.add(op36);
        
        
        quit=new JButton("Quit!");
        quit.setBounds(720,368,180,50);
        quit.setFont(new Font("Gill Sans", 5, 28));
        quit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit.setBackground(Color.YELLOW);
        quit.setForeground(Color.BLACK);
        frm3.add(quit);

        frm3.setVisible(true);
        frm.setVisible(false);
        op33.addMouseListener(this);
        op34.addMouseListener(this);
        op35.addMouseListener(this);
        op36.addMouseListener(this);
        quit.addMouseListener(this);
    
    }
    
    public void q10(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:01)");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/one.png")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //Question
        question = new JLabel(" The JDK command to compile a class in the file Test.java is ?");
        question.setBounds(63,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 29));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op37=new JButton("java Test");
        op37.setBounds(86,538,320,43);
        op37.setFont(new Font("Gill Sans", 5, 25));
        op37.setBackground(Color.BLACK);
        op37.setForeground(Color.WHITE);
        frm3.add(op37);
        
        //option 2
        op38=new JButton("javac Test.java");
        op38.setBounds(86,610,320,43);
        op38.setFont(new Font("Gill Sans", 5, 25));
        op38.setBackground(Color.BLACK);
        op38.setForeground(Color.WHITE);
        frm3.add(op38);
        
        //option 3
        op39=new JButton("javac Test");
        op39.setBounds(551,538,320,43);
        op39.setFont(new Font("Gill Sans", 5, 25));
        op39.setBackground(Color.BLACK);
        op39.setForeground(Color.WHITE);
        frm3.add(op39);
        
        //option 4
        op40=new JButton("none of above");
        op40.setBounds(551,610,320,43);
        op40.setFont(new Font("Gill Sans", 5, 25));
        op40.setBackground(Color.BLACK);
        op40.setForeground(Color.WHITE);
        frm3.add(op40);
        
        
        quit=new JButton("Quit!");
        quit.setBounds(720,368,180,50);
        quit.setFont(new Font("Gill Sans", 5, 28));
        quit.setFont(new Font("Gill Sans", Font.BOLD, 30));
        quit.setBackground(Color.YELLOW);
        quit.setForeground(Color.BLACK);
        frm3.add(quit);

        frm3.setVisible(true);
        frm.setVisible(false);
        op37.addMouseListener(this);
        op38.addMouseListener(this);
        op39.addMouseListener(this);
        op40.addMouseListener(this);
        quit.addMouseListener(this);
    
    }
    
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
    //In Use
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();
        
        Random ra = new Random();
        int pick = ra.nextInt(10);
        
        //q1
        if(ob==op1){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op2){  
            Q2 sam = new Q2();
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
            
            frm3.setVisible(false);
        }
        if(ob==op3){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op4){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==quit){  
            frm3.setVisible(false);
            frm3.dispose();
            quit();
        }
        
        //q2
        if(ob==op5){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op6){  
            Q2 sam = new Q2();
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
            
            frm3.setVisible(false);
        }
        if(ob==op7){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op8){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==quit){  
            frm3.setVisible(false);
            frm3.dispose();
            quit();
        }
        
        //q3
        if(ob==op9){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op11){  
            Q2 sam = new Q2();
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
            
            frm3.setVisible(false);
        }
        if(ob==op10){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op12){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==quit){  
            frm3.setVisible(false);
            frm3.dispose();
            quit();
        }
        
        //q4
        if(ob==op14){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op13){  
            Q2 sam = new Q2();
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
            
            frm3.setVisible(false);
        }
        if(ob==op15){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op16){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==quit){  
            frm3.setVisible(false);
            frm3.dispose();
            quit();
        }
        
        //q5
        if(ob==op17){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op19){  
            Q2 sam = new Q2();
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
            
            frm3.setVisible(false);
        }
        if(ob==op18){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op20){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==quit){  
            frm3.setVisible(false);
            frm3.dispose();
            quit();
        }
        
        //q6
        if(ob==op22){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op21){  
            Q2 sam = new Q2();
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
            
            frm3.setVisible(false);
        }
        if(ob==op23){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op24){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==quit){  
            frm3.setVisible(false);
            frm3.dispose();
            quit();
        }
        
        //q7
        if(ob==op26){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op25){  
            Q2 sam = new Q2();
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
            
            frm3.setVisible(false);
        }
        if(ob==op27){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op28){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==quit){  
            frm3.setVisible(false);
            frm3.dispose();
            quit();
        }
        
        //q8
        if(ob==op30){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op29){  
            Q2 sam = new Q2();
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
            
            frm3.setVisible(false);
        }
        if(ob==op31){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op32){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==quit){  
            frm3.setVisible(false);
            frm3.dispose();
            quit();
        }
        
        //q9
        if(ob==op33){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op35){  
            Q2 sam = new Q2();
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
            
            frm3.setVisible(false);
        }
        if(ob==op34){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op36){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==quit){  
            frm3.setVisible(false);
            frm3.dispose();
            quit();
        }
        
        //q10
        if(ob==op37){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op38){  
            Q2 sam = new Q2();
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
            
            frm3.setVisible(false);
        }
        if(ob==op39){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        if(ob==op40){  
            frm3.setVisible(false);
            frm3.dispose();
            wrong();
        }
        
        if(ob==quit){  
            frm3.setVisible(false);
            frm3.dispose();
            quit();
        }
    }
    
    
    public void close(){
        System.exit(0);
    }
    
    //Connect with Quit Button
    public void quit(){
    this.setBounds(300,30,40,40);
    this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/quit1.jpg")));
     
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
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/incorrect.png")));
     
    pan.add(jlb);

    this.setTitle("Wrong Answer...!");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
 
}
