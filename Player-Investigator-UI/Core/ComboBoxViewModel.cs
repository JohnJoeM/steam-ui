using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Investigator_UI.Core
{
    public class ComboBoxViewModel
    {
        public List<string> GameCollection { get; set; }

        public ComboBoxViewModel()
        {
            GameCollection = new List<string>()
            {
                "CS:GO",
                "DOTA 2",
                "Apex Legends",
                

            };

        }
    }
}
