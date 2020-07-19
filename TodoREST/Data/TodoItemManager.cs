using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoREST
{
	public class TodoItemManager
	{
		IRestService restService;

		public TodoItemManager (IRestService service)
		{
			restService = service;
		}

		public Task<List<TodoItem>> GetTasksAsync ()
		{
			return restService.RefreshDataAsync ();	
		}

		public Task SaveTaskAsync (TodoItem item)
		{
			return restService.SaveTodoItemAsync (item);
		}

		public Task DeleteTaskAsync (TodoItem item)
		{
			return restService.DeleteTodoItemAsync (item.id);
		}
	}
}
