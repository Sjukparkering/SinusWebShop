
namespace SinusWebShop.Managers
{
      public static class CartManager
      {
            public static List<ProductModel> Cart { get; set; } = new();

            public static double? GetTotalPrice()
            {
            return (double?)Cart.Sum(p => p.Price);
            }
      }
    
}

