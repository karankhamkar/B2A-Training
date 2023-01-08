namespace ToDoItemCascading.Model
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public bool IsDone { get; set; }
    }
}
