using WebAPI_IMS.Data.Entities;
using WebAPI_IMS.Data.Repository_Layer.Repository_Interfaces;
using WebAPI_IMS.Data.Service_Layer.Service_Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI_IMS.Data.Service_Layer
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task AddSupplierAsync(Supplier supplier)
        {
            await _supplierRepository.AddSupplierAsync(supplier);
        }

        public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
        {
            return await _supplierRepository.GetAllSuppliersAsync();
        }

        public async Task<Supplier> GetSupplierByIdAsync(int id)
        {
            return await _supplierRepository.GetSupplierByIdAsync(id);
        }
    }
}
