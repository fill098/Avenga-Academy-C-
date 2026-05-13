/* Requirements
1.Get the title of the first product in the Fragrances category with a price above $100.

2.Select the brand of the last product that has a stock lower than 40.

3.Retrieve the description of the first product with a rating equal to 4.43.

4.Get the title of the last Skincare product with a price under $50.

5.Select the rating of the first product with a brand that contains the word "Apple".

6.Get the description of the last product with "display" in the description.

7.Select the title of the first Laptop that has a stock greater than 80.

8.Get the brand of the last product with "Pro" in the title.

9.Retrieve the title of the first product that has a price above $1200.

10.Select the stock count of the last product that belongs to the Smartphones category.

11.Get the description of the first product with a brand name starting with 'H'.

12.Retrieve the price of the last product that has "Essence" in its title.

13.Select the brand of the first product with a description longer than 100 characters.

14.Get the title of the last product with a rating below 4.1 and stock over 30.

15.Retrieve the description of the first product that has "Serum" in the title.

16.Use a dictionary to map products by their category.

Bonus
17.Create new class ProductDetails with 3 properties: Id, Title and Price and 
map the existing product data to a collection of ProductDetails objects.
*/

// Data Sample
using Class01.Homework.Models;
using System.Xml;
using static Class01.Homework.Models.Product;

List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};



var result1 = products
    .Where(p => p.Category == ProductCategory.Fragrances && p.Price > 100)
    .FirstOrDefault()
    .Title;

Console.WriteLine(result1);

var result2 = products
    .Where(p => p.Stock < 40)
    .LastOrDefault()
    .Brand;

Console.WriteLine(result2);

var result3 = products
    .Where(p => p.Rating == 4.43)
    .FirstOrDefault()
    .Description;

Console.WriteLine(result3);

var result4 = products
    .Where(p => p.Price < 50)
    .LastOrDefault()
    .Title;

Console.WriteLine(result4);

var result5 = products
    .Where(p => p.Brand.Contains("Apple"))
    .FirstOrDefault()
    .Rating;

Console.WriteLine(result5);

var result6 = products
    .Where(p => p.Description.Contains("display"))
    .LastOrDefault()
    .Description;

Console.WriteLine(result6);

var result7 = products
    .Where(p => p.Stock > 80)
    .FirstOrDefault()
    .Title;

Console.WriteLine(result7);

var result8 = products
    .Where(p => p.Title.Contains("Pro"))
    .LastOrDefault()
    .Brand;

Console.WriteLine(result8);

var result9 = products
    .Where(p => p.Price > 1200)
    .FirstOrDefault()
    .Title;

Console.WriteLine(result9);


var result10 = products
    .Where(p => p.Category == ProductCategory.Smartphones)
    .LastOrDefault()
    .Stock;

Console.WriteLine(result10);

var result11 = products
    .Where(p => p.Brand.StartsWith("H"))
    .FirstOrDefault()
    .Description;

Console.WriteLine(result11);


var result12 = products
    .Where(p => p.Title.Contains("Essence"))
    .LastOrDefault()
    .Price;

Console.WriteLine(result12);

var result13 = products
    .Where(p => p.Description.Length > 100)
    .FirstOrDefault()
    .Brand;

Console.WriteLine(result13);

var result14 = products
    .Where(p => p.Rating < 4.1 && p.Stock > 30)
    .LastOrDefault()
    .Title;

Console.WriteLine(result14);

var result15 = products
    .Where(p => p.Title.Contains("Serum"))
    .FirstOrDefault()
    .Description;

Console.WriteLine(result15);

var result16 = products
    .GroupBy(p => p.Category)
    .ToDictionary(g => g.Key, g => g.ToList());


var smartphoneProducts = result16[ProductCategory.Smartphones];



foreach(var phone in smartphoneProducts)
{
    Console.WriteLine(phone.Title);
}

var productDetails = products
    .Select(p => new ProductDetails(p.Id, p.Title, p.Price))
    .ToList();


foreach (var product in productDetails)
{
    Console.WriteLine($"Title - {product.Title}, Price - {product.Price} ");
}



