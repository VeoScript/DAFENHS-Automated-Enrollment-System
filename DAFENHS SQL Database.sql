create database DAFENHS 

use DAFENHS   

--Table for the Registration of Security Features
create table RegisterSecurityAccount
(
	ID_Number varchar(50) NOT NULL PRIMARY KEY,
	Fullname varchar(50) NOT NULL,
	Position varchar(50) NOT NULL,
	Account_Username varchar(50) NOT NULL,
	Account_Password varchar(50) NOT NULL,
	Account_Type varchar(50) NOT NULL,
	CONSTRAINT uni_important UNIQUE (Fullname, Account_Username)
);   

select * from  RegisterSecurityAccount  
insert into RegisterSecurityAccount values('1510399-1', 'Jerome Joseph R. Villaruel', 'Administrator', 'jeromevillaruel', 'jerome17', 'ADMIN')

--Table for the Registration of Junior Highschool Student
create table StudentRegistration_JuniorHighschool
(
	LRN varchar(50) PRIMARY KEY,
	StudentImage image NOT NULL,
	LastName varchar(50) NOT NULL,
	FirstName varchar(50) NOT NULL,
	MiddleName varchar(50) NOT NULL,
	Gender varchar(50) NOT NULL,
	Age int NOT NULL,
	Student_Address varchar(100) NOT NULL,
	Birthdate varchar(50) NOT NULL,
	BirthPlace varchar(50) NOT NULL,
	Name_Father varchar(50) NOT NULL,
	Name_Mother varchar(50) NOT NULL,
	Name_Guardian varchar(50),
	Guradian_Relationship varchar(50),
	CONSTRAINT u_JuniorFullname UNIQUE (LastName, FirstName, MiddleName)
);  


select LRN from StudentRegistration_JuniorHighschool where LRN='122022100059'
delete from StudentRegistration_JuniorHighschool where  LRN='122022100059'
update StudentRegistration_JuniorHighschool set LRN = '122319100007' where LastName='Catig'
delete from StudentRegistration_JuniorHighschool

--Table for the Registration of Senior Highschool Student
create table StudentRegistration_SeniorHighschool
(
	LRN varchar(50) PRIMARY KEY,
	StudentImage image NOT NULL,
	LastName varchar(50) NOT NULL,
	FirstName varchar(50) NOT NULL,
	MiddleName varchar(50) NOT NULL,
	Gender varchar(50) NOT NULL,
	Age int NOT NULL,
	Student_Address varchar(100) NOT NULL,
	Birthdate varchar(50) NOT NULL,
	BirthPlace varchar(50) NOT NULL,
	Name_Father varchar(50) NOT NULL,
	Name_Mother varchar(50) NOT NULL,
	Name_Guardian varchar(50),
	Guradian_Relationship varchar(50)
	CONSTRAINT u_SeniorFullname UNIQUE (LastName, FirstName, MiddleName)
); 

select * from StudentRegistration_SeniorHighschool

--Table for Enrollment Status of Junior Highschool
create table EnrollmentStatus_JuniorHighschool
(
	LRN varchar(50) NOT NULL FOREIGN KEY REFERENCES StudentRegistration_JuniorHighschool(LRN) PRIMARY KEY,
	Gender varchar(50) NOT NULL,
	GradeLevel int NOT NULL,
	Section varchar(50) NOT NULL,
	SchoolYear varchar(50) NOT NULL,
	Class_Advisory varchar(50) NOT NULL,
	Class_Schedule varchar(255) NOT NULL
); 

select * from EnrollmentStatus_JuniorHighschool
select count(LRN) as 'Total' from EnrollmentStatus_JuniorHighschool where Section='Rizal' AND GradeLevel=7 AND SchoolYear='2016-2017'
delete from EnrollmentStatus_JuniorHighschool where LRN = '1510399-1'
delete from EnrollmentStatus_JuniorHighschool
drop table EnrollmentStatus_JuniorHighschool
 
 
SELECT
  SUM(CASE WHEN Gender = 'Male' THEN 1 ELSE 0 END) as MaleCount,
  SUM(CASE WHEN Gender = 'Female' THEN 1 ELSE 0 END) as FemaleCount,
  COUNT(*) as TotalCount
FROM StudentRegistration_JuniorHighschool

--select EnrollmentStatus_JuniorHighschool.LRN, StudentRegistration_JuniorHighschool.LastName, StudentRegistration_JuniorHighschool.Gender from EnrollmentStatus_JuniorHighschool inner join StudentRegistration_JuniorHighschool on EnrollmentStatus_JuniorHighschool.LRN = StudentRegistration_JuniorHighschool.LRN, SUM(CASE WHEN Gender = 'Male' THEN 1 ELSE 0 END) as MaleCount, SUM(CASE WHEN Gender = 'Female' THEN 1 ELSE 0 END) as FemaleCount, COUNT(*) as TotalCount FROM StudentRegistration_JuniorHighschool


--Table for Enrollment Status of Senior Highschool
create table EnrollmentStatus_SeniorHighschool
(
	LRN varchar(50) NOT NULL FOREIGN KEY REFERENCES StudentRegistration_SeniorHighschool(LRN),
	Gender varchar(50) NOT NULL,
	Track varchar(50) NOT NULL,
	GradeLevel int NOT NULL,
	Section varchar(50) NOT NULL,
	SchoolYear varchar(50) NOT NULL,
	Class_Advisory varchar(50) NOT NULL,
	Class_Schedule varchar(255) NOT NULL
);  

