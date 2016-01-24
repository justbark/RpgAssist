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
                shared.currentSpell.Rank = Convert.ToInt32(RankEditTxtBx.Text);
                shared.currentSpell.Description = DescriptionEditTxtBx.Text;
                shared.currentSpell.Requirement = ReqEditTxtBx.Text;
                shared.currentSpell.Area = AreaEditTxtBx.Text;
                shared.currentSpell.Duration = DurationEditTxtBx.Text;

                shared.currentSpell.Casts = 0;                       //The spell has just been added. So it couldnt have been cast already                                       //go get casts per day        

                shared.character.spells.Add(shared.currentSpell);               //add this spell to Character class
                shared.spellListView.Items.Add(shared.currentSpell.SpellName);    //add this spell to spell list
                this.Close();
            }
            else
            {
                SubmitEditBtn.Content = "Edit spell";
                SpellNameEditTxtBx.Text = shared.currentSpell.SpellName;
                RankEditTxtBx.Text = Convert.ToString(shared.currentSpell.Rank);
                DescriptionEditTxtBx.Text = shared.currentSpell.Description;
                ReqEditTxtBx.Text = shared.currentSpell.Requirement;
                AreaEditTxtBx.Text = shared.currentSpell.Area;
                DurationEditTxtBx.Text = shared.currentSpell.Duration;
                                         //go get casts per day
                this.Close();
            }
            
            
        }
    }
}
