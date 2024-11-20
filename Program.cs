
string[] array = new string[] { "Russia", "Denmark", "Kazan" };

int lenNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
        lenNewArray++;
}

string[] newArray = new string[lenNewArray];
int idx = 0;
Console.Write("[");
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        Console.Write($"{newArray[idx]}, ");
        idx++;
    }
}
Console.Write("]");
