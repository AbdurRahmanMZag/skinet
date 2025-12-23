using System;
using Core.Entities;
using Core.Specification;

namespace Infrastructure.Data;

public class TypeListSpecification : BaseSpecification<Product, string>
{
    public TypeListSpecification()
    {
        AddSelect(x => x.Type);
        ApplyDistinct();
    }
}