<Query Kind="Expression">
  <Connection>
    <ID>cc0e1ccb-41f3-47d2-b4dc-d6757a2e233c</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-V9BJ1OE</Server>
    <Database>DB_EMPLOYEE</Database>
  </Connection>
</Query>


// QUES 4: Write LINQ to get records using inner join and display columns from both tables.


from e in EMPLOYEEs 
join s in SALARies 
on e.EMP_ID equals s.EMP_ID 
select new { empid=e.EMP_ID,empname=e.EMP_NAME ,months=s.MONTHS}