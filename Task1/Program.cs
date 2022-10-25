// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите числа  через запятую:");
string nums = Console.ReadLine();
string [] HowManyNums = new string [nums.Length];
int j = 0;
for (int i = 0; i < HowManyNums.Length; i++)
{
  if (nums[i] == ',')
  {
    j++;
  }
  else
  {
    HowManyNums[j] = HowManyNums[j]+$"{nums[i]}";
  }
}
j++;
int [] resultNumbers = new int[j];
PrintArray (resultNumbers, HowManyNums);
int count = 0;
for (int i = 0; i < j; i++)
{
  if (resultNumbers[i]>0)
  {
    count++;
  }
}
Console.WriteLine ("Пользователь ввел чисел больше 0: "+count);

void PrintArray (int [] array, string [] aboveZero)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = int.Parse(aboveZero[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}