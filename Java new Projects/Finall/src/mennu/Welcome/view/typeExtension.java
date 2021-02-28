/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome.view;

public class typeExtension {
        private String itemType;
    private String tyname;
   
    public typeExtension(){}
    
    public typeExtension(String _itemType,String _tyname){
        this.itemType = _itemType;
        this.tyname = _tyname;
        
        
    }

    public String getItemType() {
        return itemType;
    }

    public String getTyname() {
        return tyname;
    }

  

}