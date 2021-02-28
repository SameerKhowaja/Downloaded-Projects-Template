<?php include('header.php'); ?>
<?php  $result= mysql_query("select * from buy ") or die (mysql_error());
        $months = array_fill(1,12,0);
        
        while($row= mysql_fetch_array($result) ){
            
               
            switch (date("n", strtotime($row['date']))) {
               case 1:
                    $months[1]+=$row['total_bag'];
                    break;
                case 2:
                    $months[2]+=$row['total_bag'];
                    break;
                case 3:
                    $months[3]+=$row['total_bag'];
                    break;
                case 4:
                    $months[4]+=$row['total_bag'];
                    break;
                case 5:
                    $months[5]+=$row['total_bag'];
                    break;
                case 6:
                    $months[6]+=$row['total_bag'];
                    break;
                case 7:
                    $months[7]+=$row['total_bag'];
                    break;
                case 8:
                    $months[8]+=$row['total_bag'];
                    break;
                case 9:
                    $months[9]+=$row['total_bag'];
                    break;
                case 10:
                    $months[10]+=$row['total_bag'];
                    break;
                case 11:
                    $months[11]+=$row['total_bag'];
                    break;
                case 12:
                    $months[12]+=$row['total_bag'];                    
                    break;
                default:
                    break;
            }
        }
        $months_values = '';
        foreach ($months as $month) {
            $months_values .= $month.',';
        }
    

        echo '<script>'
        . 'var months = ['. $months_values
                . ']'
                . '</script>';
        ?>
<div class="box-content">
    <div class="col-xs-9">
        <canvas id="chart">  </canvas>
    </div>
</div>
<?php include('footer.php'); ?>