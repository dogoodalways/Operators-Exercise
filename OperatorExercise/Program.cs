namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //Console.WriteLine("How many months have you been a Jr. Software Developer?");
            //var jrSoftware = int.Parse(Console.ReadLine());
            //Console.WriteLine($"OK, {name} we are happy to hear that you have been working on  Junior level for {jrSoftware} months");
            //Console.WriteLine("How many apps have you built per month as a Junior Software Developer?");
            //var appsMonth = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many months have you worked as a Senior Software Developer?");
            //var monthWorked = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many apps per month have you developed as a Senior Software Developer");
            //var srApps = int.Parse(Console.ReadLine());
            //var totalJr = appsMonth * jrSoftware;
            //var totalSr = srApps * monthWorked;
            //var totalAll = totalJr + totalSr;
            //var diffJrsr = totalSr - totalJr;
            //var monthTotal = jrSoftware + monthWorked;
            //var avgAppmonth = monthTotal / totalAll;
            //Console.WriteLine($"You built {totalJr} apps as a Junior Software Developer and {totalSr} apps as a Senior " +
            //    $"Developer. Altogether you built {totalAll} apps! Good for you! You built  {diffJrsr} more apps as a Senior developer " +
            //    $"than as a Junior developer. This means you built {avgAppmonth} apps per month.");

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4) 
                Console.WriteLine($"{a}/{b}is {quotient} remainder {remainder}");

            
        }
    }
}
