using System;
using System.Collections.Generic;

class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Fee { get; set; }
}

interface IEnrollable
{
    void Enroll(Course course);
}

class User : IEnrollable
{
    public string Name { get; set; }
    public List<Course> EnrolledCourses { get; set; } = new List<Course>();

    public void Enroll(Course course)
    {
        EnrolledCourses.Add(course);
        Console.WriteLine($"Enrolled in {course.Title} for {course.Fee}");
    }

    public void Enroll(Course course, string couponCode)
    {
        decimal discount = couponCode == "SAVE50" ? 50 : 0;
        decimal finalFee = course.Fee - discount;
        EnrolledCourses.Add(course);
        Console.WriteLine($"Enrolled in {course.Title} with coupon for {finalFee}");
    }
}

class Program
{
    static void Main()
    {
        Course c1 = new Course { Id = 1, Title = "C# Basics", Fee = 1000 };
        Course c2 = new Course { Id = 2, Title = "OOP in C#", Fee = 1500 };

        User user = new User { Name = "Alice" };
        user.Enroll(c1);
        user.Enroll(c2, "SAVE50");
    }
}
