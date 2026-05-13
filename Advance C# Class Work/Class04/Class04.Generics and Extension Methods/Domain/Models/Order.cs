namespace Class04.Generics_and_Extension_Methods.Domain.Models
{
    public class Order : BaseEntity
    {
        public string Recever { get; set; }

        public string Address { get; set; }
        public override string GetInfo()
        {
            return $"{Id}) {Recever} - {Address}";
        }


    }
}
