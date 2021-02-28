/*
 * ClipBoard 
 * 
 * Developed by Ny Aina Erick RANDRIANJAFY
 * (c) 02/04/2015
 * Java SE
 * 
 * e-mail : ainaerik@gmail.com
 * 
 */


import java.awt.datatransfer.Clipboard;
import java.awt.datatransfer.ClipboardOwner;
import java.awt.datatransfer.StringSelection;
import java.awt.datatransfer.Transferable;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class ClipBoard extends JFrame implements ClipboardOwner {
	private static final long serialVersionUID = 1L;
	
	public ClipBoard(){
		super("ClipBoard");
		setSize(300,100);
		setLocationRelativeTo(null);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setResizable(false);
		setVisible(true);
		init();
	}
	private void init() {
		setLayout(new FlowLayout());
		
		JTextField txt = new JTextField(15);
		JButton btnCopy = new JButton("Copy to Clipboard");
		
		add(txt);
		add(btnCopy);
		
		btnCopy.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				copyToClipboard(txt.getText());
			}
		});
	}
	
	private void copyToClipboard(String str) {
		StringSelection strSelection = new StringSelection(str);
		Clipboard clipboard = Toolkit.getDefaultToolkit().getSystemClipboard();
		clipboard.setContents(strSelection, this);
		JOptionPane.showMessageDialog(this, "Copied to clipboard");
	}
	
	public static void main(String [] args) {
		EventQueue.invokeLater(new Runnable(){
			public void run(){
				new ClipBoard();
			}
		});
	}

	@Override
	public void lostOwnership(Clipboard arg0, Transferable arg1) {
		// TODO Auto-generated method stub
		
	}

}
