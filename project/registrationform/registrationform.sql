use regestrationform
create table regs_form
(
ID int primary key identity(1,1) not null,
FirstName nvarchar(50) not null,
LastName nvarchar(100) not null,
Gender nvarchar(100) not null,
Address nvarchar(100) not null,
City nvarchar(100) not null,
State nvarchar(100) not null,
UserName nvarchar(100) not null,
Email nvarchar(100) not null,
Password nvarchar(100) not null
)
Select * from regs_form
create procedure sp_regs
(
@FirstName nvarchar(50), @LastName nvarchar(100), @Gender nvarchar(100), @Address nvarchar(100), @City nvarchar(100), @State nvarchar(100),
@UserName nvarchar(100), @Email nvarchar(100), @Password nvarchar(100)
)
as
begin
insert into regs_form(FirstName,LastName,Gender,Address,City,State,UserName,Email,Password) values (@FirstName,@LastName,@Gender,@Address,@City,@State,
@UserName,@Email,@Password)
end