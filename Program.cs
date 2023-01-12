string [] array = new string [6] {"SQL", "C++", "Java", "Python", "C#", "Hello"};
string [] newArray = new string [array.Length];

void FormationNewArray(string [] array, string [] newArray)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
   }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FormationNewArray(array, newArray);
PrintArray(newArray);