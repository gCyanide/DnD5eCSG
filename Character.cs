using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndDrugonsCharacterSheetGenerator
{
    class Character
    {
        // need to think about vitality class ?
        public string Name { get; set; }                     // Character's name.
        public int Level { get; set; }                       // Character's level.
        public string Backstory { get; set; }                // Character's backstory.
        public string Alignment { get; set; }                // Character's alignment.
        public string Experience { get; set; }               // Character's experience.
        public Class Class { get; set; }                     // Character's class.
        public Race Race { get; set; }                       // Character's race.
        public SubInfo SubInfo { get; set; }                 // Character's look.
        public Stats Stats { get; set; }                     // Character's stats.
        public SavingThrows SavingThrows { get; set; }       // Character's saving throws.
        public Skills Skills { get; set; }                   // Character's skills.
        public List<Spell> Spells { get; set; }              // Character's spells.
        public List<Item> Inventory { get; set; }            // Character's inventory.
    }
}