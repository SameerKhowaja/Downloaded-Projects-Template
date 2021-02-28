
package mennu.Welcome.view;

import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;
import javax.swing.*;
import java.util.ArrayList;
import java.util.List;
import javax.swing.border.Border;
public class WorkClass {
   
    
       
  public static final class frame extends JFrame{

          JLabel label,heading,usernam,JL_fname,JL_lname,JL_mail,JL_id,sx,tel,depart;
          JTextField JT_id,JT_fname,JT_lname,JT_email,JT_tel;
          JComboBox gender,jc, dept;
           String s,d;
            Statement st;
            ResultSet rs;
          JButton save,btn_first,btn_next,btn_previous,btn_last;
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
    
    public frame(){
        
     super("                                              stafff");
     
    
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

    
    
     label = new JLabel("<html>UGANDA MARTYRS UNIVERSITY NYAMITANGA CAMPUS EQUIPMENT TRACKING SYSTEM</html>", SwingConstants.CENTER);
     //background header
  label.setBackground(Color.black);
  label.setOpaque(true);
  label.setForeground(Color.WHITE);
     Border border = BorderFactory.createLineBorder(Color.WHITE);
  label.setVerticalAlignment(SwingConstants.TOP);
  label.setBorder(border);
  
  
  heading= new JLabel("<html>welcome to staff panel</html>", SwingConstants.CENTER);
  
  heading.setForeground(Color.WHITE);
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
     label.setBounds(0, 0, 500, 20);
    
     heading.setBounds(20, 20, 500, 20);
     
     JL_id.setBounds(20, 50, 100, 20);
     usernam.setBounds(20, 80, 100, 20);
     JL_fname.setBounds(20, 110, 100, 20);
     JL_lname.setBounds(20, 140, 100, 20);
     JL_mail.setBounds(20, 170, 100, 20);
      sx.setBounds(20, 200, 100, 20);
      tel.setBounds(20, 230, 100, 20);
      depart.setBounds(20, 260, 100, 20);


     JT_id = new JTextField(20);
     JT_fname = new JTextField(20);
     JT_lname = new JTextField(20);
     JT_email = new JTextField(20);
     JT_tel = new JTextField(20);
      //combobox
        gender = new JComboBox(str1);
       
     JT_id.setBounds(130,50,150,20);
     jc.setBounds(130,80,150,20);
     JT_fname.setBounds(130, 110, 150, 20);
     JT_lname.setBounds(130, 140, 150, 20);
     JT_email.setBounds(130, 170, 150, 20);
     gender.setBounds(130, 200, 150, 20);
     JT_tel.setBounds(130, 230, 150, 20);
     dept.setBounds(130, 260, 150, 20);
     JT_tel.setBounds(130, 230, 150, 20);

     
     save = new JButton("Save");
     btn_first = new JButton("First");
     btn_next = new JButton("Next");
     btn_previous = new JButton("Previous");
     btn_last = new JButton("Last");
     
     
     save.setBounds(300, 50, 100, 20);
     btn_first.setBounds(300, 80, 100, 20);
     btn_next.setBounds(300, 110, 100, 20);
     btn_previous.setBounds(300, 140, 100, 20);
     btn_last.setBounds(300, 170, 100, 20);
     
      //button save
        save.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
              
               if(e.getSource() == save)
        {
            AddtoRecord();
        }
               else{
                   
                   JOptionPane.showMessageDialog(null, "fail");
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
        
        ShowPosInfo(pos);
        
        add(save);
        add(btn_last);
        add(btn_first);
        add(btn_previous);
        add(btn_next);
        
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
        setLayout(null);
        getContentPane().setBackground(Color.decode("#bdb76b"));
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setSize(500,350);
        setResizable(false);
        setVisible(true);

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


    public void actionPerformed(ActionEvent e) {
    
         
        if(e.getSource() == save)
        {
            AddtoRecord();
        }
        
      
    }}
       
 public static void main(String[] args){ 
     
       new frame();
 }


  }


/////////////////////  END  :)
