namespace Bookfiy.Web.Core.ViewModels
{
    public class CategoryFormViewModel
    {

        public int Id { get; set; }

        [MaxLength(100 , ErrorMessage ="Max Length Can't be More Than 100 Character.!")] //Server Side 
        public string Name { get; set; } = null!;
    }
}
