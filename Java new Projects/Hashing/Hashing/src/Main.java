/*
 * Hashing & Salting using MD5 and SHA-1
 * 
 * Developed by Ny Aina Erick RANDRIANJAFY
 * (c) 06/04/2015
 * Java SE
 * 
 * e-mail : ainaerik@gmail.com
 * 
 */


import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Main extends JFrame {

	private static final long serialVersionUID = 1L;

	public Main() {
		super("Hashing & Salting : MD5-SHA1");
		init();
	}
	
	private void init() {
		setSize(500,220);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setLocationRelativeTo(null);
		setResizable(false);
		setVisible(true);
		build();
	}
	
	private void build() {
		setLayout(new GridLayout(6,1,5,5));
		
		Font police = new Font("Tahoma", 9, 14);
		
		Color fontColor = new Color(147,142,142);
		Color backGround = new Color(35,34,34);
		Color backTxt = new Color(75,75,75);
		
		getContentPane().setBackground(backGround);
	
		JLabel welc = new JLabel("Hashing & Salting : MD5-SHA1", JLabel.CENTER);
		JLabel lblPass = new JLabel("Enter your password : ", JLabel.CENTER);
		
		welc.setForeground(fontColor);
		welc.setFont(police);
		lblPass.setForeground(fontColor);
		
		JTextField txtPass = new JTextField(15);
		JButton btnHash = new JButton("Hash");
		
		btnHash.setForeground(fontColor);
		btnHash.setBackground(backTxt);
		txtPass.setForeground(fontColor);
		txtPass.setBackground(backTxt);
		
		JLabel lblMD5 = new JLabel("", JLabel.CENTER);
		JLabel lblSHA1 = new JLabel("", JLabel.CENTER);
		
		Color blu = new Color(0,150,252);
		Color gree = new Color(101,153,21);
		
		lblMD5.setForeground(blu);
		lblSHA1.setForeground(gree);
		
		add(welc);
		add(lblPass);
		add(txtPass);
		add(btnHash);
		add(lblMD5);
		add(lblSHA1);
		
		btnHash.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String mdp = txtPass.getText();
				
				if(!mdp.isEmpty()) {
					if(mdp.length()<5){
						JOptionPane.showMessageDialog(null, "Too short password","Error", JOptionPane.ERROR_MESSAGE);
						lblMD5.setText("");
						lblSHA1.setText("");
					}else{
						
						String salt = "5bd8f95467hk32s7s699lt84";
						
						String md5 = Hash.md5(txtPass.getText()+salt);
						String sha1 = Hash.sha1(txtPass.getText()+salt);
						
						lblMD5.setText("MD5 : " + md5);
						lblSHA1.setText("SHA-1 : " + sha1);
					}
					
				}else{
					JOptionPane.showMessageDialog(null, "Input your password","Error", JOptionPane.ERROR_MESSAGE);
					lblMD5.setText("");
					lblSHA1.setText("");
				}
				
			}
			
		});
		
		
	}
	
	public static void main(String [] args) {
		
		try{
			//UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
		}catch(Exception ex){}
		
		EventQueue.invokeLater(new Runnable(){
			public void run() {
				new Main();
			}
		});
		
	}
}


