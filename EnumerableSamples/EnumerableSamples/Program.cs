using EnumerableSamples;

Console.WriteLine("===============");
Console.WriteLine("Enumerables");
Console.WriteLine("===============");

#region List
//Console.WriteLine("*** List<T> ***");
//var product = new List<Product>
//{
//   new Product { Id = 1, Name = "Coke", Price = 100 },
//   new Product { Id = 2, Name = "Milk", Price = 70 },
//   new Product { Id = 3, Name = "iPhone", Price = 300 },
//   new Product { Id = 4, Name = "iWatch", Price = 120 },
//};

//Console.WriteLine("Original list =>");
//for (int i = 0; i < product.Count; i++)
//{
//   Console.WriteLine(product[i]);
//}

//Console.WriteLine("Ordered list =>");
//product = product.OrderByDescending(p => p.Price).ToList();
//for (int i = 0; i < product.Count; i++)
//{
//   Console.WriteLine(product[i]);
//}

#endregion

#region Dictionary1
//Console.WriteLine("*** Dictionary<TKey, TValue> ***");
//var fruits = new Dictionary<string, int> 
// { 
// { "Manzana", 10 },
// { "Pera", 12},
// { "Sandía", 15 },
// { "Uva", 30 },
// { "Aguacate", 16 },
// { "Kiwi", 5 }
//};

//if (fruits.ContainsKey("Limón"))
//{
//  fruits["Limón"] += 20;
//}
//else
//{
//  fruits.Add("Limón", 20);
//}

//foreach (var fruit in fruits)
//{
//   Console.WriteLine($"{fruit.Key} => {fruit.Value}");
//}

#endregion

#region Dictionary2
Console.WriteLine("*** Dictionary<TKey, TValue> ***");
var products = new Dictionary<int, Product>
{
    { 1, new Product { Id = 1, Name = "Coke", Price = 100 } },
    { 2, new Product { Id = 2, Name = "Milk", Price = 70 } },
    { 3, new Product { Id = 3, Name = "iPhone", Price = 300 } },
    { 4, new Product { Id = 4, Name = "iWatch", Price = 120 } },
};

if (products.ContainsKey(5))
{
    products[5].Price *= 20;
}
else
{
    products.Add(5, new Product { Id = 5, Price = 110, Name = "Shirt" });
}

foreach (var product in products)
{
    Console.WriteLine($"{product.Key} => {product}");
}

#endregion
