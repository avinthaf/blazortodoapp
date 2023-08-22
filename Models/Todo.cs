using System;
namespace BlazorTodoApp.Models
{
	public class Todo
	{
        public string Title { get; set; }
        public DateTime DueBy { get; set; }
        public bool IsComplete { get; set; }
    }
}

