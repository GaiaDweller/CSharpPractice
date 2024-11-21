using System;

namespace HelloWorld
{
  class secretworddata
  {
    public string Word { get; set;}
  }
  class Vroom 
  {
    int speed = 1;
    string word = "Vroom";
    char character = 'C';
      static void Main(string[] args)
      {
        Vroom MyVroomVroom = new Vroom(); 
        Console.WriteLine(MyVroomVroom.word);
        Console.WriteLine(MyVroomVroom.character);
        Console.WriteLine(MyVroomVroom.speed);
        Console.WriteLine("SAY SOMETHING COOL MY BROTHER:");
        string mysupercoolinput = Console.ReadLine();
        Console.WriteLine("THATS SO REAL MY FRIEND");
        Console.WriteLine($"Random ahh Dude: {mysupercoolinput}");
      }
  }
}