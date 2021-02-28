<?php

/*
***************************************************
*** Student Management System                   ***
***---------------------------------------------***
*** Developer: Dejene Techane                   ***
*** Title: Admin Welcome                        ***
***************************************************
*/

/* Procedure
*********************************************
 * ----------- *
 * PHP Section *
 * ----------- *
Step 1: Perform Session Validation.
 * ------------ *
 * HTML Section *
 * ------------ *
Step 2: Display the Dashboard.

*********************************************
*/

error_reporting(0);
include_once 'smsdb.php';
/********************* Step 1 *****************************/
session_start();
        if(!isset($_SESSION['username'])){
            $_GLOBALS['message']="Session Timeout.Click here to <a href=\"index.php\">Re-LogIn</a>";
           
        }
      //This is to protect unauthorized users
 else if(!($_SESSION['role']=="Administrator")){
    unset($_SESSION['username']);
  $_GLOBALS['message']="Please, You are accessing unauthorized page.Click here to <a href=\"../index.php\">Re-LogIn</a>";
 }
        else if(isset($_REQUEST['logout'])){
           unset($_SESSION['username']);
            $_GLOBALS['message']="You are Loggged Out Successfully.";
            header('Location:index.php');
        }
?>

<html>
    <head>
        <title>SMS-DashBoard</title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
         <link rel="icon" type="jpg/png" href="images/logo.png"/>
        <link rel="stylesheet" type="text/css" href="sms.css"/>
    </head>
    <body>
        <?php
       /********************* Step 2 *****************************/
        if(isset($_GLOBALS['message'])) {
            echo "<div class=\"message\">".$_GLOBALS['message']."</div>";
        }
        ?>
        <div id="container">
             <div class="header">                              
                <?php require'header.php';?>                
                </div>
            <div class="menubar">

                <form name="admwelcome" action="admwelcome.php" method="post">
                    <ul id="menu">
                        <?php if(isset($_SESSION['username'])){ ?>
                        <li><input type="submit" value="LogOut" name="logout" class="subbtn" title="Log Out"/></li>
                      <?php include'menus.php';?>

                       
                        <?php } ?>
                    </ul>
                </form>
            </div>
            <div class="page">
                <?php if(isset($_SESSION['username'])){ ?>
                	


               <?php
                $result=executeQuery("select * from user where username='".$_SESSION['username']."';");
                $r=mysql_fetch_array($result);
                closedb();?>
                <h4 style="color:#000000;text-align:center;margin:2px 3px 5px 5px;"><i> &nbsp;Welcome <?php echo htmlspecialchars_decode($r['role'], ENT_QUOTES);?></i></h4>
               <img src="images/page.gif" height="130"/> 
                
                <?php }?>

            </div>

           <div id="footer">
           <?php include'footer.php';?>
             </div>
      </div>
  </body>
</html>
