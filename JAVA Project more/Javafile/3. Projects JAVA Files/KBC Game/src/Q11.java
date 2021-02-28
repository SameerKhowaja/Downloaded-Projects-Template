import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.File;
import java.util.*;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;

public class Q11 extends JFrame implements MouseListener, ActionListener{
    JFrame frm3;
    public JButton quit1, quit2, quit3, quit4, quit5;
    public JButton op1, op2, op3, op4;
    public JButton op5, op6, op7, op8;
    public JButton op9, op10, op11, op12;
    public JButton op13, op14, op15, op16;
    public JButton op17, op18, op19, op20;
    public JButton b1,b2,b3,b4,b5;
    public JLabel label, question, question2;
    
    public void q1(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:11");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eleven.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        question = new JLabel();
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 25));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op1=new JButton("5");
        op1.setBounds(86,538,320,43);
        op1.setFont(new Font("Gill Sans", 5, 25));
        op1.setBackground(Color.BLACK);
        op1.setForeground(Color.WHITE);
        op1.setVisible(false);
        frm3.add(op1);
        
        //option 2
        op2=new JButton("4");
        op2.setBounds(86,610,320,43);
        op2.setFont(new Font("Gill Sans", 5, 25));
        op2.setBackground(Color.BLACK);
        op2.setForeground(Color.WHITE);
        op2.setVisible(false);
        frm3.add(op2);
        
        //option 3
        op3=new JButton("0");
        op3.setBounds(551,538,320,43);
        op3.setFont(new Font("Gill Sans", 5, 25));
        op3.setBackground(Color.BLACK);
        op3.setForeground(Color.WHITE);
        op3.setVisible(false);
        frm3.add(op3);
        
        //option 4
        op4=new JButton("1");
        op4.setBounds(551,610,320,43);
        op4.setFont(new Font("Gill Sans", 5, 25));
        op4.setBackground(Color.BLACK);
        op4.setForeground(Color.WHITE);
        op4.setVisible(false);
        frm3.add(op4);
        
        b1=new JButton("Click Me!");
        b1.setBounds(65,440,800,60);
        b1.setFont(new Font("Gill Sans", 5, 25));
        b1.setBackground(Color.BLACK);
        b1.setForeground(Color.WHITE);
        frm3.add(b1);
      
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
        b1.addMouseListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q2(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:11");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eleven.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();

        question = new JLabel();
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 25));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op5=new JButton("1");
        op5.setBounds(86,538,320,43);
        op5.setFont(new Font("Gill Sans", 5, 25));
        op5.setBackground(Color.BLACK);
        op5.setForeground(Color.WHITE);
        op5.setVisible(false);
        frm3.add(op5);
        
        //option 2
        op6=new JButton("0");
        op6.setBounds(86,610,320,43);
        op6.setFont(new Font("Gill Sans", 5, 25));
        op6.setBackground(Color.BLACK);
        op6.setForeground(Color.WHITE);
        op6.setVisible(false);
        frm3.add(op6);
        
        //option 3
        op7=new JButton("true");
        op7.setBounds(551,538,320,43);
        op7.setFont(new Font("Gill Sans", 5, 25));
        op7.setBackground(Color.BLACK);
        op7.setForeground(Color.WHITE);
        op7.setVisible(false);
        frm3.add(op7);
        
        //option 4
        op8=new JButton("false");
        op8.setBounds(551,610,320,43);
        op8.setFont(new Font("Gill Sans", 5, 25));
        op8.setBackground(Color.BLACK);
        op8.setForeground(Color.WHITE);
        op8.setVisible(false);
        frm3.add(op8);
        
        b2=new JButton("Click Me!");
        b2.setBounds(65,440,800,60);
        b2.setFont(new Font("Gill Sans", 5, 25));
        b2.setBackground(Color.BLACK);
        b2.setForeground(Color.WHITE);
        frm3.add(b2);
    
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
        b2.addMouseListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q3(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:11");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eleven.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();

        question = new JLabel();
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 25));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op9=new JButton("false");
        op9.setBounds(86,538,320,43);
        op9.setFont(new Font("Gill Sans", 5, 25));
        op9.setBackground(Color.BLACK);
        op9.setForeground(Color.WHITE);
        op9.setVisible(false);
        frm3.add(op9);
        
        //option 2
        op10=new JButton("0");
        op10.setBounds(86,610,320,43);
        op10.setFont(new Font("Gill Sans", 5, 25));
        op10.setBackground(Color.BLACK);
        op10.setForeground(Color.WHITE);
        op10.setVisible(false);
        frm3.add(op10);
        
        //option 3
        op11=new JButton("true");
        op11.setBounds(551,538,320,43);
        op11.setFont(new Font("Gill Sans", 5, 25));
        op11.setBackground(Color.BLACK);
        op11.setForeground(Color.WHITE);
        op11.setVisible(false);
        frm3.add(op11);
        
        //option 4
        op12=new JButton("1");
        op12.setBounds(551,610,320,43);
        op12.setFont(new Font("Gill Sans", 5, 25));
        op12.setBackground(Color.BLACK);
        op12.setForeground(Color.WHITE);
        op12.setVisible(false);
        frm3.add(op12);
        
        b3=new JButton("Click Me!");
        b3.setBounds(65,440,800,60);
        b3.setFont(new Font("Gill Sans", 5, 25));
        b3.setBackground(Color.BLACK);
        b3.setForeground(Color.WHITE);
        frm3.add(b3);
       
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
        b3.addMouseListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q4(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:11");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eleven.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        
        question = new JLabel();
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 25));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op13=new JButton("620.0");
        op13.setBounds(86,538,320,43);
        op13.setFont(new Font("Gill Sans", 5, 25));
        op13.setBackground(Color.BLACK);
        op13.setForeground(Color.WHITE);
        op13.setVisible(false);
        frm3.add(op13);
        
        //option 2
        op14=new JButton("615.0");
        op14.setBounds(86,610,320,43);
        op14.setFont(new Font("Gill Sans", 5, 25));
        op14.setBackground(Color.BLACK);
        op14.setForeground(Color.WHITE);
        op14.setVisible(false);
        frm3.add(op14);
        
        //option 3
        op15=new JButton("512.0");
        op15.setBounds(551,538,320,43);
        op15.setFont(new Font("Gill Sans", 5, 25));
        op15.setBackground(Color.BLACK);
        op15.setForeground(Color.WHITE);
        op15.setVisible(false);
        frm3.add(op15);
        
        //option 4
        op16=new JButton("625.0");
        op16.setBounds(551,610,320,43);
        op16.setFont(new Font("Gill Sans", 5, 25));
        op16.setBackground(Color.BLACK);
        op16.setForeground(Color.WHITE);
        op16.setVisible(false);
        frm3.add(op16);
        
        b4=new JButton("Click Me!");
        b4.setBounds(65,440,800,60);
        b4.setFont(new Font("Gill Sans", 5, 25));
        b4.setBackground(Color.BLACK);
        b4.setForeground(Color.WHITE);
        frm3.add(b4);
  
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
        b4.addMouseListener(this);
        
        frm3.setVisible(true);
        frm3.setVisible(true);
    }
    
    public void q5(){
        
        frm3=new JFrame();
        frm3.setBounds(200, 10, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Question No:11");
        frm3.getContentPane().setBackground(Color.GREEN);
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("questions/eleven.png")));
        pan.add(jlb);
        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();

        question = new JLabel();
        question.setBounds(60,440,1000,60);
        question.setFont(new Font("Gill Sans", 15, 25));
        question.setForeground(Color.WHITE);
        frm3.add(question);
        
        //option 1
        op17=new JButton("27,9");
        op17.setBounds(86,538,320,43);
        op17.setFont(new Font("Gill Sans", 5, 22));
        op17.setBackground(Color.BLACK);
        op17.setForeground(Color.WHITE);
        op17.setVisible(false);
        frm3.add(op17);
        
        //option 2
        op18=new JButton("24,9");
        op18.setBounds(86,610,320,43);
        op18.setFont(new Font("Gill Sans", 5, 22));
        op18.setBackground(Color.BLACK);
        op18.setForeground(Color.WHITE);
        op18.setVisible(false);
        frm3.add(op18);
        
        //option 3
        op19=new JButton("27,8");
        op19.setBounds(551,538,320,43);
        op19.setFont(new Font("Gill Sans", 5, 22));
        op19.setBackground(Color.BLACK);
        op19.setForeground(Color.WHITE);
        op19.setVisible(false);
        frm3.add(op19);
        
        //option 4
        op20=new JButton("24,8");
        op20.setBounds(551,610,320,43);
        op20.setFont(new Font("Gill Sans", 5, 22));
        op20.setBackground(Color.BLACK);
        op20.setForeground(Color.WHITE);
        op20.setVisible(false);
        frm3.add(op20);
        
        b5=new JButton("Click Me!");
        b5.setBounds(65,440,800,60);
        b5.setFont(new Font("Gill Sans", 5, 25));
        b5.setBackground(Color.BLACK);
        b5.setForeground(Color.WHITE);
        frm3.add(b5);
    
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
        b5.addMouseListener(this);
        
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
        int pick = ra.nextInt(5);
        
        Q12 sam = new Q12();
        
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
            b1.setVisible(false);
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
            b2.setVisible(false);
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
            b3.setVisible(false);
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
            b4.setVisible(false);
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
            b5.setVisible(false);
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

        
    }
    
    //In Use
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();

        //b1-b5
        if(ob==b1){
            playSound1();
            p1();
            question.setVisible(true);
            op1.setVisible(true);
            op2.setVisible(true);
            op3.setVisible(true);
            op4.setVisible(true);
            quit1.setVisible(false);
        }
        
        if(ob==b2){
            playSound1();
            p2();
            question.setVisible(true);
            op5.setVisible(true);
            op6.setVisible(true);
            op7.setVisible(true);
            op8.setVisible(true);
            quit2.setVisible(false);
        }
        
        if(ob==b3){
            playSound1();
            p3();
            question.setVisible(true);
            op9.setVisible(true);
            op10.setVisible(true);
            op11.setVisible(true);
            op12.setVisible(true);
            quit3.setVisible(false);
        }
        
        if(ob==b4){
            playSound1();
            p4();
            question.setVisible(true);
            op13.setVisible(true);
            op14.setVisible(true);
            op15.setVisible(true);
            op16.setVisible(true);
            quit4.setVisible(false);
        }
        
        if(ob==b5){
            playSound1();
            p5();
            question.setVisible(true);
            op17.setVisible(true);
            op18.setVisible(true);
            op19.setVisible(true);
            op20.setVisible(true);
            quit5.setVisible(false);
        }
        
        
        
        
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
        
    }
    
    
    //Connect with Quit Button
    public void quit(){
    this.setBounds(200,20,40,40);
    this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/11-15/quit10.jpg")));
    pan.add(jlb);
    this.setTitle("I Quit...!");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
    
    //Connect with Wrong Button
    public void wrong(){
    this.setBounds(400,40,40,40);
    this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/incorrect/epic fail.jpg")));
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
    
    
    
    
    public void p1(){
    this.setBounds(300,50,40,40);
    //this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/Quiz Answers/JAVA Quiz/Question 11/1.png")));
    pan.add(jlb);
    this.setTitle("Question No:11");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
    
    public void p2(){
    this.setBounds(300,50,40,40);
    //this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/Quiz Answers/JAVA Quiz/Question 11/2.png")));
    pan.add(jlb);
    this.setTitle("Question No:11");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
    
    public void p3(){
    this.setBounds(300,50,40,40);
    //this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/Quiz Answers/JAVA Quiz/Question 11/3.png"))); 
    pan.add(jlb);
    this.setTitle("Question No:11");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
    
    public void p4(){
    this.setBounds(300,50,40,40);
    //this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/Quiz Answers/JAVA Quiz/Question 11/4.png")));
    pan.add(jlb);
    this.setTitle("Question No:11");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
    
    public void p5(){
    this.setBounds(300,50,40,40);
    //this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("Wrong Answer/Quiz Answers/JAVA Quiz/Question 11/5.png")));
    pan.add(jlb);
    this.setTitle("Question No:11");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
 
}