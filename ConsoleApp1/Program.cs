using System;

class Student
{
    // Масив оцінок за кредит з різних дисциплін (10 елементів)
    private int[] grades = new int[10];

    // Індексатор для доступу до оцінок
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < grades.Length)
            {
                return grades[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Невірний індекс");
            }
        }
        set
        {
            if (index >= 0 && index < grades.Length)
            {
                grades[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Невірний індекс");
            }
        }
    }

    // Метод для розрахунку середнього рейтингу студента
    public double CalculateAverageGrade()
    {
        int total = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            total += grades[i];
        }
        return (double)total / grades.Length;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        // Ініціалізація оцінок за допомогою індексатора
        student[0] = 85;
        student[1] = 90;
        student[2] = 78;
        student[3] = 88;
        student[4] = 92;
        student[5] = 75;
        student[6] = 80;
        student[7] = 85;
        student[8] = 95;
        student[9] = 82;

        // Розрахунок середнього рейтингу
        double averageGrade = student.CalculateAverageGrade();
        Console.WriteLine($"Середній рейтинг студента: {averageGrade:F2}");
    }
}
