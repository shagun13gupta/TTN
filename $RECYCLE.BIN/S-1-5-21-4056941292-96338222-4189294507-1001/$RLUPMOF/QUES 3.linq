<Query Kind="Expression">
  <Connection>
    <ID>cc0e1ccb-41f3-47d2-b4dc-d6757a2e233c</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-V9BJ1OE</Server>
    <Database>DB_EMPLOYEE</Database>
  </Connection>
</Query>

// QUES 3:  Write LINQ to get the top two records from the table and perform sorting in descending order.



(from t in EMPLOYEEs
orderby t.EMP_ID descending
select t).Take(2)