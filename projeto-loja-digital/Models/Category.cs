namespace projeto_loja_digital.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Meal> Meals { get; set; }
    }
}
