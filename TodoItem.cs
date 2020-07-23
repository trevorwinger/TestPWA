namespace TestProgressiveWebApp
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool isDone { get; set; }

        public TodoItem(string title, bool done)
        {
            //test with git
            Title = title;
            isDone = done;
        }
    }
}
