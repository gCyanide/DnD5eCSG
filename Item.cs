using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndDrugonsCharacterSheetGenerator
{
    class Item
    {
        public string Name { get; set; }                     // Item's name.
        public string Description { get; set; }              // Item's description.
        public string Weight { get; set; }                   // Item's weight in kgs.
        public string Cost { get; set; }                     // Item's cost in gold coins.
    }
}