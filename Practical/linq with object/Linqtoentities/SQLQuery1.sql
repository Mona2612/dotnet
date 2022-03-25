
Create database db_employee  
use db_employee  
CREATE TABLE [dbo].[EmployeeDetails](  
  
[EmpId]  INT IDENTITY (1, 1) NOT NULL,  
  
[EmpName]  VARCHAR (50) NULL,  
  
[Location] VARCHAR (50) NULL,  
  
[Gender] VARCHAR (20) NULL  
  
PRIMARY KEY CLUSTERED ([EmpId] ASC)  
  
);  
insert into EmployeeDetails(EmpName,Location,Gender) values('Vaishali','Noida','Female')  
insert into EmployeeDetails(EmpName,Location,Gender) values('Shalu','Gurgaon','Female')  
insert into EmployeeDetails(EmpName,Location,Gender) values('Arpita','Gurgaon','Female')  
Select *From EmployeeDetails