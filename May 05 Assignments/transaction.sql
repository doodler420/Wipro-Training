begin transaction;
update Employees set Salary=Salary + 2000 where department='IT';
commit;