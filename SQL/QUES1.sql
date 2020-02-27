


-- QUES 1:  Create a table (datatype should be appropriate for each column).Insert data into table,Update one table data using join with other table (you can create another table   which takes the reference from the first table). Table structure should be like.
--    Id column should be primary key and identity,
--    EmpName,
--    Mobile number should have 10 digits apply constraint.
--    DateOfBirth,Address,salary,
--    ZIP code should be 6 digits long,
--    IsActive
--   CreatedDate,
--   ModifiedDate.

                   --// EMPLOYEE TABLE CREATION

create table EMPLOYEE
(
  EMP_ID int identity(100,1) PRIMARY KEY,
  EMP_NAME varchar(50),
  MOBILE_NO varchar(20) constraint TENDIGITS check(MOBILE_NO like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
  DOB date,
  EMP_ADDRESS varchar(20),
  SALARY money default NULL,
  ZIP_CODE int check (len(ZIP_CODE)=6),
  IS_ACTIVE bit,
  CREATED_DATE datetime default GETDATE(),
  MODIFIED_DATE datetime2
  
)

                  --INSERT DATA INTO TABLE EMPLOYEE

insert into EMPLOYEE(EMP_NAME,MOBILE_NO,DOB,EMP_ADDRESS,ZIP_CODE,IS_ACTIVE)
values('shagun','9868940221','1997-02-13','Badarpur',110044,1);

insert into EMPLOYEE(EMP_NAME,MOBILE_NO,DOB,EMP_ADDRESS,ZIP_CODE,IS_ACTIVE)
values('punita','8800996677','1996-04-05','Faridabad',110042,1);

insert into EMPLOYEE(EMP_NAME,MOBILE_NO,DOB,EMP_ADDRESS,ZIP_CODE,IS_ACTIVE)
values('latika','9878906567','1995-06-23','Janakpuri',110032,1);

insert into EMPLOYEE(EMP_NAME,MOBILE_NO,DOB,EMP_ADDRESS,ZIP_CODE,IS_ACTIVE)
values('neha','9475986567','1995-10-23','Akshardham',220032,1);

insert into EMPLOYEE(EMP_NAME,MOBILE_NO,DOB,EMP_ADDRESS,ZIP_CODE,IS_ACTIVE)
values('sonal','8878506598','1998-11-13','Allahabad',230466,1);

insert into EMPLOYEE(EMP_NAME,MOBILE_NO,DOB,EMP_ADDRESS,ZIP_CODE,IS_ACTIVE)
values('arpit','7878306467','1998-12-10','Ghaziabad',230032,1);

                 -- SALARY TABLE CREATION WHERE EMP_ID IS THE FOREIGN KEY REFRENCE TO EMPLOYEE TABLE

create table SALARY
(
  EMP_ID int FOREIGN KEY REFERENCES EMPLOYEE(EMP_ID),
  MONTHS varchar(20),
  SALARY money
)
 
                 --INSERT DATA INTO TABLE SALARY

insert into SALARY
values
(101,'JAN',30000)
insert into SALARY
values
(101,'FEB',25000)

insert into SALARY
values
(102,'MARCH',32000)
insert into SALARY
values
(102,'APRIL',22000)
insert into SALARY
values
(102,'SEPT',29000)

insert into SALARY
values
(100,'JAN',25000)
insert into SALARY
values
(100,'FEB',32000)
insert into SALARY
values
(100,'MARCH',38000)
insert into SALARY
values
(100,'APRIL',40000)

insert into SALARY
values
(103,'JAN',15000)
insert into SALARY
values
(103,'MARCH',22000)
insert into SALARY
values
(103,'APRIL',13000)

insert into SALARY
values
(104,'JULY',12000)
insert into SALARY
values
(104,'AUG',18000)
insert into SALARY
values
(104,'OCT',25000)
insert into SALARY
values
(104,'NOV',29000)

insert into SALARY
values
(105,'MAY',33000)
insert into SALARY
values
(105,'JUNE',39000)
insert into SALARY
values
(105,'JULY',21000)
insert into SALARY
values
(105,'AUG',29000)
insert into SALARY
values
(105,'SEPT',9000)




                  --GROUPING THE SALARY TABLE USING EMP_ID AND SUM OF THE SALARY

select emp_id,sum(salary)
from SALARY
group by EMP_ID

                  --CREATING THE VIEW OF THE ABOVE GROUP RESULT

create view [salary_view] as
select emp_id,sum(salary) total
from SALARY
group by EMP_ID

                  --VIEW THE SALARY_VIEW

select * from [salary_view]

                  --UPDATING THE SALARY COLUMN FROM SALARY_VIEW TO EMPLOYEE TABLE 

update employee 
set employee.salary=sal.total
from employee emp join salary_view sal on emp.emp_id=sal.EMP_ID

                    --SHOW EMPLOYEE TABLE

select * from EMPLOYEE

                    --SHOW SALARY TABLE

select * from SALARY
