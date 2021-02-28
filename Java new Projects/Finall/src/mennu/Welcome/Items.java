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
import mennu.Welcome.view.itemExtension;
public class Items  extends JFrame{

          JLabel label,heading,JL_itemType,JL_itemName,JL_id,JL_storeid,state;
          JTextField JT_id,JT_itemName;
          JComboBox JC_itemType,JC_storeid,states;
           String s,d, instruction;
            Statement st;
            ResultSet rs;
            
          JButton save,btn_first,btn_next,find,btn_previous,btn_last,view,btn_update,btn_delete;
          
          int pos = 0;
String str2[] = {"", "new", "old", "damaged" };
String itemid,itemname,itemType, storeid,status;
         JFrame f4;  
 
          
 
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
    public static List<itemExtension> BindList(){
        try{
            Connection con = getConnection();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("select * from items");
            List<itemExtension> list = new ArrayList<itemExtension>();
            while(rs.next()){
                itemExtension u = new itemExtension((rs.getString("itemid")),
                                     rs.getString("itemname"),
                                   rs.getString("itemType"),
                        rs.getString("storeid")
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
        JT_id.setText((BindList().get(index).getItemid()));
        
        JT_itemName.setText(BindList().get(index).getItemname());
        
      
    
    }
    
    
    public Items(){
        try{
         Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
   
      s= "select * FROM itemType";
      JC_itemType =new JComboBox();
      JC_itemType.addItem("");
   rs=st.executeQuery(s);
     
   while(rs.next())
   {
    
    JC_itemType.addItem(rs.getString(1));
   }
    }catch (Exception e){
 JOptionPane.showMessageDialog(null,"ERROR" + e);
    
    }
    try{
                  d= "select * FROM store";
             
      
   rs=st.executeQuery(d);
     JC_storeid=new JComboBox();
     JC_storeid.addItem("");
   while(rs.next())
   {
    
   JC_storeid.addItem(rs.getString(1));
   }
           
        }catch(Exception e){
           
        }
     
       f4 = new JFrame("                            WELCOME TO ITEMS");
    f4.setSize(700,450);
    f4.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    f4.setLocationRelativeTo(null);
    f4.setResizable(false);
    

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
     
 f4.setJMenuBar(jmb);
  f4. setVisible(true);
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

         heading= new JLabel("<html>welcome to equipments panel</html>", SwingConstants.CENTER);
           heading.setForeground(Color.BLACK);
            heading.setBounds(30, 80, 550, 30);
            
     JL_id = new JLabel("Item Id:");
     JL_itemType = new JLabel("Item Name:");
     JL_itemName = new JLabel("Item Type:");
    JL_storeid = new JLabel("Store Id:");
    state = new JLabel("Status:");
     
     JL_id.setBounds(170, 110, 100, 20);
         JL_itemName.setBounds(170, 170, 100, 20);
      JL_itemType.setBounds(170, 140, 100, 20);
     JL_storeid.setBounds(170, 200, 100, 20);
     state.setBounds(170, 230, 100, 20);
     
     
     
     JT_id = new JTextField(20);
     JT_itemName = new JTextField(20);
     states = new JComboBox(str2);

     
     
    JT_id.setBounds(350,110,150,20);
    JT_itemName.setBounds(350,140,150,20);
     JC_itemType.setBounds(350, 170, 150, 20);
     JC_storeid.setBounds(350, 200, 150, 20);
     states.setBounds(350, 230, 150, 20);
     
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
      
        insertpanel.add(JL_id);
       insertpanel. add(JL_itemName);
        insertpanel.add(JL_itemType);
       insertpanel. add(JL_storeid);
       insertpanel. add(state);
  
       insertpanel. add(JT_id);
    insertpanel. add(JT_itemName);
        insertpanel.add(JC_itemType);
       insertpanel. add(JC_storeid);
       insertpanel. add(states);
        
        insertpanel.add(save);
        insertpanel.add(btn_last);
       insertpanel. add(btn_first);
        insertpanel.add(btn_previous);
       insertpanel. add(btn_next);
       insertpanel. add(find);
    insertpanel. add(btn_update);
     insertpanel.add(btn_delete);
  
         insertpanel. add(label);
         insertpanel. add(heading);
     
        f4.add(insertpanel);
         f4.setVisible(true);
               
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
       
       //button delete
        btn_delete.addActionListener(new  ActionListener() {

         public void actionPerformed(ActionEvent e) {
         
try {
               Connection con;
                Class.forName("com.mysql.jdbc.Driver");
                con = DriverManager
                                .getConnection("jdbc:mysql://localhost:3306/equipment", "root", "");
          
        String sql="DELETE FROM items WHERE itemid='" + JT_id.getText() + "'";
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
                   f4.dispose();

                   
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
                   f4.dispose();

                   
       }
         }
         
     });
        
               deptmnt.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Department")) {
                  new departments();
                  f4.dispose();
                   
       }
         }
         
     });
        

