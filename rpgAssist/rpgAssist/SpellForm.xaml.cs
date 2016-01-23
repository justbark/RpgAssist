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
using System.Windows.Shapes;

namespace rpgAssist
{
    /// <summary>
    /// Interaction logic for SpellForm.xaml
    /// </summary>
    public partial class SpellForm : Window
    {
        public SpellForm()
        {
            InitializeComponent();
        }

        private void SubmitEditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (shared.currentSpell == null)
            {
                SubmitEditBtn.Content = "Add newSpell";            //change the submit btn to avoid confusion (we are adding a new spell here)
                shared.currentSpell = new Spell();

                shared.currentSpell.SpellName = SpellNameEditTxtBx.Text;
                shared.currentSpell.Rank = RankEditTxtBx.Text;
                shared.currentSpell.Description = DescriptionEditTxtBx.Text;
                shared.currentSpell.Requirement = ReqEditTxtBx.Text;
                shared.currentSpell.Area = AreaEditTxtBx.Text;
                shared.currentSpell.Duration = DurationEditTxtBx.Text;

                shared.currentSpell.Casts = 0.ToString();                       //The spell has just been added. So it couldnt have been cast already
                //GetCPD();                                           //go get casts per day        

                shared.character.spells.Add(shared.currentSpell);               //add this spell to Character class
                shared.spellListBx.Items.Add(shared.currentSpell.SpellName);    //add this spell to spell list
                this.Close();
            }
            else
            {
                SubmitEditBtn.Content = "Edit spell";
                SpellNameEditTxtBx.Text = shared.currentSpell.SpellName;
                RankEditTxtBx.Text = shared.currentSpell.Rank;
                DescriptionEditTxtBx.Text = shared.currentSpell.Description;
                ReqEditTxtBx.Text = shared.currentSpell.Requirement;
                AreaEditTxtBx.Text = shared.currentSpell.Area;
                DurationEditTxtBx.Text = shared.currentSpell.Duration;

                //GetCPD();                                           //go get casts per day
                this.Close();
            }
            
            
        }
        public void GetCPD()
        {
            int pwr = Convert.ToInt32(shared.character.Power);
            int rnk = Convert.ToInt32(shared.currentSpell.Rank);

            if (pwr == 0)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
            if (pwr == 1)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(2);
                }
                if (rnk == 1)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
            if (pwr == 2)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(3);
                }
                if (rnk == 1)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(2);
                }
                if (rnk == 2)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
            if (pwr == 3)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(4);
                }
                if (rnk == 1)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(3);
                }
                if (rnk == 2)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(2);
                }
                if (rnk == 3)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
            if (pwr == 4)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(5);
                }
                if (rnk == 1)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(4);
                }
                if (rnk == 2)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(3);
                }
                if (rnk == 3)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(2);
                }
                if (rnk == 4)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
            if (pwr == 5)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(6);
                }
                if (rnk == 1)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(5);
                }
                if (rnk == 2)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(4);
                }
                if (rnk == 3)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(3);
                }
                if (rnk == 4)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(2);
                }
                if (rnk == 5)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
            if (pwr == 6)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(7);
                }
                if (rnk == 1)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(6);
                }
                if (rnk == 3)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(5);
                }
                if (rnk == 2)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(4);
                }
                if (rnk == 4)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(3);
                }
                if (rnk == 5)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(2);
                }
                if (rnk == 6)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
            if (pwr == 7)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(8);
                }
                if (rnk == 1)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(7);
                }
                if (rnk == 3)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(6);
                }
                if (rnk == 2)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(5);
                }
                if (rnk == 4)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(4);
                }
                if (rnk == 5)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(3);
                }
                if (rnk == 6)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(2);
                }
                if (rnk == 7)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
            if (pwr == 8)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(9);
                }
                if (rnk == 1)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(8);
                }
                if (rnk == 3)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(7);
                }
                if (rnk == 2)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(6);
                }
                if (rnk == 4)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(5);
                }
                if (rnk == 5)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(4);
                }
                if (rnk == 6)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(3);
                }
                if (rnk == 7)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(2);
                }
                if (rnk == 8)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
            if (pwr == 9)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(10);
                }
                if (rnk == 1)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(9);
                }
                if (rnk == 3)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(8);
                }
                if (rnk == 2)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(7);
                }
                if (rnk == 4)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(6);
                }
                if (rnk == 5)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(5);
                }
                if (rnk == 6)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(4);
                }
                if (rnk == 7)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(3);
                }
                if (rnk == 8)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(2);
                }
                if (rnk == 9)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
            if (pwr == 10)
            {
                if (rnk == 0)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(11);
                }
                if (rnk == 1)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(10);
                }
                if (rnk == 3)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(9);
                }
                if (rnk == 2)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(8);
                }
                if (rnk == 4)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(7);
                }
                if (rnk == 5)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(6);
                }
                if (rnk == 6)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(5);
                }
                if (rnk == 7)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(4);
                }
                if (rnk == 8)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(3);
                }
                if (rnk == 9)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(2);
                }
                if (rnk == 10)
                {
                    shared.currentSpell.CastsPerDay = Convert.ToString(1);
                }
            }
        }
    }
}
