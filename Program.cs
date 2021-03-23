namespace ValidHours
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string hour = Console.ReadLine();

            Regex regex = new Regex(@"(([0-9])|([0-1][0-9])|(2[0-3])):([0-5][0-9]):([0-5][0-9])", RegexOptions.IgnoreCase);

            MatchCollection matchHours = regex.Matches(hour);

            foreach (Match validHour in matchHours)
            {
                if (validHour.Success)
                {
                    Console.WriteLine($"True: {validHour.Groups[0].Value}");
                }
            }
        }
    }
}
