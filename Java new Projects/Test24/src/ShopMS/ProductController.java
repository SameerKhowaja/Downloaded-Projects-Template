
package ShopMS;

import dao.DatabaseHelper;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JComboBox;
import javax.swing.JOptionPane;

public class ProductController
{
    
   public static boolean savePname(String pname)//method of saving new product
   {
       Connection con=null;
       CallableStatement csmt=null;
       boolean t=true;
       try{
           con=DatabaseHelper.getConnection();
           csmt=con.prepareCall("{CALL saveProduct(?)}");
           csmt.setString(1, pname);
           t=csmt.execute();
         
       }
       catch(Exception e)
       {
           System.out.println("Error is:\t"+e.toString());
       }
       return t;
   }
   public static boolean savePurchase(String pname,String price,String date,String qty)////method of saving purchase product
   {
       Connection con=null;
       CallableStatement csmt=null;
       boolean t=true;
       try{
           con=DatabaseHelper.getConnection();
           csmt=con.prepareCall("{CALL save_purchase(getProductId(?),?,?,?)}");
           
           csmt.setString(1, pname);
           csmt.setString(2, price);
           csmt.setString(3, date);
           csmt.setString(4, qty);
           
           t=csmt.execute();
         
       }
       catch(Exception e)
       {
           e.printStackTrace();
       }
       finally{
           try {
               con.close();
               csmt.close();
           } catch (SQLException ex) {
               ex.printStackTrace();
           }
       }
       return t;
   }
   public static boolean saveSale(String pname,String price,String date,String qty)////method of saving sale product
   {
       Connection con=null;
       CallableStatement csmt=null;
       boolean t=true;
       try{
           con=DatabaseHelper.getConnection();
           csmt=con.prepareCall("{CALL save_sale(getProductId(?),?,?,?)}");
           csmt.setString(1, pname);
           csmt.setString(2, price);
           csmt.setString(3, date);
           csmt.setString(4, qty);
           
           t=csmt.execute();
         
       }
       catch(Exception e)
       {
           e.printStackTrace();
       }
       finally{
           try {
               con.close();
               csmt.close();
           } catch (SQLException ex) {
               ex.printStackTrace();
           }
       }
       return t;
   }
   public static void avgPrice()////method of getting average product price
   {
       
       Connection con=null;
       CallableStatement csmt=null;
       ResultSet rs=null;
       try{
           con=DatabaseHelper.getConnection();
           csmt=con.prepareCall("{CALL avg_price()}");
           csmt.execute(); 
           rs=csmt.getResultSet();
           List pList=new ArrayList();
           while(rs.next())
           {
               pList.add(rs.getString(1));
           }
          
       }
       catch(Exception e)
       {
           JOptionPane.showMessageDialog(null, e);
       }
   }
   public static void viewProduct()//method of viewing product
   {
       
       Connection con=null;
       CallableStatement csmt=null;
       ResultSet rs=null;
       try{
           con=DatabaseHelper.getConnection();
           csmt=con.prepareCall("{CALL view_product()}");
           csmt.execute(); 
           rs=csmt.getResultSet();
           List pList=new ArrayList();
           while(rs.next())
           {
               pList.add(rs.getString(1));
           }
          
       }
       catch(Exception e)
       {
           JOptionPane.showMessageDialog(null, e);
       }
   }
   
   public static boolean login(String name,String password)
   {
       Connection con=null;
       ResultSet rs=null;
       PreparedStatement ps=null;
       
       try
       {
           con=DatabaseHelper.getConnection();
           ps=con.prepareStatement("select name,password from login where name=? and password=?");
           ps.setString(1, name);
           ps.setString(2, password);
           rs=ps.executeQuery();
           if(rs.next())
           {
               return true;
           }
           else
           {
               return false;
           }
           
           
           
       }
       catch(Exception e)
       {
           System.out.println("Error is:\t"+e.toString());
            return false;
           
       }
       
   }
   
   public static boolean updatePass(String newpass,String oldpass)
   {
       Connection con=null;
       ResultSet rs=null;
       PreparedStatement ps=null;
       
       try
       {
           con=DatabaseHelper.getConnection();
           ps=con.prepareStatement("update test_24.login set password=? where password=?"); 
           ps.setString(1, newpass);
           ps.setString(2, oldpass);
           ps.execute();
           return true;
           
           
           
       }
       catch(Exception e)
       {
           System.out.println("Error is:\t"+e.toString());
            return false;
           
       }
       
   }
   
   public static boolean saveSale1()////method of saving sale product
   {
       Connection con=null;
       CallableStatement csmt=null;
       boolean t=true;
       try{
           con=DatabaseHelper.getConnection();
           csmt=con.prepareCall("{CALL save_sale(getProductId(?),?,?,?)}");
           
           t=csmt.execute();
         
       }
       catch(Exception e)
       {
           e.printStackTrace();
       }
       finally{
           try {
               con.close();
               csmt.close();
           } catch (SQLException ex) {
               ex.printStackTrace();
           }
       }
       return t;
   }
    
}
