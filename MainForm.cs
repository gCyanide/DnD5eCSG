using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace DungeonsAndDrugonsCharacterSheetGenerator
{
    public partial class MainForm : Form
    {
        Character JohnDoe;
        public MainForm()
        {
            InitializeComponent();
            JohnDoe = new Character();
            CreateCharacter();
            GenerateJson();
        }

        private void CreateCharacter()
        {
            JohnDoe.Alignment = "Lawful Good";
            JohnDoe.Backstory = "I'm test!";
            JohnDoe.Class = new Class()
            {
                CharactedClass = (int) Classes.Artificer
            };
            JohnDoe.Experience = "0000";
            JohnDoe.Level = 1;
            JohnDoe.Race = new Race()
            {
                CharacterRace = (int) Races.Human
            };
            JohnDoe.Name = "Test";
            JohnDoe.SavingThrows = new SavingThrows()
            {
                StrengthSavingThrow = 0,
                ConstituionSavingThrow = 0,
                DextertirySavingThrow = 0,
                IntelligenceSavingThrow = 0,
                WisdomSavingThrow = 0,
                CharismaSavingThrow = 0
            };
            JohnDoe.Skills = new Skills()
            {
                Acrobatics = 0,
                AnimalHandling = 0,
                Arcana = 0,
                Athletics = 0,
                Deception = 0,
                History = 0,
                Insight = 0,
                Intimidation = 0,
                Investigation = 0,
                Medicine = 0,
                Nature = 0,
                Perception = 0,
                Persuation = 0,
                Religion = 0,
                SleightOfHands = 0,
                Stealth = 0,
                Survival = 0,
                PassiveInsight = 0,
                PassiveIntelligence = 0,
                PassivePerception = 0
            };
            JohnDoe.Stats = new Stats()
            {
                Strength = 0,
                Dexterity = 0,
                Constitution = 0,
                Intelligence = 0,
                Wisdom = 0,
                Charisma = 0
            };
            JohnDoe.SubInfo = new SubInfo()
            {
                Skintone = "White",
                Age = 0,
                EyesColor = "Black",
                Hair = "White",
                Height = 180,
                Weight = 80
            };
            JohnDoe.Inventory = new List<Item>();
            JohnDoe.Spells = new List<Spell>();
        }

        private void GenerateJson()
        {
            string jsonString = JsonSerializer.Serialize(JohnDoe);
            File.WriteAllText("config.json", jsonString);
        }
    }
}