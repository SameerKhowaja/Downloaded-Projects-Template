/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome.view;


        
public class itemExtension {

    private String itemid,itemname,itemType, storeid;

    
    public itemExtension(){}
    
    public itemExtension(String _itemid,String _itemname,String _itemType,String _storeid){
        this.itemid = _itemid;
        this.itemname = _itemname;
          this.itemType = _itemType;
            this.storeid = _storeid;
        
        
    }

    public String getItemid() {
        return itemid;
    }

    public String getItemname() {
        return itemname;
    }

    public String getItemType() {
        return itemType;
    }

    public String getStoreid() {
        return storeid;
    }

 

}    

