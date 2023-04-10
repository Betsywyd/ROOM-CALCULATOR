// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
Console.WriteLine("\r");
Console.Write("Enter Length:");
double length= double.Parse(Console.ReadLine());
Console.Write("Enter Width:");
double width = double.Parse(Console.ReadLine());
Console.Write("Enter Height:");
double height = double.Parse(Console.ReadLine());
double area = length*width;
double perimeter = 2 * (length + width);
double volume = length * width * height;
double surfaceArea = (length * width + width * height + length * height) * 2;
Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine($"Volume: {volume}");
Console.WriteLine($"Surface area: {surfaceArea}");
if (area <= 250) { 
    Console.WriteLine("This is a small-sized room.");
}
else if (area < 650 && area > 250) { 
    Console.WriteLine("This is a medium-sized room.");
}
else if (area >= 650) { 
    Console.WriteLine("This is a large-sized room.");
}
Console.WriteLine("\r");
Console.WriteLine("Thank you for using the Room Detail Generator!");


