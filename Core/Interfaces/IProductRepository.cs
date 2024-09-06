﻿using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetProductsAsync(string? brand, string? type, string ? sort);
    Task<Product?> GetProductByIdAsync(int id); //return product or null
    Task<IReadOnlyList<string>> GetBrandAsync(); 
    Task<IReadOnlyList<string>> GetTypeAsync(); 
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
    bool ProductExists(int id);
    Task<bool> SaveChangesAsync();
}
