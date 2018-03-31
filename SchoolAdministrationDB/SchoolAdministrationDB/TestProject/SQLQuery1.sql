CREATE PROCEDURE AddNewStudent
(
	@StudentFirstName varchar(max),
	@StudentSurname varchar(max),
	@Id varchar(13),
	@CurrentGrade int,
	@Gender bit,
	@StudentNumber varchar(max) OUT
)
AS
BEGIN

EXEC CreateNewStudentNumber(@StudentNumber)

INSERT INTO dbo.Student(StudentNumber,
						FirstName,
						LastName,
						Id,
						CurrentGrade,
						Gender)
VALUES(@StudentNumber,
	   @StudentFirstName,
	   @StudentSurname,
	   @Id,
	   @CurrentGrade,
	   @Gender)

SELECT @StudentNumber

END