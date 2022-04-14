// See https://aka.ms/new-console-template for more information

using asyncTutorial.food;

namespace asyncTutorial
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var eggs = await eggsTask;

            var bacon = await baconTask;

            var toast = await toastTask;

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
            
            
            watch.Stop();
            Console.WriteLine($"Total Execution Time: {watch.ElapsedMilliseconds}ms");
        }
            private static Juice PourOJ()
            {
                Console.WriteLine("Pouring orange juice");
                return new Juice();
            }
        
            private static void ApplyJam(Toast toast) => Console.WriteLine("Putting jam on the toast");
            private static void ApplyButter(Toast toast) => Console.WriteLine("Putting butter on the toast");

            static async Task<Toast> MakeToastWithButterAndJamAsync(int num)
            {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                var toast = await ToastBreadAsync(num);
                ApplyButter(toast);
                ApplyJam(toast);
                Console.WriteLine("toast is ready");
                watch.Stop();
                Console.WriteLine($"toast Execution Time: {watch.ElapsedMilliseconds}ms");
                return toast;
            }
            
            private static async Task<Toast> ToastBreadAsync(int slices)
            {
                // var watch = new System.Diagnostics.Stopwatch();
                // watch.Start();
                for(int slice = 0; slice < slices; slice++)
                {
                    Console.WriteLine("Putting a slice of bread in the toaster");
                }
                Console.WriteLine("Starting toasting....");
                await Task.Delay(3000);
                Console.WriteLine("Remove toast from toaster");
                // watch.Stop();
                // Console.WriteLine($"toast Execution Time: {watch.ElapsedMilliseconds}ms");
                return new Toast();
            }
            
            private static async Task<Bacon> FryBaconAsync(int slices)
            {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                Console.WriteLine($"putting {slices} slices of bacon in the pan");
                Console.WriteLine("cooking first side of bacon...");
                await Task.Delay(3000);
                for (int slice = 0; slice < slices; slice++)
                {
                    Console.WriteLine("flipping a slice of bacon");
                }
                Console.WriteLine("cooking the second side of bacon...");
                await Task.Delay(3000);
                Console.WriteLine("Put bacon on plate");
                Console.WriteLine("bacon is ready");
                watch.Stop();
                Console.WriteLine($"FryBacon Execution Time: {watch.ElapsedMilliseconds}ms");
                return new Bacon();
            }
        
            private static async Task<Egg> FryEggsAsync(int howMany)
            {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                Console.WriteLine("Warming the egg pan...");
                await Task.Delay(3000);
                Console.WriteLine($"cracking {howMany} eggs");
                Console.WriteLine("cooking the eggs ...");
                await Task.Delay(3000);
                Console.WriteLine("Put eggs on plate");
                Console.WriteLine("eggs are ready");
                watch.Stop();
                Console.WriteLine($"FryEgg Execution Time: {watch.ElapsedMilliseconds}ms");
                return new Egg();
            }
        
            private static Coffee PourCoffee()
            {
                Console.WriteLine("Pouring coffee");
                return new Coffee();
            }

    }
}