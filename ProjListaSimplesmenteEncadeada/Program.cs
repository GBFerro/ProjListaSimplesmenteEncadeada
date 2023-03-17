using ProjListaSimplesmenteEncadeada;

ListaSimplesmenteEncadeada list = new();
Item item2;
Random random = new Random();

do
{
    Console.Clear();
    int x = random.Next(100);
    item2 = new(x);
    list.Push(item2);
    list.Print();
    Console.ReadLine();
} while (true);

Item item = new(21);
list.Push(item);
list.Print();

item = new(40);
list.Push(item);
list.Print();

item = new(10);
list.Push(item);
list.Print();

item = new(22);
list.Push(item);
list.Print();

