using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public class DigitalMusic : DigitalMedia
	{
		private string _addedDate;
		private string _artist;
		private string _genre;
		private string _itemNote;
		private string _name;
		private string _owner;
		private string _digitalLocation;
		private static int _digitallMusicTotal;
		private string _digitalSubtype = "Music";
		private int _releaseYear;
		private string _specialVariant;
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

		public DigitalMusic()
		{
			throw new NotImplementedException();
		}
	}
}
