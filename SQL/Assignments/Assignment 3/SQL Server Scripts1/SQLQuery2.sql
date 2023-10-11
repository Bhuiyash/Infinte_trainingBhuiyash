create Database AssignmentthreeDB
use AssignmentthreeDB

--we will create table EMP and DEPT
create table EMP
(
EMPNO int ,
EMPNAME varchar(50),
JOB varchar(50),
MGRID int,
HIREDATE date,
SAL int,
COMM int,
DEPTNO int

)
--now we create second table
create table DEPT (
    DEPTNO int,
    DNAME varchar(30),
    LOC varchar(30)
);


--inserting the values in both the tables.
insert into DEPT values (10, 'ACCOUNTING', 'NEW YORK'),
				(20, 'RESEARCH', 'DALLAS'),
				(30, 'SALES', 'CHICAGO'),
				(40,'OPERATIONS','BOSTON')

select * from DEPT

insert into EMP (EMPNO, EMPNAME, JOB, MGRID, HIREDATE, SAL, COMM, DEPTNO)
values
   
    (7369, 'SMITH', 'CLERK', 7902, CONVERT(DATE, '17-DEC-80', 5), 800, NULL, 20),
    (7499, 'ALLEN', 'SALESMAN', 7698, CONVERT(DATE, '20-FEB-81', 5), 1600, 300, 30),
    (7521, 'WARD', 'SALESMAN', 7698, CONVERT(DATE, '22-FEB-81', 5), 1250, 500, 30),
    (7566, 'JONES', 'MANAGER', 7839, CONVERT(DATE, '02-APR-81', 5), 2975, NULL, 20),
    (7654, 'MARTIN', 'SALESMAN', 7698, CONVERT(DATE, '28-SEP-81', 5), 1250, 1400, 30),
    (7698, 'BLAKE', 'MANAGER', 7839, CONVERT(DATE, '01-MAY-81', 5), 2850, NULL, 30),
    (7782, 'CLARK', 'MANAGER', 7839, CONVERT(DATE, '09-JUN-81', 5), 2450, NULL, 10),
    (7788, 'SCOTT', 'ANALYST', 7566, CONVERT(DATE, '19-APR-87', 5), 3000, NULL, 20),
    (7839, 'KING', 'PRESIDENT', NULL, CONVERT(DATE, '17-NOV-81', 5), 5000, NULL, 10),
    (7844, 'TURNER', 'SALESMAN', 7698, CONVERT(DATE, '08-SEP-81', 5), 1500, 0, 30),
    (7876, 'ADAMS', 'CLERK', 7788, CONVERT(DATE, '23-MAY-87', 5), 1100, NULL, 20),
    (7900, 'JAMES', 'CLERK', 7698, CONVERT(DATE, '03-DEC-81', 5), 950, NULL, 30),
    (7902, 'FORD', 'ANALYST', 7566, CONVERT(DATE, '03-DEC-81', 5), 3000, NULL, 20),
    (7934, 'MILLER', 'CLERK', 7782, CONVERT(DATE, '23-JAN-82', 5), 1300, NULL, 10);

select * from EMP;

--Queries



--1. Retrieve a list of MANAGERS. 
SELECT EMPNAME
FROM EMP
WHERE JOB = 'MANAGER';

--2. Find out the names and salaries of all employees earning more than 1000 per month. 
SELECT EMPNAME, SAL
FROM EMP
WHERE SAL > 1000;

--3. Display the names and salaries of all employees except JAMES. 
SELECT EMPNAME, SAL
FROM EMP
WHERE EMPNAME <> 'JAMES';

--4. Find out the details of employees whose names begin with ‘S’. 
SELECT *
FROM EMP
WHERE EMPNAME LIKE 'S%';

--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
SELECT EMPNAME
FROM EMP
WHERE EMPNAME LIKE '%A%';
--6. Find out the names of all employees that have ‘L’ as their third character in their name. 
SELECT EMPNAME
FROM EMP
WHERE SUBSTRING(EMPNAME, 3, 1) = 'L';

--7. Compute daily salary of JONES. 
SELECT EMPNAME, SAL / 30 AS DailySalary
FROM EMP
WHERE EMPNAME = 'JONES';


--8. Calculate the total monthly salary of all employees. 
SELECT SUM(SAL) AS TotalMonthlySalary
FROM EMP;

--9. Print the average annual salary . 
SELECT AVG(SAL * 12) AS AverageAnnualSalary
FROM EMP;

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
SELECT EMPNAME, JOB, SAL, DEPTNO
FROM EMP
WHERE DEPTNO = 30 AND JOB <> 'SALESMAN';

--11. List unique departments of the EMP table. 
SELECT DISTINCT DEPTNO
FROM EMP;

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
SELECT EMPNAME AS Employee, SAL AS "Monthly Salary"
FROM EMP
WHERE (DEPTNO = 10 OR DEPTNO = 30) AND SAL > 1500;

--13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
SELECT EMPNAME, JOB, SAL
FROM EMP
WHERE (JOB = 'MANAGER' OR JOB = 'ANALYST') AND SAL NOT IN (1000, 3000, 5000);

--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
SELECT EMPNAME, SAL, COMM
FROM EMP
WHERE COMM > SAL * 1.1;

--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
SELECT EMPNAME
FROM EMP
WHERE (EMPNAME LIKE '%L%L%' AND DEPTNO = 30) OR MGRID = 7782;

--16. Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees. 
select
	(select count(*) from EMP
				where datediff(year,hiredate,getdate()) between 30 and 40) 'Total'
				,EMPNAME as 'Total Employees',datediff(year,hiredate,getdate()) 'Experience' from emp
where datediff(year,hiredate,getdate()) between 30 and 40

--17. Retrieve the names of departments in ascending order and their employees in descending order. 
SELECT D.DNAME AS Department, E.EMPNAME AS Employee
FROM DEPT D
LEFT JOIN EMP E ON D.DEPTNO = E.DEPTNO
ORDER BY D.DNAME ASC, E.EMPNAME DESC;

--18. Find out experience of MILLER. 
SELECT EMPNAME, DATEDIFF(YEAR, HIREDATE, '2023-10-11') AS ExperienceInYears
FROM EMP
WHERE EMPNAME = 'MILLER';


