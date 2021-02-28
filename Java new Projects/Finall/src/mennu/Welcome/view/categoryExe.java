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
public class categoryExe {
    
private String cateid;
    private String categoryname;
   
    public categoryExe(){}
    
    public categoryExe(String _cateid,String _categoryname){
        this.cateid = _cateid;
        this.categoryname = _categoryname;
        
        
    }
     public String getCateid() {
        return cateid;
    }

    public String getCategoryname() {
        return categoryname;
    }

   

}