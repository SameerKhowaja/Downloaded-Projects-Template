/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome.view;

import java.awt.Color;
import java.awt.Font;
import java.awt.event.*;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import javax.swing.*;
import javax.swing.border.Border;

public class Work extends JFrame{
 JLabel label,heading,usernam,JL_fname,JL_lname,JL_mail,JL_id,sx,tel,depart;
 JTextField JT_id,JT_fname,JT_lname,JT_email,JT_tel;
          JComboBox gender,jc, dept;
           String s,d;
            Statement st;
            ResultSet rs;
          JButton save,btn_first,btn_next,btn_previous,btn_last,view,btn_update,btn_delete;
          int pos = 0;
 String str1[] = { "Male", "Female" };
String staffId,username,fname, lname, email, sex,contact,dep;

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
    public static List<Staffextension> BindList(){
        try{
            Connection con = getConnection();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("select * from staff");
            List<Staffextension> list = new ArrayList<Staffextension>();
            while(rs.next()){
                Staffextension u = new Staffextension((rs.getString("staffId")),
                                     rs.getString("username"),
                                    rs.getString("fname"),
                                    rs.getString("lname"),
                                    rs.getString("email"),
                                 rs.getString("sex"),
                        
                            
               Integer.parseInt(rs.getString("contact")),
                 rs.getString("dep"),
                        rs.getString("status")
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
        JT_id.setText((BindList().get(index).getStaffId()));
        
        JT_fname.setText(BindList().get(index).getFname());
        
        JT_lname.setText(BindList().get(index).getLname());
        
        JT_email.setText(BindList().get(index).getEmail());
        JT_tel.setText(Integer.toString(BindList().get(index).getContact()));

    }
    

 public Work(){
     super("INSERT UPDATE DELETE");
     
      try{
         Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
   
              s= "select * FROM users";
             
      
   rs=st.executeQuery(s);
     
   while(rs.next())
   {
    jc =new JComboBox();
    jc.addItem(rs.getString(2));
   }
    }catch (Exception e){
 JOptionPane.showMessageDialog(null,"ERROR" + e);
    
    }
    try{
                  d= "select * FROM dept";
             
      
   rs=st.executeQuery(d);
     
   while(rs.next())
   {
    dept=new JComboBox();
   dept.addItem(rs.getString(1));
   }
           
        }catch(Exception e){
           
        }
    JMenuBar jmb = new JMenuBar();
     jmb.setBackground(Color.white);
      
    JMenu jmhome = new JMenu("Home");

    JMenuItem jmiwelcome = new JMenuItem("welcome");
    
    jmhome.add(jmiwelcome);
    jmb.add(jmhome);
      jmhome.setForeground(Color.BLACK);
      
    JMenu jmStaff = new JMenu("AddStaff");
    JMenuItem jmiOpen = new JMenuItem("staff");
    JMenuItem jmiClose = new JMenuItem("view");
 
    jmStaff.add(jmiOpen);
    jmStaff.add(jmiClose);
    jmStaff.addSeparator();
    jmb.add(jmStaff);
    
    
    JMenu jmStudent = new JMenu("Students");
    jmb.add(jmStudent);

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

      JMenu fileMenu = new JMenu("Logout");
     jmb.add(fileMenu);
     setJMenuBar(jmb);
    setVisible(true);

    
     label = new JLabel("<html>UGANDA MARTYRS UNIVERSITY NYAMITANGA CAMPUS <center>EQUIPMENT TRACKING SYSTEM</center></html>", SwingConstants.CENTER);
     //background header
  label.setBackground(Color.black);
  label.setOpaque(true);
  label.setForeground(Color.WHITE);
  //color for header
  label.setForeground(Color.lightGray);
  label.setFont(new Font("SELF", Font.BOLD,15));
     Border border = BorderFactory.createLineBorder(Color.WHITE);
  label.setVerticalAlignment(SwingConstants.TOP);
  label.setBorder(border);
  
  
  heading= new JLabel("<html>welcome to staff panel</html>", SwingConstants.CENTER);
  
  heading.setForeground(Color.WHITE);
  label.setVerticalAlignment(SwingConstants.TOP);
  label.setBorder(border);
  
     JL_id = new JLabel("Id:");
     usernam = new JLabel("Username:");
     JL_fname = new JLabel("Fname:");
     JL_lname = new JLabel("Lname:");
     JL_mail = new JLabel("Email:");
     sx = new JLabel("Sex:");
    tel = new JLabel("TelNo:");
    depart = new JLabel("Department:");
     label.setBounds(0, 0, 500, 70);
    
     heading.setBounds(20, 80, 500, 20);
     
     JL_id.setBounds(20, 110, 100, 20);
     usernam.setBounds(20, 140, 100, 20);
     JL_fname.setBounds(20, 170, 100, 20);
     JL_lname.setBounds(20, 200, 100, 20);
     JL_mail.setBounds(20, 230, 100, 20);
      sx.setBounds(20, 260, 100, 20);
      tel.setBounds(20, 290, 100, 20);
      depart.setBounds(20, 320, 100, 20);


     JT_id = new JTextField(20);
     JT_fname = new JTextField(20);
     JT_lname = new JTextField(20);
     JT_email = new JTextField(20);
     JT_tel = new JTextField(20);
      //combobox
        gender = new JComboBox(str1);
       
     JT_id.setBounds(130,110,150,20);
     jc.setBounds(130,140,150,20);
     JT_fname.setBounds(130, 170, 150, 20);
     JT_lname.setBounds(130, 200, 150, 20);
     JT_email.setBounds(130, 230, 150, 20);
     gender.setBounds(130, 260, 150, 20);
     JT_tel.setBounds(130, 290, 150, 20);
     dept.setBounds(130, 320, 150, 20);

      save = new JButton("Save");
     btn_first = new JButton("First");
     btn_next = new JButton("Next");
     btn_previous = new JButton("Previous");
     btn_last = new JButton("Last");
     view= new JButton("View");
     btn_update = new JButton("Update");
     btn_delete = new JButton("Delete");
     
    save.setBounds(300, 110, 80, 20);
     btn_first.setBounds(300, 140, 80, 20);
     btn_next.setBounds(300, 170, 80, 20);
     btn_previous.setBounds(300, 200, 80, 20);
     btn_last.setBounds(300, 230, 80, 20);
    view.setBounds(300, 260, 80, 20);
      //button save
     btn_update.setBounds(300, 290, 80, 20);
     btn_delete.setBounds(300, 320, 80, 20);
     
     
     setLayout(null);
      ShowPosInfo(pos);
     add(label);
         add(heading);
         add(JL_id);
          add(usernam);
        add(JL_fname);
        add(JL_lname);
        add(JL_mail);
        add(sx);
         add(tel);
        add(depart);
        
     
     add(gender);
        add(JT_id);
        add(jc);
        add(JT_fname);
        add(JT_lname);
        add(JT_email);
        add(JT_tel);
        add(dept);
     
     
     add(save);
        add(btn_last);
        add(btn_first);
        add(btn_previous);
        add(btn_next);
        add(view);
     add(btn_update);
     add(btn_delete);
     
      //button save
        save.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
              
               if(e.getSource() == save)
        {
            AddtoRecord();
        }
               
         }
         
     });
     
  
    //button delete
        btn_delete.addActionListener(new  ActionListener() {

         public void actionPerformed(ActionEvent e) {
         try{
          
             theQuery("delete from staff where staffId = ?"+JT_id.getText());
         }
         catch(Exception ex){}
         }
     });
        
     setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
     setVisible(true);
     setLocationRelativeTo(null);
     setSize(500,400);
 }
     
