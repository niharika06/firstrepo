<?php
echo "Enter row of rows";
$row = read_stdin();
$n=$row;$i=1;
while($i<=$row)
{   
 for($j=1;$j<=$n/2;$j++)
    { 
       echo " ";
            }  
  for($k=1;$k<=$i;$k++){
        echo "*"; 
   }  
  echo "\n";
    $i=$i+2; 
   $n=$n-2;  
  }$i=1;
$n=$row;
while($i<=$n){
    for($j=1;$j<=$i;$j++)    {
        echo " ";     
       }   
 $row=$row-2; 
   for($k=1;$k<=$row;$k++){ 
       echo "*";  
  }    
echo "\n"; 
   $i=$i+1;  
      }
function read_stdin(){
        $give=fopen("php://stdin","r");   
 $input=fgets($give,100); 
   $input=rtrim($input);   
 fclose($give);  
  return $input;
}
?>