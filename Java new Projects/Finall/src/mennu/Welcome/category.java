/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome;

import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;
import javax.swing.*;
import javax.swing.border.Border;
import login.login;
import mennu.Welcome.view.categoryExe;
import mennu.Welcome.view.progExtension;

public class category  extends JFrame{
    
          JLabel label,heading,JL_id,JL_catname;
          JTextField JT_categry,JT_id;
          
           String s,d, instruction;
            Statement st;
            ResultSet rs;
          JButton save,btn_first,btn_next,find,btn_previous,btn_last,view,btn_update,btn_delete;
          int pos = 0;       
          
          String cateid,categoryname;
         JFrame f6;
    //get the Connection With Mysql database
    public static Connection getConnection()      
    {
        Connection cn;
        try{
            cn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
            return cn;
        }catch(Exception ex){
            ex.printStackTrace();
        }
        return null;
    }


    // bind a list with ResultSet
    public static List<categoryExe> BindList(){
        try{
            Connection con = getConnection();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("select * from category");
            List<categoryExe> list = new ArrayList<categoryExe>();
            while(rs.next()){
                categoryExe u = new categoryExe((rs.getString("cateid").trim()),
                                     rs.getString("categoryname")
                                   
                        );
                     

                list.add(u);
                
            }
            return list;
           
        }catch(Exception ex){
            ex.printStackTrace();
        }
        return null;
    }
 
   //Showing the Users Info in jtexfields
    public void ShowPosInfo(int index){
        JT_id.setText((BindList().get(index).getCateid()));
        JT_categry.setText((BindList().get(index).getCategoryname()));
        JT_categry.setText((BindList().get(index).getCategoryname()));

        
      
    
    }


