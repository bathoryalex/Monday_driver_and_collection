using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MondayDrive
{
    public partial class editingForm : Form
    {
        public editingForm()
        {
            InitializeComponent();
        }

        private void driveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pathTextBox.Text = driveComboBox.SelectedIndex == -1 ? string.Empty : driveComboBox.SelectedItem.ToString();
            pathTextBox.ReadOnly = true;
        }

        private void editingForm_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            List<DriveInfo> availableDrives = new List<DriveInfo>();
            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady)
                {
                    availableDrives.Add(drive);
                }
            }

            driveComboBox.DataSource = availableDrives;

            driveComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            pathTextBox.Text = driveComboBox.SelectedItem.ToString();
        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pathTextBox.Text != "")
            {
                string[] dirEntries = Directory.GetDirectories(pathTextBox.Text);
                string[] fileEntries = Directory.GetFiles(pathTextBox.Text);
                var entriesList = new List<string>();

                foreach (var dirEntry in dirEntries)
                {
                    entriesList.Add(dirEntry);
                }

                foreach (var fileEntry in fileEntries)
                {
                    entriesList.Add(fileEntry);
                }

                listBox.DataSource = entriesList;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var selectedItemInListBox = (string)listBox.SelectedItem;
            var attribute = File.GetAttributes(selectedItemInListBox);
            if (attribute == FileAttributes.Directory)
            {
                pathTextBox.Text = (string)listBox.SelectedItem;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            File.Delete(@"path");
            MessageBox.Show("This function is not working yet, sorry! :(");
        }
    }
}


