using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Application.Interfaces.Services
{
	public interface IBaseService
	{
		/// <summary>
		/// Validate a model
		/// </summary>
		/// <param name="model">Model.</param>
		IEnumerable<string> Validate(object model);
	}
}
