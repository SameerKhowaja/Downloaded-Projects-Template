
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
import mennu.Welcome.view.StudExtension;


public  class Student extends JFrame {
          JLabel label,heading,usernam,JL_fname,JL_lname,JL_mail,JL_id,sx,tel,proggie,course,state;
          JTextField JT_id,JT_fname,JT_lname,JT_tel;
          JComboBox gender,jc, prog2,crse1,states;
           String s,d, instruction,sq;
            Statement st;
            ResultSet rs;
          JButton save,btn_first,btn_next,btn_previous,btn_last,view,btn_update,find,btn_delete;
          int pos = 0;
 String str1[] = {"select Gender", "Male", "Female" };
  String str2[] = { "active", "disabled" };
String regNo,username,fname, lname, email, sex,contact,progid,crseid,status;
          
  
    JFrame frame;
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
    public static List<StudExtension> BindList(){
        try{
            Connection con = getConnection();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("select * from student");
            List<StudExtension> list = new ArrayList<StudExtension>();
            while(rs.next()){
                StudExtension u = new StudExtension((rs.getString("regNo")),
                                   
                                     rs.getString("username"),
                                    rs.getString("fname"),
                                    rs.getString("lname"),
                                 rs.getString("sex"),
                            
               Integer.parseInt(rs.getString("contact")),
                 rs.getString("progid"),
                        rs.getString("crseid"),
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
        
                JT_id.setText((BindList().get(index).getRegNo()));
        
        JT_fname.setText(BindList().get(index).getFname());
        
        JT_lname.setText(BindList().get(index).getLname());

        JT_tel.setText(Integer.toString(BindList().get(index).getContact()));
      
    
    }
public Student() {
    
      try{
         Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
   
              s= "select * FROM users";
             
      
   rs=st.executeQuery(s);
     jc =new JComboBox();
     
     jc.addItem("select usernme");// default value is set to an empty string
     
   while(rs.next())
   {
    
    jc.addItem(rs.getString(2));
   }
    }catch (Exception e){
 JOptionPane.showMessageDialog(null,"ERROR" + e);
    
    }
       try{
                  sq= "select * FROM programs";
             
      
   rs=st.executeQuery(sq);
        prog2=new JComboBox();
        prog2.addItem("select program");
   while(rs.next())
   {
 
   prog2.addItem(rs.getString(1));
   }
           
        }catch(Exception e){
           
        }
       
       
       try{
                  d= "select * FROM course";
             
      
   rs=st.executeQuery(d);
       crse1=new JComboBox();
       crse1.addItem("select course");
   while(rs.next())
   {
   crse1.addItem(rs.getString(1));
   }
           
        }catch(Exception e){
           
        }
   
     frame = new JFrame("                            WELCOME TO STUDENT");
         frame.setSize(700,500);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setLocationRelativeTo(null);
    frame.setResizable(false);
    

  JPanel insertpanel=new JPanel();
   insertpanel.setLayout(null);
   
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
       JMenuItem prog = new JMenuItem("Programs");
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
     
 frame.setJMenuBar(jmb);
  frame. setVisible(true);
         insertpanel.setBackground(Color.WHITE);
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

         heading= new JLabel("<html>welcome to student panel</html>", SwingConstants.CENTER);
           heading.setForeground(Color.BLACK);
            heading.setBounds(30, 80, 550, 30);
                
      
     JL_id = new JLabel("RegNo:");
     usernam = new JLabel("Username:");
     JL_fname = new JLabel("Fname:");
     JL_lname = new JLabel("Lname:");
     sx = new JLabel("Sex:");
    tel = new JLabel("TelNo:");
    proggie = new JLabel("Programe:");
    course = new JLabel("Course:");
    state = new JLabel("Status:");
    JL_id.setBounds(170, 110, 100, 20);
    
     usernam.setBounds(170, 140, 100, 20);
     JL_fname.setBounds(170, 170, 100, 20);
     JL_lname.setBounds(170, 200, 100, 20);
      sx.setBounds(170, 230, 100, 20);
      tel.setBounds(170, 260, 100, 20);
      proggie.setBounds(170, 290, 100, 20);
      course.setBounds(170, 320, 100, 20);
      state.setBounds(170, 360, 100, 20);
     

     JT_id = new JTextField(20);
     JT_fname = new JTextField(20);
     JT_lname = new JTextField(20);
     JT_tel = new JTextField(20);
     //JT_pass= new JTextField(20);
      //combobox
     gender = new JComboBox(str1);
     states = new JComboBox(str2);

     JT_id.setBounds(350,110,150,20);
     jc.setBounds(350,140,150,20);
     JT_fname.setBounds(350, 170, 150, 20);
     JT_lname.setBounds(350, 200, 150, 20);
     gender.setBounds(350, 230, 150, 20);
     JT_tel.setBounds(350, 260, 150, 20);
prog2.setBounds(350, 290, 150, 20);
crse1.setBounds(350, 320, 150, 20);
states.setBounds(350, 350, 150, 20);
//JT_pass.setBounds(350, 380, 150, 20);


      insertpanel.add(JL_id);
      insertpanel.add(usernam);
      insertpanel.add(JL_fname);
      insertpanel.add(JL_lname);
      insertpanel.add(sx);
      insertpanel.add(tel);
      insertpanel.add(proggie);
      insertpanel.add(course);
         insertpanel.add(heading);
         insertpanel. add(label);
          insertpanel. add(state);
         
         
insertpanel.add(JT_id);
      insertpanel.add(jc);
      insertpanel.add(JT_fname);
      insertpanel.add(JT_lname);
      insertpanel.add(gender);
      insertpanel.add(JT_tel);
      insertpanel.add(prog2);
      insertpanel.add(crse1);
      insertpanel. add(states);
       //insertpanel.add(JT_pass);

         
         
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

        
        insertpanel.add(save);
        insertpanel.add(btn_last);
       insertpanel. add(btn_first);
        insertpanel.add(btn_previous);
       insertpanel. add(btn_next);
       insertpanel. add(find);
    insertpanel. add(btn_update);
     insertpanel.add(btn_delete);
        frame.add(insertpanel);
         frame.setVisible(true);
         
        
        

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
          //button save
        find.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
            
         new findStudent();
        
               
         }
         
     });
        
       //button delete
       
        btn_delete.addActionListener(new  ActionListener() {

         public void actionPerformed(ActionEvent e) {
         
try {
               Connection con;
                Class.forName("com.mysql.jdbc.Driver");
                con = DriverManager
                                .getConnection("jdbc:mysql://localhost:3306/equipment", "root", "");
          
        String sql="DELETE FROM student WHERE regNo='" + JT_id.getText() + "'";
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
                   frame.dispose();

                   
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
                   frame.dispose();

                   
       }
         }
         
     });
        
               deptmnt.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Department")) {
                  new departments();
                  frame.dispose();
                   
       }
         }
         
     });
        

      jmiStore.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("stores")) {
                  new Stores();
                  frame.dispose();
                   
       }
         }
         
     }); 
      
      
      prog.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Programs")) {
                  new Programs();
                  frame.dispose();
                   
       }
         }
         
     }); 
     
      
      jmiItem.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("Item")) {
                  new Items();
                  frame.dispose();
       }
         }
         
     }); 
      
        jmiType.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("ItemType")) {
                  new ItemType();
                  frame.dispose();
       }
         }
         
     }); 
     jmiaddstudent.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("StudentPanel")) {
                  new Student();
                  frame.dispose();
       }
         }
         
     });
     
     crse.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Course")) {
                  new Course();
                  frame.dispose();
                   }
         }
         
     });
        log.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Logout")) {
                 new login();
                  frame.dispose();
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
         regNo = JT_id.getText().trim().trim();
     username = jc.getSelectedItem().toString().trim();
        fname = JT_fname.getText().trim().trim();
        lname = JT_lname.getText().trim();
         sex =gender.getSelectedItem().toString().trim();
         contact=  JT_tel.getText().trim();
         progid= prog2.getSelectedItem().toString().trim();
         crseid=crse1.getSelectedItem().toString().trim();
          status=states.getSelectedItem().toString().trim();
          //password = JT_pass.getText().trim();


        try
        {
            
            
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(regNo +""+ username + " " + fname + " " + lname);
        
             instruction = "Insert into student (regNo,username,fname, lname,sex,contact,progid,crseid,status)" + "VALUES(?,?,?,?,?,?,?,?,?)";
            //instruction = "Insert into users (username,password,fname)" + "VALUES(?,?,?)";

             PreparedStatement preparedStatement = conn.prepareStatement(instruction);
            preparedStatement.setString(1, regNo);
            preparedStatement.setString(2, username);
            preparedStatement.setString(3, fname);
            preparedStatement.setString(4, lname);
            preparedStatement.setString(5, sex);
             preparedStatement.setString(6, contact);
              preparedStatement.setString(7, progid);
              preparedStatement.setString(8, crseid);
              preparedStatement.setString(9, status);
               //preparedStatement.setString(10, password);

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
        (null, "" + e);
           
        }
        finally
        {
            regNo="";
            username = "";
            fname = "";
            lname = "";
              sex = "";
              contact="";
              progid="";
              crseid="";
              status="";
//              password="";
        }
    }
    
    
    private void modify()
    {   
        try
        {
            
           regNo = JT_id.getText().trim();
     username = jc.getSelectedItem().toString().trim();
        fname = JT_fname.getText().trim();
        lname = JT_lname.getText().trim();
         sex =gender.getSelectedItem().toString().trim();
         contact=  JT_tel.getText().trim();
         progid= prog2.getSelectedItem().toString().trim();
         crseid=crse1.getSelectedItem().toString().trim();
         status=states.getSelectedItem().toString().trim();
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(regNo +""+ username + " " + fname + " " + lname);
 // create a Statement from the connection
        String   sql1  ="update student set fname = '"+JT_fname.getText()+"',lname = '"+JT_lname.getText()+"',"
                + "sex = '"+gender.getSelectedItem()+"',contact = '"+JT_tel.getText()+"',progid = '"+prog2.getSelectedItem().toString()+"'"
                + ", crseid = '"+crse1.getSelectedItem().toString()+"',status = '"+states.getSelectedItem().toString()+"' where regNo = '" + JT_id.getText() + "'";

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
        new Student();
    }
  }
  

