<?php
$dbHost = 'localhost';
$dbUsername = 'root';
$dbPassword = '';
$dbName = 'admin_opac';
//connect with the database
$db = new mysqli($dbHost,$dbUsername,$dbPassword,$dbName);
//get search term
$searchTerm = $_GET['term'];
//get matched data from skills table
$query = $db->query("SELECT * FROM books WHERE title LIKE '%".$searchTerm."%'"
        . " OR author LIKE '%".$searchTerm."%' OR publisher_name LIKE '%".$searchTerm."%' "
        . "OR place_publication LIKE '%".$searchTerm."%'OR section LIKE '%".$searchTerm."%' "
        . "OR copyright_year LIKE '%".$searchTerm."%' ORDER BY title ASC");
while ($row = $query->fetch_assoc()) {
    $id=$row['accession_no'];
    $data[] = $row['title'];
    //$data[] = $row['author'];
    //$data[] = $row['copyright_year'];
    //$data[] = $row['publisher_name'];
    //$data[] = $row['place_publication'];
    //$data[] = $row['section'];
   // $data[] = $row['title'];
}
//return json data

echo json_encode($data);
?>