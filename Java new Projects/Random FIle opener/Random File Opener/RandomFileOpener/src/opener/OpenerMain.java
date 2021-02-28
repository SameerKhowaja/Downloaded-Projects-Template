/**
 * This program is exactly what its name suggest
 * just browse for a directory and run it
 * its gonna select a random file from the directory and open it for you
 * this works if you have a folder full of movies and you don't know which one to watch and etc...
 */


package opener;

import java.awt.BorderLayout;
import java.awt.Cursor;
import java.awt.Desktop;
import java.awt.Dimension;
import java.awt.EventQueue;
import java.awt.Toolkit;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JFileChooser;
import javax.swing.JMenuBar;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.UIManager;

import java.awt.FlowLayout;

import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

import javax.swing.JScrollPane;
import javax.swing.JTextArea;

import java.awt.Color;
import java.io.File;
import java.util.Random;
import javax.swing.ImageIcon;

@SuppressWarnings("serial")
public class OpenerMain extends JFrame {

	/**
	 * Variables here...
	 */
	private JPanel contentPane;
	private JTextField txtPath;
	private JFileChooser fileChooser;
	private JTextArea textArea;
	private JButton btnRunRandom;
	private File file;
	private OpenerWhatThisIsFor frmWhat = new OpenerWhatThisIsFor();

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					OpenerMain frame = new OpenerMain();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public OpenerMain() {
		setIconImage(Toolkit.getDefaultToolkit().getImage(OpenerMain.class.getResource("/res/icons.png")));
		System.out.println("Creating window");
		
		setToNimbus();		
		setTitle("Random File Opener");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 518, 411);
		
		JMenuBar menuBar = new JMenuBar();
		setJMenuBar(menuBar);
		
		JMenu mnHelp = new JMenu("Help");
		menuBar.add(mnHelp);
		
