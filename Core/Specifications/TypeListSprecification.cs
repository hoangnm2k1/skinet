using Core.Entities;

namespace Core.Specifications;

public class TypeListSprecification : BaseSpecification<Product, string>
{
 public TypeListSprecification()
    {
        AddSelect(x => x.Type);
        ApplyDistinct();
    }
}
