

string[] EnterStringToArr()
{
    Console.WriteLine("Input number of rows");
    int count = int.Parse(Console.ReadLine());
    string[] workArr = new string [count];
    Console.WriteLine($"Input {count} of rows");
    for (int i = 0; i < count; i++)
    {
        workArr[i] = Console.ReadLine();
    }
    return workArr;

}

string[] CreatingArrStringsLessThan3(string[] workArr)
{
    int count = 0;
    foreach (string item in workArr)
    {
        if (item.Length <= 3)
        {
            count ++;
           
        }
    }
    string[] result = new string[count];
    int i = 0;
    foreach (string item in workArr)
    {
        if (item.Length <= 3)
        {
            result[i] = item;
            i++;
        }
    }

    return result;
}

string PrintArr(string[] workArr)
{
    string arString = "[";
    for (int i = 0; i < workArr.Length; i++)
    {
        arString += $"\"{workArr[i]}\"";
        if (i < workArr.Length - 1)
        {
            arString += ",";
        }

    }
    arString += "]";
    return arString;
}
string[] workArr = EnterStringToArr();
string[] result = CreatingArrStringsLessThan3(workArr);

string firstArray = PrintArr(workArr);
string secondArray = PrintArr(result);

Console.WriteLine(firstArray + " -> " + secondArray);