string[] array = new string[] {"Hello", "2", "World", ":-)"};
string[] new_array = new string[array.Length];
int j = 0;
        
for (int i = 0; i < array.Length; i++) 
{
    if (array[i].Length <= 3) 
    {
        new_array[j] = array[i];
        j++;
    }
}
        
System.Array.Resize(ref new_array, j);
System.Console.Write($"[{string.Join(", ",new_array)}]");