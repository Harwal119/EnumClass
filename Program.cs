using System;
internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        Console.WriteLine((int)DaysOfTheWeek.friday);
        // int num = 3;
        // DaysOfTheWeek anotherday = (DaysOfTheWeek)num;
        // Console.Write(anotherday);
        // string[] names = Enum.GetNames(typeof(DaysOfTheWeek));
        // Console.WriteLine(names);
        // int[] nums (int[])Enum.GetValues(typeof(DaysOfTheWeek));
        // foreach(var nums in nums)
        // {
        //     Console.WriteLine(nums);
        // }

//         static void PrintDayMessage(DaysOfTheWeek day)
// {
//     Console.WriteLine($"Today is {day}")
// }
//  PrintDayMessage(DaysOfTheWeek.friday);

}
}

enum DaysOfTheWeek

{
    monday = 1,
    tuesday,
    wednesday,
    thursday,
    friday,
    saturday,
    sunday
}

