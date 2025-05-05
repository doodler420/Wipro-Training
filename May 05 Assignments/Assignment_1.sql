create procedure HigherEndProducts as
begin
	select * from Products where Price>60000;
end;
