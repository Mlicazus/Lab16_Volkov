// Console.Write("Сколько студентов в группе?");
// int studentCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentCount];
// int sum = 0;
// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
//     sum += grades[i];
// }
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }
// Console.WriteLine($"Средний балл: {sum / grades.Length}");

// int[] points = { 4, 10, 2, 9, 5 };
// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//         points[i] += 1;
//     }
// }
// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };
// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }
//     return slots;
// }
// int[] slots = GenerateScheduleSlots(8);
// int countEven = 0;
// foreach (int even in slots)
// {
//     if (even % 2 == 0)
//     {
//         countEven++;
//     }
// }
// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] slotsEven = new int[countEven];
//     int index = 0;
//     for (int j = 0; j < lessonsCount; j++)
//     {
//         if (slots[j] % 2 == 0)
//         {
//             slotsEven[index] = slots[j];
//             index++;
//         }
//     }
//     return slotsEven;
// }
// int[] slotsEven = GenerateEvenSlots(8);
// foreach (int slot in slotsEven)
// {
//     Console.WriteLine(slot);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }