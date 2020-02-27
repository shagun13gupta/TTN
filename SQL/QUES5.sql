

--QUES 5: How to create and invoke user defined functions ?

--SOLUTION:  


                  --STUDENT TABLE CREATION

create table student
( 
  ROLL_NO INT,
  NAME VARCHAR(20),
  MARKS INT
)

INSERT INTO student
VALUES(1,'SHAGUN',90)
INSERT INTO student
VALUES(2,'GAURAV',98)
INSERT INTO student
VALUES(3,'RAAZ',80)
INSERT INTO student
VALUES(4,'VAIBHAV',95)

                   --SCALAR VALUE FUNCTION CREATION

CREATE FUNCTION GETNAME(@RNO INT)
RETURNS VARCHAR(20)
AS
BEGIN
  RETURN (SELECT NAME from student where ROLL_NO=@RNO)
END
                   --EXECUTION OF GETNAME FUNCTION
				 
PRINT dbo.GETNAME(2)

                   --TABLE VALUE FUNCTION CREATION

CREATE FUNCTION GETSTUDENT(@MARK INT)
RETURNS TABLE
AS
  RETURN (SELECT *FROM student where MARKS>=@MARK)

                   --EXECUTION OF GETSTUDENT FUNCTION

SELECT * FROM GETSTUDENT(90)
