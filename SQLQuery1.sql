Create database Company;
use Company;



Create table Employe(
Eno int NOt null,
Ename varchar(60),
Salary int,
Designation varchar(30),
Depno int,
Primary Key(Eno)
);

select * from Employe;

create table Department(
Depno int not null,
Dname varchar(50),
Dloc varchar(50),
Primary key(Depno)
);
select * from Department;

Create Procedure GetEmpUsingEmpno

AS
BEGIN
Set Nocount on;
Select * from employe 
End
Go
 

 exec GtEmpUsingEmpno 2;

create Procedure DeleteEmp
(@Eno int)
As
Begin
Set Nocount on;
Delete From Employe where Eno=@Eno
End
go

create Procedure InsertEmp
(@Eno int,@Ename varchar (50),
@Salary int,
@Designation varchar(60),
@Depno int
)
As
Begin
Set Nocount on;
insert into Employe values(@Eno,@Ename,@Salary,@Designation,@Depno)
End
Go

exec InsertEmp 2,'Rahul',30000,'Cleark',2;

insert into Department values (1,'Sales','Mumbai');
insert into Department values (2,'Marketing','Mumbai');
insert into Department values (3,'Developer','Pune');

CREATE PROCEDURE updateEmp
(@Eno int,@Ename varchar (50),
@Salary int,
@Designation varchar(60),
@Depno int
)
As
Begin
Update Employe 
set Ename=@Ename,Salary=@Salary,Designation=@Designation,Depno=@Depno
where Eno=@Eno
End
go


