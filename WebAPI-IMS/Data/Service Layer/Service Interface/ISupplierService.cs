using WebAPI_IMS.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI_IMS.Data.Service_Layer.Service_Interfaces
{
    public interface ISupplierService
    {
        Task AddSupplierAsync(Supplier supplier);
        Task<IEnumerable<Supplier>> GetAllSuppliersAsync();
        Task<Supplier> GetSupplierByIdAsync(int id);
    }
}
