SELECT 
    Name,
    Department,
    Salary,
    AVG(Salary) OVER() AS AvgSalary  -- Calculates average salary across all rows
FROM Employees;