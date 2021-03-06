﻿using System;
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
using Sudoku.View;
using Sudoku.Controls;
using Sudoku.Model;

namespace Sudoku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Values.Fill();
            Display.DrawTable(Table, Main);
            Display.DrawBoard(Board, Main);
            Protection.Protect();
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                Controller.W(Board, Main);
            }

            if (e.Key == Key.A)
            {
                Controller.A(Board, Main);
            }

            if (e.Key == Key.S)
            {
                Controller.S(Board, Main);
            }

            if (e.Key == Key.D)
            {
                Controller.D(Board, Main);
            }

            //To enter Values
            if (e.Key == Key.NumPad1)
            {
                Controller.One(Display.position, Board, Main);
            }

            if (e.Key == Key.NumPad2)
            {
                Controller.Two(Display.position, Board, Main);
            }

            if (e.Key == Key.NumPad3)
            {
                Controller.Three(Display.position, Board, Main);
            }

            if (e.Key == Key.NumPad4)
            {
                Controller.Four(Display.position, Board, Main);
            }

            if (e.Key == Key.NumPad5)
            {
                Controller.Five(Display.position, Board, Main);
            }

            if (e.Key == Key.NumPad6)
            {
                Controller.Six(Display.position, Board, Main);
            }

            if (e.Key == Key.NumPad7)
            {
                Controller.Seven(Display.position, Board, Main);
            }

            if (e.Key == Key.NumPad8)
            {
                Controller.Eight(Display.position, Board, Main);
            }

            if (e.Key == Key.NumPad9)
            {
                Controller.Nine(Display.position, Board, Main);
            }

            if (e.Key == Key.Back)
            {
                Controller.Delete(Display.position, Board, Main);
            }

            if (e.Key == Key.Enter)
            {
                Evaluate.Check(Board, Table);
            }
        }
    }
}
