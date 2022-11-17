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
using System.Text.RegularExpressions;

namespace QuestTxt
{
    /// <summary>
    /// Логика взаимодействия для QuestWindow.xaml
    /// </summary>
    public partial class QuestWindow : Window
    {
        Saves current_save = new Saves();

        Levels current_level = new Levels();

        Options option1 = new Options();
        Options option2 = new Options();
        Options option3 = new Options();

        Riddles riddle = new Riddles();

        public QuestWindow()
        {
            InitializeComponent();
        }

        public QuestWindow(int saveID)
        {
            InitializeComponent();

            using (QuestTxtEntities2 db = new QuestTxtEntities2())
            {
                current_save = db.Saves.Find(saveID);
            }
        }

        public QuestWindow(Saves save)
        {
            InitializeComponent();

            current_save = save;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
            //tb_riddle.Visibility = Visibility.Hidden;
            //button_submitRiddle.Visibility = Visibility.Hidden;
            //try
            //{

            //    using (QuestTxtEntities2 db = new QuestTxtEntities2())
            //    {
            //        current_level = db.Levels.Find(current_save.currentLevel);

            //        tb_Main.Text = current_level.textOFLevel;

            //        if (current_level.isEnd != true)
            //        {
            //            if (current_level.Options1 != null)
            //            {
            //                option1 = db.Options.Find(current_level.FirstOptionID);
            //                button_FirstOption.Content = option1.optionText;

            //                if (current_level.Options1 != null)
            //                {
            //                    option2 = db.Options.Find(current_level.SecondOptionID);
            //                    button_SecondOption.Content = option2.optionText;
            //                }
            //                if (current_level.Options1 != null)
            //                {
            //                    option3 = db.Options.Find(current_level.ThirdOptionID);
            //                    button_ThirdOption.Content = option3.optionText;
            //                }
            //            }
            //            else if (current_level.riddleID != null)
            //            {
            //                riddle = db.Riddles.Find(current_level.riddleID);

            //                tb_riddle.Visibility = Visibility.Visible;
            //                button_submitRiddle.Visibility = Visibility.Visible;

            //                button_FirstOption.Content = "";
            //                button_SecondOption.Content = "";
            //                button_ThirdOption.Content = "";
            //            }
            //        }
            //        else
            //        {
            //            button_FirstOption.Content = "Начать сначала";

            //            button_SecondOption.Content = "Начать сначала";
            //            button_ThirdOption.Content = "Начать сначала";
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Неизвестная ошибка");
            //}
        }

        private void button_FirstOption_Click(object sender, RoutedEventArgs e)
        {
            if (current_level.isEnd == true)
            {
                current_save.currentLevel = 100;
            }
            else if (current_level.FirstOptionID != null)
            {
                if (button_FirstOption.Content != "")
                    using (QuestTxtEntities2 db = new QuestTxtEntities2())
                    {
                        current_save.currentLevel = option1.nextLevelID;
                    }
            }
            Refresh();
        }

        private void button_SecondOption_Click(object sender, RoutedEventArgs e)
        {
            if (current_level.isEnd == true)
            {
                current_save.currentLevel = 100;
            }
            else if (current_level.SecondOptionID != null)
            {
                if (button_SecondOption.Content != "")
                    using (QuestTxtEntities2 db = new QuestTxtEntities2())
                    {
                        current_save.currentLevel = option2.nextLevelID;
                    }
            }
            Refresh();
        }

        private void button_ThirdOption_Click(object sender, RoutedEventArgs e)
        {
            if (current_level.isEnd == true)
            {
                current_save.currentLevel = 100;
            }
            else if (current_level.ThirdOptionID != null)
            {
                if (button_ThirdOption.Content != "")
                    using (QuestTxtEntities2 db = new QuestTxtEntities2())
                    {
                        current_save.currentLevel = option3.nextLevelID;
                    }
            }
            Refresh();
        }

