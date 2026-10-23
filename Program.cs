Console.Write("Сколько студентов в группе? ");
int studentCount = int.Parse(Console.ReadLine());
int[] grades = new int[studentCount];

double sum = 0;

for (int i = 0; i < grades.Length; i++)
{
   Console.Write($"Оценка студента{i + 1}: ");
   grades[i] = int.Parse(Console.ReadLine());
   sum += grades[i];
}
foreach (int grade in grades)
{
   Console.WriteLine(grade);
}
double a = sum / studentCount;
Console.WriteLine($"Средний балл группы: {a}");




int[] points = { 4, 7, 2, 9, 5 };

for (int i = 0; i < points.Length; i++)
{
   if (points[i] < 10)
   {
      points[i] = points[i] + 1;
   }

}

foreach (int point in points)
{
   Console.WriteLine(point);
}




int[] grades = { 4, 5, 3, 5, 4, 2 };

for (int i = 0; i < grades.Length - 1; i++)
{
   for (int j = 0; j < grades.Length - 1 - i; j++)
   {
      if (grades[j] < grades[j + 1])
      {

         int temp = grades[j];
         grades[j] = grades[j + 1];
         grades[j + 1] = temp;
      }
   }
}

foreach (int grade in grades)
{
   Console.WriteLine(grade);
}


int[] GenerateScheduleSlots(int lessonsCount)
{
   int[] slots = new int[lessonsCount];

   for (int i = 0; i < lessonsCount; i++)
   {
      slots[i] = (i + 1)*2;
   }

   return slots;
}

int[] slots = GenerateScheduleSlots(6);

foreach (int slot in slots)
{
   Console.WriteLine(slot);
}




int[] grades = { 4, 5, 3, 5, 4, 2 };
Array.Sort(grades);

foreach (int grade in grades)
{
   Console.WriteLine(grade);
}

//А








