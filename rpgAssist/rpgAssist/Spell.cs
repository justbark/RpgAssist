using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgAssist
{
    public class Spell
    {
        private string spellName;
        private int castsPerDay;
        private int casts;
        private int rank;
        private string description;
        private string tradition;
        private string requirement;
        private string duration;
        private string area;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public string Requirement
        {
            get { return requirement; }
            set { requirement = value; }
        }
        public string Tradition
        {
            get { return tradition; }
            set { tradition = value; }
        }
        public string SpellName
        {
            get { return spellName; }
            set { spellName = value; }
        }
        public int CastsPerDay
        {
            get { return castsPerDay; }
            set { castsPerDay = value; }
        }
        public int Casts
        {
            get { return casts; }
            set { casts = value; }
        }
        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public void computeCPD(int pwr)
        {
            this.castsPerDay = (pwr + 1) - this.Rank;
        }
        
    }
}
