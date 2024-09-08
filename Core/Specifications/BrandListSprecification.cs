using Core.Entities;

namespace Core.Specifications;

public class BrandListSprecification : BaseSpecification<Product, string>
{
    public BrandListSprecification()
    {
        AddSelect(x => x.Brand);
        ApplyDistinct();
    }
}
