create database AssignmentFourDB
use AssignmentFourDB
--Question One
declare @x int
declare @result int
set @x = 5 
set @result = 1
while @x > 1
begin
    set @result = @result * @x
    set @x = @x - 1
end
select @result as factorial



--Question Three.

