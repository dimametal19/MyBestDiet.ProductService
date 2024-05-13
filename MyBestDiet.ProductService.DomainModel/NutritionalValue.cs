namespace MyBestDiet.ProductService.DomainModel;

public class NutritionalValue
{
    public int Id { get; set; }

    public string ExternalId { get; set; }

    public decimal Protein { get; set; }

    public decimal Fat { get; set; }

    public decimal Carb { get; set; }

    public decimal Calorie { get; set; }
}