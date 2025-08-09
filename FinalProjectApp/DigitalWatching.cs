using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public class DigitalWatching : DigitalMedia
	{
		private string _addedDate;
		private string _genre;
		private string _itemNote;
		private string _watchingType;
		private string _name;
		private string _owner;
		private string _digitalLocation;
		private static int _digitalWatchingTotal;
		private string _digitalSubtype = "Watching";
		private int _releaseYear;

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

		public DigitalWatching()
		{
			throw new NotImplementedException();
		}
	}
}
