
<?php
 /*
 * ***************************************************
 * ** Student Management System                    ***
 * **--------------------------------------------- ***
 * ** Developer: Dejene Techane                    ***
 * ** Title: Student Management(Add,delete,Modify) ***
 * ***************************************************
 */

/* Procedure
 * ********************************************

 * ----------- *
 * PHP Section *
 * ----------- *

  Step 1: Perform Session Validation.

  Step 2: Event to Process...
  Case 1 : Logout - perform session cleanup.
  Case 2 : Dashboard - redirect to Dashboard
  Case 3 : Delete - Delete the selected Student/s from System.
  Case 4 : Edit - Update the new information.
  Case 5 : Add - Add new student to the system.

 * ------------ *
 * HTML Section *
 * ------------ *

  Step 3: Display the HTML Components for...
  Case 1: Add - Form to receive new user information.
  Case 2: Edit - Form to edit Existing User Information.
  Case 3: Default Mode - Displays the Information of Existing Users, If any.
 * ********************************************
 */

error_reporting(0);
session_start();
include_once 'smsdb.php';
/* * ************************ Step 1 ************************ */
if (!isset($_SESSION['username'])) {
    $_GLOBALS['message'] = "Session Timeout.Click here to <a href=\"index.php\">Re-LogIn</a>";
} 
//This is to protect unauthorized users
 else if(!($_SESSION['role']=="Administrator")){
    unset($_SESSION['username']);
  $_GLOBALS['message']="Please, You are accessing unauthorized page.Click here to <a href=\"index.php\">Re-LogIn</a>";
 }else if (isset($_REQUEST['logout'])) {
    /*     * ************************ Step 2 - Case 1 ************************ */
    //Log out and redirect login page
    unset($_SESSION['username']);
    header('Location:index.php');
} else if (isset($_REQUEST['dashboard'])) {
    /*     * ************************ Step 2 - Case 2 ************************ */
    //redirect to dashboard

    header('Location: admwelcome.php');
} else if (isset($_REQUEST['ins'])) {
    /*     * ************************ Step 2 - Case 2 ************************ */
    //redirect to dashboard

    header('Location: insmng.php');
} else if (isset($_REQUEST['std'])) {
    /*     * ************************ Step 2 - Case 2 ************************ */
    //redirect to dashboard

    header('Location: importstd.php');

}

?>
<html>
    <head>
        <title>SMS-Manage Student</title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
        <link rel="icon" type="jpg/png" href="images/logo.png"/>
        <link rel="stylesheet" type="text/css" href="sms.css"/>
        <script type="text/javascript" src="validate.js" ></script>    
        <script language="JavaScript" type="text/javascript" src="jquery.js"></script>
        <script language="JavaScript" type="text/javascript" src="jTPS.js"></script>
		<link rel="stylesheet" type="text/css" href="jTPS.css">

        <script>

                $(document).ready(function () {
               
                        $('#demoTable').jTPS( {perPages:[5,12,15,50,'ALL'],scrollStep:1,scrollDelay:30,
                                clickCallback:function () {    
                                        // target table selector
                                        var table = '#demoTable';
                                        // store pagination + sort in cookie
                                        document.cookie = 'jTPS=sortasc:' + $(table + ' .sortableHeader').index($(table + ' .sortAsc')) + ',' +
                                                'sortdesc:' + $(table + ' .sortableHeader').index($(table + ' .sortDesc')) + ',' +
                                                'page:' + $(table + ' .pageSelector').index($(table + ' .hilightPageSelector')) + ';';
                                }
                        });

                        // reinstate sort and pagination if cookie exists
                        var cookies = document.cookie.split(';');
                        for (var ci = 0, cie = cookies.length; ci < cie; ci++) {
                                var cookie = cookies[ci].split('=');
                                if (cookie[0] == 'jTPS') {
                                        var commands = cookie[1].split(',');
                                        for (var cm = 0, cme = commands.length; cm < cme; cm++) {
                                                var command = commands[cm].split(':');
                                                if (command[0] == 'sortasc' && parseInt(command[1]) >= 0) {
                                                        $('#demoTable .sortableHeader:eq(' + parseInt(command[1]) + ')').click();
                                                } else if (command[0] == 'sortdesc' && parseInt(command[1]) >= 0) {
                                                        $('#demoTable .sortableHeader:eq(' + parseInt(command[1]) + ')').click().click();
                                                } else if (command[0] == 'page' && parseInt(command[1]) >= 0) {
                                                        $('#demoTable .pageSelector:eq(' + parseInt(command[1]) + ')').click();
                                                }
                                        }
                                }
                        }

                        // bind mouseover for each tbody row and change cell (td) hover style
                        $('#demoTable tbody tr:not(.stubCell)').bind('mouseover mouseout',
                                function (e) {
                                        // hilight the row
                                        e.type == 'mouseover' ? $(this).children('td').addClass('hilightRow') : $(this).children('td').removeClass('hilightRow');
                                }
                        );

                });


        </script>
        <style>
                body {
                        font-family: Tahoma;
                        font-size: 10pt;
                }
                #demoTable thead th {										
                        white-space: nowrap;
                        overflow-x:hidden;
                        padding: 3px;
                }
                #demoTable tbody td{
												
                        padding: 3px;
                }
        </style>
       
    </head>
    <body>
