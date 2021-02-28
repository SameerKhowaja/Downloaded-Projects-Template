/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome.view;

/**
 *
 * @author YUAN
 */
public class storesExe {
    

   private String storeid,storename;
  
   
     
    public storesExe(){}
    public storesExe(String _storeid,String _storename){
        this.storeid = _storeid;
        this.storename = _storename;
        
    }

    public String getStoreid() {
        return storeid;
    }

    public String getStorename() {
        return storename;
    }

   
}

   