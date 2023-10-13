use AssignmentFourDB

--Question Two

create procedure generate_multiplication_table
    @x int
as
begin
    declare @y int
    set @y = 1

    while @y <= @x
    begin
        declare @result int
        set @result = @y * @x

        print cast(@y as varchar) + ' x ' + cast(@x as varchar) + ' = ' + cast(@result as varchar)
        
        set @y = @y + 1
    end
end

execute generate_multiplication_table @x = 5

