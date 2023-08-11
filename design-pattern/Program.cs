// See https://aka.ms/new-console-template for more information
// records in c#
// They are like struct or classes but has differences
// where to use records ?
// - value euqality 
// - object immutability scenarios
Console.WriteLine("Hello, World!");
Person p1 = new ("kamil", "hussain");
Person p2 = new ("kamil","hussain");
//Console.WriteLine($"Printing record entity:{p1}");
Console.WriteLine($"Are they equal ? {p1 == p2 }"); // true = >  if p1 and p2 has same object props' value but for classes this is always true since their types are same.
Console.WriteLine($"Are referrences equal ? {ReferenceEquals(p1,p2)}"); // this is always since both are different referrences

