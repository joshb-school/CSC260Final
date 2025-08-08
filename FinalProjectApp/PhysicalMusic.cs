using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public class PhysicalMusic : PhysicalMedia
	{
		private string _addedDate;
		private string _artist;
		private bool _completeCase;
		private string _genre;
		private string _itemNote;
		private string _musicType;
		private string _name;
		private string _owner;
		private string _physicalLocation;
		private static int _physicalMusicTotal;
		private string _physicalSubtype = "Music";
		private int _releaseYear;
		private string _specialVariant;
		private bool _working;

        public PhysicalMusic()
        {
            throw new NotImplementedException();
        }

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
	}
}
