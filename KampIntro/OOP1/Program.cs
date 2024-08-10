// See https://aka.ms/new-console-template for more information
using OOP1;

Console.WriteLine("Hello, World!");
Product product = new Product();

product.Id = 1;
product.CategoryId = 1;
product.ProductName = "Helva";
product.UnitPrice = 0;
product.UnitsInStock = 20;


Product product1 = new Product { Id = 2, CategoryId = 1, ProductName = "Kiraz", UnitPrice = 40, UnitsInStock = 45 };

ProductService productService = new ProductService();
productService.Add(product);   
productService.Add(product1);

productService.Update(product);
productService.Update(product1);

