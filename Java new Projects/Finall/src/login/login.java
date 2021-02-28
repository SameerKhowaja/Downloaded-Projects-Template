
package login;
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.BorderFactory;
import javax.swing.JButton;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import mennu.Welcome.welcome;

import javax.swing.JTextField;
import javax.swing.SwingConstants;
import javax.swing.border.Border;
import mennu.Welcome.StudentsPanel;
 
public  class login extends JFrame implements ActionListener {
    //declare instance variables
    JFrame f;
     Connection conn;
      private String username, password;
    JTextField empidtext;
    JPasswordField empnametext;
    JButton reset, insertsubmit,exit;
     JLabel empidlabel, empnamelabel;
     ResultSet rset;
     
     
     
     
 
public  login() {
      
     f = new JFrame("login");
    f.setSize(500,300);
    f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    f.setLocationRelativeTo(null);
    f.setResizable(false);
  JPanel insertpanel=new JPanel();

 JLabel label1 = new JLabel("<html>UGANDA MARTYRS UNIVERSITY NYAMITANGA CAMPUS <center>EQUIPMENT TRACKING SYSTEM</center></html>", SwingConstants.CENTER);
Border border = BorderFactory.createLineBorder(Color.BLACK);
  label1.setVerticalAlignment(SwingConstants.TOP);
  label1.setBorder(BorderFactory.createLineBorder(Color.darkGray));
  label1.setBorder(border);
 
  
 empidlabel=new JLabel("Username");
 empidtext=new JTextField(20);
 
empnamelabel=new JLabel("Password");
 empnametext=new  JPasswordField(20);
 empnametext.setEchoChar('*');

 //buttons
  insertsubmit=new JButton("Login");
 reset=new JButton("Reset");
  exit = new JButton("Exit");
  
 //background color for a panel
 insertpanel.setBackground(Color.WHITE);
 //end
 empidlabel.setFont(new Font("self", Font.BOLD,15));
 empidlabel.setForeground(Color.black);
 
 empnamelabel.setForeground(Color.black);
 empnamelabel.setFont(new Font("self", Font.BOLD,15));
 
 //color for header
  label1.setForeground(Color.lightGray);
  label1.setFont(new Font("SELF", Font.BOLD,15));
  
  //background header
  label1.setBackground(Color.black);
  
   label1.setOpaque(true);
   
   
 insertpanel.setLayout(null);
 
        insertpanel.add(exit);

        
 //positioning image header
 //label.setBounds(100, 2, 50, 100);
 
  //positioning header
 label1.setBounds(0,0, 500, 70);
 //positioning username
 empidlabel.setBounds(100, 100, 100, 20);
 empidtext.setBounds(200, 100, 200, 30);
 //positioning password
 empnamelabel.setBounds(100, 150, 100, 30);
 empnametext.setBounds(200, 150, 200, 30);
 //postioning buttons
 insertsubmit.setBounds(140, 200, 80, 30);
  reset.setBounds(225, 200, 80, 30);
  exit.setBounds(310, 200, 80, 30);
  
 //adding image to a panel
  //insertpanel.add(label);
  
  //end
  
 insertpanel.add(label1);
 
 insertpanel.add(empidlabel);
 insertpanel.add(empidtext);
 
 insertpanel.add(empnamelabel);
 insertpanel.add(empnametext);
 
 
 insertpanel.add(insertsubmit);
 insertpanel.add(reset);
 
 
 f.add(insertpanel);
 f.setVisible(true);
  
    
    empidtext.addActionListener(this);
    empnametext.addActionListener(this);
     insertsubmit.addActionListener(this);
    
     reset.addActionListener(this);
   exit.addActionListener(this);

}

public void init_connection(){
        //open connection to database
    try
    {conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/equipment", "root", "");
    } catch(SQLException ex) { System.err.println(ex); }
}

 @Override
    public void actionPerformed(ActionEvent e) {
     // TODO Auto-generated method stub
        username = empidtext.getText();
        password = new String( empnametext.getPassword());
      
       if(e.getSource() == insertsubmit)
        {
             checkforLogin();
     
            //
        }
       else if(e.getSource() ==  reset)
        {
empidtext.setText("");
 empnametext.setText("");
        }
       else if(e.getSource()==exit){
               
                System.exit(0);
       }
            }
 
    private void checkforLogin()
    {
        try
        {
            String instr = "SELECT *FROM users WHERE username = ? AND password = ?";
            PreparedStatement ps = conn.prepareStatement(instr);
            ps.setString(1, username);
            ps.setString(2, password);
           //ps.setString(2, role);
            System.out.println(username + " " + password);
            rset = ps.executeQuery();
           
            if(!rset.next())
                JOptionPane.showMessageDialog
        (f, "Incorrect username or password, please try again","Access Error",
                JOptionPane.ERROR_MESSAGE);
            else 
                if(rset.getString("role").equals("Admin"))
                        welcome();
                else
                  StudentsPanel();

        }catch(Exception e) { System.err.println("checking for login "+ e);}
    }
private void welcome() throws SQLException
    {
        
        rset.close();
        //close previous gui db connection
        conn.close();
        new welcome();
        f.dispose();
   
       
    
    }
private void StudentsPanel() throws SQLException
    {
      conn.close();
        f.dispose();
      new StudentsPanel();
        
    }
}