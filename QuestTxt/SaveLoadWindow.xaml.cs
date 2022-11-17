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
    /// Логика взаимодействия для SaveLoadWindow.xaml
    /// </summary>
    public partial class SaveLoadWindow : Window
    {
        Saves currentSave = new Saves();
        List<Saves> k = new List<Saves>();
        bool isSaveMode = true;
        public SaveLoadWindow()
        {
            InitializeComponent();
        }

        public SaveLoadWindow(bool isSave, Saves saves)
        {
            InitializeComponent();

            currentSave = saves;
            if (!isSave)
            {
                isSaveMode = isSave;

                tb_title.Text = "ЗАГРУЗИТЬ!";

                button_Save1.Content = "Загрузить!";
                button_Save2.Content = "Загрузить!";
                button_Save3.Content = "Загрузить!";
            }


            using (QuestTxtEntities2 db = new QuestTxtEntities2())
            {
                k = db.Saves.ToList();

                if (k[0].currentLevel > 5999) tb_Save1.Text += "Под люком";
                else if (k[0].currentLevel > 3999) tb_Save1.Text += "За дверью";
                else if (k[0].currentLevel > 1999) tb_Save1.Text += "Эдик";
                else if (k[0].currentLevel > 0) tb_Save1.Text += "Стекло";

                if (k[1].currentLevel > 5999) tb_Save2.Text += "Под люком";
                else if (k[1].currentLevel > 3999) tb_Save2.Text += "За дверью";
                else if (k[1].currentLevel > 1999) tb_Save2.Text += "Эдик";
                else if (k[1].currentLevel > 0) tb_Save2.Text += "Стекло";

                if (k[2].currentLevel > 5999) tb_Save3.Text += "Под люком";
                else if (k[2].currentLevel > 3999) tb_Save3.Text += "За дверью";
                else if (k[2].currentLevel > 1999) tb_Save3.Text += "Эдик";
                else if (k[2].currentLevel > 0) tb_Save3.Text += "Стекло";

                tb_Save1.Text += ". Номер уровня: " + k[0].currentLevel;
                tb_Save2.Text += ". Номер уровня: " + k[1].currentLevel;
                tb_Save3.Text += ". Номер уровня: " + k[2].currentLevel;

            }
        }

        public SaveLoadWindow(bool isSave)
        {
            InitializeComponent();

            if (!isSave)
            {
                isSaveMode = isSave;

                tb_title.Text = "ЗАГРУЗИТЬ!";

                button_Save1.Content = "Загрузить!";
                button_Save2.Content = "Загрузить!";
                button_Save3.Content = "Загрузить!";
            }


            using (QuestTxtEntities2 db = new QuestTxtEntities2())
            {
                k = db.Saves.ToList();

                if (k[0].currentLevel > 5999) tb_Save1.Text += "Эдик";
                else if (k[0].currentLevel > 3999) tb_Save1.Text += "Под люком";
                else if (k[0].currentLevel > 1999) tb_Save1.Text += "За дверью";
                else if (k[0].currentLevel > 0) tb_Save1.Text += "Стекло";

                tb_Save1.Text += ". Номер уровня: " + k[0].currentLevel;

                if (k[1].currentLevel > 5999) tb_Save2.Text += "Эдик";
                else if (k[1].currentLevel > 3999) tb_Save2.Text += "Под люком";
                else if (k[1].currentLevel > 1999) tb_Save2.Text += "За дверью";
                else if (k[1].currentLevel > 0) tb_Save2.Text += "Стекло";

                tb_Save2.Text += ". Номер уровня: " + k[1].currentLevel;

                if (k[2].currentLevel > 5999) tb_Save3.Text += "Эдик";
                else if (k[2].currentLevel > 3999) tb_Save3.Text += "Под люком";
                else if (k[2].currentLevel > 1999) tb_Save3.Text += "За дверью";
                else if (k[2].currentLevel > 0) tb_Save3.Text += "Стекло";

                tb_Save3.Text += ". Номер уровня: " + k[2].currentLevel;
            }
        }

        private void button_Save1_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                if (k.Count != 0)
                {
                    if (!isSaveMode)
                    {
                        QuestWindow questWindow = new QuestWindow(1);
                        questWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        save(1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка");
            }
        }

        private void button_Save2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (k.Count != 0)
                {
                    if (!isSaveMode)
                    {
                        QuestWindow questWindow = new QuestWindow(2);
                        questWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        save(2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка");
            }
        }

        private void button_Save3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (k.Count != 0)
                {
                    if (!isSaveMode)
                    {
                        QuestWindow questWindow = new QuestWindow(3);
                        questWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        save(3);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка");
            }
        }

        private void button_GoBack_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow(currentSave);
            menuWindow.Show();
            this.Close();
        }

        private void save(int l)
        {
            try
            {
                using (QuestTxtEntities2 db = new QuestTxtEntities2())
                {
                    
                    var t = from k in db.ItemsList where k.saveID == l select k;
                    foreach (var k in t) db.ItemsList.Remove(k);

                    db.SaveChanges();

                    int s = 1;
                    s += db.ItemsList.Count();
                    if (currentSave.Save_ID != 4)
                    {
                        var tt = from k in db.ItemsList where k.saveID == currentSave.itemsListID select k;
                        foreach (var k in tt)
                        {
                            ItemsList tem = new ItemsList
                            {
                                ID = s,
                                itemID = k.itemID,
                                saveID = l
                            };
                            db.ItemsList.Add(tem);
                            s++;
                        }
                    }
                    else
                    {
                        currentSave.itemsListID = l;
                        foreach (var k in currentSave.ItemsList)
                        {
                            ItemsList tem = new ItemsList
                            {
                                ID = s,
                                itemID = k.itemID,
                                saveID = l
                            };
                            db.ItemsList.Add(tem);
                            s++;
                        }
                    }
                    if (currentSave.Save_ID == 4) currentSave.Save_ID = l;
                    else
                    db.Saves.Find(currentSave.Save_ID).isCurrentSave = false;
                    db.Saves.Find(l).isCurrentSave = true;
                    db.Saves.Find(l).currentLevel = currentSave.currentLevel;

                    db.SaveChanges();
                    

                }
                MessageBox.Show("Успешно сохранено!");
            }
            catch(Exception ex)
            {
               MessageBox.Show("Либо ты слишком быстро тыкал кнопки, либо сохранился в неприятном месте. Повтори попытку позже!");
            }
            finally
            {
                QuestWindow questWindow = new QuestWindow(l);
                questWindow.Show();
                this.Close();
            }
        }
    }
}
