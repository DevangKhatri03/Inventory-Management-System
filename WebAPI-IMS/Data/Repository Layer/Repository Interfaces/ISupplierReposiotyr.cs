using WebAPI_IMS.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI_IMS.Data.Repository_Layer.Repository_Interfaces
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetAllSuppliersAsync();
        Task<Supplier> GetSupplierByIdAsync(int id);
        Task AddSupplierAsync(Supplier supplier);
    }
}
