



using GenerictsIntro;

Mylist<string> mylist = new Mylist<string>();

mylist.Add("Ahmet");
Console.WriteLine(mylist.Length);
mylist.Add("Mehmet");
Console.WriteLine(mylist.Length);

mylist.Add("Hikmet");
Console.WriteLine(mylist.Length);

mylist.Add("Sermet");
Console.WriteLine(mylist.Length);

foreach (var item in mylist.Write) 
{ 
Console.WriteLine(item);

}

