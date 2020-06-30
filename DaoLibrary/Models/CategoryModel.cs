using System.Collections.Generic;

namespace DaoLibrary.Models
{
    /**
    * This Catefory Model is associated with the "Category" entity and contained 
    * within this class are all properties assigned to the category.
    */
    class CategoryModel
    {
        public int Id { get; set; }
        public int Sequence { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int TotalLimits { get; set; }

        private List<ItemModel> items = new List<ItemModel>();

        public List<ItemModel> getItems()
        {
            return items;
        }
    }
}
