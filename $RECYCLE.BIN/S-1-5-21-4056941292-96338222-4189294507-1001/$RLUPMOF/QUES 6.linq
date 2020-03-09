<Query Kind="Expression">
  <Connection>
    <ID>cc0e1ccb-41f3-47d2-b4dc-d6757a2e233c</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-V9BJ1OE</Server>
    <Database>DB_EMPLOYEE</Database>
  </Connection>
</Query>

// QUES 6:  Write LINQ to perform aggregate function Count, Max, Min, Average on the table.



(from e in EMPLOYEEs
select e.EMP_NAME).Count()

(from e in EMPLOYEEs
select e.SALARY).Max()

EMPLOYEEs.Max(e=>e.SALARY)   //LAMBDA EXPRESSION

(from e in EMPLOYEEs
select e.SALARY).Min()

EMPLOYEEs.Min(e=>e.SALARY)   //LAMDA EXPRESSION

(from e in EMPLOYEEs
select e.SALARY).Average()

EMPLOYEEs.Average(e=>e.SALARY)