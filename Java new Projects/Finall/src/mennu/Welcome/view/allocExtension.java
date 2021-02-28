/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome.view;

/**
 *
 * @author YUAN allocExtension
 */
public class allocExtension {
    
 private String allocid,username,itemid ;
 String qty;
 String datealloc,status;

    
    public allocExtension(){}
    
    public allocExtension(String _allocid,String _username,String _itemid,String _qty,String _datealloc,String _status){
        this.allocid = _allocid;
        this.username = _username;
          this.itemid = _itemid;
            this.qty = _qty;
            this.datealloc = _datealloc;
             this.status = status;

    }

    public String getAllocid() {
        return allocid;
    }

    public String getUsername() {
        return username;
    }

    public String getItemid() {
        return itemid;
    }

    public String getQty() {
        return qty;
    }

    public String getDatealloc() {
        return datealloc;
    }

    public String getStatus() {
        return status;
    }

    

 

}    

