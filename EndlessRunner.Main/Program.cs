var map = new Map();
var displayThread = new Thread(() =>
{
  while(true)
  {
    Console.Clear();
    Console.WriteLine(map);

    Thread.Sleep(1000);
    var newRow = map.GenerateNewRow();
    map.AddNewRow(newRow);
    map.GoRight = false;
    map.GoLeft = false;
  }

});

var controlThread = new Thread(() =>
{
  while (true)
  {
    if (Console.KeyAvailable)
    {
      var input = Console.ReadKey(true);
      if (input.Key == ConsoleKey.A)
      {
        map.GoLeft = true;
        map.GoRight = false;
      }
      else if (input.Key == ConsoleKey.D)
      {
        map.GoLeft = false;
        map.GoRight = true;
      }
    }
  }
});

displayThread.Start();
controlThread.Start();