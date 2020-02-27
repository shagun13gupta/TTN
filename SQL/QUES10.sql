

--QUES 10: Difference between stored procedures and user defined functions. Explain with suitable examples.


 1) Functions returns the value whereas procedure does not return anything

 2) functions can have only input parameters whereas procedures can have input/output parameter

 3) functions allows select statement only whereas procedures allows select and DML statement.

 4) functions can be called from procedures whereas procedures cannot be called from functions.

 

           --STORED PROCEDURE

create proc UpdateTest_proc
(@Name varchar(20),
 @Age int
)
as
begin
update test set name=@Name where age=@Age
end

        --USER DEFINED FUNCTIONS

CREATE FUNCTION GETNAME(@RNO INT)
RETURNS VARCHAR(20)
AS
BEGIN
  RETURN (SELECT NAME from student where ROLL_NO=@RNO)
END
                  
	