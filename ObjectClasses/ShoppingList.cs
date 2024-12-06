using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace StudentHousing.ObjectClasses
{
    public class ShoppingList
    {
        private static readonly string filePath = Path.Combine("..", "..", "..", "Database", "shoppingList.json");

        public static void AddProduct(Product product)
        {
            List<Product> products = new List<Product>();
            if (File.Exists(filePath))
            {
                string existingData = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(existingData))
                {
                    try
                    {
                        products = JsonSerializer.Deserialize<List<Product>>(existingData);
                    }
                    catch (JsonException)
                    {
                        products = new List<Product>();
                    }
                }

                products.Add(product);
                string jsonData = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(filePath, jsonData);

            }
        }
        public static List<Product> GetProducts()
        {
            string jsonContent = File.ReadAllText(filePath);
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonContent);
            return products;

        }


    }
}
