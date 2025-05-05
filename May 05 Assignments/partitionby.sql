SELECT  
    Name,  
    Department,  
    Salary,  
    AVG(Salary) OVER(PARTITION BY Department) AS DeptAvgSalary  
FROM Employees;
--This query calculates the average salary for each department separately while preserving all individual employee records, unlike GROUP BY which would collapse the results.
-- The PARTITION BY clause divides the data into departmental groups before applying the AVG() function.

