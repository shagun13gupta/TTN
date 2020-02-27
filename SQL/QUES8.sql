
--QUES 8:Create and invoke one stored procedure from another stored procedure.


select * from student
select * from test

                 --CREATING THE FIRST PROCEDURE i.e UPDATE PROCEDURE
				 

create proc UpdateTest_proc
(@Name varchar(20),
 @Age int
)
as
begin
update test set name=@Name where age=@Age
end


                  --CREATING THE SECOND PROCEDURE WHERE I AM CALLING THE FIRST PROCEDURE INSIDE


create proc CallUpdate_proc
(
 @TName varchar(20),
 @TAge int
)
as
begin
exec UpdateTest_proc @Name=@TName , @Age=@TAge
end


                      --EXECUTING THE SECOND PROCEDURE

exec CallUpdate_proc @TName='gaurav' ,@TAge=21


