/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.BorderFactory;
import javax.swing.JButton;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;

import javax.swing.SwingConstants;
import javax.swing.border.Border;
import javax.swing.table.DefaultTableModel;


public class findStudent extends JFrame implements ActionListener {
    JLabel  uname;
    JFrame f;
    JTextField tf5;
    JButton b1;

    Connection con;

    ResultSet rs, rs1;

    Statement st, st1;

    PreparedStatement pst;

   String s;

    static JTable table;

    String[] columnNames = {"Registration No", "Username", "First Name", "Last Name"," Sex","Course"};


   
 
public findStudent() {
   
     f = new JFrame("                  search");
    f.setSize(500,100);
    f.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
    f.setLocationRelativeTo(null);
    f.setResizable(false);

    
JPanel insertpanel=new JPanel();
  
   insertpanel.setLayout(null);

   //label = new JLabel("<html>Type your name below to find out equipments assigned to you</html>", SwingConstants.CENTER);
 
  
 insertpanel.setBackground(Color.WHITE);
 
 
  
 //color for header

 uname = new JLabel("Enter Registration number");
          tf5 = new JTextField(20);


        b1 = new JButton("Search");

        b1.addActionListener(this);

  //positioning header

uname.setBounds(0, 30, 150, 30);
tf5.setBounds(150, 30, 180, 30);
b1.setBounds(320, 30, 100, 30);
        


  insertpanel.add(tf5);
   insertpanel.add(uname);
    insertpanel.add(b1);
  //end insertpanel.setLayout(null);

  


 f.add(insertpanel);
 f.setVisible(true);

        
   
    
    /*try {
                String str = tf5.getText();

    Class.forName("com.mysql.jdbc.Driver");
     con = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
  
            st = con.createStatement();

            PreparedStatement st = con.prepareStatement("select * from student WHERE username=?");
            st.setString(1, str);
            //Excuting Query
            ResultSet rs = st.executeQuery();

           /* Vector v = new Vector();

            while (rs.next()) {

                s = rs.getString(1);

                v.add(s);

            }

            c1 = new JComboBox(v);

            

            

            st.close();

            rs.close();

        } catch (Exception e) {

        }
*/

      //button save
        b1.addActionListener(new ActionListener() {
          
         @Override
         public void actionPerformed(ActionEvent e) {
            
                        showTableData();
        
               
         }
         
     });   

}

    
    
 
    @Override
    public void actionPerformed(ActionEvent e) {
      if (e.getActionCommand().equals("View")) {
      //new Resuilt();
      f.setVisible(false);
      
      }
    
    
    }
    public void showTableData() {

 

        f = new JFrame("                                  Results");

        f.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);

        f.setLayout(new BorderLayout());
        f.pack();
         f.setLocationRelativeTo(null);

//TableModel tm = new TableModel();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

//DefaultTableModel model = new DefaultTableModel(tm.getData1(), tm.getColumnNames());

//table = new JTable(model);

        table = new JTable();

        table.setModel(model);

        table.setAutoResizeMode(JTable.AUTO_RESIZE_ALL_COLUMNS);

        table.setFillsViewportHeight(true);

        JScrollPane scroll = new JScrollPane(table);

        scroll.setHorizontalScrollBarPolicy(

                JScrollPane.HORIZONTAL_SCROLLBAR_AS_NEEDED);

        scroll.setVerticalScrollBarPolicy(

                JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED);


//String textvalue = textbox.getText();
        String regNo = "";

        String username = "";

        String fname = "";

        String lname = "";

        String sex = "";
        
        String crsename="";

 

        try {
            String str=tf5.getText();
      Class.forName("com.mysql.jdbc.Driver");
     con = DriverManager.getConnection("jdbc:mysql://localhost/equipment","root","");
  
            st = con.createStatement();

            PreparedStatement st = con.prepareStatement("select * from student,course where student.crseid=course.coursid AND regNo=?");
            st.setString(1, str);
            //Excuting Query
            ResultSet rs = st.executeQuery();


            int i = 0;

            while (rs.next()) {
                regNo = rs.getString("regNo");
                username = rs.getString("username");

                fname = rs.getString("fname");

                lname = rs.getString("lname");

                sex = rs.getString("sex");
                
                crsename = rs.getString("crsename");


                model.addRow(new Object[]{regNo,username, fname, lname, sex,crsename});

                i++;

            }

            if (i < 1) {

                JOptionPane.showMessageDialog(null, "No Record Found", "Error", JOptionPane.ERROR_MESSAGE);

            }

            if (i == 1) {

                System.out.println(i + " Record Found");

            } else {

                System.out.println(i + " Records Found");

            }

        } catch (Exception ex) {

            JOptionPane.showMessageDialog(null, ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);

        }

        f.add(scroll);

        f.setVisible(true);

        f.setSize(700, 300);

    }
    
public static void main(String args[]) {
       new findStudent();
  }

}
