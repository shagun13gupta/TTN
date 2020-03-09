<Query Kind="Expression">
  <Connection>
    <ID>cc0e1ccb-41f3-47d2-b4dc-d6757a2e233c</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-V9BJ1OE</Server>
    <Database>DB_EMPLOYEE</Database>
  </Connection>
</Query>


// QUES 10: Write LINQ to find 3rd highest Salary from the table.


(from e in EMPLOYEEs
orderby e.SALARY descending 
select e).Skip(2).FirstOrDefault()


