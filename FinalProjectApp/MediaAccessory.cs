using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public class MediaAccessory : OtherItem
	{
		private int _addedDate;
		private string _itemNote;
		private string _name;
		private static int _mediaAccessoryTotal;
		private string _otherSubtype = "Media Accessory";
		private string _owner;
		private string _specialVariant;
		private bool _working;
		private string _accessoryFor;

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

		public MediaAccessory()
		{
			throw new NotImplementedException();
		}
	}
}
