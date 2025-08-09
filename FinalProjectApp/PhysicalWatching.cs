using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public class PhysicalWatching : PhysicalMedia
	{
		private string _addedDate;
		private bool _completeCase;
		private string _genre;
		private string _itemNote;
		private string _watchingType;
		private string _name;
		private string _owner;
		private string _physicalLocation;
		private static int _physicalWatchingTotal;
		private string _physicalSubtype = "Watching";
		private int _releaseYear;
		private bool _working;

		public override void AddItem()
		{
			throw new NotImplementedException();
		}

		public override void DeleteItem()
		{
			throw new NotImplementedException();
		}

		public override void DisplayTotal()
		{
			throw new NotImplementedException();
		}

		public override void EditItem()
		{
			throw new NotImplementedException();
		}

		public PhysicalWatching()
		{
			throw new NotImplementedException();
		}
	}
}
