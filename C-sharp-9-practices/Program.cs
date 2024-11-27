using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace C_sharp_9_practices
{
    class Program
    {
        static void Main(string[] args)
        {
            string a=string.Empty;

            var tasks = new Task[]{
                Task.Run(async () => {a = await ConcurrencyVsParalelismTasks.GetFirstTaskAsync();}),
                Task.Run(async () => await ConcurrencyVsParalelismTasks.GetSecondTaskAsync()),
                Task.Run(async () => await ConcurrencyVsParalelismTasks.GetThirdTaskAsync())
            };

            //Concurrency: The ability of a system to handle multiple tasks at the same time, 
            //             These tasks do not necessarily execute simultaneously; instead, 
            //             they may be interleaved, giving the appearance of simultaneous execution.
            a=string.Empty;
            Console.WriteLine($"Begin of WhenAll");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task.WhenAll(tasks);
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} Ms -> {a}");
            
            a=string.Empty;
            Console.WriteLine($"Begin of WaitAll");
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            Task.WaitAll(tasks);
            stopwatch1.Stop();
            Console.WriteLine($"{stopwatch1.ElapsedMilliseconds} Ms -> {a}");

            //Paralelism: Involves real execution of multiple tasks even in multiple-core at exactly the same time.
            
            a=string.Empty;
            Console.WriteLine($"Begin of Parallel.For");
            Stopwatch stopwatch3= new Stopwatch();
            stopwatch3.Start();
            Parallel.ForEach(tasks, task => {
                Console.WriteLine($"{task.Id}: {task.Status}");
            });
            stopwatch3.Stop();
            Console.WriteLine($"{stopwatch3.ElapsedMilliseconds} Ms -> {a}");
        }
    }
}