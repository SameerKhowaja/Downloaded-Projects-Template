/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome.view;


public class Staffextension {
    private String staffId;
    private String username;
    private String fname;
  private String lname;
    private String email;
    private String sex;
      private int contact;
        private String dep;
        private String status;

    public Staffextension(){}
    public Staffextension(String _staffId,String _username,String _fname,String _lname,String _email,String _sex,int _contact,String _dep,String _status){
        this.staffId = _staffId;
        this.username = _username;
        this.fname = _fname;
        this.lname = _lname;
        this.email = _email;
        this.sex = _sex;
        this.contact = _contact;
        this.dep = _dep;
        this.status = _status;
    }

    public String getStaffId() {
        return staffId;
    }

    public String getUsername() {
        return username;
    }

    public String getFname() {
        return fname;
    }

    public String getLname() {
        return lname;
    }

    public String getEmail() {
        return email;
    }

    public String getSex() {
        return sex;
    }

    public int getContact() {
        return contact;
    }

    public String getDep() {
        return dep;
    }

    public String getStatus() {
        return status;
    }

    
}