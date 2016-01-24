using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.Serialization;
using System.Xml;

namespace rpgAssist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public static class shared
    {
        public static Spell currentSpell;
        public static Character character;
        public static ListView spellListView;
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            shared.spellListView = SpellListView;
            //SpellListView.View = ;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".xml";
            dlg.Filter = "xml documents (.xml)|*.xml";
            if (dlg.ShowDialog() == true)
            {
                string filename = dlg.FileName;
                Character character = new Character();

                updateChar();

                XmlData.saveData(shared.character, filename);
            }
           

        }

        private void RollBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultListBx.Items.Clear();
            Roll myRoll = new Roll(Convert.ToInt16(DieNumberTxtBx.Text), Convert.ToInt16(DieTypeTxtBx.Text), Convert.ToInt16(ModifierTxtBx.Text));
            ResultToChangeLbl.Content = Convert.ToString(myRoll.rollDice());
            for (int i = 0; i < myRoll.dieRes.Length; i++)
            {
                ResultListBx.Items.Add("dice number " + (i + 1) + " = " + myRoll.dieRes[i]);
            }
        }

        private void AddSpellBtn_Click(object sender, RoutedEventArgs e)
        {
            shared.currentSpell = null;
            SpellForm spellForm = new SpellForm();
            spellForm.Show();
        }

        private void NewCharBtn_Click(object sender, RoutedEventArgs e)
        {
            shared.character = new Character();
            CharNameTxtBx.Clear();
            AncestryTxtBx.Clear();
            AgeTxtBx.Clear();
            GenderTxtBx.Clear();
            BuildTxtBx.Clear();
            ReligionTxtBx.Clear();
            LangTxtBx.Clear();
            AppearanceTxtBx.Clear();
            PersTxtBx.Clear();
            TalentsTxtBx.Clear();
            ProfTxtBx.Clear();
            BackgroundTxtBx.Clear();
            NoviceTxtBx.Clear();
            NoviceTrainingTxtBx.Clear();
            NoviceTalentsTxtBx.Clear();
            ExpertPathTxtBx.Clear();
            CharacterObjTxtBx.Clear();
            ExpertStoryDevTxtBx.Clear();
            ExpertTalentsTxtBx.Clear();
            MasterPathTxtBx.Clear();
            MasterQuestTxtBx.Clear();
            MasterStoryDevTextBx.Clear();
            MasterTalentTxtBx.Clear();
            SpellListView.Items.Clear();
           
            //equipment stuff
            //----------------
            StrTxtBx.Clear();
            WillTxtBx.Clear();
            AgilTxtBx.Clear();
            IntTxtBx.Clear();
            HealthTxtBx.Clear();
            DmgTxtBx.Clear();
            HRTxtBx.Clear();
            InsaneTxtBx.Clear();
            PwrTxtBx.Clear();
            DefTxtBx.Clear();
            CorruptTxtBx.Clear();
            PerceptTxtBx.Clear();
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == true)
            {
                shared.character = new Character();
                XmlLoad<Character> loadCharacter = new XmlLoad<Character>();

                shared.character = loadCharacter.loadData(openFileDialog1.FileName);

                CharNameTxtBx.Text = shared.character.CharName;
                AncestryTxtBx.Text = shared.character.Ancestry;
                AgeTxtBx.Text = shared.character.Age;
                GenderTxtBx.Text = shared.character.Gender;
                BuildTxtBx.Text = shared.character.Build;
                ReligionTxtBx.Text = shared.character.Religion;
                LangTxtBx.Text = shared.character.Languages;
                AppearanceTxtBx.Text = shared.character.Appearance;
                PersTxtBx.Text = shared.character.Personality;
                TalentsTxtBx.Text = shared.character.RacialTalent;
                ProfTxtBx.Text = shared.character.Profession;
                BackgroundTxtBx.Text = shared.character.Background;
                NoviceTxtBx.Text = shared.character.NovicePath;
                NoviceTrainingTxtBx.Text = shared.character.NoviceTraining;
                NoviceTalentsTxtBx.Text = shared.character.NoviceTalents;
                ExpertPathTxtBx.Text = shared.character.ExpertPath;
                CharacterObjTxtBx.Text = shared.character.ExpertCharObj;
                ExpertStoryDevTxtBx.Text = shared.character.ExpertStoryDev;
                ExpertTalentsTxtBx.Text = shared.character.ExpertTalents;
                MasterPathTxtBx.Text = shared.character.MasterPath;
                MasterQuestTxtBx.Text = shared.character.MasterQuest;
                MasterStoryDevTextBx.Text = shared.character.MasterStoryDev;
                MasterTalentTxtBx.Text = shared.character.MasterTalents;


                //equipment stuff
                //----------------
                StrTxtBx.Text = shared.character.Strength;
                WillTxtBx.Text = shared.character.Will;
                AgilTxtBx.Text = shared.character.Agility;
                IntTxtBx.Text = shared.character.Intelect;
                HealthTxtBx.Text = shared.character.Health;
                DmgTxtBx.Text = shared.character.Dmg;
                HRTxtBx.Text = shared.character.HealingRate;
                InsaneTxtBx.Text = shared.character.Insanity;
                PwrTxtBx.Text = Convert.ToString(shared.character.Power);
                DefTxtBx.Text = shared.character.Def;
                CorruptTxtBx.Text = shared.character.Corruption;
                PerceptTxtBx.Text = shared.character.Perception;

                foreach(Spell spell in shared.character.spells)
                {
                    SpellListView.Items.Add(spell.SpellName);
                }
            }
        }

        private void CastBtn_Click(object sender, RoutedEventArgs e)
        {
            updateChar();
            if (shared.currentSpell.Casts >= shared.currentSpell.CastsPerDay)
            {
                string msg = "you cannot cast this spell anymore";
                string caption = "No more casts!";
                MessageBox.Show(msg, caption, MessageBoxButton.OK);
                return;
            }
            shared.currentSpell.Casts = shared.currentSpell.Casts ++;

            foreach (ListViewItem lvw in SpellListView.Items)
            {
                Spell currSpell = shared.character.spells.Where(x => x.SpellName == lvw.ToString()).First();
                if (currSpell != null)
                {
                    if (shared.currentSpell.Casts >= shared.currentSpell.CastsPerDay)
                    {
                        Color col = (Color)ColorConverter.ConvertFromString("Red");
                        Brush brush = new SolidColorBrush(col);
                        lvw.Background = brush;
                    }
                }
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            SpellForm spellForm = new SpellForm();
            spellForm.Show();
        }

        private void SpellListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateChar();
            //use this to update spell info next to the list box.
            //get the current spell from the listbox.Selected item.
            shared.currentSpell = shared.character.spells.Where(x => x.SpellName == SpellListView.SelectedItem.ToString()).First();
            //update spell labels to the right of SpellListbox
            SpellToChangeLbl.Content = shared.currentSpell.SpellName;
            TraditionToChangeLbl.Content = shared.currentSpell.Tradition;
            RequirementToChangeLbl.Content = shared.currentSpell.Requirement;
            AreaToChangeLbl.Content = shared.currentSpell.Area;
            SpentToChangeLbl.Content = shared.currentSpell.Casts;
            CastsPerDayToChangeLbl.Content = shared.currentSpell.CastsPerDay;
            RankToChangeLbl.Content = shared.currentSpell.Rank;
            DurationToChangeLbl.Content = shared.currentSpell.Duration;
            DescriptionToChangeLbl.Content = shared.currentSpell.Description;
        }

        public void updateChar()
        {
            shared.character.CharName = CharNameTxtBx.Text;
            shared.character.Ancestry = AncestryTxtBx.Text;
            shared.character.Age = AgeTxtBx.Text;
            shared.character.Gender = GenderTxtBx.Text;
            shared.character.Build = BuildTxtBx.Text;
            shared.character.Religion = ReligionTxtBx.Text;
            shared.character.Languages = LangTxtBx.Text;
            shared.character.Appearance = AppearanceTxtBx.Text;
            shared.character.Personality = PersTxtBx.Text;
            shared.character.RacialTalent = TalentsTxtBx.Text;
            shared.character.Profession = ProfTxtBx.Text;
            shared.character.Background = BackgroundTxtBx.Text;
            shared.character.NovicePath = NoviceTxtBx.Text;
            shared.character.NoviceTraining = NoviceTrainingTxtBx.Text;
            shared.character.NoviceTalents = NoviceTalentsTxtBx.Text;
            shared.character.ExpertPath = ExpertPathTxtBx.Text;
            shared.character.ExpertCharObj = CharacterObjTxtBx.Text;
            shared.character.ExpertStoryDev = ExpertStoryDevTxtBx.Text;
            shared.character.ExpertTalents = ExpertTalentsTxtBx.Text;
            shared.character.MasterPath = MasterPathTxtBx.Text;
            shared.character.MasterQuest = MasterQuestTxtBx.Text;
            shared.character.MasterStoryDev = MasterStoryDevTextBx.Text;
            shared.character.MasterTalents = MasterTalentTxtBx.Text;


            //equipment stuff
            //----------------
            shared.character.Strength = StrTxtBx.Text;
            shared.character.Will = WillTxtBx.Text;
            shared.character.Agility = AgilTxtBx.Text;
            shared.character.Intelect = IntTxtBx.Text;
            shared.character.Health = HealthTxtBx.Text;
            shared.character.Dmg = DmgTxtBx.Text;
            shared.character.HealingRate = HRTxtBx.Text;
            shared.character.Insanity = InsaneTxtBx.Text;
            shared.character.Power = Convert.ToInt32(PwrTxtBx.Text);
            shared.character.Def = DefTxtBx.Text;
            shared.character.Corruption = CorruptTxtBx.Text;
            shared.character.Perception = PerceptTxtBx.Text;
        }
    }
}
