

<?php

/*
***************************************************
*** Examination Management System               ***
***---------------------------------------------***
*** Developer: Dejene Techane                   ***
*** Title: Summary Report                       ***
***************************************************
*/

error_reporting(0);
session_start();
include_once '../include/emsdb.php';
if(!isset($_SESSION['username'])) {
    $_GLOBALS['message']="Session Timeout.Click here to <a href=\"../index.php\">Re-LogIn</a>";
}
 //This is to protect unauthorized users
 else if(!($_SESSION['role']=="Student")){
    unset($_SESSION['username']);
  $_GLOBALS['message']="Please, You are accessing unauthorized page.Click here to <a href=\"../index.php\">Re-LogIn</a>";
 }
else if(isset($_REQUEST['logout']))
{
    //Log out and redirect login page
       unset($_SESSION['username']);
       header('Location: ../index.php');

}
else if(isset($_REQUEST['dashboard'])){
    //redirect to dashboard
    //
     header('Location: stdwelcome.php');

    }
    else if(isset($_REQUEST['change']))
    {
        //redirect to testconducter
       
       $_SESSION['qn']=substr($_REQUEST['change'],7);
       header('Location: examconducter.php');

    }
    else if(isset($_REQUEST['finalsubmit'])){
    //redirect to dashboard
    //
     header('Location: examtake.php');

    }
     else if(isset($_REQUEST['fs'])){
    //redirect to dashboard
    //
     header('Location: testack.php');

    }

   
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">

<html>
  <head>
    <title>EMS-Summary</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <link rel="icon" type="jpg/png" href="../images/logo.png"/>
    <meta http-equiv="CACHE-CONTROL" content="NO-CACHE"/>
    <meta http-equiv="PRAGMA" content="NO-CACHE"/>
    <meta name="ROBOTS" content="NONE"/>

    <link rel="stylesheet" type="text/css" href="../ems.css"/>
    <script type="text/javascript" src="../validate.js" ></script>
    <script type="text/javascript" src="../cdtimer.js" ></script>
    <script type="text/javascript" >
    <!--
        <?php
                $elapsed=time()-strtotime($_SESSION['starttime']);
                if(((int)$elapsed/60)<(int)$_SESSION['duration'])
                {
                    $result=executeQuery("select TIME_FORMAT(TIMEDIFF(endtime,CURRENT_TIMESTAMP),'%H') as hour,TIME_FORMAT(TIMEDIFF(endtime,CURRENT_TIMESTAMP),'%i') as min,TIME_FORMAT(TIMEDIFF(endtime,CURRENT_TIMESTAMP),'%s') as sec from studenttest where uid=".$_SESSION['uid']." and testid=".$_SESSION['testid'].";");
                    if($rslt=mysql_fetch_array($result))
                    {
                     echo "var hour=".$rslt['hour'].";";
                     echo "var min=".$rslt['min'].";";
                     echo "var sec=".$rslt['sec'].";";
                    }
                    else
                    {
                        $_GLOBALS['message']="Try Again";
                    }
                    closedb();
                }
                else
                {
                    echo "var sec=01;var min=00;var hour=00;";
                }
        ?>

    -->
    </script>


    </head>
  <body >
       <?php

        if($_GLOBALS['message']) {
            echo "<div class=\"message\">".$_GLOBALS['message']."</div>";
        }
        ?>
      <div id="container">
     <div class="header">                              
                <?php require'../include/header.php';?>                
                </div>
           <form id="summary" action="summary.php" method="post">
          <div class="menubar">
              
                        <?php if(isset($_SESSION['username'])) {
                         // Navigations
                         ?>
              
          </div>
      <div class="page">
                 <table border="0" width="100%" class="ntab">
                  <tr>
                      <th style="width:40%;"><h3><span id="timer" class="timerclass"></span></h3></th>
                      
                  </tr>
              </table>
          <?php

                        $result=executeQuery("select * from studentquestion where testid=".$_SESSION['testid']." and uid=".$_SESSION['uid']." order by qnid ;");
                        if(mysql_num_rows($result)==0) {
                          echo"<h3 style=\"color:#0000cc;text-align:center;\">Please Try Again.</h3>";
                        }
                        else
                        {
                           //editing components
                 ?>
          <table cellpadding="30" cellspacing="10" class="datatable">
                        <tr>
                            <th>Question No</th>
                            <th>Status</th>
                            <th>Change Your Answer</th>
                       </tr>
        <?php
                        while($r=mysql_fetch_array($result)) {
                                    $i=$i+1;
                                    if($i%2==0)
                                    {
                                    echo "<tr class=\"alt\">";
                                    }
                                    else{ echo "<tr>";}
                                    echo "<td>".$r['qnid']."</td>";
                                    if(strcmp(htmlspecialchars_decode($r['answered'],ENT_QUOTES),"unanswered")==0 ||strcmp(htmlspecialchars_decode($r['answered'],ENT_QUOTES),"review")==0)
                                    {
                                        echo "<td style=\"color:#ff0000\">".htmlspecialchars_decode($r['answered'],ENT_QUOTES)."</td>";
                                    }
                                    else
                                    {
                                        echo "<td>".htmlspecialchars_decode($r['answered'],ENT_QUOTES)."</td>";
                                    }
                                    echo"<td><input type=\"submit\" value=\"Change ".$r['qnid']."\" name=\"change\" class=\"ssubbtn\" /></td></tr>";
                                }

                                ?>
              <tr>
                  <td colspan="3" style="text-align:center;"><input type="submit" name="finalsubmit" value="Final Submit" class="ssubbtn"/></td>
              </tr>
                    </table>
                            <?php
                            }
                            closedb();

         
                    }
                    ?>

      </div>

           </form>
   <div id="footer">
           <?php include'../include/footer.php';?>
       </div>
      </div>
  </body>
</html>

