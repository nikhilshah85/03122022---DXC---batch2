CREATE TABLE EmployeeInfo
(
	empNo INT NOT NULL PRIMARY KEY,
	empName varchar(20),
	empDesignation varchar(20),
	empSalary int,
	empIsPermenant bit
)

insert into EmployeeInfo values(101,'Nikhil','Sales',5000,1)
insert into EmployeeInfo values(102,'Nikhil','Sales',5000,1)
insert into EmployeeInfo values(103,'Nikhil','Sales',5000,1)
insert into EmployeeInfo values(104,'Nikhil','Sales',5000,1)
insert into EmployeeInfo values(105,'Nikhil','Sales',5000,1)


create table Products
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit)

insert into Products values(501,'Pepsi','Cold-Drink',50,1)

insert into Products values(502,'Pepsi','Cold-Drink',50,1)

insert into Products values(503,'Pepsi','Cold-Drink',50,1)

insert into Products values(504,'Pepsi','Cold-Drink',50,1)
insert into Products values(505,'Pepsi','Cold-Drink',50,1)




