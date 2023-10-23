--sql code for ado code- Bhuiyash kumar

create database codeBasedSql
use codeBasedSql

create table Code_Employee (
    empno int primary key,
    empname varchar(35) NOT NULL,
    empsal numeric(10,2) check (empsal >= 25000),
    emptype char(1) check (emptype IN ('F', 'P'))
);
create procedure AddEmployee
    @empname varchar(35),
    @empsal numeric(10,2),
    @emptype char(1)
as
begin
    declare @new_empno int;
    -- Generate a new employee number
    select @new_empno = COALESCE(MAX(empno), 0) + 1 from Code_Employee;
    -- Insert the new employee record
    insert into Code_Employee (empno, empname, empsal, emptype)
    values (@new_empno, @empname, @empsal, @emptype);
end;
select *from Code_Employee
