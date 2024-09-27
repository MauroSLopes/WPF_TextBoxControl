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

namespace WPF_TextBoxControl.View.UserControls.TextControls
{
    /// <summary>
    /// Interação lógica para ClearableTextBox.xam
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {

        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set { 
                placeholder = value; 
                tbPlaceHolder.Text = placeholder;
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                tbPlaceHolder.Visibility = Visibility.Hidden;
            }
            else tbPlaceHolder.Visibility = Visibility.Visible;


        }
    }
}
