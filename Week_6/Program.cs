// string [] fruit = {"apples","bananas","oranges"]

string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";

Console.WriteLine($"{fruit[0]},{fruit[2]},{fruit[3]}");

int fruitArreyLenght = fruit.Length;

Console.WriteLine($"There are {fruitArreyLenght} in your array. ");

for (int i = 0; i < fruitArreyLenght; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string elemet in fruit)
{
    Console.WriteLine(elemet);
}
