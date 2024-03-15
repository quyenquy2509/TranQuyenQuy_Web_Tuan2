using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TranQuyenQuy_2180604129_Buoi2.Models
{
    public class Product
    {
        [DisplayName ("Mã sản phẩm")]       
        
        public int Id { get; set; }
        [Required, StringLength(100)]
        [DisplayName("Tên SP")]
        public string Name { get; set; }
        [Range(0.01, 10000.00)]
        [DisplayName("Giá SP")]
        public decimal Price { get; set; }
        [DisplayName("Ghi Chú")]
        public string Description { get; set; }
        [DisplayName("Loại SP")]
        public int CategoryId {  get; set; }
    }
}