      jmiStore.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("stores")) {
                  new Stores();
                  f4.dispose();
                   
       }
         }
         
     }); 
      
      prog.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Program")) {
                  new Programs();
                  f4.dispose();
                   
       }
         }
         
     }); 
     
      
      jmiItem.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("Item")) {
                  new Items();
                  f4.dispose();
       }
         }
         
     }); 
      
        jmiType.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
       
     
                   if (e.getActionCommand().equals("ItemType")) {
                  new ItemType();
                  f4.dispose();
       }
         }
         
     }); 
     jmiaddstudent.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("StudentPanel")) {
                  new Student();
                  f4.dispose();
       }
         }
         
     });
     
     crse.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Course")) {
                  new Course();
                  f4.dispose();
                   }
         }
         
     });
        log.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Logout")) {
                 new login();
                  f4.dispose();
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
         itemid = JT_id.getText().trim();
        itemname = JT_itemName.getText().trim();
        storeid = JC_storeid.getSelectedItem().toString();
        itemType = JC_itemType.getSelectedItem().toString();
        status=states.getSelectedItem().toString(); 
            
            
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(itemid +"" + itemname + " " +itemType + " "+ storeid);
        
             instruction = "Insert into items (itemid,itemname,itemType, storeid,status)" + "VALUES(?,?,?,?,?)";
            PreparedStatement preparedStatement = conn.prepareStatement(instruction);
            preparedStatement.setString(1, itemid);
            preparedStatement.setString(2, itemname);
            preparedStatement.setString(3, itemType);
            preparedStatement.setString(4, storeid);
            preparedStatement.setString(5, status);
            
            preparedStatement.executeUpdate();
           
 JOptionPane.showConfirmDialog(null, "Your Data Has been Inserted",
                "Result", JOptionPane.DEFAULT_OPTION,
                JOptionPane.PLAIN_MESSAGE);

        st.close();
        conn.close();
        }
        catch(Exception e)
        {
JOptionPane.showMessageDialog  (null,"" + e);         
        }  
        finally
        {
            itemid="";
            itemname = "";
            itemType = "";
            storeid = "";
             status = "";
        }
    }
    
    
    private void modify()
    {   
        try
        {
         itemid = JT_id.getText().trim();
        itemname = JT_itemName.getText().trim();
        storeid = JC_storeid.getSelectedItem().toString();
        itemType = JC_itemType.getSelectedItem().toString();
        status=states.getSelectedItem().toString();
 
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(itemid +""+ itemname + " " + itemType + " " + storeid);
 // create a Statement from the connection
    String   sql1  ="update items set itemname = '"+JT_itemName.getText().trim()+"',itemType = '"+JC_itemType.getSelectedItem().toString().trim()+"',storeid = '"+JC_storeid.getSelectedItem().toString().trim()+"',status = '"+states.getSelectedItem().toString().trim()+"' where itemid = '" + JT_id.getText().trim() + "'";

          st.executeUpdate(sql1);
JOptionPane.showConfirmDialog(null, "Your Data Has been updated",
                "Result", JOptionPane.DEFAULT_OPTION,
                JOptionPane.PLAIN_MESSAGE);          
        }
        catch(Exception e)
        {
                          JOptionPane.showMessageDialog(null,"error" + e);
        }

    
  }}
  

