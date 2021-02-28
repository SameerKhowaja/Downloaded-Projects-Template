import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.File;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;

public class Name extends JFrame implements MouseListener, ActionListener {
    
    public JButton btnplay, about, exit, quit;
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
    public String str = "";
    public JLabel label, question, question2;
    public JTextField name;
    JFrame frm;

    public Name(){
        frm = new JFrame();
        frm.setBounds(230, 50, 680, 400);
        frm.setDefaultCloseOperation(3);
        frm.setLayout(null);
        frm.setTitle("KAUN BANEGA CROREPATI...! (Made By SAMEER KHOWAJA)");
        frm.getContentPane().setBackground(Color.BLACK);

        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("main/name.jpg")));
        pan.add(jlb);
        frm.setContentPane(jlb);
        frm.setResizable(false);
        frm.pack();
        
        //more
        label = new JLabel("Enter Your Name Here : ");
        label.setBounds(310,205,350,45);
        label.setFont(new Font("Gill Sans", 15, 30));
        label.setFont(new Font("Gill Sans", Font.BOLD, 30));
        //label.setBackground(Color.RED);
        label.setForeground(Color.magenta);
        frm.add(label);
        
        name = new JTextField();
        name.setBounds(315,255,350,45);
        name.setFont(new Font("Gill Sans", 6, 25));
        name.setBackground(Color.GREEN);
        name.setForeground(Color.BLACK);
        frm.add(name);
        
        btnplay = new JButton("OK!");
        btnplay.setBounds(555,307,110,45);
        btnplay.setFont(new Font("Gill Sans", 3, 20));
        btnplay.setBackground(Color.YELLOW);
        btnplay.setForeground(Color.BLACK);
        frm.add(btnplay);
        
        about = new JButton("Rules!");
        about.setBounds(435,307,110,45);
        about.setFont(new Font("Gill Sans", 3, 20));
        about.setBackground(Color.YELLOW);
        about.setForeground(Color.BLACK);
        frm.add(about);
        
        exit = new JButton("Exit!");
        exit.setBounds(315,307,110,45);
        exit.setFont(new Font("Gill Sans", 3, 20));
        exit.setBackground(Color.YELLOW);
        exit.setForeground(Color.BLACK);
        frm.add(exit);
        
        question = new JLabel("");
        question.setBounds(415,350,1000,45);
        question.setFont(new Font("Gill Sans", 2, 18));
        question.setForeground(Color.BLACK);
        frm.add(question);
         
        btnplay.addActionListener(this);
        btnplay.addMouseListener(this);
        about.addMouseListener(this);
        exit.addActionListener(this);
        exit.addMouseListener(this);
        
        frm.setVisible(true);
    }
    
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
    public void actionPerformed(ActionEvent e){
       Object ob = e.getSource(); 
       
       if(ob==btnplay){
           playSound();
            str=name.getText();
            Thread thread1 = new Thread (){
		public void run () {
		for(int a=1; a<=4; a++){
                try{
                    btnplay.setText("Loading...!");
                    btnplay.setFont(new Font("Gill Sans", 3, 20));
                    exit.setVisible(false);
                    about.setVisible(false);
                    btnplay.setBounds(420,307,150,45);
                    btnplay.setBorderPainted(false);
                    btnplay.setFocusPainted(false);
                    Thread.sleep(1000);
		}catch(Exception e){}
                    if(a==1){
			Play sam = new Play();
                        sam.Letsplay(str);
                        frm.setVisible(false);
                    }
		}
		}
            };
            thread1.start();
	}
       
       if(ob==exit){
           playSound();
            Thread thread1 = new Thread (){
		public void run () {
		for(int a=1; a<=4; a++){
                    exit.setText("Closing...!");
                    exit.setFont(new Font("Gill Sans", 3, 20));
                    btnplay.setVisible(false);
                    name.setText("Thanks For Playing...!");
                    about.setVisible(false);
                    exit.setBounds(420,307,150,45);
                    exit.setBorderPainted(false);
                    exit.setFocusPainted(false);
		try{
                    Thread.sleep(1000);
		}catch(Exception e){}
                    if(a==1){
			System.exit(0);
                    }
		}
		}
            };
            thread1.start();
	}
    }
    
    //In Use
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();
        
        if(ob==about){ 
            playSound();
            about();
            name.setText("");
        }   
        
    }
    
    //Connect with Author Button
    public void about(){
    this.setBounds(200,20,40,40);
    JPanel pan = new JPanel();
    JLabel jlb = new JLabel();
    jlb.setIcon(new ImageIcon(getClass().getResource("lifeline/rules.png")));
    pan.add(jlb);
    this.setTitle("Author");
    this.setContentPane(jlb);
    this.setResizable(false);
    this.pack();
    this.setVisible(true);
    }
    
    public static void main(String[] args) {
       Name k = new Name();
    }
    
    public void playSound() {
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
    
}
