using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Data.Structures.SkillEngine;

namespace DataTools.SkillEditor
{
    public partial class SkillEditor
    {
        public static void Start()
        {
            new SkillEditor().Show();
        }

        public SkillEditor()
        {
            InitializeComponent();

           // SkillBuilder.BuildAll();
           // QuestBuilder.Quests = QuestBuilder.GetQuests();
            SkillBuilder.skills = SkillBuilder.Getskills();

            TeratomeListBox.DataContext = SkillBuilder.skills;
            //TeratomeListBox.Items.SortDescriptions.Add(new SortDescription("QuestId", ListSortDirection.Ascending));

           // FilterId.TextChanged += FilterChanged;
           // FilterMapName.TextChanged += FilterChanged;

           // TeratomeListBox.SelectionChanged += SelectionChanged;
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Skill quest = (Skill)TeratomeListBox.SelectedItem;

            if (quest == null)
                return;

            propertyGrid.SelectedObject = quest;
        }

        private void FilterChanged(object sender, TextChangedEventArgs e)
        {
            TeratomeListBox.Items.Filter += FilterByName;
        }

        private bool FilterByName(object obj)
        {
            Skill npc = (Skill)obj;

            if (FilterId.Text.Length > 0)
            {
                if (npc.Name.IndexOf(FilterId.Text, StringComparison.OrdinalIgnoreCase) == -1)
                    return false;
            }

            return true;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
           SkillBuilder.SaveData((IEnumerable<Skill>)TeratomeListBox.DataContext);
            Reload(null, null);
        }

        private void Reload(object sender, RoutedEventArgs e)
        {
            TeratomeListBox.DataContext = SkillBuilder.skills;
        }

        private void New(object sender, RoutedEventArgs e)
        {
          /*  if (SkillBuilder.skills.Any(q => q.Name == "NewQuest" || q.QuestId == 123456789))
            {
                MessageBox.Show(
                    "Вы уже добавили пустой квест и не редактировали его!\nПрежде чем добавлять новый, заполните старый!",
                    "Внимание!");
                return;
            }
            QuestBuilder.Quests.Add(new Quest { Name = "NewQuest", QuestId = 123456789 });
            Reload(null, null);
        
           */
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            /*
            QuestBuilder.Quests.Remove((Quest)TeratomeListBox.SelectedItem);
            Reload(null, null);
        
             * 
             */
        }
        /*
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            MyListBoxItem item = listBox1.Items[e.Index] as MyListBoxItem; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {
                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    item.Message, // The message linked to the item
                    listBox1.Font, // Take the font from the listbox
                    new SolidBrush(item.ItemColor), // Set the color 
                    0, // X pixel coordinate
                    e.Index * listBox1.ItemHeight // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
            }
            else
            {
                // The item isn't a MyListBoxItem, do something about it
            }
        }
         */
    }
}
