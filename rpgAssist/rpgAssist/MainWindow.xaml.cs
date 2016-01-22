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
        public static ListBox spellListBx;
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            shared.spellListBx = SpellListBox;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";
            if (dlg.ShowDialog() == true)
            {
                string filename = dlg.FileName;
                Character character = new Character();

                XmlData.saveData(character, filename);
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

        private void SpellListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //use this to update spell info next to the list box.
            //get the current spell from the listbox.Selected item.
            shared.currentSpell = shared.character.spells.Where(x => x.SpellName == SpellListBox.SelectedItem.ToString()).First();
        }
    }
}
