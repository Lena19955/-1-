string [] array = new string [6] {"SQL", "C++", "Java", "Python", "C#", "Hello"};
string [] newArray = new string [array.Length];

void formationNewArray(string [] array, string [] newArray)
{
   int count = 0;
   for (int i = 0; i <= array.Length; i++)
   {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
   }
}