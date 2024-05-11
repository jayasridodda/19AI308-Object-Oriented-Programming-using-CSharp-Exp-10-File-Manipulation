using System;
struct student
{
    public string name;
    public int age;
    public int marks;
};

class Program
{
    static void Main(string[] args)
    {
        student[] s = new student[5];
        for (int i = 0; i < 5; i++)
        {
            
           s[i].name = Console.ReadLine();
           s[i].age = Convert.ToInt32(Console.ReadLine());
            s[i].marks = Convert.ToInt32(Console.ReadLine());
        }
       
        string path = @"C:\studentInfo.txt";
        using (StreamWriter sw = File.AppendText(path))
        {
            for (int i = 0; i < 5; i++)
            {
                sw.WriteLine(s[i].name + " " + s[i].age + " " + s[i].marks);
            }
        }
        Console.WriteLine(File.ReadAllText(path));
    }
}
