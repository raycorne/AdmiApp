using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmiApp.Core.Responses
{
	public class MainListStringResponse
	{
		public bool IsSuccess { get; set; }
		public string? ErrorMessage { get; set; }
		public List<string>? Content { get; set; }
	}
}