		JMenuItem mntmWhatsThisProgram = new JMenuItem("What's this program for?");
		mntmWhatsThisProgram.setIcon(new ImageIcon(OpenerMain.class.getResource("/res/background.png")));
		mntmWhatsThisProgram.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				frmWhat.setVisible(true);
			}
		});
		mnHelp.add(mntmWhatsThisProgram);
		
		JMenuItem mntmAbout = new JMenuItem("About");
		mntmAbout.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				textArea.setText("");
				textArea.append("Program Name: Random File Opener\nProgrammer: Rockette\nFreeware");
			}
		});
		mntmAbout.setIcon(new ImageIcon(OpenerMain.class.getResource("/res/edu_languages.png")));
		mnHelp.add(mntmAbout);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(new BorderLayout(0, 0));
		
		JPanel panelTop = new JPanel();
		contentPane.add(panelTop, BorderLayout.NORTH);
		panelTop.setLayout(new FlowLayout(FlowLayout.CENTER, 5, 5));
		
		JLabel lblPath = new JLabel("Path:");
		panelTop.add(lblPath);
		
		txtPath = new JTextField();
		txtPath.setEnabled(false);
		panelTop.add(txtPath);
		txtPath.setColumns(30);
		
		JButton btnBrowse = new JButton("Browse");
		btnBrowse.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent evt) {
				btnBrowseIsClicked();
			}
		});
		panelTop.add(btnBrowse);
		
		JPanel panelMid = new JPanel();
		contentPane.add(panelMid, BorderLayout.CENTER);
		panelMid.setLayout(new BorderLayout(0, 0));
		
		JScrollPane scrollPane = new JScrollPane();
		panelMid.add(scrollPane, BorderLayout.CENTER);
		
		textArea = new JTextArea();
		textArea.setForeground(Color.GREEN);
		textArea.setBackground(Color.BLACK);
		textArea.setEditable(false);
		scrollPane.setViewportView(textArea);
		
		JPanel panelBottom = new JPanel();
		contentPane.add(panelBottom, BorderLayout.SOUTH);
		panelBottom.setLayout(new FlowLayout(FlowLayout.CENTER, 5, 5));
		
		btnRunRandom = new JButton("Run Random!");
		btnRunRandom.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent evt) {
				btnRunRandomIsClicked();
			}
		});
		btnRunRandom.setEnabled(false);
		panelBottom.add(btnRunRandom);
		
		
		
		//initialize the file chooser object
		System.out.println("Initializing file chooser object");
		fileChooser = new JFileChooser("C:\\");
		fileChooser.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
		fileChooser.setDialogTitle("Select Directory...");
		
		
		setToCenterScreen();
		
		
		System.out.println("Launching");
	}
	
	
	
	/**
	 * ALL METHODS HERE!!!!!!!
	 */
	
	
	/*
	 * Set look and feel to nimbus
	 * because i like nimbus
	 */
	private void setToNimbus(){
		System.out.println("Doing nimbus");
		
			try{
				UIManager.setLookAndFeel("javax.swing.plaf.nimbus.NimbusLookAndFeel");
			}catch(Exception e){
				e.printStackTrace();
			}
	}
	
	
	
	/**
	 * Set the window to the center screen
	 * we wanna be the center of attention now, don't we?
	 */
	private void setToCenterScreen(){
		System.out.println("Setting window to center screen");
		
		Dimension dim = Toolkit.getDefaultToolkit().getScreenSize();
		int x = (int) ((dim.getWidth() - this.getWidth()) / 2);
		int y = (int) ((dim.getHeight() - this.getHeight()) / 2);
		this.setLocation(x, y);
	}
	
	
	
	/**
	 * What happens when you press browse???
	 */
	private void btnBrowseIsClicked(){
		
		if(fileChooser.showDialog(this, "Select Directory") == JFileChooser.APPROVE_OPTION){
			txtPath.setText(fileChooser.getSelectedFile().getPath());
			
			file = new File(txtPath.getText());
			textArea.append("You selected: " + txtPath.getText() + "\n");
			btnRunRandom.setEnabled(true);
			
		}else{
			textArea.append("Nothing selected...\n");
			btnRunRandom.setEnabled(false);
		}
		
	}
	
	
	/**
	 * what happens when you click Run Random?
	 */
	private void btnRunRandomIsClicked(){
			
		//get all files and directories from the selected folder.
		textArea.setText("");
		DirectoryRunner(file);
		
	}
	
	
	/**
	 * this method recurse the if it finds the selected item is directory
	 * its still buggy so i put some sorry messages
	 * i will update it though once i figured out how to solve it...
	 */
	private void DirectoryRunner(File Dir){
		setCursor(Cursor.getPredefinedCursor(Cursor.WAIT_CURSOR));
		
		try{
			//contain list of item in the directory into an array list
			File arrFileLIst[] = Dir.listFiles();		
			textArea.append("Found " + arrFileLIst.length + " items.\n");
			
				//evaluate if folder is empty
				//if yes, ask user to select another folder
				if(arrFileLIst.length == 0){
					textArea.append("This folder is empty, please select another one.\n");
					
				}else{
					//display the list into the text area
					for(int x = 0; x < arrFileLIst.length; x++){
						textArea.append(" =>" + arrFileLIst[x].getName() + " [" + arrFileLIst[x].getPath() + "]" + "\n");
					}
					
					//select a random item from the list
					Random random = new Random();
					int y = random.nextInt(arrFileLIst.length);
					
					//evaluate if the selected item is also a directory
					//if yes, recurse this method using that directory
					//else, ask persmission to open the selected file
					textArea.append("\nSelected item: " + arrFileLIst[y].getName() + "\n");
					textArea.append("Path: " + arrFileLIst[y].getPath() + "\n");
					
						if(arrFileLIst[y].isDirectory()){
							textArea.append("The selected item is also a directory, recursing method...\n\n");
							DirectoryRunner(arrFileLIst[y]);
						}else{
							
							if(askUser(arrFileLIst[y])){
								try{
									textArea.append("Opening file with default program associated to the extension, please wait.\n");
									Desktop.getDesktop().open(arrFileLIst[y]);
								}catch(Exception e){
									textArea.append("Sorry, cannot open the file.\n");
									textArea.append(e.getMessage());
								}
								
							}
							
						}
				}
		}catch(Exception e){
			textArea.append("Sorry, an error occured!\n");
			textArea.append(e.getMessage());
		}
		
		setCursor(Cursor.getDefaultCursor());
		
		
	}
	
	/**
	 * ask the user if he/she wants to open the file
	 */
	private boolean askUser(File TheFile){
		
		if(JOptionPane.showConfirmDialog(this, "Do you wanna open this? \n\nFile: " + TheFile.getName() + "\nPath: " + TheFile.getPath()
				,"Open File"
				,JOptionPane.YES_NO_OPTION) == JOptionPane.YES_OPTION){
			return true;
		}else{
			return false;
		}
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	

}
