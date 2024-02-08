using Task5;
Counter counter = new Counter(5);
Console.WriteLine($"Initial value: {counter.Value}");
counter.Decrement();
Console.WriteLine($"After decrement: {counter.Value}");
counter.Reset();
Console.WriteLine($"After reset: {counter.Value}");

