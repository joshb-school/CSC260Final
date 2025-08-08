using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public class PhysicalReading : PhysicalMedia
	{
		private string _addedDate;
		private string _author;
		private string _genre;
		private string _itemNote;
		private string _name;
		private string _owner;
		private bool _partOfSeries;
		private string _physicalLocation;
		private static int _physicalReadingTotal;
		private readonly string _physicalSubtype = "Reading";
		private string _readingType;
		private int _releaseYear;

        public PhysicalReading()
        {
            throw new NotImplementedException();
        }

        public override void DisplayTotal()
		{
			throw new NotImplementedException();
		}

		public override void AddItem()
		{
			throw new NotImplementedException();
		}

		public override void EditItem()
		{
			throw new NotImplementedException();
		}

		public override void DeleteItem()
		{
			throw new NotImplementedException();
		}
	}
}
