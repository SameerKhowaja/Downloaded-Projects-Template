import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.*;
import java.awt.event.ActionEvent;
import java.io.File;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;

public class Play extends JFrame implements MouseListener, ActionListener{
    JFrame frm2;
    public JButton btnplay, about, exit, quit;
    public JLabel label, question;
    
    public void Letsplay(String str){
        frm2 = new JFrame();
        frm2.setBounds(200, 20, 0, 0);
        frm2.setDefaultCloseOperation(3);
        frm2.setLayout(null);
        frm2.setTitle("KAUN BANEGA CROREPATI");
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("main/play.png")));
        pan.add(jlb);
        frm2.setContentPane(jlb);
        frm2.setResizable(true);
        frm2.pack();
      
        //more
        label = new JLabel("Welcome " + str);
        label.setBounds(170,20,350,45);
        label.setFont(new Font("Gill Sans", 15, 25));
        label.setForeground(Color.WHITE);
        frm2.add(label);
        
        question = new JLabel(" Are you ready to play the game ? ");
        question.setBounds(65,480,600,60);
        question.setFont(new Font("Gill Sans", 15, 35));
        question.setForeground(Color.WHITE);
        frm2.add(question);
        
        btnplay = new JButton("Start!");
        btnplay.setBounds(500,585,339,44);
        btnplay.setFont(new Font("Gill Sans", 5, 25));
        btnplay.setBackground(Color.BLACK);
        btnplay.setForeground(Color.WHITE);
        frm2.add(btnplay);
        
        about = new JButton("Author!");
        about.setBounds(700,403,170,50);
        about.setFont(new Font("Gill Sans", 7, 26));
        about.setBackground(Color.YELLOW);
        about.setForeground(Color.BLACK);
        frm2.add(about);
        
        exit = new JButton("Exit!");
        exit.setBounds(53,585,339,44);
        exit.setFont(new Font("Gill Sans", 7, 26));
        exit.setBackground(Color.BLACK);
        exit.setForeground(Color.WHITE);
        frm2.add(exit);

        btnplay.addMouseListener(this);
        btnplay.addActionListener(this);
        about.addMouseListener(this);
        exit.addMouseListener(this);
        exit.addActionListener(this);        
        
        frm2.setVisible(true);
        frm2.setVisible(true);
    }
    
    
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();
        
        if(ob==about){ 
            playSound1();
            about(); 
        }
    }
    
    //In Use
    public void actionPerformed(ActionEvent e){
	Object ob=e.getSource();
	
        Random ra = new Random();
        int pick = ra.nextInt(10);
            
        if(ob==btnplay){ 
            playSound();
            Thread thread1 = new Thread (){
            public void run () {
		for(int a=1; a<=4; a++){
                    try{
			btnplay.setBackground(Color.ORANGE);
                        btnplay.setForeground(Color.BLACK);
                        btnplay.setText("Playing...!");
                        question.setText("Please Wait! Setting Up Your Game Data...!");
                        question.setBounds(120,480,1000,60);
                        btnplay.setBorderPainted(false);
                        btnplay.setFocusPainted(false);
                        exit.setVisible(false);
                        about.setVisible(false);
			Thread.sleep(2000);
            if(a==2){    
                Topics sam = new Topics();
                sam.playing();
                frm2.setVisible(false);
            
            }
                    }catch(Exception e){}
		}
            }
            };
            thread1.start();
        }
        
        
        if(ob==exit){ 
            playSound2();
            Thread thread1 = new Thread (){
            public void run () {
		for(int a=1; a<=4; a++){
                    try{
			exit.setBackground(Color.RED);
                        exit.setForeground(Color.BLACK);
                        exit.setText("Exiting...!");
                        exit.setBorderPainted(false);
                        exit.setFocusPainted(false);
                        question.setText("Please Wait! Closing Your Game...!");
                        question.setBounds(170,480,1000,60);
                        btnplay.setVisible(false);  
                        about.setVisible(false);
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
    
    //Connect with Author Button
    public void about(){
    this.setBounds(205,25,0,0);
    //this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("main/by.jpg"))); 
    pan.add(jlb);
    this.setTitle("Author");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
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
