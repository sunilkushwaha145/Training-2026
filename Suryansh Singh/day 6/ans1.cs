using System;
class Student{
    public int StudentId;
    public string StudentName;
    public int Age;
    public string Course;
    public void DisplayDetails(){
        Console.WriteLine("ID: " + StudentId);
        Console.WriteLine("Name: " + StudentName);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Course: " + Course);
        Console.WriteLine();
    }
    public void UpdateCourse(string courseName){
        Course = courseName;
    }
    public string GetStudentName(){
        return StudentName;
    }
    public int GetBirthYear(int currentYear){
        return currentYear - Age;
    }
}

class Program{
    static void Main(){
        Student s1 = new Student();
        s1.StudentId = 101;
        s1.StudentName = "Rahul";
        s1.Age = 20;
        s1.Course = "BCA";
        Student s2 = new Student();
        s2.StudentId = 102;
        s2.StudentName = "Aman";
        s2.Age = 21;
        s2.Course = "B.Tech";\
        Student s3 = new Student();
        s3.StudentId = 103;
        s3.StudentName = "Priya";
        s3.Age = 19;
        s3.Course = "MCA";
        s1.UpdateCourse("Computer Science");
        s1.DisplayDetails();
        Console.WriteLine("Student Name: " + s1.GetStudentName());
        Console.WriteLine("Birth Year: " + s1.GetBirthYear(2025));
    }
}