    // bind a list with ResultSet
    
    
    public category(){
        f6 = new JFrame("                            WELCOME TO CATEGORY PANEL");
    f6.setSize(700,450);
    f6.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    f6.setLocationRelativeTo(null);
    f6.setResizable(false);
    

  JPanel insertpanel=new JPanel();
   insertpanel.setLayout(null);

         insertpanel.setBackground(Color.WHITE);

     JMenuBar jmb = new JMenuBar();
     jmb.setBackground(Color.white);
      
    JMenu jmhome = new JMenu("Home");
        JMenuItem welcome = new JMenuItem("welcome");

    JMenuItem exit = new JMenuItem("Exit");
    jmhome.add(welcome);
    jmhome.add(exit);
    jmb.add(jmhome);
      jmhome.setForeground(Color.BLACK);

   JMenu jmStaff = new JMenu("AddStaff");
    JMenuItem addstaff = new JMenuItem("staff");
JMenuItem deptmnt = new JMenuItem("Department");
 
    jmStaff.add(addstaff);
    
    jmStaff.add(deptmnt);
    jmStaff.addSeparator();
    jmb.add(jmStaff); 
    
    
    JMenu jmStudent = new JMenu("Students");
    JMenuItem jmiaddstudent = new JMenuItem("StudentPanel");
     JMenuItem crse = new JMenuItem("Course");
       JMenuItem prog = new JMenuItem("Program");
    jmStudent.add(prog);
     jmStudent.add(crse) ;
    jmStudent.add(jmiaddstudent);
    jmb.add(jmStudent);

    JMenu jmItem = new JMenu("Items");
    JMenuItem jmiItem = new JMenuItem("Item");
     JMenuItem jmiStore = new JMenuItem("Stores");
     JMenuItem jmiType = new JMenuItem("ItemType");
     jmItem.add(jmiItem) ;
     jmItem.add(jmiStore) ;
     jmItem.add(jmiType);
    
    jmb.add(jmItem);
    
    JMenu jmOptions = new JMenu("Options");
    JMenu a = new JMenu("A");
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
     
 f6.setJMenuBar(jmb);
  f6. setVisible(true);
       
    
     label = new JLabel("<html>UGANDA MARTYRS UNIVERSITY NYAMITANGA CAMPUS <center>EQUIPMENT TRACKING SYSTEM</center></html>", SwingConstants.CENTER);
     //background header
  label.setBackground(Color.black);
  label.setOpaque(true);
  label.setForeground(Color.WHITE);
  //color for header
  label.setForeground(Color.lightGray);
  label.setFont(new Font("SELF", Font.BOLD,20));
     Border border = BorderFactory.createLineBorder(Color.WHITE);
  label.setVerticalAlignment(SwingConstants.TOP);
  label.setBorder(border);
  label.setVerticalAlignment(SwingConstants.TOP);
  label.setBorder(border);
       label.setBounds(0, 0, 700, 70);

         heading= new JLabel("<html>welcome to category panel</html>", SwingConstants.CENTER);
           heading.setForeground(Color.BLACK);
            heading.setBounds(30, 80, 550, 30);
                
    
     JL_id = new JLabel("Category Id:");
     JL_catname = new JLabel("Category Name:");
    
    JL_id.setBounds(170, 110, 100, 20);
     JL_catname.setBounds(170, 140, 100, 20);
    


     JT_categry = new JTextField(20);
     JT_id = new JTextField(20);
     
     JT_id.setBounds(350,110,150,20);
     JT_categry.setBounds(350,140,150,20);
     
     
     save = new JButton("Save");
     btn_first = new JButton("First");
     btn_next = new JButton("Next");
     btn_previous = new JButton("Previous");
     btn_last = new JButton("Last");
     find= new JButton("Find");
     btn_update = new JButton("Update");
     btn_delete = new JButton("Delete");
     
     
     
     save.setBounds(15, 350, 80, 30);
     btn_first.setBounds(100, 350, 80, 30);
     btn_next.setBounds(185, 350, 80, 30);
     btn_previous.setBounds(270, 350, 85, 30);
     btn_last.setBounds(360, 350, 80, 30);
    find.setBounds(450, 350, 80, 30);
     btn_update.setBounds(535, 350, 80, 30);
     btn_delete.setBounds(620, 350, 70, 30);  

        
        insertpanel.add(save);
        insertpanel.add(btn_last);
       insertpanel. add(btn_first);
        insertpanel.add(btn_previous);
       insertpanel. add(btn_next);
       insertpanel. add(find);
    insertpanel. add(btn_update);
     insertpanel.add(btn_delete);
     
 insertpanel.add(JL_id);
   insertpanel.add(JL_catname);
   
    insertpanel.add(JT_categry);
        insertpanel.add(JT_id);

    
     insertpanel. add(label);
         insertpanel.add(heading);
         
         f6.add(insertpanel);
         f6.setVisible(true);
      
     //button save
        save.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
            
            AddtoRecord();
        
               
         }
         
     }); 
      
         btn_update.addActionListener(new ActionListener(){
           @Override
         public void actionPerformed(ActionEvent e) {
            
         modify();   
        }
        
        }
        
        );
       
         
        //button delete
        btn_delete.addActionListener(new  ActionListener() {

         public void actionPerformed(ActionEvent e) {
         
try {
               Connection con;
                Class.forName("com.mysql.jdbc.Driver");
                con = DriverManager
                                .getConnection("jdbc:mysql://localhost:3306/equipment", "root", "");
          
        String sql="DELETE FROM category WHERE cateid='" + JT_id.getText().trim() + "'";
        st.executeUpdate(sql);
               
 JOptionPane.showConfirmDialog(null, "deleted",
                "Result", JOptionPane.DEFAULT_OPTION,
                JOptionPane.PLAIN_MESSAGE);

        }
          catch (Exception event) {
        System.out.println(event.toString());


        }
      

         }
     });
        
         exit.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Exit")) {
                System.exit(0);

                   
       }
         }
         
     }); 
        
  welcome.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("welcome")) {
                  new welcome();
                   f6.dispose();

                   
       }
         }
         
     });
        addstaff.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("staff")) {
                  new Staff();
                   f6.dispose();

                   
       }
         }
         
     });
        
               deptmnt.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Department")) {
                  new departments();
                  f6.dispose();
                   
       }
         }
         
     });
        

      jmiStore.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("stores")) {
                  new Stores();
                  f6.dispose();
                   
       }
         }
         
     }); 
     
      
      jmiItem.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("Item")) {
                  new Items();
                  f6.dispose();
       }
         }
         
     }); 
      
      
      
      prog.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("Program")) {
                  new Items();
                  f6.dispose();
       }
         }
         
     }); 
      
      
        jmiType.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("ItemType")) {
                  new ItemType();
                  f6.dispose();
       }
         }
         
     }); 
     jmiaddstudent.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("StudentPanel")) {
                  new Student();
                  f6.dispose();
       }
         }
         
     });
     
     crse.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Course")) {
                  new Course();
                  f6.dispose();
                   }
         }
         
     });
        log.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Logout")) {
                 new login();
                  f6.dispose();
                   }
         }
         
     });
        
     
       // Button to show the Next user from the List
        btn_next.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
               pos++;
               if(pos < BindList().size()){
                   ShowPosInfo(pos);
               }
               else{
                   pos = BindList().size() - 1;
                   ShowPosInfo(pos);
                   JOptionPane.showMessageDialog(null, "END");
               }
         }
         
     });

        
        // Button to show the First user from the List
        btn_first.addActionListener(new ActionListener(){
        
        @Override
        public void actionPerformed(ActionEvent e){
             pos = 0;
             ShowPosInfo(pos);
        }
        });
        



        // Button to show the Last user from the List
        btn_last.addActionListener(new ActionListener(){
        
        @Override
        public void actionPerformed(ActionEvent e){
           
            pos = BindList().size() - 1;
            ShowPosInfo(pos);
        }
        });
                


         //Button to show the Previous user from the List


