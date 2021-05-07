<?php
header('Access-Control-Allow-Origin: *');
header('Access-Control-Allow-Methods: GET, POST, PATCH, PUT, DELETE, OPTIONS');
header('Access-Control-Allow-Headers: Origin, Content-Type, X-Auth-Token');
header('Access-Control-Allow-Credentials: true,');

  
// //Define your host here.
// 	$HostName = "mariadb-29986-0.cloudclusters.net:29986";
	 
// 	//Define your MySQL Database Name here.
// 	$DatabaseName = "company";
	 
// 	//Define your Database UserName here.
// 	$HostUser = "root";
	 
// 	//Define your Database Password here.
// 	$HostPass = "mysql_indresh";
 
$servername = "mariadb-29986-0.cloudclusters.net:29986";
$username = "root";
$password = "mysql_indresh";
$dbname = "company";
$conn = new mysqli($servername,$username,$password,$dbname);
if($conn->connect_error){
die("connection failed:" . $conn->connect_error);

}
$sql ="SELECT * from student_data";
$result = $conn->query($sql);
$response = array();
if($result->num_rows > 0)
{
    while ($row = $result ->fetch_assoc()){
        array_push($response,$row);

    }
}
$conn ->close();
header('Content-Type: application/json');
echo json_encode($response);

?>
