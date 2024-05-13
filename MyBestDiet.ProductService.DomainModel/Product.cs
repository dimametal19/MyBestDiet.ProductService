namespace MyBestDiet.ProductService.DomainModel;

public class Product
{
    public int Id { get; set; }

    public string ExternalId { get; set; }

    public string Name { get; set; }

    public ProductCategory Category { get; set; }

    public NutritionalValue NutritionalValue { get; set; }
}