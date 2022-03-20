
using System;
using System.Diagnostics;

static Array CreateStringArray()
{
    string[] cars = new string[3];

    cars[0] = "Volvo";
    cars[1] = "Lincoln";
    cars[2] = "Mercedes Benz";

    return cars;

}

static Array SumArray(int[] sumsUp)
{
    foreach(int i in sumsUp)
    {
        var intArraySum = sumsUp.Sum();

    }
        return sumsUp;
}

static List<int> RemoveNum(List<int> removableList, int numRemove)
{
    removableList.Add(5);
    removableList.Add(16);
    removableList.Add(32);
    removableList.Add(68);
    removableList.Add(169);
    removableList.Add(78);

    bool doesListContainParam = removableList.Contains(numRemove);

    if (doesListContainParam != true)
    {
        Console.WriteLine("Sorry this number isnt in the list.");
    }

        return removableList;
    

}

string fruit = "cherries";

static List<string> AddToList(string fruitX)
{ 
    var x = "cherries";
    List<string> stringList = new List<string>();
    stringList.Add("grapes");
    stringList.Add("oranges");
    stringList.Add(fruitX);

    return stringList;

}

//var test = AddToList(fruit);

//foreach (var item in test)
//{
  //  Console.WriteLine(item);
//}

static int TryMe(int x, int y)
{


    try
    {
        var division = x / y;
        Console.WriteLine(division);
        return division;
    }
    catch (ArithmeticException ex)
    {
        Console.WriteLine("That, is not correct.");
        return 9;
    }
}