<?php
if (isset($_GLOBALS['message'])) {
    echo "<div class=\"message\">" . $_GLOBALS['message'] . "</div>";
}
?>
        <div id="container">
             <div class="header">                              
                <?php require'header.php';?>                
                </div>
            <form name="stdmng" action="studentmng.php" method="post">
                <div class="menubar" id="menubar" name="menubar">


                    <ul id="menu">
<?php
if (isset($_SESSION['username'])) {
// Navigations
?>
                        <li><input type="submit" value="LogOut" name="logout" class="subbtn" title="Log Out"/></li>
                        <li><input type="submit" value="DashBoard" name="dashboard" class="subbtn" title="Dash Board"/></li>
                        
<?php
    //navigation for Add option
    if (isset($_REQUEST['add'])) {
?>
<?php
    } else if (isset($_REQUEST['edit'])) { //navigation for Edit option
?>
                        <li><input type="submit" value="Cancel" name="cancel" class="subbtn" title="Cancel"/></li>
                        <li><input type="submit" value="Save" name="savem" class="subbtn" onclick="validateform('stdmng')" title="Save the changes"/></li>

<?php
    } else if(isset($_REQUEST['view'])){
    	?>
    	 <li><input type="submit" value="Cancel" name="cancel" class="subbtn" title="Cancel"/></li>
         <li> <input type="submit" name="print" value="Print" onclick="tablePrint();" class="subbtn"></li> 
         <script>
function tablePrint(){ 
 document.all.menubar.style.visibility = 'hidden';  
    var display_setting="toolbar=no,location=no,directories=no,menubar=no,";  
    display_setting+="scrollbars=no,width=auto, height=auto, left=100, top=25";  
 //   var tableData = '<table border="1">'+document.getElementsByTagName('table')[0].innerHTML+'</table>';
    var content_innerhtml = document.getElementById("printout").innerHTML;  
    var document_print=window.open("","",display_setting);  
    document_print.document.open();  
    document_print.document.write('<body style="font-family:verdana; font-size:12px;" onLoad="self.print();self.close();" >');  
    document_print.document.write(content_innerhtml);  
    document_print.document.write('</body></html>');  
    document_print.print();  
    document_print.document.close(); 
   
    return false;  
    } 
  $(document).ready(function() {
    oTable = jQuery('#example').dataTable({
    "bJQueryUI": true,
    "sPaginationType": "full_numbers"
    } );
  });   
</script>
<?php
    	
    }else {  //navigation for Default
?>
                        
                        <li><input type="submit" value="Add" name="std" class="subbtn" title="Add" title="Add new Student Profile"/></li>
                       
<?php }
} ?>
                    </ul>

                </div>
                <div class="page">
