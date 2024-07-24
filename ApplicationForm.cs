using ArrayFunctionsNamespace;
using DirectoryFunctionsNamespace;
using FileFunctionsNamespace;
using HardwareFunctionsNamespace;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using XMLFileFunctionsNamespace;
namespace WindowsFormsApp3
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // set size of panels.
            int size_full = this.ClientSize.Width;
            panel1.Width = size_full / 2;
            panel2.Width = size_full - size_full / 2;
            panel_buttons_1.Width = size_full / 2;
            panel_buttons_2.Width = size_full - size_full / 2;

            // settings file
            ExeName = FileFunctions.FileName.Programm().Replace(" ", "_");
            ExeDirectory = DirectoryFunctions.DirectoryPath.Programm();
            SettingsFilePath = ExeDirectory + ExeName + ".xml";
            if (System.IO.File.Exists(SettingsFilePath) == false)
            {
                XMLFileFunctions.CreateFile(SettingsFilePath, ExeName);
                XmlDocument xml_doc = XMLFileFunctions.LoadFile(SettingsFilePath);
                XMLFileFunctions.AddToRoot(xml_doc, "FolderUpdate");
                XMLFileFunctions.AddToRoot(xml_doc, "FolderSource");
                XMLFileFunctions.SaveFile(xml_doc, SettingsFilePath);
            }
            else
            {
                XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
                TextBox_Folder_Update.Text = xml_root.SelectSingleNode("FolderUpdate").InnerText;
                Textbox_Folder_Source.Text = xml_root.SelectSingleNode("FolderSource").InnerText;
            }

            // set size
            Size screen_size = HardwareFunctions.ScreenResoltion();
            this.Size = new Size((int)((double)screen_size.Width * (double)0.75), (int)((double)screen_size.Height * (double)0.75));

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            int size_full = this.ClientSize.Width;
            panel1.Width = size_full / 2;
            panel2.Width = size_full - size_full / 2;
            panel_buttons_1.Width = size_full / 2;
            panel_buttons_2.Width = size_full - size_full / 2;
        }
        string ExeDirectory = "";
        string ExeName = "";
        string SettingsFilePath = "";
        private void Button_Folder_Update_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                XMLFileFunctions.ChangeNodeText(SettingsFilePath, "FolderUpdate", dialog.SelectedPath);
                TextBox_Folder_Update.Text = dialog.SelectedPath;
            }
        }
        private void Button_Folder_Source_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                XMLFileFunctions.ChangeNodeText(SettingsFilePath, "FolderSource", dialog.SelectedPath);
                Textbox_Folder_Source.Text = dialog.SelectedPath;
            }
        }
        string[] UpdateFiles = null;
        string[] SourceFiles = null;

        private void Button_ShowFiles_FolderUpdate_Click(object sender, EventArgs e)
        {
            XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
            string update_folder = xml_root.SelectSingleNode("FolderUpdate").InnerText;
            UpdateFiles = DirectoryFunctions.GetFiles.All(update_folder, true, true);
            TextBox_Folder_Update.Clear();
            TextBox_Folder_Update.Text += ArrayFunctions.StringArray.Convert.ToFileString(UpdateFiles);
        }
        private void Button_Compare_Click(object sender, EventArgs e)
        {
            XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
            string update_folder = xml_root.SelectSingleNode("FolderUpdate").InnerText;
            string source_folder = xml_root.SelectSingleNode("FolderSource").InnerText;
            UpdateFiles = DirectoryFunctions.GetFiles.All(update_folder, true, true);
            SourceFiles = DirectoryFunctions.GetFiles.All(source_folder, true, true);
            //ArrayFunctions.TimeExecutionShow = true;
            string[] FilesExists = ArrayFunctions.StringArray.Find.StringsInArray(SourceFiles, UpdateFiles);
            Textbox_Folder_Source.Text = "1. Equal.\t" + FilesExists.Length.ToString() + " files found.\r\n\r\n";
            Textbox_Folder_Source.Text += ArrayFunctions.StringArray.Convert.ToFileString(FilesExists);
            TextBox_Folder_Update.Text = "1. Equal.\t" + FilesExists.Length.ToString() + " files found.\r\n\r\n";
            TextBox_Folder_Update.Text += ArrayFunctions.StringArray.Convert.ToFileString(FilesExists);

            Textbox_Folder_Source.Text += "\r\n\r\n\r\n";
            TextBox_Folder_Update.Text += "\r\n\r\n\r\n";


            // check if the same named files are not different

            string[] files_in_source = ArrayFunctions.StringArray.EachElement.Add.ToStart(FilesExists, source_folder + "\\");
            string[] files_in_update = ArrayFunctions.StringArray.EachElement.Add.ToStart(FilesExists, update_folder + "\\");
            int different_files = 0;
            for (int i = 0; i < FilesExists.Length; i++)
            {
                if (FileFunctions.FileInformation.IsTheSame(files_in_source[i], files_in_update[i]) == false)
                {
                    Debug.WriteLine(files_in_source[i]);
                    different_files += 1;
                }
            }

            // Note made in Warsaw. Workplace. 2024-07-12 11:14. 
            // +1 for /. -1 to go to index. +1 next index because current index is in folder path.
            Textbox_Folder_Source.Text += "2. Equal names. Difference found. \t" + different_files.ToString() + " files found.\t(Note. Created, Modified is different because of file was copied)\r\n\r\n";
            TextBox_Folder_Update.Text += "2. Equal names. Difference found. \t" + different_files.ToString() + " files found.\t(Note. Created, Modified is different because of file was copied)\r\n\r\n";

            for (int i = 0; i < FilesExists.Length; i++)
            {
                if (FileFunctions.FileInformation.IsTheSame(files_in_source[i], files_in_update[i]) == false)
                {
                    Textbox_Folder_Source.Text += files_in_source[i].Substring(source_folder.Length + 1 - 1 + 1) + "\r\n" +
                        "Update file. Accessed: " + FileFunctions.FileInformation.Accessed(files_in_update[i]).ToString() + "\tSize: " + FileFunctions.FileInformation.Size(files_in_update[i]).ToString() + "\r\n" +
                        "Source file. Accessed: " + FileFunctions.FileInformation.Accessed(files_in_source[i]).ToString() + "\tSize: " + FileFunctions.FileInformation.Size(files_in_source[i]).ToString() + "\r\n";
                    TextBox_Folder_Update.Text += files_in_source[i].Substring(source_folder.Length + 1 - 1 + 1) + "\r\n" +
                        "Update file. Accessed: " + FileFunctions.FileInformation.Accessed(files_in_update[i]).ToString() + "\tSize: " + FileFunctions.FileInformation.Size(files_in_update[i]).ToString() + "\r\n" +
                        "Source file. Accessed: " + FileFunctions.FileInformation.Accessed(files_in_source[i]).ToString() + "\tSize: " + FileFunctions.FileInformation.Size(files_in_source[i]).ToString() + "\r\n";

                }
            }



            Textbox_Folder_Source.Text += "\r\n\r\n\r\n";
            TextBox_Folder_Update.Text += "\r\n\r\n\r\n";



            string[] FilesDoNotExistsInUpdate = ArrayFunctions.StringArray.Find.StringsNotInArray(UpdateFiles, SourceFiles);
            Textbox_Folder_Source.Text += "2. Not in Update folder.\t" + FilesDoNotExistsInUpdate.Length.ToString() + " files found.\r\n\r\n";
            Textbox_Folder_Source.Text += ArrayFunctions.StringArray.Convert.ToFileString(FilesDoNotExistsInUpdate);
            TextBox_Folder_Update.Text += "2. Not in Update folder.\t" + FilesDoNotExistsInUpdate.Length.ToString() + " files found.\r\n\r\n";
            TextBox_Folder_Update.Text += ArrayFunctions.StringArray.Convert.ToFileString(FilesDoNotExistsInUpdate);

            Textbox_Folder_Source.Text += "\r\n\r\n\r\n";
            TextBox_Folder_Update.Text += "\r\n\r\n\r\n";

            string[] FilesDoNotExistsInSource = ArrayFunctions.StringArray.Find.StringsNotInArray(SourceFiles, UpdateFiles);
            Textbox_Folder_Source.Text += "3. Not in Source folder.\r\n\r\n";
            Textbox_Folder_Source.Text += ArrayFunctions.StringArray.Convert.ToFileString(FilesDoNotExistsInSource);
            TextBox_Folder_Update.Text += "3. Not in Source folder.\r\n\r\n";
            TextBox_Folder_Update.Text += ArrayFunctions.StringArray.Convert.ToFileString(FilesDoNotExistsInSource);

            IsComparePressed = true;
        }
        private void Button_ShowFiles_FolderSource_Click(object sender, EventArgs e)
        {
            XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
            string source_folder = xml_root.SelectSingleNode("FolderSource").InnerText;
            SourceFiles = DirectoryFunctions.GetFiles.All(source_folder, true, true);
            Textbox_Folder_Source.Clear();
            Textbox_Folder_Source.Text += ArrayFunctions.StringArray.Convert.ToFileString(SourceFiles);
        }

        private void TextBox_Folder_Update_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void Button_Folder_Update_MouseEnter(object sender, EventArgs e)
        {
            TextBox_Information.Text = "Select the folder with the files to be updated from source folder";
        }

        private void Button_Folder_Update_MouseLeave(object sender, EventArgs e)
        {
            TextBox_Information.Clear();
        }

        private void Button_ShowFiles_FolderUpdate_MouseEnter(object sender, EventArgs e)
        {
            TextBox_Information.Text = "Show files that are in Update folder";
        }

        private void Button_ShowFiles_FolderUpdate_MouseLeave(object sender, EventArgs e)
        {
            TextBox_Information.Clear();
        }

        private void Button_Folder_Source_MouseEnter(object sender, EventArgs e)
        {
            TextBox_Information.Text = "Select the folder with the files which are for updating files in the update folder";
        }

        private void Button_Folder_Source_MouseLeave(object sender, EventArgs e)
        {
            TextBox_Information.Clear();
        }

        private void Button_Switch_Folder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Attention! Source is important.\r\nRecommended. Switch manually using folder selection", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
                string source_folder = xml_root.SelectSingleNode("FolderSource").InnerText;
                string update_folder = xml_root.SelectSingleNode("FolderUpdate").InnerText;
                XMLFileFunctions.ChangeNodeText(SettingsFilePath, "FolderUpdate", source_folder);
                XMLFileFunctions.ChangeNodeText(SettingsFilePath, "FolderSource", update_folder);




                Textbox_Folder_Source.Text = update_folder;
                TextBox_Folder_Update.Text = source_folder;

            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            TextBox_Information.Text = "Copy missing files from Source folder to Update folder";

        }

        bool IsComparePressed = false;



        private void button1_MouseLeave(object sender, EventArgs e)
        {
            TextBox_Information.Text = "";
        }

        private void panel_buttons_Paint(object sender, PaintEventArgs e)
        {

        }
        // Note made in Warsaw. Workplace. 2024-07-10 12:23. 
        // Threat and invoke because it will copy to the end and the progress is not seen.
        private void Button_Copy_To_Update_Click(object sender, EventArgs e)
        {
            TaskCopyToUpdate = new Task(Copy_To_Update);
            TaskCopyToUpdate.Start();
        }

        Task TaskCopyToUpdate = null;
        private void Copy_To_Update()
        {
            if (IsComparePressed == false)
            {
                MessageBox.Show("You must press Compare to enable this button");
                return;
            }

            XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
            string update_folder = xml_root.SelectSingleNode("FolderUpdate").InnerText;
            string source_folder = xml_root.SelectSingleNode("FolderSource").InnerText;




            string[] FilesDoNotExistsInUpdate = ArrayFunctions.StringArray.Find.StringsNotInArray(UpdateFiles, SourceFiles);

            string[] FilesFromSource = ArrayFunctions.StringArray.EachElement.Add.ToStart(FilesDoNotExistsInUpdate, source_folder + "\\");
            string[] FilepathInUpdate = ArrayFunctions.StringArray.EachElement.Add.ToStart(FilesDoNotExistsInUpdate, update_folder + "\\");
            Update_TextBox_String = "Copying files to Update folder.\t" + FilesFromSource.Length.ToString() + " files needs to be copied" + "\r\n\r\n";
            Update_TextBox_IsAdd = false;
            this.Invoke(new EventHandler(Update_TextBox_FolderSource));
            this.Invoke(new EventHandler(Update_TextBox_FolderUpdate));

            for (int i = 0; i < FilesFromSource.Length; i++)
            {
                if (System.IO.File.Exists(FilepathInUpdate[i]) == true)
                {
                    MessageBox.Show("Critical Error. There is file that was found missing.\\Programm will be closed");
                    Close();
                    return;
                }
                FileFunctions.Copy(FilesFromSource[i], FilepathInUpdate[i]);
                string time_str = DateTime.Now.ToString("HH-mm-ss");

                Update_TextBox_String = (i + 1).ToString() + ".\t" + time_str + "\tFile copied: " + FilesFromSource[i] + "\r\n";
                Update_TextBox_IsAdd = true;
                this.Invoke(new EventHandler(Update_TextBox_FolderSource));
                this.Invoke(new EventHandler(Update_TextBox_FolderUpdate));


                //Thread.Sleep(100);

            }


            Update_TextBox_String = "\r\n\r\n\r\nCompleted.\t" + FilesFromSource.Length.ToString() + " files were copied.\r\n";
            Update_TextBox_IsAdd = true;
            this.Invoke(new EventHandler(Update_TextBox_FolderSource));
            this.Invoke(new EventHandler(Update_TextBox_FolderUpdate));
            IsComparePressed = false;

        }

        private void Update_TextBox_FolderUpdate(object sender, EventArgs e)
        {
            if (Update_TextBox_IsAdd == true)
            {
                Textbox_Folder_Source.Text += Update_TextBox_String;
                Textbox_Folder_Source.SelectionStart = Textbox_Folder_Source.TextLength;
                Textbox_Folder_Source.ScrollToCaret();
            }
            else
            {
                Textbox_Folder_Source.Text = Update_TextBox_String;
            }
        }

        string Update_TextBox_String = "";
        bool Update_TextBox_IsAdd = false;
        private void Update_TextBox_FolderSource(object sender, EventArgs e)
        {
            if (Update_TextBox_IsAdd == true)
            {
                TextBox_Folder_Update.Text += Update_TextBox_String;
                TextBox_Folder_Update.SelectionStart = TextBox_Folder_Update.TextLength;
                TextBox_Folder_Update.ScrollToCaret();
            }
            else
            {
                TextBox_Folder_Update.Text = Update_TextBox_String;
            }
        }


        private void Button_Remove_Update_Folder_Click(object sender, EventArgs e)
        {
            if (IsComparePressed == false)
            {
                MessageBox.Show("You must press Compare to enable this button");
                return;
            }


            if (MessageBox.Show("Attention. Deletion.\r\nAre you sure you want to delete files in Update folder?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
                string update_folder = xml_root.SelectSingleNode("FolderUpdate").InnerText;
                string source_folder = xml_root.SelectSingleNode("FolderSource").InnerText;




                string[] FilesDoNotExistsInSource = ArrayFunctions.StringArray.Find.StringsNotInArray(SourceFiles, UpdateFiles);

                //string[] FilesFromSource = ArrayFunctions.StringArray.EachElement.Add.ToStart(FilesDoNotExistsInSource, source_folder + "\\");
                string[] FilepathInUpdate = ArrayFunctions.StringArray.EachElement.Add.ToStart(FilesDoNotExistsInSource, update_folder + "\\");

                Update_TextBox_String = "Deleting files in Update Folder.\t" + FilepathInUpdate.Length.ToString() + " files needs to be deleted" + "\r\n\r\n";
                Update_TextBox_IsAdd = false;
                this.Invoke(new EventHandler(Update_TextBox_FolderSource));
                this.Invoke(new EventHandler(Update_TextBox_FolderUpdate));


                for (int i = 0; i < FilepathInUpdate.Length; i++)
                {
                    if (System.IO.File.Exists(FilepathInUpdate[i]) == false)
                    {
                        MessageBox.Show("Critical Error. File was found missing.\\Programm will be closed");
                        Close();
                        return;
                    }
                    FileFunctions.FileDelete(FilepathInUpdate[i]);
                    string time_str = DateTime.Now.ToString("HH-mm-ss");


                    Update_TextBox_String = (i + 1).ToString() + ".\t" + time_str + "\tFile deleted: " + FilepathInUpdate[i] + "\r\n";
                    Update_TextBox_IsAdd = true;
                    this.Invoke(new EventHandler(Update_TextBox_FolderSource));
                    this.Invoke(new EventHandler(Update_TextBox_FolderUpdate));



                }


                Update_TextBox_String = "\r\n\r\n\r\nCompleted.\t" + FilepathInUpdate.Length.ToString() + " files were deleted.\r\n";
                Update_TextBox_IsAdd = true;
                this.Invoke(new EventHandler(Update_TextBox_FolderSource));
                this.Invoke(new EventHandler(Update_TextBox_FolderUpdate));


                IsComparePressed = false;
            }
        }

        private void Button_Open_FolderUpdate_Click(object sender, EventArgs e)
        {
            XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
            string update_folder = xml_root.SelectSingleNode("FolderUpdate").InnerText;

            Process.Start("explorer.exe", update_folder);
        }

        private void Button_Open_FolderSource_Click(object sender, EventArgs e)
        {
            XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
            string source_folder = xml_root.SelectSingleNode("FolderSource").InnerText;

            Process.Start("explorer.exe", source_folder);
        }


        // Works. Note made in Moscow. Workplace. 2024-07-24 12:25. 
        private void Button_Show_Empty_Folders_Click(object sender, EventArgs e)
        {
            XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
            string source_folder = xml_root.SelectSingleNode("FolderSource").InnerText;
            string[] dirs = System.IO.Directory.GetDirectories(source_folder, "*", System.IO.SearchOption.AllDirectories);

            // counting
            int empty_folder_count = 0;
            for (int i = 0; i < dirs.Length; i++)
            {
                if (DirectoryFunctions.IsEmpty(dirs[i]) == true)
                {
                    empty_folder_count += 1;
                }
            }

            string[] empty_dirs = new string[empty_folder_count];
            int ifill = 0;
            for (int i = 0; i < dirs.Length; i++)
            {
                if (DirectoryFunctions.IsEmpty(dirs[i]) == true)
                {
                    empty_dirs[ifill] = dirs[i];
                    ifill += 1;
                }
            }



            Textbox_Folder_Source.Text = "Empty Folders:\r\n\r\n";
            Textbox_Folder_Source.Text += ArrayFunctions.StringArray.Convert.ToFileString(empty_dirs);
        }

        private void Button_Delete_Empty_Folders_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Attention. Deletion.\r\nAre you sure you want to delete empty folders?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                XmlElement xml_root = XMLFileFunctions.GetRoot(SettingsFilePath);
                string source_folder = xml_root.SelectSingleNode("FolderSource").InnerText;
                string[] dirs = System.IO.Directory.GetDirectories(source_folder, "*", System.IO.SearchOption.AllDirectories);

                // counting
                int empty_folder_count = 0;
                for (int i = 0; i < dirs.Length; i++)
                {
                    if (DirectoryFunctions.IsEmpty(dirs[i]) == true)
                    {
                        empty_folder_count += 1;
                    }
                }

                string[] empty_dirs = new string[empty_folder_count];
                int ifill = 0;
                for (int i = 0; i < dirs.Length; i++)
                {
                    if (DirectoryFunctions.IsEmpty(dirs[i]) == true)
                    {
                        empty_dirs[ifill] = dirs[i];
                        ifill += 1;
                    }
                }
                Textbox_Folder_Source.Text = "Deleting empty folders\r\n\r\n";
                for (int i = 0; i < empty_dirs.Length; i++)
                {
                    System.IO.Directory.Delete(empty_dirs[i]);
                    
                    Textbox_Folder_Source.Text += (i + 1).ToString() +". Deleted:\t" + empty_dirs[i] + "\r\n";
                }
            }
        }

        private void Button_Free_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer message.\r\nThis Button is free to use.\r\nIt was left to show there is space for buttons");
        }
    }
}
