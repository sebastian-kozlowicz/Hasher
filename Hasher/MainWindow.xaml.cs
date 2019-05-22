using Hasher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Hasher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Encodes raw text into hashed format
        /// </summary>
        /// <param name="sender">The key was pressed</param>
        /// <param name="e">The events of the TextChanged</param>
        private void Encode(object sender, TextChangedEventArgs e)
        {
            if (rawText.Text == string.Empty)
            {
                ClearButton_Click(sender, e);
            }
            else
            {
                MD5HashText.Text = Cipher.ComputeMD5Hash(rawText.Text);
                SHA1HashText.Text = Cipher.ComputeSHA1Hash(rawText.Text);
                SHA256HashText.Text = Cipher.ComputeSha256Hash(rawText.Text);
                SHA384HashText.Text = Cipher.ComputeSha384Hash(rawText.Text);
                SHA512HashText.Text = Cipher.ComputeSha512Hash(rawText.Text);
                RIPEMD160HashText.Text = Cipher.ComputeRipemd160Hash(rawText.Text);
            }
        }

        /// <summary>
        /// Saves hashed outputs to file
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The events of the Click</param>
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (rawText.Text == string.Empty)
                return;

            var row = new File();
            row["rawText"] = rawText.Text;
            row["MD5"] = MD5HashText.Text;
            row["SHA1"] = SHA1HashText.Text;
            row["SHA256"] = SHA256HashText.Text;
            row["SHA384"] = SHA384HashText.Text;
            row["SHA512"] = SHA512HashText.Text;
            row["RIPEMD160"] = RIPEMD160HashText.Text;

            File.Save(row);

        }

        /// <summary>
        /// Clears all TextBoxes
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The events of the Click</param>
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            rawText.Text = string.Empty;
            MD5HashText.Text = string.Empty;
            SHA1HashText.Text = string.Empty;
            SHA256HashText.Text = string.Empty;
            SHA384HashText.Text = string.Empty;
            SHA512HashText.Text = string.Empty;
            RIPEMD160HashText.Text = string.Empty;
        }
    }
}
