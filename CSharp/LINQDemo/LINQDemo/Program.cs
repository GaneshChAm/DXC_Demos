namespace LINQDemo
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Step-1:Define Database
            //string[] Fruits = { "Apple", "Mango", "Guava", "Grapes", "Cherry", "Avacando", "Banana", "Watermelon", "PineApple", "Lichi" };
            ////foreach (var item in Fruits)
            ////{
            ////    if(item.StartsWith('A'))
            ////    {
            ////        Console.WriteLine(item);
            ////    }
            ////}
            ////Step-2:Write Query
            ////var query = from x in Fruits where x.StartsWith('A') select x;
            ////var query = from x in Fruits where x.Length % 2 == 0 select x;
            ////var query = from x in Fruits orderby x select x;
            //var query = from x in Fruits orderby x descending select x;
            ////Step-3:Execute Query
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            // Step 1. Define DataSource
            List<Product> p = new List<Product>()
            {
                new Product { Id = 1,Name = "Laptop" ,Brand = "MSI",Quantity = 5, Price = 65000},
                new Product { Id = 2,Name = "Desktop" ,Brand = "Lenova",Quantity = 10, Price = 60000},
                new Product { Id = 3,Name = "Mobile" ,Brand = "Xiomi",Quantity = 15, Price = 55000},
                new Product { Id = 4,Name = "Camera" ,Brand = "Nikon",Quantity = 20, Price = 50000},
                new Product { Id = 5,Name = "Tablet" ,Brand = "Samsung",Quantity = 25, Price = 45000},
                new Product { Id = 6,Name = "Earphones" ,Brand = "Boat",Quantity = 30, Price = 40000},
            };
            
            //var query = from x in p where x.Id == 3 select x;
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name} {item.Brand} {item.Quantity} {item.Price}");
            //}

            //-------- LAMBDA EXPRESSIONS--------

            //var result = p.Where(x => x.Id == 3).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name} {item.Brand} {item.Quantity} {item.Price}");
            //}

            //var item = p.Find(x => x.Id == 3);
            var item = p.Where(x => x.Price == p.Max(p => p.Price)).FirstOrDefault();
            Console.WriteLine($"{item.Id} {item.Name} {item.Brand} {item.Quantity} {item.Price}");
        }
    }
}