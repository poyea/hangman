﻿using System;
using System.Collections;
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

namespace hangman
{
    /* Author: @poyea
     * https://github.com/poyea
     * 
     */
    public partial class MainWindow : Window
    {
        List<Label> ListofLabel;
        List<Canvas> ListofBar;
        /* The above is for the word display */
        List<UIElement> TheHangMan; /*The hangman as a whole*/
        TextBlock WrongBox;
        string WordNow; /* store the current word to be guessed */
        int WrongGuesses; /* number of wrong guesses now */
        int MaximumGuess = 7;
        Word WordInstance = Word.WordPack;

        public MainWindow()
        {
            InitializeComponent();
            WrongBox = new TextBlock();
            WrongBox.Margin = new Thickness(250, 30, 0, 0);
            WrongBox.FontSize = 20;
            WrongBox.TextWrapping = TextWrapping.Wrap;
            /* We hold wrong characters guessed in the WrongBox */
            Grid.Children.Add(WrongBox);
            GuessButton.IsEnabled = false;

        }

        private void StartButtonClick(object sender, RoutedEventArgs e)
        {
            ListofLabel = new List<Label>();
            ListofBar = new List<Canvas>();
            SwapButtonState();
            
            CharList.Items.Clear();
            for (int i = 65; i <= 90; ++i)
            {
                CharList.Items.Add((char)i);
            }
            Grid.SetRow(WrongBox, 0);
            Grid.SetColumn(WrongBox, 1);
            WrongBox.Text = "";

            int Space = 0;
            WordInstance.LoadWord(); /* LoadANewWord */
            WordNow = WordInstance.TheWord;
            foreach (char c in WordNow) 
            {
                /*We make the word display in run time in this loop.*/
                Label lbl = new Label();
                Canvas can = new Canvas();
                can.Background = Brushes.Black;
                can.Width = 15;
                can.Height = 3;
                can.Margin = new Thickness(-220+ Space, 0, 0, 0);
                Grid.SetRow(can, 1);
                Grid.SetColumn(can, 1);
                Grid.Children.Add(can);

                lbl.Margin = new Thickness(-220 + Space, 28, 0, 0);
                lbl.Visibility = Visibility.Hidden;
                lbl.Width = 60;
                lbl.HorizontalContentAlignment = HorizontalAlignment.Center;
                lbl.FontSize = 20;
                lbl.Content = c;

                Grid.SetRow(lbl, 1);
                Grid.SetColumn(lbl, 1);
                Grid.Children.Add(lbl);

                ListofLabel.Add(lbl);
                ListofBar.Add(can);
                Space += 60;
            }

            TheHangMan = new List<UIElement>() { HangGround, HangBar, HangHead, HangBody, HangHands, HangLegs, HangRope };
            foreach (UIElement ele in TheHangMan)
            {

                ele.Visibility = Visibility.Hidden;
            }
            WrongGuesses = 0;
            ShowWrongGuesses.Content = MaximumGuess - WrongGuesses;
        }

        private bool HasWon(List<Label> Lol)
        {
            bool HasHidden = false;
            foreach (Label l in Lol)
            {
                if (l.Visibility == Visibility.Hidden)
                    HasHidden = true;
            }
            return !HasHidden;
        }

        private void SwapButtonState()
        {
            StartButton.IsEnabled = !StartButton.IsEnabled;
            GuessButton.IsEnabled = !GuessButton.IsEnabled;
        }

        private void ClearTable()
        {
            foreach (Label u in ListofLabel)
                u.Content = "";
            foreach (Canvas c in ListofBar)
                c.Visibility = Visibility.Hidden;
        }

        private void GuessButtonClick(object sender, RoutedEventArgs e)
        {
            bool flag = false;

            if (CharList.SelectedItem != null && WrongGuesses < MaximumGuess)
            {
                foreach (Label l in ListofLabel)
                {
                    if ((char)l.Content == (char)CharList.SelectedItem)
                    {
                        l.Visibility = Visibility.Visible;
                        flag = true;
                    }
                }

                if (!flag)
                {
                    WrongBox.Text += " " + (char)CharList.SelectedItem;
                    DrawOneStep();
                    //System.Media.SystemSounds.Asterisk.Play();
                }
                if (CharList.SelectedItem != null)
                    CharList.Items.Remove(CharList.SelectedItem);
            }

            if (HasWon(ListofLabel))
            {
                MessageBox.Show("You won! Press Start button to replay!");
                SwapButtonState();
                ClearTable();
            }
        }


        private void DrawOneStep()
        {
            if (WrongGuesses < MaximumGuess) {
            if (TheHangMan[WrongGuesses].Visibility == Visibility.Hidden)
            {
                TheHangMan[WrongGuesses].Visibility = Visibility.Visible;
                WrongGuesses++; /* We add one wrong guess when we draw. */
                ShowWrongGuesses.Content = MaximumGuess - WrongGuesses;
                if (WrongGuesses >= MaximumGuess)
                {
                    MessageBox.Show("Game Over!");
                    MessageBox.Show("The correct word is "+WordNow);
                    MessageBox.Show("Press Start button to replay!");
                    SwapButtonState();
                    ClearTable();
                }
            }
            }
        }

        private void AboutButtonClick(object sender, RoutedEventArgs e)
        {
            AboutWindow abw = new AboutWindow();
            abw.Show();
            About.Visibility = Visibility.Hidden;
        }
    }
}
