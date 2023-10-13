 use AssignmentFourDB
 --question three
create Table Holiday(
holiday_date Date,
holiday_name NVARCHAR(100)
);
Insert into Holiday(holiday_date, holiday_name)
values
('2023-12-25', 'Christmas'),
('2023-07-28', 'Eid'),
('2023-09-05', 'Pongal'),
('2023-11-12', 'Diwali'),
('2023-08-15', 'Independence Day'),
('2023-03-13', 'Holi')
select * from Holiday
create or alter trigger HolidayManipulationErrorTrigger
on holiday
after insert, update, delete
as
begin
    declare @holidayMessage nvarchar(100);
    declare @errorMessage nvarchar(200); 

    if exists (select 1 from holiday where holiday_date in (select holiday_date from inserted)) begin
        select @holidayMessage = holiday_name from holiday where holiday_date in (select holiday_date from inserted);
        select @errorMessage = 'Due to ' + @holidayMessage + ' You cannot manipulate data';
        rollback;
        raiserror(@errorMessage, 16, 1)
    end
end
update Holiday set holiday_name = 'Independence Day' where holiday_date='2023-12-25';

 