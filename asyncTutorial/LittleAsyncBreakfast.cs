using asyncTutorial.food;

namespace asyncTutorial;


public class LittleAsyncBreakfast
{
    private static Juice PourOJ()
    {
        Console.WriteLine("Pouring orange juice");
        return new Juice();
    }
}