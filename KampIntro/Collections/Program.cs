




//string[] isimler = new string[] { "Engin", "Kerem", "Ahmet", "Halil" };



//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);

List<string> list = new List<string>() { "Engin", "Kerem", "Ahmet", "Halil" };


list.Add("Selami"); 

foreach (string s in list) {  Console.WriteLine(s + " Begefendi"); }

