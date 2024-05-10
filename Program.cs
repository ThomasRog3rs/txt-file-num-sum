using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string calibrationDocument =
        "/home/tom/RiderProjects/AdventOfCode1/AdventOfCode1/CalibrationDocuments/CalibrationDocument.txt";
    
        string[] lines = File.ReadAllLines(calibrationDocument);
        List<int> calibrationValues = new List<int>();
        int sum = 0;
        
        foreach (var line in lines)
        {
            var numbers = line.ToCharArray().Where(x => char.IsDigit(x)).ToArray();
            string calibrationValue = "";
      
            calibrationValue = $"{numbers[0]}{numbers[numbers.Length - 1]}";
            Console.WriteLine(calibrationValue);
            calibrationValues.Add(Int32.Parse(calibrationValue));
        }
    
        sum = calibrationValues.Sum();
        Console.WriteLine($"Sum of all calibration values: {sum}");
    }
}
