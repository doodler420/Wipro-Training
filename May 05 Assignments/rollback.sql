begin transaction;
delete from Students where Marks<60;
 

--if there is a mistake
rollback;