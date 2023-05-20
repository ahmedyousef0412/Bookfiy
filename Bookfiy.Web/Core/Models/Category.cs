
namespace Bookfiy.Web.Core.Models
{
    public class Category
    {

        public int Id { get; set; }

        [MaxLength(100)] //I Use MaxLength because string by default will be Max in DB
        public string Name { get; set; } = null!; //Will Not be Null

        public bool  IsDeleted { get; set; }
        public DateTime   CreatedOn { get; set; } = DateTime.Now;
        public DateTime?  LastUpdatedOn { get; set; }
    }
}
