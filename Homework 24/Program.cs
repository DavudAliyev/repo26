using Homework_24;
using System.Collections;

MyList<string> names = new MyList<string>();

names.Add("Adil");
names.Add("Rauf");
names.Add("Raul");
names.Add("Aysu");

foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("=======================================");

string[] namesArr = { "Adil", "Rauf", "Raul", "Aysu" };


ArrayList arrList0 = new ArrayList();
arrList0.Add("Salam");
arrList0.Add("Necesen");
arrList0.Add(23);
arrList0.Add(names);


arrList0.RemoveAt(2);
arrList0.AddRange(namesArr);
arrList0.AddRange(arrList0);
arrList0.RemoveRange(0, 2);
arrList0.Remove("Aysu");
Console.WriteLine(arrList0.Contains("Adil"));
Console.WriteLine(arrList0.IndexOf("Adil"));
Console.WriteLine(arrList0.Capacity);
Console.WriteLine(arrList0.Count);
Console.WriteLine(arrList0[0]);

Console.WriteLine("==========================");

SortedList nonGenSortedList = new SortedList();

nonGenSortedList.Add("11", 12);
nonGenSortedList.Add("12", 13);
nonGenSortedList.Add("13", 24);
nonGenSortedList.Add("14", 19);
nonGenSortedList.Add("15", "salam");


Console.WriteLine("sorted list");
Console.WriteLine(nonGenSortedList["12"]);

Queue nonGenqueue = new Queue();
nonGenqueue.Enqueue("necesen");
nonGenqueue.Enqueue('A');

Console.WriteLine("Non Gen Queue items:");

var item1 = nonGenqueue.Dequeue();
Console.WriteLine(nonGenqueue.Peek());

Console.WriteLine("Non Gen Queue items: ");
foreach (var item in nonGenqueue)
{
    Console.WriteLine(item);
}

Stack nonGenStack = new Stack();
nonGenStack.Push("Salam");
nonGenStack.Push('S');