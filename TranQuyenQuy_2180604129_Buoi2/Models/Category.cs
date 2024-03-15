using System.ComponentModel.DataAnnotations;

namespace TranQuyenQuy_2180604129_Buoi2.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
