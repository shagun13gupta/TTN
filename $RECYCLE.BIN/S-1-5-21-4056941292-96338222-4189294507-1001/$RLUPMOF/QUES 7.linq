<Query Kind="Expression">
  <Connection>
    <ID>cc0e1ccb-41f3-47d2-b4dc-d6757a2e233c</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-V9BJ1OE</Server>
    <Database>DB_EMPLOYEE</Database>
  </Connection>
</Query>

// QUES 7:  Write LINQ to perform the Grouping operation.



from t in EMPLOYEEs
group t by t.EMP_ID 

EMPLOYEEs.GroupBy(t=>t.EMP_ID)   //LAMBDA EXPRESSION

from t in SALARies
group t by t.EMP_ID


SALARies.GroupBy(t=>t.EMP_ID)    //LAMBDA EXPRESSION