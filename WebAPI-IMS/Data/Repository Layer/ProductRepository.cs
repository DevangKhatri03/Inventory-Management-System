using WebAPI_IMS.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_IMS.Data.Repository_Layer.Repository_Interfaces;
using WebAPI_IMS.Data.Context;

namespace WebAPI_IMS.Data.Repository_Layer
{
    public class ProductRepository : IProductRepository
    {
        // Injecting the DB context into the repository layer via constructor
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Add a new product to the database
        public async Task AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        // Delete a product from the database by its ID
        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();  
            }
            // Optionally, handle case where the product is not found
            else
            {
                
            }
        }

        // Get all products from the database
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products
                .Include(p => p.Category)  // Eagerly load Category related data
                .Include(p => p.Supplier)  // Eagerly load Supplier related data
                .ToListAsync();
        }

        // Get a specific product by its ID
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(p => p.Id == id);  // Use the id parameter
        }

        // Update an existing product in the database
        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();  
        }
    }
}
