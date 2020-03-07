<Query Kind="Expression">
  <Connection>
    <ID>cc0e1ccb-41f3-47d2-b4dc-d6757a2e233c</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-V9BJ1OE</Server>
    <Database>DB_EMPLOYEE</Database>
  </Connection>
</Query>

// QUES 8: Write LINQ to differentiate First and FirstOrDefault and display both the result.


(from s in Students 
where s.ROLL_NO==1
select new{s.ROLL_NO,s.NAME,s.MARKS}).First()

Students.First(t=>t.ROLL_NO==1)      //LAMBDA EXPRESSION

(from s in Students 
where s.ROLL_NO==6
select new{s.ROLL_NO,s.NAME,s.MARKS}).FirstOrDefault()

Students.FirstOrDefault(t=>t.ROLL_NO==6)    //LAMBDA EXPRESSION