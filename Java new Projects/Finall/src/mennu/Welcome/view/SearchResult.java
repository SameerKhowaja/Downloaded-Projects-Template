/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome.view;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;

public class SearchResult extends JFrame   {
JFrame frame1;
JTextField textbox;
JLabel label;
JButton b;
JPanel panel;
static JTable table;

String driverName = "com.mysql.jdbc.Driver";
String url = "jdbc:mysql://localhost:3306/equipment";
String userName = "root";
String password = "";
String[] columnNames = {"Staff Id", "Username", "First Name", "Last Name", "Email Address", " Sex", "contact","dep"};

public SearchResult() {
frame1 = new JFrame("Database Search Result");
frame1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
frame1.setLayout(new BorderLayout()); 
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
frame1.add(Box.createHorizontalGlue());

 b = new JButton("Button");
        b.setPreferredSize(new Dimension(16, 16));
       //view all from database button actions here
        b.addActionListener(new ActionListener(){
        @Override
         public void actionPerformed(ActionEvent e) {
              
               if(e.getSource() == b)
        {
                   new SearchResult();
                   
            


        }
               
         }
         
     });

String staffId= "";
String usenam="";
String fname= "";
String lname= "";
String email = "";
String sex = "";
String contact = "";
String dep = "";
    


try
{ 
Class.forName(driverName); 
Connection con = DriverManager.getConnection(url, userName, password);
String sql = "select * from staff ";
PreparedStatement ps = con.prepareStatement(sql);
ResultSet rs = ps.executeQuery(sql);


int i =0;
while(rs.next())
{
    staffId = rs.getString("staffId");
usenam = rs.getString("username");
fname = rs.getString("fname");
lname = rs.getString("lname");
email = rs.getString("email");
sex = rs.getString("sex"); 
contact= rs.getString("contact"); 
dep = rs.getString("dep"); 
model.addRow(new Object[]{staffId,usenam, fname, lname,email, sex,contact,dep});
i++; 
}

if(i <1)
{
JOptionPane.showMessageDialog(null, "No Record Found","Error",
JOptionPane.ERROR_MESSAGE);
}
if(i ==1)
{
System.out.println(i+" Record Found");
}
else
{
System.out.println(i+" Records Found");
}
}
catch(Exception ex)
{
JOptionPane.showMessageDialog(null, ex.getMessage(),"Error",
JOptionPane.ERROR_MESSAGE);
}
frame1.add(scroll);
frame1.setVisible(true);
frame1.setSize(new Dimension(600,300));
frame1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame1.setLocationRelativeTo(null);
        frame1.setResizable(false);

}

public static void main(String args[])
{
SearchResult sr = new SearchResult();

}
}