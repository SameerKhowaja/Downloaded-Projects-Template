/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome.view;

public class crseExtension {
    private String coursid;
    private String crsename;
   
    public crseExtension(){}
    
    public crseExtension(String _courseid,String _crsename){
        this.coursid = _courseid;
        this.crsename = _crsename;
        
        
    }

    public String getCourseid() {
        return coursid;
    }

    public String getCrsename() {
        return crsename;
    }

}