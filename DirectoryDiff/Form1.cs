using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectoryDiff
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            txtDir1.Text = folderPath;
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            txtDir2.Text = folderPath;
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtDir1.Text) && !String.IsNullOrEmpty(txtDir2.Text))
            {
                string pathA = txtDir1.Text;
                string pathB = txtDir2.Text;

                System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(pathA);
                System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(pathB);

                // Take a snapshot of the file system.
                IEnumerable<System.IO.FileInfo> list1 = dir1.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
                IEnumerable<System.IO.FileInfo> list2 = dir2.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

                //A custom file comparer defined in FileCompare.cs
                FileCompare myFileCompare = new FileCompare();

                // This query determines whether the two folders contain 
                // identical file lists, based on the custom file comparer 
                // that is defined in the FileCompare class. 
                // The query executes immediately because it returns a bool. 
                bool areIdentical = list1.SequenceEqual(list2, myFileCompare);

                if (areIdentical == true)
                {
                    lstFiles.Items.Add("the two folders are the same");
                }
                else
                {
                    lstFiles.Items.Add("The two folders are not the same");
                }

                // Find the set difference between the two folders. 
                // Start with Folder 1
                var queryList1Only = (from file in list1
                                      select file).Except(list2, myFileCompare);

                lstFiles.Items.Add("The following files are in Directory 1 but not Directory 2:");
                foreach (var v in queryList1Only)
                {
                    lstFiles.Items.Add(v.FullName);
                }

                // Then Folder 2
                var queryList2Only = (from file in list2
                                      select file).Except(list1, myFileCompare);

                lstFiles.Items.Add("The following files are in Directory 2 but not in Directory 1:");
                foreach(var v in queryList2Only)
                {
                    lstFiles.Items.Add(v.FullName);
                }
            }
        }

        private void btnSimiliar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDir1.Text) && !String.IsNullOrEmpty(txtDir2.Text))
            {
                string pathA = txtDir1.Text;
                string pathB = txtDir2.Text;

                System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(pathA);
                System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(pathB);

                // Take a snapshot of the file system.
                IEnumerable<System.IO.FileInfo> list1 = dir1.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
                IEnumerable<System.IO.FileInfo> list2 = dir2.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

                //A custom file comparer defined in FileCompare.cs
                FileCompare myFileCompare = new FileCompare();

                // This query determines whether the two folders contain 
                // identical file lists, based on the custom file comparer 
                // that is defined in the FileCompare class. 
                // The query executes immediately because it returns a bool. 
                bool areIdentical = list1.SequenceEqual(list2, myFileCompare);

                if (areIdentical == true)
                {
                    lstFiles.Items.Add("the two folders are the same");
                }
                else
                {
                    lstFiles.Items.Add("The two folders are not the same");
                }

                // Find the common files. It produces a sequence and doesn't  
                // execute until the foreach statement. 
                var queryCommonFiles = list1.Intersect(list2, myFileCompare);

                if (queryCommonFiles.Count() > 0)
                {
                    lstFiles.Items.Add("The following files are in both folders:");
                    foreach (var v in queryCommonFiles)
                    {
                        lstFiles.Items.Add(v.FullName); //shows which items end up in result list
                    }
                }
                else
                {
                    lstFiles.Items.Add("There are no common files in the two folders.");
                }
            }
        }
    }
}
