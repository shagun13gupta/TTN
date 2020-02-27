

--QUES 4: What are the benefits of using views also give an example ?

--SOLUTION:  

--views are the virtual table . It is used in such cases when we want to show limited amount of data to the user.
--Views are used to only display the required data.View is used to hide the complexity of the databases table.


create view [test_view] as
select name,city
from test

select * from [test_view]