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

// // Задача А
// System.Console.Write("Введите число: ");
// int n = int.Parse(System.Console.ReadLine());
// int[] massifN = new int[n];
// for (int i = 0; i < n; i++)
// {
//     massifN[i] = (i + 1) * (i + 1);
// }
// foreach (int num in massifN)
// {
//     System.Console.WriteLine(num);
// }

// // Задача Б
// int[] massif = { 1, -2, -3, -4, 5, -6, -7, -8, -9, 10 };
// for (int i = 0; i < massif.Length; i++)
// {
//     if (massif[i] < 0)
//     {
//         massif[i] = 0;
//     }
// }
// foreach (int num in massif)
// {
//     System.Console.WriteLine(num);
// }

// System.Console.Write("Введите свою фамилию: ");
// string surname = System.Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//     System.Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// System.Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // Вариант 7
// int[] SquareAll(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] *= numbers[i];
//     }
//     return numbers;
// }
// int[] numbers = { 1, 2, 3, 4, 5 };
// int[] newMassif = SquareAll(numbers);
// foreach (int num in newMassif)
// {
//     System.Console.WriteLine(num);
// }

// // Вариант 9
// int[] MergeArrays(int[] first, int[] second)
// {
//     int[] massif = new int[first.Length + second.Length];
//     for (int i = 0; i < first.Length; i++)
//     {
//         massif[i] = first[i];
//     }
//     int k = 0;
//     for (int j = first.Length; j < first.Length + second.Length; j++)
//     {
//         massif[j] = second[k];
//         k++;
//     }
//     return massif;
// }
// int[] first = { 1, 2, 3 };
// int[] second = { 4, 5 };
// int[] massif = MergeArrays(first, second);
// foreach (int num in massif)
// {
//     System.Console.WriteLine(num);
// }