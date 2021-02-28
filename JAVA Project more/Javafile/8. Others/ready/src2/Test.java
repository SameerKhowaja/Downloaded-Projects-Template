import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
import javax.swing.JButton;
import javax.swing.JFrame;

public class Test extends JFrame {

    public static void main(String[] args) {
        new Test();
    }

    public Test() {
        JButton button = new JButton("play");
        button.addActionListener(new  ActionListener() {
        public void actionPerformed(ActionEvent e) {
                playSound();
        }});
        this.getContentPane().add(button);
        this.setVisible(true);
    }

    public void playSound() {
        try {
            AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(new File("Kbc.wav"));
            Clip clip = AudioSystem.getClip( );
            clip.open(audioInputStream);
            clip.start( );
        }
        catch(Exception e)  {
            e.printStackTrace( );
        }
    }
    

}