
package mennu.Welcome;


import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.BorderFactory;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;

import javax.swing.SwingConstants;
import javax.swing.border.Border;
import login.login;


public  class welcome extends JFrame implements ActionListener {

    static void addActionListener(ActionListener actionListener) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    JLabel  label,label1;
    JFrame f;

   
 
public welcome() {
   
     f = new JFrame("WELCOME TO ADMIN PANEL");
    f.setSize(700,450);
    f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    f.setLocationRelativeTo(null);
    f.setResizable(false);

  JPanel insertpanel=new JPanel();
  
   label = new JLabel("<html>Welcome To Admin panel</html>", SwingConstants.CENTER);
 
        
  label1 = new JLabel("<html>UGANDA MARTYRS UNIVERSITY NYAMITANGA CAMPUS <center>EQUIPMENT TRACKING SYSTEM</center></html>", SwingConstants.CENTER);
 Border border = BorderFactory.createLineBorder(Color.BLACK);
  label1.setVerticalAlignment(SwingConstants.TOP);
  label1.setBorder(BorderFactory.createLineBorder(Color.darkGray));
  label1.setBorder(border);
  
 insertpanel.setBackground(Color.WHITE);
 
 
  
 //color for header
  label1.setForeground(Color.lightGray);
  label1.setFont(new Font("SELF", Font.BOLD,15));
  
  //background header
  label1.setBackground(Color.black);
  
   label1.setOpaque(true);
   
    label.setForeground(Color.BLACK);
  label.setFont(new Font("SELF", Font.BOLD,15));
  
  
 insertpanel.setLayout(null);
 
  //positioning header
 label1.setBounds(0,0, 700, 80);
label.setBounds(100,100,200,30);
 


  insertpanel.add(label);
  
  //end
  
 insertpanel.add(label1);
 
 f.add(insertpanel);
 f.setVisible(true);
  
        
   JMenuBar jmb = new JMenuBar();
     jmb.setBackground(Color.white);
      
    JMenu jmhome = new JMenu("Home");
    JMenuItem jmiwelcome = new JMenuItem("Exit");
    jmhome.add(jmiwelcome);
    jmb.add(jmhome);
      jmhome.setForeground(Color.BLACK);

   JMenu jmStaff = new JMenu("AddStaff");
    JMenuItem addstaff = new JMenuItem("staff");
    JMenuItem dept = new JMenuItem("Department");
 
    jmStaff.add(addstaff);
    
    jmStaff.add(dept);
    jmStaff.addSeparator();
    jmb.add(jmStaff);
    
    
    JMenu jmStudent = new JMenu("Students");
    JMenuItem jmiaddstudent = new JMenuItem("StudentPanel");
     JMenuItem crse = new JMenuItem("Course");
      JMenuItem prog = new JMenuItem("Program");
     jmStudent.add(crse) ;
    jmStudent.add(jmiaddstudent);
    jmStudent.add(prog);
    jmb.add(jmStudent);
    
    JMenu jmItem = new JMenu("Items");
    JMenuItem jmiItem = new JMenuItem("Item");
     JMenuItem jmiStore = new JMenuItem("Stores");
     JMenuItem jmiType = new JMenuItem("ItemType");
     
     jmItem.add(jmiItem) ;
     jmItem.add(jmiStore) ;
     jmItem.add(jmiType);
    
    jmb.add(jmItem);

    JMenu jmOptions = new JMenu("Menu");
    JMenu a = new JMenu("Item");
    JMenuItem b = new JMenuItem("B");
    JMenuItem c = new JMenuItem("C");
    JMenuItem d = new JMenuItem("D");
    a.add(b);
    a.add(c);
    a.add(d);
    jmOptions.add(a);

    JMenu e = new JMenu("E");
    e.add(new JMenuItem("F"));
    e.add(new JMenuItem("G"));
    jmOptions.add(e);

    jmb.add(jmOptions);

    JMenu jmHelp = new JMenu("Help");
    JMenuItem jmiAbout = new JMenuItem("About");
    jmHelp.add(jmiAbout);
    jmb.add(jmHelp);
    
    // construct a File menu
    jmHelp.add(jmiAbout);
    jmb.add(jmHelp);
    

      
      JMenu logT = new JMenu("Logout");
      JMenuItem log = new JMenuItem("Logout");
      logT.add(log);
      jmb.add(logT);
      jmiwelcome.addActionListener(this);
     
     jmiaddstudent.addActionListener(this);
     crse.addActionListener(this);
    log.addActionListener(this);
   prog.addActionListener(this);
    addstaff.addActionListener(this);
    dept.addActionListener(this);
    jmiStore.addActionListener(this) ;
     jmiType.addActionListener(this);
    
    jmiItem.addActionListener(this);
    b.addActionListener(this);
    c.addActionListener(this);
    d.addActionListener(this);
    jmiAbout.addActionListener(this);
    
    f.setJMenuBar(jmb);
    f.setVisible(true);

    

}

 
    @Override
    public void actionPerformed(ActionEvent e) {
      if (e.getActionCommand().equals("staff")) {
      new Staff();
      f.setVisible(false);
      
      }
    
     else  if (e.getActionCommand().equals("StudentPanel")) {
          new Student();
          f.setVisible(false);
       }
     
     else
      if (e.getActionCommand().equals("Exit")) {
         System.exit(0);
    }
      else if(e.getActionCommand().equals("Logout")){
          new login();
          f.setVisible(false);
      }
      else if (e.getActionCommand().equals("Course")){
           new Course();
           f.setVisible(false);
      }
       else if (e.getActionCommand().equals("Department")){
           new departments();
           f.setVisible(false);
    }
         else if (e.getActionCommand().equals("Program")){
           new Programs();
           f.setVisible(false);
    }
 else if (e.getActionCommand().equals("Item")){
           new Items();
           f.setVisible(false);
    }
       else if (e.getActionCommand().equals("Stores")){
           new Stores();
           f.setVisible(false);
    }
       
    else if (e.getActionCommand().equals("ItemType")){
           new ItemType();
           f.setVisible(false);
    }
}}