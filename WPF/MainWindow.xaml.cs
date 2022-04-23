﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using BLL;
using BLL.Questions;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List<YesOrNot> yesOrNotQuestions;
        // List<OpenQuestion> openQuestions;
        // List<RadioButtonQuestion> radioButtonQuestions;
        // List<CheckBoxQuestion> checkBoxQuestions;
        // List<Sorting> sortingquestions;
        public MainWindow()
        {
            InitializeComponent();
            UsersList.ItemsSource = UsersMock.GetUsersListMock();
            
        }

        private void ComboBoxQuestion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboBoxQuestion.SelectedIndex)
            {
                case 0:
                    StackPanelYesNo.Visibility = Visibility.Visible;
                    StackPanelWriteAQuestion.Visibility = Visibility.Hidden;
                    StackPanelChooseOneAnswerFromSeveral.Visibility = Visibility.Hidden;
                    StackPanelSelectMultipleAnswersFromMultiple.Visibility = Visibility.Hidden;
                    StackPanelSorting.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    StackPanelWriteAQuestion.Visibility = Visibility.Visible;
                    StackPanelYesNo.Visibility = Visibility.Hidden;
                    StackPanelChooseOneAnswerFromSeveral.Visibility = Visibility.Hidden;
                    StackPanelSelectMultipleAnswersFromMultiple.Visibility = Visibility.Hidden;
                    StackPanelSorting.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    StackPanelChooseOneAnswerFromSeveral.Visibility = Visibility.Visible;
                    StackPanelWriteAQuestion.Visibility = Visibility.Hidden;
                    StackPanelYesNo.Visibility = Visibility.Hidden;
                    StackPanelSelectMultipleAnswersFromMultiple.Visibility = Visibility.Hidden;
                    StackPanelSorting.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    StackPanelSelectMultipleAnswersFromMultiple.Visibility = Visibility.Visible;
                    StackPanelChooseOneAnswerFromSeveral.Visibility = Visibility.Hidden;
                    StackPanelWriteAQuestion.Visibility = Visibility.Hidden;
                    StackPanelYesNo.Visibility = Visibility.Hidden;
                    StackPanelSorting.Visibility = Visibility.Hidden;
                    break;
                case 4:
                    StackPanelSorting.Visibility = Visibility.Visible;
                    StackPanelSelectMultipleAnswersFromMultiple.Visibility = Visibility.Hidden;
                    StackPanelChooseOneAnswerFromSeveral.Visibility = Visibility.Hidden;
                    StackPanelWriteAQuestion.Visibility = Visibility.Hidden;
                    StackPanelYesNo.Visibility = Visibility.Hidden;
                    break;
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        


        private void ButtonAddAnAswerOption_Click(object sender, RoutedEventArgs e)
        {
            RadioButton newradiobutton = new RadioButton();
            StackPanelChooseOneAnswerFromSeveral.Children.Add(newradiobutton);
            TextBox newtextBox = new TextBox();
            newtextBox.Width = 294;
            newtextBox.Height = 26;
            newradiobutton.Content = newtextBox;
            
        }

        private void ButtonAddAnAswerOptionForMultipleAnswers_Click(object sender, RoutedEventArgs e)
        {
            CheckBox newcheckbox = new CheckBox();
            StackPanelSelectMultipleAnswersFromMultiple.Children.Add(newcheckbox);
            TextBox newtextBox = new TextBox();
            newtextBox.Width = 295;
            newtextBox.Height = 29;
            newcheckbox.Content = newtextBox;
        }

        private void buttonForSorting_Click(object sender, RoutedEventArgs e)
        {
            TextBox newtextBox = new TextBox();
            newtextBox.Height = 26;
            newtextBox.Width = 315;
            StackPanelSorting.Children.Add(newtextBox);
        }
    }
}
