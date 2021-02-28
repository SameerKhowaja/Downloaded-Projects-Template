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
import mennu.Welcome.view.storesExe;
public class Stores  extends JFrame{

          JLabel label,heading,JL_storeid,JL_storename;
          JTextField JT_id,JT_Storename;
          
           String s,d, instruction;
            Statement st;
            ResultSet rs;
          JButton save,btn_first,btn_next,btn_previous,btn_last,find,view,btn_update,btn_delete;
          int pos = 0;       
          
          String storeid ,storename;
         
          JFrame f8;
    

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
    public static List<storesExe> BindList(){
        try{
            Connection con = getConnection();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("select * from store");
            List<storesExe> list = new ArrayList<storesExe>();
            while(rs.next()){
                storesExe u = new storesExe((rs.getString("storeid")),
                                     rs.getString("storename")
                                   
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
        
                JT_id.setText((BindList().get(index).getStoreid()));
        
        JT_Storename.setText(BindList().get(index).getStorename());
        
       
      
    
    }
    
    
    public Stores(){
        
      f8 = new JFrame("                            WELCOME TO STORES PANEL");
    f8.setSize(700,450);
    f8.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    f8.setLocationRelativeTo(null);
    f8.setResizable(false);
    

  JPanel insertpanel=new JPanel();
   insertpanel.setLayout(null);
JMenuBar jmb = new JMenuBar();
     jmb.setBackground(Color.white);
         insertpanel.setBackground(Color.WHITE);

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
     
 f8.setJMenuBar(jmb);
  f8. setVisible(true);
       
     
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

         heading= new JLabel("<html>welcome to Stores panel</html>", SwingConstants.CENTER);
           heading.setForeground(Color.BLACK);
            heading.setBounds(30, 80, 550, 30);
                
     JL_storeid = new JLabel("Store Id:");
     JL_storename = new JLabel("Store Nme:");
     
    
     
    JL_storeid.setBounds(170, 110, 100, 20);
     JL_storename.setBounds(170, 140, 100, 20);
    


     JT_id = new JTextField(20);
     JT_Storename = new JTextField(20);
     
     JT_id.setBounds(350,110,150,20);
     JT_Storename.setBounds(350, 140, 150, 20);
     
     
         
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
     
     insertpanel.add(JL_storeid );
   insertpanel.add(JL_storename);
   
    insertpanel.add(JT_id);
    insertpanel.add(JT_Storename);
     insertpanel. add(label);
         insertpanel.add(heading);
          f8.add(insertpanel);
         f8.setVisible(true);
         
       
        
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
          
        String sql="DELETE FROM store WHERE storeId='" + JT_id.getText() + "'";
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
                   f8.dispose();

                   
       }
         }
         
     });
        addstaff.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("staff")) {
                  new Staff();
                   f8.dispose();

                   
       }
         }
         
     });
        
               deptmnt.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Department")) {
                  new departments();
                  f8.dispose();
                   
       }
         }
         
     });
        
      
      jmiItem.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("Item")) {
                  new Items();
                  f8.dispose();
       }
         }
         
     }); 
      
        jmiType.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("ItemType")) {
                  new ItemType();
                  f8.dispose();
       }
         }
         
     }); 
        
        
        prog.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("Program")) {
                  new ItemType();
                  f8.dispose();
       }
         }
         
     }); 
        
        
     jmiaddstudent.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("StudentPanel")) {
                  new Student();
                  f8.dispose();
       }
         }
         
     });
     
     crse.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Course")) {
                  new Course();
                  f8.dispose();
                   }
         }
         
     });
        log.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Logout")) {
                 new login();
                  f8.dispose();
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
         storeid  = JT_id.getText().trim();
          storename= JT_Storename.getText().trim();
       
        try
        {
            
            
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(storeid  +""+ storename + " " );
        
             instruction = "Insert into store (storeid ,storename)" + "VALUES(?,?)";
            PreparedStatement preparedStatement = conn.prepareStatement(instruction);
            preparedStatement.setString(1, storeid );
            preparedStatement.setString(2, storename);
            
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
            storeid ="";
            storename = "";
            
        }
    }
    
    
    private void modify()
    {   
        try
        {
            
            
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(storeid  +""+ storename + " ");
 // create a Statement from the connection
    String   sql1  ="update store set storename = '"+JT_Storename.getText()+"' where storeId  = '" + JT_id.getText() + "'";

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
     public static void main(String args[]) {
        new Stores();
    }   
    
  }
  