SELECT EnrollmentStatus_SeniorHighschool.LRN AS 'LRN', StudentRegistration_SeniorHighschool.LastName AS 'Last', StudentRegistration_SeniorHighschool.FirstName AS 'First', StudentRegistration_SeniorHighschool.MiddleName AS 'Middle', StudentRegistration_SeniorHighschool.Gender AS 'Gender', StudentRegistration_SeniorHighschool.Age AS 'Age', StudentRegistration_SeniorHighschool.Student_Address AS 'Address', StudentRegistration_SeniorHighschool.Birthdate AS 'Birth Date', StudentRegistration_SeniorHighschool.BirthPlace AS 'Birth Place', StudentRegistration_SeniorHighschool.Name_Father AS 'Father', StudentRegistration_SeniorHighschool.Name_Mother AS 'Mother', StudentRegistration_SeniorHighschool.Name_Guardian AS 'Guardian', StudentRegistration_SeniorHighschool.Guradian_Relationship AS 'Relationship' FROM StudentRegistration_SeniorHighschool INNER JOIN EnrollmentStatus_SeniorHighschool ON StudentRegistration_SeniorHighschool.LRN = EnrollmentStatus_SeniorHighschool.LRN WHERE Track='GAS' AND Section='1' AND GradeLevel='11' AND SchoolYear='2016-2017'

select * from EnrollmentStatus_SeniorHighschool
delete from EnrollmentStatus_SeniorHighschool
drop table EnrollmentStatus_SeniorHighschool

--Table for the Registration of the Teachers
create table Register_Teachers
(
	ID_Number varchar(50) NOT NULL PRIMARY KEY,
	FullName varchar(50) NOT NULL Unique,
	Gender varchar(50) NOT NULL,
	Position varchar(50) NOT NULL,
	Teacher_Rank varchar(50) NOT NULL 
); 

--Table for the Registration of the Section
create table Register_Section
(
	MySection varchar(50) NOT NULL PRIMARY KEY, 
	Category varchar(50) NOT NULL,
	Track varchar(50)
);  

--Table for the Registration of the Subjects
create table Register_Subject
(
	GradeLevel int NOT NULL,
	MySubject varchar(100) NOT NULL,
	Category varchar(50) NOT NULL
);

--Table for the Registration of the ClassSchedule
create table Class_Schedule
(
	MySubject varchar(100) NOT NULL,
	MyTime varchar(50) NOT NULL,
	Teacher varchar(100) NOT NULL,
	Category varchar(50),
	GradeLevel int,
	SchoolYear varchar(50),
	Section varchar(50),
	Track varchar(50)
	CONSTRAINT uni_First UNIQUE (SchoolYear, MyTime, Teacher),
	CONSTRAINT uni_Second UNIQUE (GradeLevel, Section, SchoolYear, MySubject),
	CONSTRAINT uni_Third UNIQUE (GradeLevel, Section, SchoolYear, MyTime),
	CONSTRAINT uni_Fourth UNIQUE (SchoolYear, MyTime, Teacher, Track),
	CONSTRAINT uni_Fifth UNIQUE (GradeLevel, Section, SchoolYear, MySubject, Track),
	CONSTRAINT uni_Sixth UNIQUE (GradeLevel, Section, SchoolYear, MyTime, Track),
);

select * from Class_Schedule
delete from Class_Schedule
drop table Class_Schedule

--Table for the Searching Features
create table ClassList
(
	SchoolYear varchar(50) NOT NULL,
	GradeLevel int NOT NULL,
	Section varchar(50) NOT NULL,
	Student_Male int NOT NULL,
	Student_Female int NOT NULL,
	Student_Total int NOT NULL
);

select * from ClassList

--Table for the Assigning of Teachers and Subjects
create table Class_Subject_Teacher
(
	GradeLevel int NOT NULL,
	Section varchar(50) NOT NULL,
	MySubject varchar(100) NOT NULL,
	MyTeacher varchar(100) NOT NULL,
	SchoolYear varchar(50) NOT NULL
);

--Table for the Class Advisory
create table Class_Advisory_Junior
(
	GradeLevel int NOT NULL,
	Section varchar(50) NOT NULL,
	Adviser varchar(100) NOT NULL,
	SchoolYear varchar(50) NOT NULL
	Constraint uni_AdviserJunior UNIQUE (SchoolYear, Section, Adviser, GradeLevel)
); 

create table Class_Advisory_Senior
(
	GradeLevel int NOT NULL,
	Section varchar(50) NOT NULL,
	Adviser varchar(100) NOT NULL,
	SchoolYear varchar(50) NOT NULL,
	Track varchar(50)
	Constraint uni_AdviserSenior UNIQUE (SchoolYear, Section, Adviser, GradeLevel, Track)
); 

drop table Class_Advisory_Junior

drop table Class_Advisory_Senior

select * from StudentRegistration_JuniorHighschool 
select * from StudentRegistration_SeniorHighschool
select * from EnrollmentStatus_JuniorHighschool 
select * from EnrollmentStatus_SeniorHighschool
select * from Register_Teachers
select * from Register_Subject
select * from Class_Subject_Teacher
select * from Class_Advisory_Senior
select * from Class_Advisory_Junior

delete from Class_Advisory_Junior where Adviser='Mrs. D. Labita'

delete from StudentRegistration_JuniorHighschool 
delete from StudentRegistration_SeniorHighschool
delete from EnrollmentStatus_JuniorHighschool 
delete from EnrollmentStatus_SeniorHighschool
delete from Register_Teachers
delete from Register_Subject
delete from Register_Section
delete from Class_Subject_Teacher
delete from Class_Advisory

select LRN from StudentRegistration_JuniorHighschool

select GradeLevel, Section, SchoolYear from EnrollmentStatus_JuniorHighschool

select LRN from StudentRegistration_JuniorHighschool where LRN='122321100008'

update StudentRegistration_JuniorHighschool set LRN='122321100026' where LRN='122321100008'