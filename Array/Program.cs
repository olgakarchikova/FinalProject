
string [] myArray = {"Hello", "--", "5", "Bye", "Olga"};
string [] newArray = new string[myArray.Length];

void Replace(string [] myarray, string [] newArray)
{
    int count = 0;
    for(int i=0; i < myArray.Length; i++)
        if (myArray[i].Length <= 3)
        {
            newArray[count] = myArray[i];
            count ++;
        }
}

void ShowArray(string [] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
}

Replace(myArray, newArray);
ShowArray(newArray);
