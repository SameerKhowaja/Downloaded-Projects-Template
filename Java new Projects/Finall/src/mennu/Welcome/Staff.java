 
package mennu.Welcome;
import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import javax.swing.BorderFactory;
import javax.swing.JButton;
import javax.swing.JComboBox;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.SwingConstants;
import javax.swing.border.Border;

import login.login;
import mennu.Welcome.view.Staffextension;


public  class Staff extends JFrame {
          JLabel label,heading,usernam,JL_fname,JL_lname,JL_mail,JL_id,sx,tel,depart,state;
          JTextField JT_id,JT_fname,JT_lname,JT_email,JT_tel;
          JComboBox gender,usernameJC, dept,states;
           String s,d, instruction;
            Statement st;
            ResultSet rs;
          JButton save,btn_first,btn_next,btn_previous,btn_last,find,btn_update,btn_delete;
          int pos = 0;
 String str1[] = {"select gender", "Male", "Female" };
 String str2[] = {"select status", "active", "disabled" };
String staffId,username,fname, lname, email, sex,contact,dep,status;
          
          
          
  
    JFrame f;

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
   public  void ShowPosInfo(int index){
        
 JT_id.setText((BindList().get(index).getStaffId()));
        
        JT_fname.setText(BindList().get(index).getFname());
        
        JT_lname.setText(BindList().get(index).getLname());
        
        JT_email.setText(BindList().get(index).getEmail());
        JT_tel.setText(Integer.toString(BindList().get(index).getContact()));
    }
 
public Staff() {
   
     f = new JFrame("                            WELCOME TO STAFF PANEL");
    f.setSize(700,500);
    f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    f.setLocationRelativeTo(null);
    f.setResizable(false);
    

  JPanel insertpanel=new JPanel();
   insertpanel.setLayout(null);

         insertpanel.setBackground(Color.WHITE);

    
      try{
         Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
   
              s= "select * FROM users";
             
      
   rs=st.executeQuery(s);
      usernameJC =new JComboBox();
      usernameJC.addItem("");
   while(rs.next())
   {
    usernameJC.addItem(rs.getString("username"));
   }
    }catch (Exception e){
 JOptionPane.showMessageDialog(null,"ERROR" + e);
    
    }
    try{
                  d= "select * FROM dept";
               dept=new JComboBox();
               dept.addItem("");
      
   rs=st.executeQuery(d);
     
   while(rs.next())
   {
  
   dept.addItem(rs.getString(1));
   }
           
        }catch(Exception e){
           
        }
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
     
 f.setJMenuBar(jmb);
  f. setVisible(true);
    

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
  
  
  heading= new JLabel("<html>welcome to staff panel</html>", SwingConstants.CENTER);
  
  heading.setForeground(Color.black);
  label.setVerticalAlignment(SwingConstants.TOP);
  label.setBorder(border);
    
     JL_id = new JLabel("StaffNo:");
     usernam = new JLabel("Username:");
     JL_fname = new JLabel("Fname:");
     JL_lname = new JLabel("Lname:");
     JL_mail = new JLabel("Email:");
     sx = new JLabel("Sex:");
    tel = new JLabel("TelNo:");
    depart = new JLabel("Department:");
    state = new JLabel("Status:");
     label.setBounds(0, 0, 700, 70);
    
     heading.setBounds(30, 80, 550, 30);
     
     JL_id.setBounds(170, 110, 100, 25);
     usernam.setBounds(170, 140, 100, 25);
     JL_fname.setBounds(170, 170, 100, 25);
     JL_lname.setBounds(170, 200, 100, 25);
     JL_mail.setBounds(170, 230, 100, 25);
      sx.setBounds(170, 260, 100, 25);
      tel.setBounds(170, 290, 100, 25);
      depart.setBounds(170, 320, 100, 25);
      state.setBounds(170, 350, 100, 25);


     JT_id = new JTextField(20);
     JT_fname = new JTextField(20);
     JT_lname = new JTextField(20);
     JT_email = new JTextField(20);
     JT_tel = new JTextField(20);
     
      //comboboxd
        gender = new JComboBox(str1);
        states = new JComboBox(str2);
        
     JT_id.setBounds(350,110,150,20);
     usernameJC.setBounds(350,140,150,20);
     JT_fname.setBounds(350, 170, 150, 20);
     JT_lname.setBounds(350, 200, 150, 20);
     JT_email.setBounds(350, 230, 150, 20);
     gender.setBounds(350, 260, 150, 20);
     JT_tel.setBounds(350, 290, 150, 20);
     dept.setBounds(350, 320, 150, 20);
     states.setBounds(350, 350, 150, 20);
     
     save = new JButton("Save");
     btn_first = new JButton("First");
     btn_next = new JButton("Next");
     btn_previous = new JButton("Previous");
     btn_last = new JButton("Last");
     find= new JButton("Find");
     btn_update = new JButton("Update");
     btn_delete = new JButton("Delete");
     
     
     save.setBounds(15, 400, 80, 30);
     btn_first.setBounds(100, 400, 80, 30);
     btn_next.setBounds(185, 400, 80, 30);
     btn_previous.setBounds(270, 400, 85, 30);
     btn_last.setBounds(360, 400, 80, 30);
    find.setBounds(450, 400, 80, 30);
     btn_update.setBounds(535, 400, 80, 30);
     btn_delete.setBounds(620, 400, 70, 30);  

//ShowPosInfo(pos);
        
        insertpanel.add(save);
        insertpanel.add(btn_last);
       insertpanel. add(btn_first);
        insertpanel.add(btn_previous);
       insertpanel. add(btn_next);
       insertpanel. add(find);
    insertpanel. add(btn_update);
     insertpanel.add(btn_delete);
      
        insertpanel. add(label);
         insertpanel.add(heading);
         insertpanel.add(JL_id);
         insertpanel. add(usernam);
        insertpanel.add(JL_fname);
        insertpanel.add(JL_lname);
        insertpanel.add(JL_mail);
        insertpanel.add(sx);
        insertpanel. add(tel);
       insertpanel. add(depart);
        insertpanel. add(state);
        
        insertpanel.add(gender);
        insertpanel.add(JT_id);
        insertpanel.add(usernameJC);
        insertpanel.add(JT_fname);
        insertpanel.add(JT_lname);
        insertpanel.add(JT_email);
        insertpanel.add(JT_tel);
        insertpanel.add(dept);
        insertpanel.add(states);
        
        f.add(insertpanel);
         f.setVisible(true);
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
          
        String sql="DELETE FROM staff WHERE staffId='" + JT_id.getText() + "'";
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
       
         welcome.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("welcome")) {
                  new welcome();
                   f.dispose();

                   
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
        addstaff.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("staff")) {
                  new Staff();
                   f.dispose();

                   
       }
         }
         
     });
        
           prog.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Program")) {
                  new Programs();
                   f.dispose();

                   
       }
         }
         
     });
        
               deptmnt.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Department")) {
                  new departments();
                  f.dispose();
                   
       }
         }
         
     });
        

      jmiStore.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("stores")) {
                  new Stores();
                  f.dispose();
                   
       }
         }
         
     }); 
     
      
      jmiItem.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("Item")) {
                  new Items();
                  f.dispose();
       }
         }
         
     }); 
      
        jmiType.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("ItemType")) {
                  new ItemType();
                  f.dispose();
       }
         }
         
     }); 
     jmiaddstudent.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("StudentPanel")) {
                  new Student();
                  f.dispose();
       }
         }
         
     });
     
     crse.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Course")) {
                  new Course();
                  f.dispose();
                   }
         }
         
     });
        log.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Logout")) {
                 new login();
                  f.dispose();
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
                //ShowPosInfo(pos);                
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
           staffId = JT_id.getText().trim();
     username = usernameJC.getSelectedItem().toString();
        fname = JT_fname.getText().trim();
        lname = JT_lname.getText().trim();
         email = JT_email.getText().trim();
         sex =gender.getSelectedItem().toString().trim();
         contact=  JT_tel.getText().trim();
         dep= dept.getSelectedItem().toString().trim();
         status=states.getSelectedItem().toString().trim();  
            
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(staffId +""+ username + " " + fname + " " + lname);
        
             instruction = "Insert into staff (staffId,username,fname, lname, email,sex,contact,dep,status)" + "VALUES(?,?,?,?,?,?,?,?,?)";
            PreparedStatement preparedStatement = conn.prepareStatement(instruction);
            preparedStatement.setString(1, staffId);
            preparedStatement.setString(2, username);
            preparedStatement.setString(3, fname);
            preparedStatement.setString(4, lname);
            preparedStatement.setString(5, email);
            preparedStatement.setString(6, sex);
             preparedStatement.setString(7, contact);
              preparedStatement.setString(8, dep);
              preparedStatement.setString(9, status);
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
              status="";
        }
    }
    
 
     private void modify()
    {   
        try
        {
            
             staffId = JT_id.getText().trim();
     username = usernameJC.getSelectedItem().toString();
        fname = JT_fname.getText().trim();
        lname = JT_lname.getText().trim();
         email = JT_email.getText().trim();
         sex =gender.getSelectedItem().toString().trim();
         contact=  JT_tel.getText().trim();
         dep= dept.getSelectedItem().toString().trim();
         status=states.getSelectedItem().toString().trim();
         
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(staffId +""+ username + " " + fname + " " + lname);
 // create a Statement from the connection
    String   sql1  ="update staff set fname = '"+JT_fname.getText()+"',lname = '"+JT_lname.getText()+"'"
     + ",email = '"+JT_email.getText()+"',sex = '"+gender.getSelectedItem()+"',contact = '"+JT_tel.getText()+"',dep='"+dept.getSelectedItem()+"',status = '"+states.getSelectedItem()+"' where staffId = '" + JT_id.getText() + "'";

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
    
  
  

}