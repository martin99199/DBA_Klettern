
-- --------------------------------------------------
-- Einfügen von Grunddaten
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EF_FH_Verwaltung_Db];
GO

-- INSERT Daten in die Tabelle Offices

GO
SET IDENTITY_INSERT dbo.Offices ON
GO


INSERT INTO dbo.Offices (Id, Location)
VALUES (1, '201');
INSERT INTO dbo.Offices (Id, Location)
VALUES (2, '202');
INSERT INTO dbo.Offices (Id, Location)
VALUES (3, '203');
INSERT INTO dbo.Offices (Id, Location)
VALUES (4, '301');
INSERT INTO dbo.Offices (Id, Location)
VALUES (5, '302');
INSERT INTO dbo.Offices (Id, Location)
VALUES (6, '303');
INSERT INTO dbo.Offices (Id, Location)
VALUES (7, '401');
INSERT INTO dbo.Offices (Id, Location)
VALUES (8, '402');
INSERT INTO dbo.Offices (Id, Location)
VALUES (9, '403');
INSERT INTO dbo.Offices (Id, Location)
VALUES (10, '404');
INSERT INTO dbo.Offices (Id, Location)
VALUES (11, '425');

GO
SET IDENTITY_INSERT dbo.Offices OFF
GO


-- INSERT Daten in die Tabelle Persons

GO
SET IDENTITY_INSERT dbo.Persons ON
GO

INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (1, 'Froschauer', 'Roman', '2016-03-01', null);
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (2, 'Aicher', 'Anton', null, '2005-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (3, 'Fath', 'Susanne', null, '2001-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (4, 'Derndorfer', 'Clemens', '1997-10-01', null);
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (5, 'Rokitansky', 'Walter', '1997-10-01', null);
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (6, 'Kim', 'Choon', null, '2002-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (7, 'Kloner', 'Gerhard', null, '2003-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (8, 'Reitinger', 'Philipp', null, '2005-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (9, 'Sternberger', 'Franz', null, '2005-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (10, 'Willibald', 'Fritz', null, '2002-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (11, 'Lackner', 'Anna', null, '2004-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (12, 'Veck', 'Sue', null, '2000-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (13, 'Prunthaller', 'Patrick', null, '2003-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (14, 'Ensinger', 'Alexandra', null, '2000-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (15, 'Schwarz', 'Christian', null, '2004-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (16, 'Schneider', 'Johann', null, '2001-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (17, 'Zeinhofer', 'Robert', null, '2005-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (18, 'Stadlmann', 'Burkhart', '1997-03-01', null);
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (20, 'Fischer', 'Bruno', null, '2001-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (21, 'Aigner', 'Christoph', null, '2004-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (22, 'Holt', 'Markus', null, '2004-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (23, 'Untermayr', 'Alexander', null, '2005-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (24, 'König', 'Benedikt', null, '2001-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (25, 'Janko', 'Martin', null, '2005-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (26, 'Schiefermayr', 'Klaus', '2001-10-01', null);
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (27, 'Vorderberger', 'Hannes', null, '2002-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (28, 'Hallewell', 'Jean', '1999-03-01', null);
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (29, 'Weiss', 'Anton', null, '2001-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (30, 'Gruber', 'Peter', null, '2004-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (31, 'Unterrainer', 'Eva', null, '2003-09-01');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (32, 'Schweizer', 'Fiona', '2010-03-01', null);
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (33, 'Vaught', 'Douglas', '2001-10-01', null);
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (34, 'Grabner', 'Erika', null, '2003-01-30');
INSERT INTO dbo.Persons (Id, FamilyName, FirstName, HireDate, AdmissionDate)
VALUES (35, 'Egger', 'Martin', '2004-10-01', null);

GO
SET IDENTITY_INSERT dbo.Persons OFF
GO


-- INSERT Daten in die Tabelle Departments

GO
SET IDENTITY_INSERT dbo.Departments ON
GO


INSERT INTO dbo.Departments (Id, Name, Budget, StartingDate, DepartmentheadId)
VALUES (1, 'Elektrotechnik', 350000, '2007-09-01', 18);
INSERT INTO dbo.Departments (Id, Name, Budget, StartingDate, DepartmentheadId)
VALUES (2, 'Sprachen', 120000, '2007-09-01', 33);
INSERT INTO dbo.Departments (Id, Name, Budget, StartingDate, DepartmentheadId)
VALUES (3, 'Datenverarbeitung', 200000, '2007-09-01', 4);
INSERT INTO dbo.Departments (Id, Name, Budget, StartingDate, DepartmentheadId)
VALUES (4, 'Mathematik', 250000, '2007-09-01', 26);

GO
SET IDENTITY_INSERT dbo.Departments OFF
GO



-- INSERT Daten in die Tabelle Courses

GO
SET IDENTITY_INSERT dbo.Courses ON
GO


INSERT INTO dbo.Courses (Id, Title, EctsPoints, Department_Id)
VALUES (1050, 'C#', 1, 3);
INSERT INTO dbo.Courses (Id, Title, EctsPoints, Department_Id)
VALUES (1061, 'Datenbanken', 2, 3);
INSERT INTO dbo.Courses (Id, Title, EctsPoints, Department_Id)
VALUES (1045, 'Algorithmen und Datenstrukturen', 3, 3);
INSERT INTO dbo.Courses (Id, Title, EctsPoints, Department_Id)
VALUES (2030, 'Elektrotechnik', 1, 1);
INSERT INTO dbo.Courses (Id, Title, EctsPoints, Department_Id)
VALUES (2021, 'Mikroprozessortechnik', 2, 1);
INSERT INTO dbo.Courses (Id, Title, EctsPoints, Department_Id)
VALUES (2042, 'Regelungstechnik', 3, 1);
INSERT INTO dbo.Courses (Id, Title, EctsPoints, Department_Id)
VALUES (4022, 'Englisch', 2, 2);
INSERT INTO dbo.Courses (Id, Title, EctsPoints, Department_Id)
VALUES (4041, 'Spanisch', 3, 2);
INSERT INTO dbo.Courses (Id, Title, EctsPoints, Department_Id)
VALUES (4061, 'Russisch', 4, 2);
INSERT INTO dbo.Courses (Id, Title, EctsPoints, Department_Id)
VALUES (3141, 'Lineare Algebra', 1, 4);

GO
SET IDENTITY_INSERT dbo.Courses OFF
GO



-- INSERT Daten in die Tabelle Courses_OnlineCourse

GO
SET IDENTITY_INSERT dbo.Courses_OnlineCourse ON
GO


INSERT INTO dbo.Courses_OnlineCourse (Id, URL)
VALUES (2030, 'http://www.fineartschool.net/Poetry');
INSERT INTO dbo.Courses_OnlineCourse (Id, URL)
VALUES (2021, 'http://www.fineartschool.net/Composition');
INSERT INTO dbo.Courses_OnlineCourse (Id, URL)
VALUES (4041, 'http://www.fineartschool.net/Macroeconomics');
INSERT INTO dbo.Courses_OnlineCourse (Id, URL)
VALUES (3141, 'http://www.fineartschool.net/Trigonometry');

GO
SET IDENTITY_INSERT dbo.Courses_OnlineCourse OFF
GO


-- INSERT Daten in die Tabelle Courses_OnSiteCourse

GO
SET IDENTITY_INSERT dbo.Courses_OnSiteCourse ON
GO


INSERT INTO dbo.Courses_OnSiteCourse (Id, LectureRoom, Day, Time)
VALUES (1050, 'HS009', 'Montag', '11:30');
INSERT INTO dbo.Courses_OnSiteCourse (Id, LectureRoom, Day, Time)
VALUES (1061, 'HS123', 'Dienstag', '13:15');
INSERT INTO dbo.Courses_OnSiteCourse (Id, LectureRoom, Day, Time)
VALUES (1045, 'SR130','Mittwoch', '15:30');
INSERT INTO dbo.Courses_OnSiteCourse (Id, LectureRoom, Day, Time)
VALUES (4061, 'SR105', 'Donnerstag', '11:15');
INSERT INTO dbo.Courses_OnSiteCourse (Id, LectureRoom, Day, Time)
VALUES (2042, 'HS125', 'Freitag', '11:00');
INSERT INTO dbo.Courses_OnSiteCourse (Id, LectureRoom, Day, Time)
VALUES (4022, 'SR110', 'Mittwoch', '9:00');

GO
SET IDENTITY_INSERT dbo.Courses_OnlineCourse OFF
GO


-- INSERT Daten in die Tabelle PersonCourse

GO
SET IDENTITY_INSERT dbo.PersonCourse ON
GO


INSERT INTO dbo.PersonCourse(Courses_Id, Persons_Id)
VALUES (1050, 1);
INSERT INTO dbo.PersonCourse(Courses_Id, Persons_Id)
VALUES (1061, 31);
INSERT INTO dbo.PersonCourse(Courses_Id, Persons_Id)
VALUES (1045, 5);
INSERT INTO dbo.PersonCourse(Courses_Id, Persons_Id)
VALUES (2030, 4);
INSERT INTO dbo.PersonCourse(Courses_Id, Persons_Id)
VALUES (2021, 27);
INSERT INTO dbo.PersonCourse(Courses_Id, Persons_Id)
VALUES (2042, 25);
INSERT INTO dbo.PersonCourse(Courses_Id, Persons_Id)
VALUES (4022, 18);
INSERT INTO dbo.PersonCourse(Courses_Id, Persons_Id)
VALUES (4041, 32);
INSERT INTO dbo.PersonCourse(Courses_Id, Persons_Id)
VALUES (4061, 34);

GO
SET IDENTITY_INSERT dbo.PersonCourse OFF
GO


-- INSERT Daten in die Tabelle PersonOffice

GO
SET IDENTITY_INSERT dbo.PersonOffice ON
GO


INSERT INTO dbo.PersonOffice(Persons_Id, Offices_Id)
VALUES (1, 1);
INSERT INTO dbo.PersonOffice(Persons_Id, Offices_Id)
VALUES (4, 2);
INSERT INTO dbo.PersonOffice(Persons_Id, Offices_Id)
VALUES (5, 3);
INSERT INTO dbo.PersonOffice(Persons_Id, Offices_Id)
VALUES (18, 4);
INSERT INTO dbo.PersonOffice(Persons_Id, Offices_Id)
VALUES (25, 5);
INSERT INTO dbo.PersonOffice(Persons_Id, Offices_Id)
VALUES (27, 6);
INSERT INTO dbo.PersonOffice(Persons_Id, Offices_Id)
VALUES (31, 7);
INSERT INTO dbo.PersonOffice(Persons_Id, Offices_Id)
VALUES (32, 8);
INSERT INTO dbo.PersonOffice(Persons_Id, Offices_Id)
VALUES (34, 9);

GO
SET IDENTITY_INSERT dbo.PersonOffice OFF
GO


-- INSERT Daten in die Tabelle Enrollments


INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (2021, 2, 4);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (2030, 2, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (2021, 3, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (2030, 3, 4);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (2021, 6, 2);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (2042, 6, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (2021, 7, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (2042, 7, 4);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (2021, 8, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (2042, 8, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4041, 9, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4041, 10, null);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4041, 11, 2);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4041, 12, null);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4061, 12, null);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4022, 14, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4022, 13, 4);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4061, 13, 4);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4041, 14, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4022, 15, 2);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4022, 16, 2);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4022, 17, null);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4022, 19, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4061, 20, 4);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4061, 21, 2);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4022, 22, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4041, 22, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4061, 22, 2);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (4022, 23, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1045, 23, 1);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1061, 24, 4);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1061, 25, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1050, 26, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1061, 26, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1061, 27, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1045, 28, 2);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1050, 28, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1061, 29, 4);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1050, 30, 3);
INSERT INTO dbo.Enrollments (Course_Id, Person_Id, Grade)
VALUES (1061, 30, 4);



-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------