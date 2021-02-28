import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionListener;
import javax.swing.JComponent;
import javax.swing.JFrame;
import javax.swing.Timer;
import javax.swing.WindowConstants;

public class RedBall extends JComponent implements ActionListener, MouseMotionListener {

    private int ballx = 150;
    private int bally = 30;
    private int paddlex = 0;
    private int ballySpeed = 7;
    private int ballxSpeed = 5;
    public int score = 0;
    public int score1 = 0;
    private int scorefinal;
    public int bestscore;
    public int bestscore1;
    public boolean gameOver, started;

    public static void main(String[] args) {
        JFrame wind = new JFrame("RedBall Made By SAMEER KHOWAJA");
        RedBall g = new RedBall();
        wind.add(g);
        wind.pack();
        wind.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        wind.setLocationRelativeTo(null);
        wind.setVisible(true);
        wind.addMouseMotionListener(g);

        Timer tt = new Timer(17, g);
        tt.start();
    }
    
    @Override
    public Dimension getPreferredSize() {
        return new Dimension(800, 600);
    }

    @Override
    protected void paintComponent(Graphics g) {

        //draw the sky
        g.setColor(Color.cyan);
        g.fillRect(0, 0, 800, 600);

        //draw the ground
        g.setColor(Color.GREEN);
        g.fillRect(0, 550, 800, 100);

        //draw the paddel
        g.setColor(Color.black);
        g.fillRect(paddlex, 525, 100, 20);

        //draw the ball
        g.setColor(Color.RED);
        g.fillOval(ballx, bally, 30, 30);

        //score	
        if(score >= 100) {
            g.setColor(Color.red);
            g.setFont(new Font("Arial", 8, 50));
            g.drawString(String.valueOf(score + score1), 30 / 1 - 15, 80);
        }else{
            g.setColor(Color.magenta);
            g.setFont(new Font("Arial", 8, 50));
            g.drawString(String.valueOf(score), 30 / 1 - 15, 80);
        }
        
        // start && gameOver
        g.setColor(Color.green);
        g.setFont(new Font("Arial", 8, 50));

        if (gameOver) {
            g.drawString(String.valueOf(" Your Score :" + scorefinal), 50 / 1 - 15, 200);
        }
    }

    @Override
    public void actionPerformed(ActionEvent e) {

        ballx = ballx + ballxSpeed;
        bally = bally + ballySpeed;

        // Window Down 
        if (ballx >= paddlex && ballx <= paddlex + 100 && bally >= 495) {
            ballySpeed = -8;
            score += 2;
            gameOver = false;
        }

        if (bally >= 600) {
            score = 0;
            bally = 30;
            gameOver = true;
        }

        // Window up
        if (bally <= 0) {
            ballySpeed = 8;
        }

        // Window right
        if (ballx >= 775) {
            ballxSpeed = -6;
        }

        // Window left
        if (ballx <= 0) {
            ballxSpeed = 7;
        }

        //**********************************************************************
        bestscore = score;
        bestscore1 = score1;

        if(scorefinal > bestscore){
        } else {
            scorefinal = score + score1;
        }
        
        if(scorefinal > bestscore){
        } else {
            scorefinal = score + score1;
        }
        
        repaint();
    }

    @Override
    public void mouseMoved(MouseEvent e) {

        paddlex = e.getX() - 50;
        repaint();
    }

    @Override
    public void mouseDragged(MouseEvent e) {}

}