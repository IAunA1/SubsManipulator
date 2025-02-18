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

namespace SubsManipulator
{
    public partial class MainWindow : Window
    {
        private SubsFile subsFile;
        public static MainWindow appWindow;

        public MainWindow()
        {
            InitializeComponent();
            appWindow = this;
        }

        private void FileButton_Click(object sender, RoutedEventArgs e)
        {
            subsFile = new SubsFile();
            subsFile.Get_OriginalFile();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            subsFile.Update_File(subsFile, delayTextBox.Text);
        }
    }
}