btn_previous.addActionListener(new ActionListener(){
        
        @Override
        public void actionPerformed(ActionEvent e){
          
            pos--;
            if(pos > 0){
                ShowPosInfo(pos);                
            }
            else{
                pos = 0;
                ShowPosInfo(pos);
                JOptionPane.showMessageDialog(null, "END");
            }
        }
        });
    }
      private void AddtoRecord()
    {   
     
       
        try
        {
            categoryname = JT_categry.getText().trim();
      cateid=JT_id.getText().trim();
            
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(categoryname  +"" );
        
             instruction = "Insert into category (cateid,categoryname )" + "VALUES(?,?)";
            PreparedStatement preparedStatement = conn.prepareStatement(instruction);
            preparedStatement.setString(1, cateid );
            preparedStatement.setString(2, categoryname );

            preparedStatement.executeUpdate();
           
 JOptionPane.showConfirmDialog(null, "Your Data Has been Inserted",
                "Result", JOptionPane.DEFAULT_OPTION,
                JOptionPane.PLAIN_MESSAGE);

        st.close();
        conn.close();
        }
        catch(Exception e)
        {
            JOptionPane.showMessageDialog
        (null, "error" + e);
           
        }
        finally
        {
            cateid="";
            categoryname ="";
            
        }}
     private void modify()
    {   
        try
        {
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(categoryname  +"");
 // create a Statement from the connection
    String   sql1  ="update programs set progname = '"+JT_categry.getText()+"' where progId  = '" + JT_id.getText() + "'";

          st.executeUpdate(sql1);
JOptionPane.showConfirmDialog(null, "Your Data Has been updated",
                "Result", JOptionPane.DEFAULT_OPTION,
                JOptionPane.PLAIN_MESSAGE);          
        }
        catch(Exception e)
        {
                          JOptionPane.showMessageDialog(null,"error" + e);
        }
        
    }
      public static void main(String args[]){ 
           new category();
    }  
    
  }
  

