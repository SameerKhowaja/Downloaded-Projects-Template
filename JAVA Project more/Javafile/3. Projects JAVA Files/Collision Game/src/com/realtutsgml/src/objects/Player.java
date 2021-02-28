package com.realtutsgml.src.objects;

import java.awt.Graphics2D;
import java.awt.Image;
import java.awt.Rectangle;
import java.awt.event.KeyEvent;
import java.util.LinkedList;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import com.realtutsgml.src.GlobalPosition;
import com.realtutsgml.src.input.Controller;
import java.io.File;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;


public class Player extends GlobalPosition{
	
	private final String playerimage = "/images/player.png";
	private final LinkedList<Enemy> e = Controller.getEnemyBounds();
	
	int velX = 0;
	int velY = 0;
	
	public Player(int x, int y){
		super(x, y);
	}
	
	public void update(){
		x+=velX;
		y+=velY;
		
		if(x < 0){
			x = 0;
		}
		if(y < 0){
			y = 0;
		}
		if(x > 705){
			x = 705;
		}
		if(y > 545){
			y = 545;
		}
		
		Collision();
	}
	
	public void Collision(){
		for(int i = 0; i < e.size(); i++){
			if(getBounds().intersects(e.get(i).getBounds())){
                            playSound();
                            JOptionPane.showMessageDialog(null, "You collided the enemy block. \n Thanks For Playing...!", "Game Over!", JOptionPane.WARNING_MESSAGE);
                            System.exit(0);
			}
		}
	}
        
        public void playSound() {
        try {
            AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(new File("C:\\Users\\Sameer Khowaja\\Documents\\NetBeansProjects\\MainClass\\src\\images\\out.wav"));
            Clip clip = AudioSystem.getClip( );
            clip.open(audioInputStream);
            clip.start( );
        } catch(Exception e)  {}
    }
	
	public void keyPressed(KeyEvent e){
		int key = e.getKeyCode();
		
            switch (key) {
                case KeyEvent.VK_RIGHT:
                    velX = 2;
                    break;
                case KeyEvent.VK_LEFT:
                    velX = -2;
                    break;
                case KeyEvent.VK_DOWN:
                    velY = 2;
                    break;
                case KeyEvent.VK_UP:
                    velY = -2;
                    break;
                default:
                    break;
            }
		
	}
	
	public void keyReleased(KeyEvent e){
		int key = e.getKeyCode();
		
            switch (key) {
                case KeyEvent.VK_RIGHT:
                    velX = 0;
                    break;
                case KeyEvent.VK_LEFT:
                    velX = 0;
                    break;
                case KeyEvent.VK_DOWN:
                    velY = 0;
                    break;
                case KeyEvent.VK_UP:
                    velY = 0;
                    break;
                default:
                    break;
            }
	}
	
	public Rectangle getBounds(){
		return new Rectangle(x, y, 32, 32);
	}
	
	public void draw(Graphics2D g2d){
		g2d.drawImage(getPlayerImage(), x, y, null);
		g2d.draw(getBounds());
	}
	
	public Image getPlayerImage(){
		ImageIcon i = new ImageIcon(getClass().getResource(playerimage));
		return i.getImage();
	}

}
