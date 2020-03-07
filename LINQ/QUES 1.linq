<Query Kind="Expression">
  <Connection>
    <ID>cc0e1ccb-41f3-47d2-b4dc-d6757a2e233c</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-V9BJ1OE</Server>
    <Database>DB_EMPLOYEE</Database>
  </Connection>
</Query>



//QUES 1: Write LINQ syntax and define each term of the syntax.


// 1) QUERY SYNTAX

from e in EMPLOYEEs
where e.EMP_ID==100
select e


// 2) METHOD SYNTAX

EMPLOYEEs.Where(x=>x.EMP_ID==100).ToList()


// 3) MIXED SYNTAX


(from e in EMPLOYEEs
select e).Skip(2)

