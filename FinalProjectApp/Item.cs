using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public abstract class Item
	{
		private string _name;
		private string _addedDate;
		private static int _itemTotal;
		private string _owner;
		private string _itemNote;

		public void Item()
		{
			throw new NotImplementedException();
		}

		public virtual void AddItem()
		{
			throw new NotImplementedException();
		}

		public virtual void EditItem()
		{
			throw new NotImplementedException();
		}

		public virtual void DeleteItem()
		{
			throw new NotImplementedException();
		}

		public virtual void DisplayTotal()
		{
			throw new NotImplementedException();
		}
	}
}
