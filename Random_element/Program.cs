string[] snacks = { "sushi", "pitza", "chips", "chicken", "pepsi", "coca" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are eat{snacks[randomIndex]}.");


