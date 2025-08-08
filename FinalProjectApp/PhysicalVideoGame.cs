using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp
{
	public class PhysicalVideoGame : PhysicalMedia
	{
		private string _addedDate;
		private bool _backwardsCompatible;
		private bool _completeCase;
		private string _console;
		private string _genre;
		private string _itemNote;
		private string _name;
		private string _owner;
		private string _physicalLocation;
		private readonly string _physicalSubtype = "Video Game";
		private static int _physicalVideoGameTotal;
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

		public void PhysicalVideoGame()
		{
			throw new NotImplementedException();
		}
	}
}
