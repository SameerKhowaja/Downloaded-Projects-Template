/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome;


import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;
import javax.swing.*;
import javax.swing.border.Border;
import mennu.Welcome.view.retrnExe;
public class returned  extends JFrame{

         JLabel label,heading,usrname,JL_returnedid,JL_allocid,JL_qty,state,JL_date;
          JTextField JT_returned, JT_qty,JT_date;
          JComboBox Jc_allocid,JC_username,states;
           String s,ds, instruction;
            Statement st;
            ResultSet rs;
            
          JButton b,save,btn_first,btn_next,find,btn_previous,btn_last,view,btn_update,btn_delete;
          //define variables
        int month = java.util.Calendar.getInstance().get(java.util.Calendar.MONTH);
        int year = java.util.Calendar.getInstance().get(java.util.Calendar.YEAR);
        //create object of JLabel with alignment
        JLabel l = new JLabel("", JLabel.CENTER);
        //define variable
        String day = "";
        //declaration
        JDialog d;
        //create object of JButton
        JButton[] button = new JButton[49];
          int pos = 0;
String str2[] = {"", "new", "old", "damaged" };
String returnedid, allocid,username,qty, itemid,date,status;
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
    public static List<retrnExe> BindList(){
        try{
            Connection con = getConnection();
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("select * from returned");
            List<retrnExe> list = new ArrayList<retrnExe>();
            while(rs.next()){
                retrnExe u = new retrnExe((rs.getString("returnedid").trim()),
                                     rs.getString("allocid"),
                        rs.getString("qty"),
                        rs.getString("date"),
                        rs.getString("status"),
                        rs.getString("username")

                                   
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
        JT_returned.setText((BindList().get(index).getAllocid()));
        JT_qty.setText((BindList().get(index).getQty()));
        JT_date.setText((BindList().get(index).getDate()));
        
      
    
    }


    // bind a list with ResultSet
     
   public returned(JFrame parent){

       //create object
                d = new JDialog();
                //set modal true
                d.setModal(true);
                //define string
                String[] header = { "Sun", "Mon", "Tue", "Wed", "Thur", "Fri", "Sat" };
                //create JPanel object and set layout
                JPanel p1 = new JPanel(new GridLayout(7, 7));
                //set size
                p1.setPreferredSize(new Dimension(430, 120));
                //for loop condition
                for (int x = 0; x < button.length; x++) 
                {		
                	//define variable
                        final int selection = x;
                        //create object of JButton
                        button[x] = new JButton();
                        //set focus painted false
                        button[x].setFocusPainted(false);
                        //set background colour
                        button[x].setBackground(Color.white);
                        //if loop condition
                        if (x > 6)
                        //add action listener
                        button[x].addActionListener(new ActionListener() 
                        {
                                 public void actionPerformed(ActionEvent ae) 
                                 {
                                       day = button[selection].getActionCommand();
                                       //call dispose() method
                                       d.dispose();
                                 }
                        });
                        if (x < 7)//if loop condition 
                        {
                                button[x].setText(header[x]);
                                //set fore ground colour
                                button[x].setForeground(Color.red);
                        }
                        p1.add(button[x]);//add button
                }
                //create JPanel object with grid layout
                JPanel p2 = new JPanel(new GridLayout(1, 3));
                
                //create object of button for previous month
                JButton previous = new JButton("<< Previous");
                //add action command
                previous.addActionListener(new ActionListener() 
                {
                        public void actionPerformed(ActionEvent ae) 
                        {
                            //decrement month by 1
                            month--;
                            //call method
                            displayDate();
                        }
                });
                p2.add(previous);//add button
                p2.add(l);//add label
                //create object of button for next month
                JButton next = new JButton("Next >>");
                //add action command
                next.addActionListener(new ActionListener()
                {
                        public void actionPerformed(ActionEvent ae) 
                        {
                             //increment month by 1
                             month++;
                             //call method
                            displayDate();
                        }
                });
                p2.add(next);// add next button
                //set border alignment
                d.add(p1, BorderLayout.CENTER);
                d.add(p2, BorderLayout.SOUTH);
                d.pack();
                //set location
                d.setLocationRelativeTo(parent);
                //call method
                displayDate();
                //set visible true
                d.setVisible(true);
        

   }
    public returned(){
        
       
        try{
         Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
   
      s= "select * FROM allocated";
      Jc_allocid =new JComboBox();
      Jc_allocid.addItem("");
   rs=st.executeQuery(s);
     
   while(rs.next())
   {
    
    Jc_allocid.addItem(rs.getString(1));
   }
    }catch (Exception e){
 JOptionPane.showMessageDialog(null,"ERROR" + e);
    
    }
    try{
                  ds= "select * FROM users";
             
      
   rs=st.executeQuery(ds);
     JC_username=new JComboBox();
     JC_username.addItem("");
   while(rs.next())
   {
    
   JC_username.addItem(rs.getString(2));
   }
           
        }catch(Exception e){
           
        }
     
       f8 = new JFrame("                            WELCOME TO RETURNED ITEMS");
    f8.setSize(700,450);
    f8.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    f8.setLocationRelativeTo(null);
    f8.setResizable(false);
    

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
    

    JMenu Alloc = new JMenu("Item's Allocation And Return");
    JMenuItem allocated = new JMenuItem("Allocate");
    JMenuItem rtned = new JMenuItem("Returned");
    Alloc.add(allocated);
    Alloc.add(rtned);
    jmb.add(Alloc);
    
    // construct a File menu
    
     
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

         heading= new JLabel("<html>welcome to returned items panel</html>", SwingConstants.CENTER);
           heading.setForeground(Color.BLACK);
            heading.setBounds(30, 80, 550, 30);
       JL_returnedid = new JLabel("Retuirned Id:"); 
       usrname= new JLabel("Username");
       JL_qty = new JLabel("Quantity:");
     JL_allocid = new JLabel("Allocated Id:");
    JL_date = new JLabel("Date allocated:");
    
    state = new JLabel("Status:");
     
     JL_returnedid.setBounds(170, 110, 100, 20);
     usrname.setBounds(170, 140, 100, 20);
     JL_allocid.setBounds(170, 170, 100, 20);
     JL_qty.setBounds(170, 200, 100, 20);
     JL_date.setBounds(170, 230, 100, 20);
     state.setBounds(170, 260, 100, 20);
     
     
     JT_returned=new JTextField(20);
     JT_qty = new JTextField(20);
     states = new JComboBox(str2);
     JT_date=new JTextField(20);

   //  UtilDateModel model = new UtilDateModel();
//JDatePanelImpl datePanel = new JDatePanelImpl(model);
//JDatePickerImpl datePicker = new JDatePickerImpl(datePanel);
 
//insertpanel.add(datePicker);
     
     JT_returned.setBounds(350,110,150,20);
     JC_username.setBounds(350,140,150,20);
    Jc_allocid .setBounds(350, 170, 150, 20);
      JT_qty.setBounds(350, 200, 150, 20);
      JT_date.setBounds(350, 230, 150, 20);
     states.setBounds(350, 260, 150, 20);
     
     b = new JButton("POPUP");
      save = new JButton("Save");
     btn_first = new JButton("First");
     btn_next = new JButton("Next");
     btn_previous = new JButton("Previous");
     btn_last = new JButton("Last");
     find= new JButton("Find");
     btn_update = new JButton("Update");
     btn_delete = new JButton("Delete");
     
     
     
     b.setBounds(500, 227, 80, 30);
     save.setBounds(15, 350, 80, 30);
     btn_first.setBounds(100, 350, 80, 30);
     btn_next.setBounds(185, 350, 80, 30);
     btn_previous.setBounds(270, 350, 85, 30);
     btn_last.setBounds(360, 350, 80, 30);
    find.setBounds(450, 350, 80, 30);
     btn_update.setBounds(535, 350, 80, 30);
     btn_delete.setBounds(620, 350, 70, 30);  
      
        insertpanel.add(JL_allocid);
        insertpanel.add(usrname);
        insertpanel.add(JL_returnedid);
       insertpanel. add(JL_qty);
       insertpanel.add(JL_date);
       insertpanel. add(state);
  
       insertpanel. add(JT_returned);
       insertpanel. add(JC_username);
    insertpanel. add(JT_qty);
        insertpanel.add(Jc_allocid);
       insertpanel.add(JT_date);
       insertpanel. add(states);
        
        insertpanel.add(b);
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
     
        f8.add(insertpanel);
         f8.setVisible(true);
         
         
         
         
         b.addActionListener(new ActionListener() 
        	{
        		public void actionPerformed(ActionEvent ae) 
        		{
        			//set text i.e. date
        			JT_date.setText(new allocated(f8).setPickedDate());
        		}
            });
               
 //button save
        save.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
            
            AddtoRecord();
        
               
         }
         
     });    
        
        //button save
        find.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
            
          
        
               
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
          
        String sql="DELETE FROM returned WHERE returnedid='" + JT_returned.getText() + "'";
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
                   f8.dispose();

                   
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
        

      jmiStore.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("stores")) {
                  new Stores();
                  f8.dispose();
                   
       }
         }
         
     }); 
      
      prog.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Program")) {
                  new Programs();
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
      allocated.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Allocate")) {
                  new allocated();
                  f8.dispose();
                   
       }
         }
         
     }); 
        
     rtned.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
                   if (e.getActionCommand().equals("Returned")) {
                  new allocated();
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

        
         
        try
        {
         returnedid  = JT_returned.getText().trim();
        allocid = Jc_allocid.getSelectedItem().toString().trim();
        qty = JT_qty.getText().trim();
        date=JT_date.getText().trim();
        status=states.getSelectedItem().toString(); 
      username=  JC_username.getSelectedItem().toString().trim();
            
            
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(returnedid +"" + allocid + " " +qty + " "+ itemid);
        
             instruction = "Insert into returned (returnedid,allocid, qty,date,status,username)" + "VALUES(?,?,?,?,?,?)";
            PreparedStatement preparedStatement = conn.prepareStatement(instruction);
            preparedStatement.setString(1, returnedid);
            preparedStatement.setString(2, allocid);
            preparedStatement.setString(3, qty);
            preparedStatement.setString(4, date);
            preparedStatement.setString(5, status);
            preparedStatement.setString(6, username);
            
            
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
            returnedid = "";
            allocid="";
            itemid = "";
            qty = "";
            date="";
             status = "";
             username="";
        }
    }
    
    
    private void modify()
    {   
        try
        {
        returnedid  = JT_returned.getText().trim();
        allocid = Jc_allocid.getSelectedItem().toString().trim();
        qty = JT_qty.getText().trim();
        date=JT_date.getText().trim();
        status=states.getSelectedItem().toString(); 
        username =JC_username.getSelectedItem().toString().trim();
            
 
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
        st=conn.createStatement();
            System.out.println(returnedid +""+username  + " " + allocid + " " + qty);
 // create a Statement from the connection
    String   sql1  ="update returned set allocid = '"+Jc_allocid.getSelectedItem().toString().trim()+"',qty = '"+JT_qty.getText().trim()+"',date = '"+JT_date.getText().trim()+"',status = '"+states.getSelectedItem().toString().trim()+"',username = '"+JC_username.getSelectedItem().toString().trim()+"' where returnedid  = '" + JT_returned.getText().trim() + "'";

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
     public void displayDate() 
        {
        	for (int x = 7; x < button.length; x++)//for loop
        	button[x].setText("");//set text
      	        java.text.SimpleDateFormat sdf = new java.text.SimpleDateFormat("yyyy-MM-dd");	
                //create object of SimpleDateFormat 
                java.util.Calendar cal = java.util.Calendar.getInstance();			
                //create object of java.util.Calendar 
        	cal.set(year, month, 1); //set year, month and date
         	//define variables
        	int dayOfWeek = cal.get(java.util.Calendar.DAY_OF_WEEK);
        	int daysInMonth = cal.getActualMaximum(java.util.Calendar.DAY_OF_MONTH);
        	//condition
        	for (int x = 6 + dayOfWeek, day = 1; day <= daysInMonth; x++, day++)
        	//set text
        	button[x].setText("" + day);
        	l.setText(sdf.format(cal.getTime()));
        	//set title
        	d.setTitle("Date Picker");
        }

        public String setPickedDate() 
        {
        	//if condition
        	if (day.equals(""))
        		return day;
            java.text.SimpleDateFormat sdf = new java.text.SimpleDateFormat("yyyy-MM-dd");
            java.util.Calendar cal = java.util.Calendar.getInstance();
            cal.set(year, month, Integer.parseInt(day));
            return sdf.format(cal.getTime());
        }

  
     public static void main(String args[]) {
        new returned();
    }
}
  

