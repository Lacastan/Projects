USE SchoolAdmin

CREATE TABLE Student (
    StudentNumber bigint NOT NULL UNIQUE,
    FirstName varchar(255) NOT NULL,
    LastName varchar(255) NOT NULL,
    Id varchar(13) UNIQUE,
    CurrentGrade varchar(255) NOT NULL,
	Gender bit,
	PRIMARY KEY(StudentNumber)
);

CREATE TABLE Educator (
    EmployeeId int NOT NULL UNIQUE,
    FirstName varchar(255) NOT NULL,
    LastName varchar(255) NOT NULL,
    Id varchar(255) UNIQUE,
	PRIMARY KEY(EmployeeId)
);

CREATE TABLE Class (
    ClassId int NOT NULL UNIQUE,
    Name varchar(10) NOT NULL,
	PRIMARY KEY(ClassId)
);

CREATE TABLE Subject (
    SubjectId int NOT NULL UNIQUE,
    Name varchar(255) NOT NULL,
	PRIMARY KEY(SubjectId)
);

CREATE TABLE Assessment (
    AssessmentId int NOT NULL UNIQUE,
    Name varchar(255) NOT NULL,
	TotalMarks int,
	PRIMARY KEY(AssessmentId)
);

CREATE TABLE StudentSubject (
    StudentSubjectId int NOT NULL UNIQUE,
    ClassId int NOT NULL,
	StudentNumber bigint NOT NULL,
	EmployeeId int NOT NULL,
	PRIMARY KEY(StudentSubjectId),
	FOREIGN KEY(ClassId) REFERENCES Class(ClassId),
	FOREIGN KEY(StudentNumber) REFERENCES Student(StudentNumber),
	FOREIGN KEY(EmployeeId) REFERENCES Educator(EmployeeId)
);

CREATE TABLE StudentSubjectAssesment (
    StudentSubjectId int NOT NULL,
	AssessmentId int NOT NULL,
    ClassId int NOT NULL,
	StudentNumber bigint NOT NULL,
	EmployeeId int NOT NULL,
	PRIMARY KEY(StudentSubjectId, AssessmentId),
	FOREIGN KEY(AssessmentId) REFERENCES Assessment(AssessmentId),
	FOREIGN KEY(ClassId) REFERENCES Class(ClassId),
	FOREIGN KEY(StudentNumber) REFERENCES Student(StudentNumber),
	FOREIGN KEY(EmployeeId) REFERENCES Educator(EmployeeId)
);