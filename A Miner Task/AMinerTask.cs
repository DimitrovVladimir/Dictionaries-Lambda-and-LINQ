namespace A_Miner_Task
{
    internal class AMinerTask
    {
        static void Main(string[] args)
        {
            var resourcesQuantities = new Dictionary<string, decimal>();

            var line = Console.ReadLine();

            while (line != "stop")
            {
                var resource = line;
                var quantity = decimal.Parse(Console.ReadLine());
                if (!resourcesQuantities.ContainsKey(resource))
                {
                    resourcesQuantities[resource] = 0;
                }

                resourcesQuantities[resource] += quantity;

                line = Console.ReadLine();

            }
            foreach (var resourceQuantity in resourcesQuantities)
            {
                var resource =resourceQuantity.Key;
                var quantity = resourceQuantity.Value;
                Console.WriteLine($"{resource} -> {quantity}");
            }
        }
    }
}