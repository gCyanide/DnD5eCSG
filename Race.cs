using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndDrugonsCharacterSheetGenerator
{
    class Race
    {
        public int CharacterRace { get; set; }              // Character's race.
    }

    /// <summary>
    /// Available character races.
    /// </summary>
    public enum Races
    {
        Dragonborn,
        Dwarf,
        Elf,
        ElfDrow,
        Gnome,
        HalfElf,
        Halfling,
        HalfOrc,
        Human,
        Tiefling
    }
}