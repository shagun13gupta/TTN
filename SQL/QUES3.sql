

--QUES 3:  How data can be copied from one table to another table ? 

--SOLUTION: 

select * from test


            --CREATING NEW TABLE i.e COPY_TEST

create table copy_test
( name varchar(20),
  age int,
  city varchar(20)
)
            --COPYING DATA FROM TEST TABLE TO COPY_TEST TABLE

insert into copy_test
select * from test

select * from copy_test