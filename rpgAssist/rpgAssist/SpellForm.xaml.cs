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
            if (shared.currentSpell == null)
            {
                SubmitEditBtn.Content = "Add newSpell";
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
            }
        }

        private void SubmitEditBtn_Click(object sender, RoutedEventArgs e)
        {
            Spell currSpell = shared.currentSpell != null ? shared.currentSpell : new Spell();

            currSpell.SpellName = SpellNameEditTxtBx.Text;
            currSpell.Rank = Convert.ToInt32(RankEditTxtBx.Text);
            currSpell.Description = DescriptionEditTxtBx.Text;
            currSpell.Requirement = ReqEditTxtBx.Text;
            currSpell.Area = AreaEditTxtBx.Text;
            currSpell.Duration = DurationEditTxtBx.Text;

            if (currSpell != shared.currentSpell)
            {
                currSpell.Casts = 0;
                shared.character.spells.Add(currSpell);
                ListViewItem newItem = new ListViewItem();
                newItem.Content = currSpell.SpellName;
                shared.spellListView.Items.Add(newItem);
            }
            shared.currentSpell = currSpell;
            this.Close();

        }
    }
}
