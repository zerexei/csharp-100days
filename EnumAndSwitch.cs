namespace EnumAndSwitch
{
    class Sweech
    {
        public static void Log()
        {
            List<Todo> todos = new List<Todo>(){
                new Todo() {title = "Todo 1", isDone = false},
                new Todo() {title = "Todo 2", isDone = false},
                new Todo() {title = "Todo 3", isDone = true},
            };

            foreach (var todo in todos)
            {

                switch (todo.isDone)
                {
                    case true:
                        Console.WriteLine("Todo is done.");
                        break;
                    default:
                        Console.WriteLine("Todo is not done.");
                        break;
                }

            }
        }
    }

    class Todo
    {
        public string title { get; set; }
        public bool isDone { get; set; }
    }
}