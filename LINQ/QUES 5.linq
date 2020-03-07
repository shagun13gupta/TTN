<Query Kind="Expression">
  <Connection>
    <ID>cc0e1ccb-41f3-47d2-b4dc-d6757a2e233c</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-V9BJ1OE</Server>
    <Database>DB_EMPLOYEE</Database>
  </Connection>
</Query>

// QUES 5: Write LINQ to get records using left join from two tables.



from s in Students
join t in Tests
on s.NAME equals t.Name into stu
from t in stu.DefaultIfEmpty()
select new {Rollno=s.ROLL_NO, Name=s.NAME, Marks=s.MARKS, Age=t.Age, City=t.City}