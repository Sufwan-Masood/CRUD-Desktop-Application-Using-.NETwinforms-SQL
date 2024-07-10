Create Database WINFORM_DB;

Create Table LOGIN_TABLE(
USERNAME varchar (255) not null,
PASS	varchar (255) not null
);

Insert into LOGIN_TABLE (USERNAME,PASS)
Values ('Qasim','123'),
		('saim','456');

Select * from LOGIN_TABLE;
select * from BIO_DATA;

--CRUD APPLICATION
CREATE TABLE Info(
Id int primary key,
_Name varchar (255),
Gender varchar (255),
Age int ,
Designation varchar (255),
Salary int);

select * from info;
insert into info values (122,'sjkb','dds',30,'yvatu',8777);

update info 
set id= 122, _Name='dhbkj',Gender='hak',Age=20,Salary=12
where Id = 122;