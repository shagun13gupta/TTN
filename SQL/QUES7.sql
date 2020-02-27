

--QUES 7: Give examples of self,Inner,left outer,right outer joins.




select * from student;



          --self join query on table student

select s.name,stu.marks,s.roll_no
from student s,student stu
where s.marks<stu.marks

          --inner join on table student and test

select * from test


select stu.name,stu.roll_no,stu.marks,t.city,t.age
from student stu
join test t
on stu.name=t.name


          --left join on table student and test

select stu.name,stu.roll_no,stu.marks,t.city,t.age
from student stu
left join test t
on stu.name=t.name

         --right join on table student and test

select stu.name,stu.roll_no,stu.marks,t.city,t.age
from student stu
right join test t
on stu.name=t.name
