using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryID = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;


Product product2 = new Product { Id = 2, CategoryID = 5, 
    UnitPrice = 35, ProductName = "Kalem", UnitsInStock = 5 };

ProductManager productManager = new ProductManager();
productManager.Add(product1);   
Console.WriteLine(product1.ProductName);