   private void AddtoRecord()
    {   
         staffId = JT_id.getText().trim();
     username = jc.getSelectedItem().toString();
        fname = JT_fname.getText().trim();
        lname = JT_lname.getText();
         email = JT_email.getText();
         sex =gender.getSelectedItem().toString();
         contact=  JT_tel.getText();
         dep= dept.getSelectedItem().toString();
        try
        {
            
            
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(staffId +""+ username + " " + fname + " " + lname);

            String instruction = "Insert into staff (staffId,username,fname, lname, email,sex,contact,dep)" + "VALUES(?,?,?,?,?,?,?,?)";
            PreparedStatement preparedStatement = conn.prepareStatement(instruction);
            preparedStatement.setString(1, staffId);
            preparedStatement.setString(2, username);
            preparedStatement.setString(3, fname);
            preparedStatement.setString(4, lname);
            preparedStatement.setString(5, email);
            preparedStatement.setString(6, sex);
             preparedStatement.setString(7, contact);
              preparedStatement.setString(8, dep);
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
        (null, "data has not been saved, please check your  Id if it doesn't exist","Access Error",
                JOptionPane.ERROR_MESSAGE);
           
        }
        finally
        {
            staffId="";
            username = "";
            fname = "";
            lname = "";
             email = "";
              sex = "";
              contact="";
              dep="";
        }

   
    } 
    
    
 //function to execute the insert update delete query
  public void theQuery(String query){
      Connection con = null;
      Statement st = null;
      try{
          con = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
          st = con.createStatement();
          st.executeUpdate(query);
          JOptionPane.showMessageDialog(null,"Query Executed");
      }catch(Exception ex){
          JOptionPane.showMessageDialog(null,ex.getMessage());
      }
  }
    
     public static void main(String[] args){
     
         new  Work();
     }
}
      

