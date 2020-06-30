namespace DaoLibrary.Models
{
    /**
     * This Item Model is associated with the "Item" entity and contained 
     * within this class are all properties assigned to the item.
     */
    class ItemModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public int Limit { get; set; }
    }
}
