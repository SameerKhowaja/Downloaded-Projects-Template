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
public class retrnExe {
       
 private String returnedid ,allocid;
 String qty;
 String date,status,username;

    
    public retrnExe(){}
    
    public retrnExe(String _returnedid,String _allocid,String _qty,String _date,String _status,String _username){
        this.returnedid = _returnedid;
        this.allocid = _allocid;
            this.qty = _qty;
            this.date = _date;
             this.status = status;
               this.username = _username;


    }

    public String getReturnedid() {
        return returnedid;
    }

    public String getAllocid() {
        return allocid;
    }

    public String getQty() {
        return qty;
    }

    public String getDate() {
        return date;
    }

    public String getStatus() {
        return status;
    }

    public String getUsername() {
        return username;
    }

    

    

 

}    