<?php
if (isset($_SESSION['username'])) {
    
    if (isset($_REQUEST['view'])) {
        /*         * ************************ Step 3 - Case 1 ************************ */
        //view student details
         $rslt = executeQuery("select *,concat(program,college_id,'/',LPAD(id,4,'0'),'/',substr(YEAR(NOW())-7,-2)) as sid from auto_id_generate where id=".$_REQUEST['view']."  order by id;");                  
         while($r1=mysql_fetch_array($rslt)){
         		 $p=$r1['program'];
         		 if($p=='S')
         		 	 $p="Summer";
         		 else if($p=='R')
         		 	 $p="Regular";
         		 else if($p=='E')
         		 	 $p="Evening";
         		 ?>
         		 <span id="printout">
         		 <table cellpadding="20" cellspacing="20" style="text-align:left;margin-left:6em" id="datatable">
         		               
         		  <tr>
		<td><img style="margin:10px 2px 2px 10px;float:left;" height="90" width="100" src="" alt="Attach Photo Here"/>
                   <h4 style="color:#0000cc;text-align:center;"><u><i>AMBO UNIVERSITY</i></u></h4></br>

			<h4 style="color:#0000cc;text-align:center;"><u><i>STUDENT IDENTIFICATION CARD</i></u></h4>
		</td></tr>
                   <tr><td>
		 <b>College : &nbsp;</b><u>Institute Of Technology &nbsp;</u><br/> </td></tr>
                  <tr><td>
		  <b>Department : &nbsp;</b><u>Information Technology &nbsp;</u><b>&nbsp;Program:</b> <u><?php echo $p; ?>&nbsp;</u><br/> 
		</td></tr>
		<tr><td>
                    <b>ID Number : &nbsp;</b><u><?php echo htmlspecialchars_decode($r1['sid'],ENT_QUOTES); ?>&nbsp;</u>
			<b>Name : &nbsp;</b><u><?php echo htmlspecialchars_decode($r1['name'],ENT_QUOTES); ?>&nbsp;</u>&nbsp;
		</td></tr>
        		  	<tr><td>
				
        		  	<b>Gender : &nbsp;</b><u><?php echo htmlspecialchars_decode($r1['sex'],ENT_QUOTES); ?>&nbsp;</u>&nbsp; 
        		  	<b>Nationality : &nbsp;</b><u><?php echo "Ethiopian"; ?>&nbsp;</u>
        		  	<b>Occupation : &nbsp;</b><u>Student&nbsp;</u>&nbsp;
				</td></tr>
			<tr><td>
                    <b>Issued Date : </b><u><?php echo date('M, d/Y');?>&nbsp;</u></br>
                     <b>Authorized Signature : &nbsp;</b><?php echo "_____________________________"; ?>&nbsp;</br>
                    </p>
        		 </td>
                     
                        </tr>
                        <?php
         					}
                        ?> 
                         
          </table>
          </span>
                   

<?php
    }  else {
                /*                 * ************************ Step 3 - Case 3 ************************ */
                // Defualt Mode: Displays the Existing Users, If any.
                $month=date('M');
                
                if($month=='Sep')
                $result = executeQuery("select *,concat(program,college_id,'/',LPAD(id,4,'0'),'/',substr(YEAR(NOW())-7,-2)) as idno from auto_id_generate where uid=".$_SESSION['uid']." order by id;");                  
               // echo $month;
               else              
                $result = executeQuery("select *,concat(program,college_id,'/',LPAD(id,4,'0'),'/',substr(YEAR(NOW())-8,-2)) as idno from auto_id_generate where uid=".$_SESSION['uid']." order by id;");
               
                if (mysql_num_rows($result) == 0) {
                    echo "<h3 style=\"color:#0000cc;text-align:center;\">No Students Yet..!</h3>";
                } else {
                    $i = 0;
?>
                    <table id="demoTable" cellpadding="30" cellspacing="10" class="datatable">   
                    <thead>
                        <tr>                        	
                            <th>&nbsp;</th>
                            <th>S.No.</th>
                            <th>IDNO&lt;Auto generated&gt;</th>
                             <th>Full Name</th>
                              <th>Sex</th>                          
                              <th>Details</th>
                        </tr>
                         </thead>
                         <tbody>
<?php
                    while ($r = mysql_fetch_array($result)) {
                        $i = $i + 1;
                        if ($i % 2 == 0)
                            echo "<tr class=\"alt\">";
                        else                                       
                            echo "<tr>";
                        echo "<td style=\"text-align:center;\"><input type=\"checkbox\" name=\"d$i\" value=\"" . $r['id'] . "\" /></td><td>$i</td><td>" . htmlspecialchars_decode($r['idno'], ENT_QUOTES)
                        . "</td><td>" . htmlspecialchars_decode($r['name'], ENT_QUOTES) . "</td><td>" . htmlspecialchars_decode($r['sex'], ENT_QUOTES) . "</td>"
                        
                       
                         . "<td class=\"tddata\"><a title=\"View " . htmlspecialchars_decode($r['id'], ENT_QUOTES) . "\"href=\"studentmng.php?view=" . htmlspecialchars_decode($r['id'], ENT_QUOTES) . "\"><img src=\"images/detail.png\" height=\"30\" width=\"40\" alt=\"Edit\" /></a></td></tr>";
                    
                    }
?>

					</tbody>
				<tfoot class="nav">
               		 <tr>
                        <td colspan=6 ><font color="#000000">
                                <div class="pagination"></div>
                                <div class="paginationTitle">Page</div>
                                <div class="selectPerPage"></div>
                                <div class="status"></div>
								</font>
                        </td>
                </tr>
        </tfoot>
                    </table>
<?php
                }
                closedb();
            }
        }
?>

                </div>
            </form>
            <div id="footer">
                <?php include'footer.php';?>  
                
                </div>
        </div>
    </body>
</html>

