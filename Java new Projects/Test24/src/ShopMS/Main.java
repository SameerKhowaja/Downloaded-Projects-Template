
package ShopMS;

import dao.DatabaseHelper;
import java.awt.*;
import java.awt.event.*;
import java.sql.*;
import java.text.*;
import java.util.Date;
import javax.swing.*;

/*this is main frame.User can perform his work by using this frame*/
public class Main extends JFrame implements ActionListener
{
    /**/
    JPanel panel=new JPanel();
    JTextField tname,price,pdate,qty,s_product;
    JLabel qty_label,pname,price_label,date;
    JLabel line;
    JButton purchase,anp,view_product,reset,sale_product,view_sale,product_price,exit;

    JTextField delettextfield;
    JComboBox cmbProduct=new JComboBox();
    Connection con;
    Statement st = null;
    ResultSet rs;
  

    Main()////conntructor which is used for calling other method/function
    {
        
        super("Project on a Automatic Shop Controlling System");
        panel.setBackground(Color.LIGHT_GRAY);
        panel.setLayout(null);
        add(panel);
        add_top_label();
        setSize(860,590);
        setVisible(true);
        setLocation(200,80);
        setResizable(false);
        label_textfield();
        button();
    }
   
    void add_top_label()//function/method of adding label top of the panel
    {
        line=new JLabel("CONTROL ANY KIND OF SHOP AUTOMATICALLY.");
        //line.setBackground(Color.white);
        line.setForeground(Color.BLACK);
        
        line.setBounds(280,70,800, 30);
        panel.add(line);
    }
    void label_textfield()////function or method of adding label and textfield with panel...
    {
        
        pname=new JLabel("Choose Product   : ");
        pname.setForeground(Color.black);
        pname.setBounds(100, 300, 170, 40);
        setFont(new Font("verdana", 3, 14));
        cmbProduct.setBounds(220, 300, 170, 40);
        panel.add(pname);
        panel.add(cmbProduct);
        /// retrieve data from database using combobox........................ .................
       Connection con=null;
       CallableStatement csmt=null;
       ResultSet rs=null;
       try{
           con=DatabaseHelper.getConnection();
           csmt=con.prepareCall("{CALL listProduct()}");
           csmt.execute(); 
           rs=csmt.getResultSet();
           while(rs.next())
           {
               
            String prolist=rs.getString(1);
            cmbProduct.addItem(prolist);
           
           }
           
       }
       catch(Exception e)
       {
           System.out.println("Eroor is:"+e.toString());
       }

       
       ///////////////////////////
        price_label=new JLabel("Purchase Price :");
        price_label.setForeground(Color.black);
        price_label.setBounds(410, 300, 170, 40);
        price=new JTextField(15);
        price.setBounds(530, 300, 170, 40);
        panel.add(price_label);
        panel.add(price);



        Date date1=new Date();
        SimpleDateFormat sdf=new SimpleDateFormat("dd.MM.yyyy");
        String student_id = sdf.format(date1);

        date=new JLabel("Purchase Date      :");
        date.setForeground(Color.black);
        date.setBounds(100, 400, 170, 40);
        pdate=new JTextField(student_id);
        pdate.setBounds(220, 400, 170, 40);
        panel.add(date);
        panel.add(pdate);



        qty_label=new JLabel("Quantity               :");
        qty_label.setForeground(Color.black);
        qty_label.setBounds(410, 400, 170, 40);
        qty=new JTextField(15);
        qty.setBounds(530, 400, 170, 40);
        panel.add(qty_label);
        panel.add(qty);



    }
    void button()//////function or method of adding button with panel...
    {
        //up button
        sale_product=new JButton("Sale Product");
        sale_product.setForeground(Color.LIGHT_GRAY);
        sale_product.setBackground(Color.darkGray);
        sale_product.addActionListener(this);
        sale_product.setBounds(30, 190, 180, 40);
        panel.add(sale_product);
        
        
        view_sale=new JButton("View Sale");
        view_sale.setForeground(Color.LIGHT_GRAY);
        view_sale.setBackground(Color.darkGray);
        view_sale.addActionListener(this);
        view_sale.setBounds(230, 190, 180, 40);
        panel.add(view_sale);
        
        product_price=new JButton("Product Price");
        product_price.setForeground(Color.LIGHT_GRAY);
        product_price.setBackground(Color.darkGray);
        product_price.addActionListener(this);
        product_price.setBounds(430, 190, 180, 40);
        panel.add(product_price);
        
        exit=new JButton("Exit");
        exit.setForeground(Color.LIGHT_GRAY);
        exit.setBackground(Color.darkGray);
        exit.addActionListener(this);
        exit.setBounds(630, 190, 180, 40);
        panel.add(exit);
        ///down button
        purchase=new JButton("Purchase Product");
        purchase.setForeground(Color.LIGHT_GRAY);
        purchase.setBackground(Color.darkGray);
        purchase.addActionListener(this);
        purchase.setBounds(30, 500, 180, 40);
        panel.add(purchase);
        

        anp=new JButton("Add New Product");
        anp.setForeground(Color.lightGray);
        anp.setBackground(Color.darkGray);
        anp.setBounds(230, 500, 180, 40);
        anp.addActionListener(this);
        panel.add(anp);


        view_product=new JButton("View Product");
        view_product.setForeground(Color.lightGray);
        view_product.setBackground(Color.darkGray);
        view_product.addActionListener(this);
        view_product.setBounds(430, 500, 180, 40);
        panel.add(view_product);

        reset=new JButton("Reset");
        reset.setForeground(Color.lightGray);
        reset.setBackground(Color.darkGray);
        reset.addActionListener(this);
        reset.setBounds(630, 500, 180, 40);
        panel.add(reset);



    }
    public static void main(String args[])
    {
        Main ob=new Main();//calling constructor
    }

    public void actionPerformed(ActionEvent e)
    {
        
      
       if(e.getSource()==anp)
       {
           Add_New_Product ob2=new Add_New_Product();
           dispose();
       }
       if(e.getSource()==purchase)
       {
          if((price.getText().equals(""))&&(qty.getText().equals("")))
          {
              JOptionPane.showMessageDialog(null, "Please Enter Correct Information");
          }
          else{
           ProductController.savePurchase(cmbProduct.getSelectedItem().toString(),price.getText(), pdate.getText(), qty.getText());
           JOptionPane.showMessageDialog(null, "Product Purchased Successfully");
          }
           
          
       }
       if(e.getSource()==sale_product)
       {
        // Sale_Product ob2=new Sale_Product();
         // dispose();
       //  SaleProduct ob=new SaleProduct();
         SaleProduct ob_SaleProduct=new SaleProduct();  
       }
       
       if(e.getSource()==view_product)
       {
            View_Product2 ob=new View_Product2();
       }
       if(e.getSource()==product_price)
       {
           view_product_price ob=new view_product_price();
       }
       if(e.getSource()==view_sale)
       {
          Search_Sale2 ob=new Search_Sale2();
       }
       if(e.getSource()==exit)
       {
          System.exit(0);
       }
       if(e.getSource()==reset)
       {
          price.setText("");
          qty.setText("");
       }
       
    }

    

}

