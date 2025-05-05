-- Example 3: SAVEPOINT with ROLLBACK TO
BEGIN TRANSACTION;

-- First salary update
UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpID = 1;

-- Create a savepoint
SAVE TRANSACTION IncreaseJohn;

-- Second salary update
UPDATE Employees
SET Salary = Salary + 1000
WHERE EmpID = 2;

-- Oops, rollback second increment only
ROLLBACK TRANSACTION IncreaseJohn;

-- Commit the remaining changes
COMMIT;