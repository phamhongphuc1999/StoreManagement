namespace StoreManagement.Model
{
    public class InventoryObject
    {
        public int Stt { get; set; }
        public ObjectTable ObjectEntity { get; set; }
        public int Input { get; set; }
        public int Output { get; set; }
        public int InventoryCount { get; set; }
    }
}
