

--QUES 2: How to update column name of table ?

--SOLUTION: 

--using ALTER we can update the column name of the table

--ALTER TABLE TABLENAME
--RENAME COLUMN NAME TO NEW NAME


create table test
( name varchar(20),
  age int,
  city varchar(20)
  )

select * from test

insert into test
values
('shagun',22,'delhi')
insert into test
values
('sonal',21,'allahabad')
insert into test
values
('punita',23,'faridabad')
insert into test
values
('neha',24,'akshardham')




sp_rename 'copy_test.name', 'username' , 'COLUMN';

select * from copy_test