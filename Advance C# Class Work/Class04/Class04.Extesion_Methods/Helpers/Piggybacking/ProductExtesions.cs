using Class04.Extesion_Methods.Models;

//namespace Class04.Extesion_Methods.Helpers.Piggybacking
namespace Class04.Extesion_Methods
{
    public static class ProductExtesions
    {
        public static void PrinInfo(this Product product)
        {
            Console.WriteLine(product.GetInfo());
        }
    }
}
