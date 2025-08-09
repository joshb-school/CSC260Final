using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public class DigitalSoftware : DigitalMedia
	{
		private string _addedDate;
		private static int _digitalSoftwareTotal;
		private string _digitalSubtype = "Software or Subscriptions";
		private string _itemNote;
		private string _name;
		private string _owner;
		private string _digitalLocation;
		private bool _isSubscription;

		public override void AddItem()
		{
			throw new NotImplementedException();
		}

		public override void DeleteItem()
		{
			throw new NotImplementedException();
		}

		public override void EditItem()
		{
			throw new NotImplementedException();
		}

		public override void DisplayTotal()
		{
			throw new NotImplementedException();
		}

		public DigitalSoftware()
		{
			throw new NotImplementedException();
		}
	}
}
