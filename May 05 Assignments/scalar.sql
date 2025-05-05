SELECT FirstName, UPPER(FirstName) AS UpperName FROM Students;
SELECT FirstName, DATEDIFF(YEAR, DOB, GETDATE()) AS Age FROM Students;
SELECT Name, ROUND(Salary, -3) AS RoundedSalary FROM Employees;