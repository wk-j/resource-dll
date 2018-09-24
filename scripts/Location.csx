using System.Reflection;

var rs = Assembly.GetExecutingAssembly().Location;
Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);