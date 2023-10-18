use AssignmentTwoDB

create procedure GeneratePayslip
    @EmployeeID int
as
begin
    declare @EmployeeName varchar(50)
    declare @Salary int
    declare @HRA int
    declare @DA int
    declare @PF int
    declare @IT int
    declare @Deductions int
    declare @GrossSalary int
    declare @NetSalary int

    select @EmployeeName = EMPNAME, @Salary = SAL
    from EMP
    where EMPNO = @EmployeeID

  
    set @HRA = 0.10 * @Salary
    set @DA = 0.20 * @Salary
    set @PF = 0.08 * @Salary
    set @IT = 0.05 * @Salary

    set @Deductions = @PF + @IT

    set @GrossSalary = @Salary + @HRA + @DA

    set @NetSalary = @GrossSalary - @Deductions

    print 'Employee Payslip for ' + @EmployeeName
    print 'Basic Salary: ' + cast(@Salary as varchar(20))
    print 'HRA: ' + cast(@HRA as varchar(20))
    print 'DA: ' + cast(@DA as varchar(20))
    print 'PF: ' + cast(@PF as varchar(20))
    print 'IT: ' + cast(@IT as varchar(20))
    print '--------------------------------------------'
    print 'Gross Salary: ' + cast(@GrossSalary as varchar(20))
    print 'Deductions: ' + cast(@Deductions as varchar(20))
    print '--------------------------------------------'
    print 'Net Salary: ' + cast(@NetSalary as varchar(20))
    print '------------------Thank You--------------------------'
end

select * from emp

exec GeneratePayslip @EmployeeID = 7369;
