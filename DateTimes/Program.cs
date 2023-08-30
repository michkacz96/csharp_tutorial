namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(2023, 8, 15);
            Console.WriteLine("Day od the week: {0}", awesomeDate.DayOfWeek);
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);

            Console.WriteLine("New date: {0}", awesomeDate.Date);

            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New time: {0}", lunchTime.ToString());
        }
    }
}