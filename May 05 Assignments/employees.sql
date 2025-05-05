CREATE TABLE Employees (
    EmpID INT PRIMARY KEY,
    Name VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2),
    JoinDate DATE
);
INSERT INTO Employees (EmpID, Name, Department, Salary, JoinDate)
VALUES
    (1, 'John', 'HR', 50000.00, '2021-06-01'),
    (2, 'Priya', 'Finance', 60000.00, '2020-09-15'),
    (3, 'Amit', 'IT', 75000.00, '2019-01-10'),
    (4, 'Sara', 'IT', 72000.00, '2023-02-25');