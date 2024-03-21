using SinusWebShop.Models;

namespace SinusWebShop.Managers
{
    public static class CartManager
    {
            public static List<Product> Cart { get; set; } = new();

            public static double? GetTotalPrice()
            {
            return (double?)Cart.Sum(p => p.Price);
            }
      }
    
}