        private void Refresh()
        {
            tb_riddle.Visibility = Visibility.Hidden;
            button_submitRiddle.Visibility = Visibility.Hidden;
            try
            {

                using (QuestTxtEntities2 db = new QuestTxtEntities2())
                {
                    current_level = db.Levels.Find(current_save.currentLevel);

                    tb_Main.Text = current_level.textOFLevel;


                    if (current_level.giveItemID != null)
                    {

                        ItemsList items = new ItemsList {ID=db.ItemsList.Count()+1, saveID = current_save.Save_ID, itemID = current_level.giveItemID };

                        db.ItemsList.Add(items);

                        db.SaveChanges();
                    }

                    if (current_level.isEnd != true)
                    {
                        if (current_level.FirstOptionID != null)
                        {
                            option1 = db.Options.Find(current_level.FirstOptionID);
                            if (option1.requiredItemID == null)
                                button_FirstOption.Content = option1.optionText;
                            else
                            {
                                var s = (from t
                                         in db.ItemsList
                                         where t.itemID == option1.requiredItemID
                                         && t.saveID == current_save.itemsListID
                                         select t).ToList();
                                if (s.Count != 0)
                                {
                                    button_FirstOption.Content = option1.optionText;
                                }
                                else button_FirstOption.Content = "";
                            }

                            if (current_level.SecondOptionID != null)
                            {
                                option2 = db.Options.Find(current_level.SecondOptionID);
                                if (option2.requiredItemID == null)
                                    button_SecondOption.Content = option2.optionText;
                                else
                                {
                                    var s = (from t
                                             in db.ItemsList
                                             where t.itemID == option2.requiredItemID
                                             && t.saveID == current_save.itemsListID
                                             select t).ToList();
                                    if (s.Count != 0)
                                    {
                                        button_SecondOption.Content = option2.optionText;
                                    }
                                    else button_SecondOption.Content = "";
                                }
                            }
                            else button_SecondOption.Content = "";
                            if (current_level.ThirdOptionID != null)
                            {

                                option3 = db.Options.Find(current_level.ThirdOptionID);
                                if (option3.requiredItemID == null)
                                    button_ThirdOption.Content = option3.optionText;
                                else
                                {
                                    var s = (from t
                                             in db.ItemsList
                                             where t.itemID == option3.requiredItemID
                                             && t.saveID == current_save.itemsListID
                                             select t).ToList();
                                    if (s.Count != 0)
                                    {
                                        button_ThirdOption.Content = option3.optionText;
                                    }
                                    else button_ThirdOption.Content = "";
                                }
                            }
                            else button_ThirdOption.Content = "";
                        }
                        else if (current_level.riddleID != null)
                        {
                            riddle = db.Riddles.Find(current_level.riddleID);

                            tb_riddle.Visibility = Visibility.Visible;
                            button_submitRiddle.Visibility = Visibility.Visible;

                            button_FirstOption.Content = "";
                            button_SecondOption.Content = "";
                            button_ThirdOption.Content = "";
                        }
                    }
                    else
                    {
                        button_FirstOption.Content = "Начать сначала";

                        button_SecondOption.Content = "Начать сначала";
                        button_ThirdOption.Content = "Начать сначала";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка");
            }
        }

        private void button_Menu_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow(current_save);
            menuWindow.Show();
            this.Close();
        }

        private void button_submitRiddle_Click(object sender, RoutedEventArgs e)
        {
            if (current_level.riddleID != null)
            {
                if (tb_riddle.Text.ToLower() == riddle.correctAnswer.ToLower())
                {
                    current_save.currentLevel = riddle.nextLevelID;
                }
                else current_save.currentLevel += 1;
                Refresh();
            }
        }

        private void tb_riddle_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex regex = new Regex(@"\W");
            tb_riddle.Text = regex.Replace(tb_riddle.Text, "");
        }
    }
}
