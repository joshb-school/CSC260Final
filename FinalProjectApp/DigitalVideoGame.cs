using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public class DigitalVideoGame : DigitalMedia
	{
		private string _addedDate;
		private bool _backwardsCompatible;
		private string _console;
		private string _genre;
		private string _itemNote;
		private string _name;
		private string _owner;
		private readonly string _digitalSubtype = "Video Game";
		private static int _digitalVideoGameTotal;
		private int _releaseYear;
		private string _specialVariant;
		private string _digitalLocation;

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

		public DigitalVideoGame()
		{
			throw new NotImplementedException();
		}
	}
}
