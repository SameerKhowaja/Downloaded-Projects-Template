/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mennu.Welcome.view;



public class StudExtension {
    private String regNo;
    private String username;
    private String fname;
  private String lname;
    private String sex;
      private int contact;
       private String progid;
        private String crseid;
        private String status;
    public StudExtension(){}
    public StudExtension(String _regNo,String _username,String _fname,
            String _lname,String _sex,int _contact,String _progid,String _crseid,String _status){
        this.regNo = _regNo;
        this.username = _username;
        this.fname = _fname;
        this.lname = _lname;
        this.sex = _sex;
        this.contact = _contact;
        this.progid = _progid;
        this.crseid = _crseid;
        this.status=_status;
        
    }

    public String getRegNo() {
        return regNo;
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

    public String getSex() {
        return sex;
    }

    public int getContact() {
        return contact;
    }

    public String getProgid() {
        return progid;
    }

    public String getCrseid() {
        return crseid;
    }

    public String getStatus() {
        return status;
    }

}

   