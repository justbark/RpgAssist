using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace rpgAssist
{
    public class Character
    {
        private string tradition;
        private string level;
        private string racialTalent;
        private string charName;
        private string age;
        private string gender;
        private string ancestry;
        private string size;
        private string speed;
        private string build;
        private string appearance;
        private string religion;
        private string languages;
        private string personality;
        private string quirk;
        private string profession;
        private string wealth;
        private string background;
        private string armor;
        private string armorProp;
        private string armorDef;
        private string wep1;
        private string wep1Prop;
        private string wep1Hand;
        private string wep1Dmg;
        private string wep2;
        private string wep2Prop;
        private string wep2Hand;
        private string wep2Dmg;
        private string shield;
        private string shieldProp;
        private string shieldHand;
        private string shieldDmg;
        private string inventory;
        private string novicePath;
        private string noviceTraining;
        private string noviceTalents;
        private string expertPath;
        private string expertCharObj;
        private string expertStoryDev;
        private string expertTalents;
        private string masterPath;
        private string masterQuest;
        private string masterStoryDev;
        private string masterTalents;
        private string strength;
        private string will;
        private string intelect;
        private string agility;
        private string health;
        private string dmg;
        private string healingRate;
        private string insanity;
        private string corruption;
        private string power;
        private string def;
        private string perception;


        public List<Spell> spells = new List<Spell>();

        public string Tradition
        {
            get { return tradition; }
            set { tradition = value; }
        }
        public string RacialTalent
        {
            get { return racialTalent; }
            set { racialTalent = value; }
        }
        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        public string CharName
        {
            get { return charName; }
            set { charName = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Ancestry
        {
            get { return ancestry; }
            set { ancestry = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string Build
        {
            get { return build; }
            set { build = value; }
        }
        public string Appearance
        {
            get { return appearance; }
            set { appearance = value; }
        }
        public string Religion
        {
            get { return religion; }
            set { religion = value; }
        }
        public string Languages
        {
            get { return languages; }
            set { languages = value; }
        }
        public string Personality
        {
            get { return personality; }
            set { personality = value; }
        }
        public string Quirk
        {
            get { return quirk; }
            set { quirk = value; }
        }
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
        public string Wealth
        {
            get { return wealth; }
            set { wealth = value; }
        }
        public string Background
        {
            get { return background; }
            set { background = value; }
        }
        public string Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        public string ArmorProp
        {
            get { return armorProp; }
            set { armorProp = value; }
        }
        public string ArmorDef
        {
            get { return armorDef; }
            set { armorDef = value; }
        }
        public string Wep1
        {
            get { return wep1; }
            set { wep1 = value; }
        }
        public string Wep1Prop
        {
            get { return wep1Prop; }
            set { wep1Prop = value; }
        }
        public string Wep1Hand
        {
            get { return wep1Hand; }
            set { wep1Hand = value; }
        }
        public string Wep1Dmg
        {
            get { return wep1Dmg; }
            set { wep1Dmg = value; }
        }
        public string Wep2
        {
            get { return wep2; }
            set { wep2 = value; }
        }
        public string Wep2Prop
        {
            get { return wep2Prop; }
            set { wep2Prop = value; }
        }
        public string Wep2Hand
        {
            get { return wep2Hand; }
            set { wep2Hand = value; }
        }
        public string Wep2Dmg
        {
            get { return wep2Dmg; }
            set { wep2Dmg = value; }
        }
        public string Shield
        {
            get { return shield; }
            set { shield = value; }
        }
        public string ShieldProp
        {
            get { return shieldProp; }
            set { shieldProp = value; }
        }
        public string ShieldHand
        {
            get { return shieldHand; }
            set { shieldHand = value; }
        }
        public string ShieldDmg
        {
            get { return shieldDmg; }
            set { shieldDmg = value; }
        }
        public string Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
        public string NovicePath
        {
            get { return novicePath; }
            set { novicePath = value; }
        }
        public string NoviceTraining
        {
            get { return noviceTraining; }
            set { noviceTraining = value; }
        }
        public string NoviceTalents
        {
            get { return noviceTalents; }
            set { noviceTalents = value; }
        }
        public string ExpertPath
        {
            get { return expertPath; }
            set { expertPath = value; }
        }
        public string ExpertCharObj
        {
            get { return expertCharObj; }
            set { expertCharObj = value; }
        }
        public string ExpertStoryDev
        {
            get { return expertStoryDev; }
            set { expertStoryDev = value; }
        }
        public string ExpertTalents
        {
            get { return expertTalents; }
            set { expertTalents = value; }
        }
        public string MasterPath
        {
            get { return masterPath; }
            set { masterPath = value; }
        }
        public string MasterQuest
        {
            get { return masterQuest; }
            set { masterQuest = value; }
        }
        public string MasterStoryDev
        {
            get { return masterStoryDev; }
            set { masterStoryDev = value; }
        }
        public string MasterTalents
        {
            get { return masterTalents; }
            set { masterTalents = value; }
        }
        public string Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public string Will
        {
            get { return will; }
            set { will = value; }
        }
        public string Intelect
        {
            get { return intelect; }
            set { intelect = value; }
        }
        public string Agility
        {
            get { return agility; }
            set { agility = value; }
        }
        public string Health
        {
            get { return health; }
            set { health = value; }
        }
        public string Dmg
        {
            get { return dmg; }
            set { dmg = value; }
        }
        public string HealingRate
        {
            get { return healingRate; }
            set { healingRate = value; }
        }
        public string Insanity
        {
            get { return insanity; }
            set { insanity = value; }
        }
        public string Corruption
        {
            get { return corruption; }
            set { corruption = value; }
        }
        public string Power
        {
            get { return power; }
            set { power = value; }
        }
        public string Def
        {
            get { return def; }
            set { def = value; }
        }
        public string Perception
        {
            get { return perception; }
            set { perception = value; }
        }
        
    }
}
