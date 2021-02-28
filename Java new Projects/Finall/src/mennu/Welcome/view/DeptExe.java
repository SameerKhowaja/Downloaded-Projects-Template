
package mennu.Welcome.view;

public class DeptExe {
    private String deptid;
    private String deptname;
   
    public DeptExe(){}
    
    public DeptExe(String _deptid,String _deptname){
        this.deptid = _deptid;
        this.deptname = _deptname;
        
        
    }

    public String getDeptid() {
        return deptid;
    }

    public String getDeptname() {
        return deptname;
    }

}