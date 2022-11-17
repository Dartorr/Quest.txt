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

namespace QuestTxt
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        Saves save = new Saves();
        public MenuWindow()
        {
            InitializeComponent();
        }
        public MenuWindow(Saves saves)
        {
            InitializeComponent();

            save = saves;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Begin_Click(object sender, RoutedEventArgs e)
        {
            Saves save = new Saves
            {
                Save_ID = 4,
                isCurrentSave = true,
                itemsListID = 4,
                currentLevel = 100
            };

            using (QuestTxtEntities2 db=new QuestTxtEntities2())
            {
                var sss = from alt in db.ItemsList where alt.saveID == 4 select alt;
                foreach (var ss in sss) db.ItemsList.Remove(ss);
                db.SaveChanges();
            }

            QuestWindow questWindow = new QuestWindow(save);
            questWindow.Show();
            this.Close();
        }

        private void button_Load_Click(object sender, RoutedEventArgs e)
        {
            SaveLoadWindow saveLoadWindow = new SaveLoadWindow(false);
            saveLoadWindow.Show();
            this.Close();
        }

        private void button_Save_Click(object sender, RoutedEventArgs e)
        {
            SaveLoadWindow saveLoadWindow = new SaveLoadWindow(true, save);
            saveLoadWindow.Show();
            this.Close();
        }
    }
}
