using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
    public class PhysicalVideoGame : PhysicalMedia
    {
        private static int _physicalVideoGameTotal;
        private int _releaseYear;
        private readonly string _physicalSubtype = "Video Game";
        private string _addedDate;
        private string _console;
        private string _genre;
        private string _itemNote;
        private string _name;
        private string _owner;
        private string _physicalLocation;
        private string _specialVariant;
        private bool _backwardsCompatible;
        private bool _completeCase;
        private bool _working;

        public int PhysicalVideoGameTotal
        {
            get { return _physicalVideoGameTotal; }
            set { _physicalVideoGameTotal++; }
        }

        public string AddedDate
        {
            get { return _addedDate; }
            set { _addedDate = value; }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set { _releaseYear = value; }
        }

        public string Console
        {
            get { return _console; }
            set { _console = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set {_genre = value;}
        }

        public string ItemNote
        {
            get { return _itemNote; }
            set { _itemNote = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public string PhysicalLocation
        {
            get { return _physicalLocation; }
            set { _physicalLocation = value; }
        }

        public string SpecialVariant
        {
            get { return _specialVariant; }
            set { _specialVariant = value; }
        }

        public bool BackwardsCompatible
        {
            get { return _backwardsCompatible; }
            set { _backwardsCompatible = value; }
        }

        public bool CompleteCase
        {
            get { return _completeCase; }
            set { _completeCase = value; }
        }

        public bool Working
        {
            get { return _working; }
            set { _working = value; }
        }

        public PhysicalVideoGame(string name, string owner, string console, int year, string genre, string itemNote, string physicalLocation, string specialVariant, bool backwardsCompatible, bool complete, bool working)
        {
            AddedDate = DateTime.Today.ToString();
            PhysicalVideoGameTotal++;
            this._name = name;
            this._owner = owner;
            this._console = console;
            this._releaseYear = year;
            this._genre = genre;
            this._itemNote  = itemNote;
            this._physicalLocation = physicalLocation; 
            this._specialVariant = specialVariant;
            this._backwardsCompatible = backwardsCompatible;
            this._completeCase = complete;
            this._working = working;
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
