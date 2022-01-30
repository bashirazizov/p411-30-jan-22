--create database p411test

--drop database p411test2

--create database p411test2

--use p411test

--create table Students(
--	Id int,
--	--Name varchar(50),
--	Name nvarchar(50),
--	Surname nvarchar(50),
--	--BirthDate date
--)

--drop table Students

--alter table Students add Age int, GroupName nvarchar(20)

--alter table Students drop column GroupName

--exec sp_rename "Students","Stu"

--exec sp_rename "Stu","Students"

--exec sp_rename "Students.Surname","Lastname"

--insert into Students values(10,'Mamed','Aliyev', 25)

--insert into Students values(8,'Isa','Musayev', 25)
--insert into Students values(8,'Rasim','Balayev', 25)

--insert into Students values(1,'Sevda','Alakberzade', 40),(1,'Aygun','Kazimova', 40)

--insert into Students(Id,Name) values(1,'Nicat')

--insert into Students values(8,'Rasim','Balayev', 25, '10.01.2021')

--SELECT * FROM Students
--where Name like 's%' and Name like '%a'and Lastname like '%z%'
--where Id!=8
--where Id in(8,25)
--where Id Between 10 and 100
--where Name = 'Rasim' or Id>5
--where Name = 'Rasim' and Id>10
--where id=1
--where Id>5
--where Name = 'Rasim'

--select Id, Name from Students

--update Students set Name = 'Mamed'
--where Id = 25

--delete from Students

--SELECT Name "Firstname", Lastname FROM Students

--SELECT Upper(Name) "Firstname to upper" FROM Students

--SELECT Charindex('m',Name) "index of m at Firstname" FROM Students

--Select max(Age) "En Boyuk yas" from Students
--Select min(Age) "En Kicik yas" from Students
--Select avg(Age) "Orta yas" from Students

--Select Name from Students where Age = (Select max(Age) from Students)

