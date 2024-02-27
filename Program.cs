
string[] array = { "1234", "1567", "-2", "computer science" };
string[] result = new string[array.Length];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        result[j] = array[i];
    
        Console.Write($"{result[j]} ");
        j++;
    }
}
