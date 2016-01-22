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
                SubmitEditBtn.Content = "Add newSpell";
                Spell mySpell = new Spell();
                mySpell.SpellName = SpellNameEditTxtBx.Text;
                mySpell.Rank = RankEditTxtBx.Text;
                mySpell.Description = DescriptionEditTxtBx.Text;
                shared.character.spells.Add(mySpell);
                shared.spellListBx.Items.Add(mySpell.SpellName);
            }
            else
            {
                SubmitEditBtn.Content = "Edit current spell";
            }
            
            
        }
    }
}
