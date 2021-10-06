using System.Collections.Generic;
using System.Linq;

namespace Yield_IEnumerable_Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			GetList().FirstOrDefault(e => e > 3);

			GetListYield().FirstOrDefault(e => e > 3);
		}

		static IEnumerable<int> GetListYield()
		{
			var list = new List<int> { 2, 4, 2, 1, 3 };

			foreach (var element in list)
			{
				yield return element;
			}
		}

		static IEnumerable<int> GetList()
		{
			var list = new List<int> { 2, 4, 2, 1, 3 };
			var newList = new List<int>();

			foreach (var element in list)
			{
				newList.Add(element);
			}

			return newList;
		}
	}
}
