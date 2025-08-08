using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List <PhysicalMedia> physicalMedia = new List <PhysicalMedia>();
            List <PhysicalVideoGame> physicalVideoGame = new List <PhysicalVideoGame>();
            List <PhysicalMusic> physicalMusic = new List <PhysicalMusic>();
            List <PhysicalTableGame> physicalTableGame = new List <PhysicalTableGame>();
            List <PhysicalReading> physicalReading = new List <PhysicalReading>();
            List <DigitalMedia> digitalMedia = new List <DigitalMedia>();
            List <OtherItem> otherItem = new List <OtherItem>();
            
            PhysicalVideoGame physicalVideoGame1 = new PhysicalVideoGame("Sly 2", "Josh", "Playstation 2", 2004, "Action", "", "Main Shelf", "No", false, true, true);
            physicalVideoGame.Add(physicalVideoGame1);
            PhysicalVideoGame physicalVideoGame2 = new PhysicalVideoGame("Mass Effect", "Josh", "Xbox 360", 2007, "RPG", "", "Main Shelf", "No", false, true, true);
            physicalVideoGame.Add(physicalVideoGame2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FinalProjectForm());
        }
    }
}
