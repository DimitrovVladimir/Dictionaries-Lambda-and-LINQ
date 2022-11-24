namespace Logs_Aggregator
{
    internal class LogsAggregator
    {
        static void Main(string[] args)
        {
            var namesIpsDurations =new SortedDictionary<String, SortedDictionary<String, int>>();

            var count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine();

                var tokens = line.Split();

                var name = tokens[1];
                var ip = tokens[0];
                var duration = int.Parse(tokens[2]);

                if (!namesIpsDurations.ContainsKey(name))
                {
                    namesIpsDurations[name] = new SortedDictionary<String, int>();
                }
                if (!namesIpsDurations[name].ContainsKey(ip))
                {
                    namesIpsDurations[name][ip] = 0;
                }
                namesIpsDurations[name][ip] += duration;
            }
            foreach (var nameIpDurations in namesIpsDurations) 
            { 
                var name = nameIpDurations.Key;
                var ipsDurations = nameIpDurations.Value;

                var totalDuration = ipsDurations.Sum(a => a.Value);
                var ips = ipsDurations.Select(a => a.Key).ToArray();
                Console.WriteLine($"{name}: {totalDuration} [{String.Join (", ", ips)}]");
            }
        }
    }
}