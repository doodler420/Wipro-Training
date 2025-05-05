SELECT COUNT(*) AS TotalStudents FROM Students;
SELECT AVG(Marks) AS AverageMarks FROM Students;
SELECT Department, MAX(Salary) AS HighestSalary
FROM Employees
GROUP BY Department;