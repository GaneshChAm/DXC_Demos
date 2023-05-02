namespace GenericCollections
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
            //List<Product> p = new List<Product>();
            //p.Add(new Product { Id = 1, Name = "Laptop", Brand = "MSI", Quantity = 10, Price = 55000 });
            //p.Add(new Product { Id = 2, Name = "Camera", Brand = "Nikon", Quantity = 20, Price = 75000 });

            //List<Product> p = new List<Product>();
            //Product p1 = new Product() { Id = 1, Name = "Laptop", Brand = "MSI", Quantity = 10, Price = 55000 };
            //Product p2 = new Product() { Id = 2, Name = "Camera", Brand = "Nikon", Quantity = 20, Price = 75000 };
            //p.Add(p1);
            //p.Add(p2);

            List<Product> p = new List<Product>();
            {
                new Product { Id = 1, Name = "Laptop", Brand = "MSI", Quantity = 10, Price = 55000 };
                new Product { Id = 2, Name = "Camera", Brand = "Nikon", Quantity = 20, Price = 75000 };
            }


        }
    }
}