namespace TranQuyenQuy_2180604129_Buoi2.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void DeleteById(int id);
        void Delete(int id);
    }
}
