namespace CollectionsSortDemo
{
    //class Product : IComparable<Product>
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Brand { get; set; }
    //    public int Quantity { get; set; }
    //    public int Price { get; set; }
    //    public int CompareTo(Product? obj)
    //    {
    //        if(obj.Quantity>Quantity) return -1;
    //        else if(obj.Quantity<Quantity) return 1;
    //        else return 0;
    //    }
    //}

    class Product
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    class SortByQuantity : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (x.Quantity > y.Quantity) return 1;
            else if (x.Quantity < y.Quantity) return -1;
            else return 0;
        }
    }
    class SortByPrice : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (x.Price > y.Price) return 1;
            else if (x.Price < y.Price) return -1;
            else return 0;
        }
    }
    class SortByID : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (x.Id > y.Id) return 1;
            else if (x.Id < y.Id) return -1;
            else return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>()
            {
                new Product { Id = 1,Name = "Laptop" ,Brand = "MSI",Quantity = 6, Price = 65000},
                new Product { Id = 2,Name = "Desktop" ,Brand = "Lenova",Quantity = 7, Price = 60000},
                new Product { Id = 3,Name = "Mobile" ,Brand = "Xiomi",Quantity = 5, Price = 55000},
                new Product { Id = 4,Name = "Camera" ,Brand = "Nikon",Quantity = 10, Price = 5000},
                new Product { Id = 5,Name = "Tablet" ,Brand = "Samsung",Quantity = 2, Price = 45000},
                new Product { Id = 6,Name = "Earphones" ,Brand = "Boat",Quantity = 9, Price = 4000},
            };
            p.Sort(new SortByID());
            foreach (var item in p)
            {
                Console.WriteLine(item.Id  +"\t" + item.Name + "\t" + item.Brand + "\t" + item.Quantity + "\t" + item.Price );
            }
        }
    }
}