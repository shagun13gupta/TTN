

--QUES 9: Difference b/w having clause and where clause provide examples.




--Having clause is used with the aggregate functions because where clause cannot be used with aggregate functions.
--Where clause works on Rows data not on aggregated data.


--WHERE clause works as a pre filter whereas HAVING clause works as a post filter..


select * from student
where name='shagun'

select * from SALARY

select emp_id
from SALARY
group by EMP_ID
having count(emp_id)>3


