using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndDrugonsCharacterSheetGenerator
{
    class Character
    {
        // need to think about vitality class ?
        public string Name;                     // Character's name.
        public int Level;                       // Character's level.
        public string Backstory;                // Character's backstory.
        public string Alignment;                // Character's alignment.
        public string Experience;               // Character's experience.
        public CharacterClass Class;            // Character's class.
        public Race Race;                       // Character's race.
        public SubInfo SubInfo;                 // Character's look.
        public Stats Stats;                     // Character's stats.
        public SavingThrows SavingThrows;       // Character's saving throws.
        public Skills Skills;                   // Character's skills.
        public List<Spell> Spells;              // Character's spells.
        public List<Item> Inventory;            // Character's inventory.
    }
}