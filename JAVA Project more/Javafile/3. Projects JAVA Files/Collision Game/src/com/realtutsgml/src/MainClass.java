package com.realtutsgml.src;

import javax.swing.JFrame;

public class MainClass {

	public static final int WIDTH = 745, HEIGHT = 605;
	public static final String TITLE = "(COLLISION GAME)   Made By SAMEER KHOWAJA";
	
	public static void main(String args[]) {
		
		JFrame frame = new JFrame(TITLE);
		frame.pack();
		frame.setSize(WIDTH,HEIGHT);
		frame.setResizable(false);
		frame.setLocationRelativeTo(null);
		frame.add(new Game());
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setVisible(true);

	}

}
