using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hasher;
using System.Windows;

namespace Hasher.Models
{
    public class File
    {
        /// <summary>
        /// Stores hash function names and its outputs
        /// </summary>
        private readonly Dictionary<string, string> _dictionary;

        public File()
        {
            _dictionary = new Dictionary<string, string>();
        }

        /// <summary>
        /// Assigns and returns value to/from dictionary that stores hash function names and its outputs
        /// </summary>
        /// <param name="key">Hash function name</param>
        /// <returns>Hash function output for certain algorithm</returns>
        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }

        /// <summary>
        ///  Opens File Dialog Box and saves hashed outputs in txt file
        /// </summary>
        /// <param name="row">Stores hashed text encoded with certain algorithm</param>
        public static void Save(File row)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "Outputs.txt";
            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == true)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());

                writer.WriteLine(TextFormat(row));

                writer.Dispose();
                writer.Close();
            }
        }

        /// <summary>
        /// Saves formated hashed outputs into text string that each line contain single output
        /// </summary>
        /// <param name="row">Stores hashed text encoded with certain algorithm</param>
        /// <returns>Formated text string</returns>
        public static string TextFormat(File row)
        {
            string text = String.Format("Encrypted text: {0}\n", row["rawText"]);
            text += String.Format("MD5 hash: {0}\n", row["MD5"]);
            text += String.Format("SHA1 hash: {0}\n", row["SHA1"]);
            text += String.Format("SHA256 hash: {0}\n", row["SHA256"]);
            text += String.Format("SHA384 hash: {0}\n", row["SHA384"]);
            text += String.Format("SHA512 hash: {0}\n", row["SHA512"]);
            text += String.Format("RIPEMD160 hash: {0}\n", row["RIPEMD160"]);

            return text;
        }
    }
}
