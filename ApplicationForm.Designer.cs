namespace WinFormsApp2
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            panel_buttons = new Panel();
            panel7 = new Panel();
            panel_buttons_1 = new Panel();
            Button_Open_FolderUpdate = new Button();
            Button_Switch_Folder = new Button();
            Button_ShowFiles_FolderUpdate = new Button();
            Button_Folder_Update = new Button();
            panel_buttons_2 = new Panel();
            panel8 = new Panel();
            Button_Free = new Button();
            panel6 = new Panel();
            Button_Delete_Empty_Folders = new Button();
            Button_Show_Empty_Folders = new Button();
            Button_Remove_Update_Folder = new Button();
            Button_Copy_To_Update = new Button();
            panel5 = new Panel();
            Button_Open_FolderSource = new Button();
            Button_Compare = new Button();
            Button_ShowFiles_SourceUpdate = new Button();
            Button_Folder_Source = new Button();
            panel3 = new Panel();
            TextBox_Information = new TextBox();
            panel2 = new Panel();
            Textbox_Folder_Source = new TextBox();
            panel1 = new Panel();
            TextBox_Folder_Update = new TextBox();
            panel4 = new Panel();
            panel_buttons.SuspendLayout();
            panel_buttons_1.SuspendLayout();
            panel_buttons_2.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel_buttons
            // 
            panel_buttons.Controls.Add(panel7);
            panel_buttons.Controls.Add(panel_buttons_1);
            panel_buttons.Controls.Add(panel_buttons_2);
            panel_buttons.Dock = DockStyle.Top;
            panel_buttons.Location = new Point(0, 0);
            panel_buttons.Name = "panel_buttons";
            panel_buttons.Size = new Size(1341, 120);
            panel_buttons.TabIndex = 0;
            panel_buttons.Paint += panel_buttons_Paint;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 41);
            panel7.Name = "panel7";
            panel7.Size = new Size(626, 79);
            panel7.TabIndex = 4;
            // 
            // panel_buttons_1
            // 
            panel_buttons_1.Controls.Add(Button_Open_FolderUpdate);
            panel_buttons_1.Controls.Add(Button_Switch_Folder);
            panel_buttons_1.Controls.Add(Button_ShowFiles_FolderUpdate);
            panel_buttons_1.Controls.Add(Button_Folder_Update);
            panel_buttons_1.Dock = DockStyle.Top;
            panel_buttons_1.Location = new Point(0, 0);
            panel_buttons_1.Name = "panel_buttons_1";
            panel_buttons_1.Size = new Size(626, 41);
            panel_buttons_1.TabIndex = 3;
            // 
            // Button_Open_FolderUpdate
            // 
            Button_Open_FolderUpdate.Dock = DockStyle.Left;
            Button_Open_FolderUpdate.Location = new Point(320, 0);
            Button_Open_FolderUpdate.Name = "Button_Open_FolderUpdate";
            Button_Open_FolderUpdate.Size = new Size(160, 41);
            Button_Open_FolderUpdate.TabIndex = 5;
            Button_Open_FolderUpdate.Text = "Open Folder";
            Button_Open_FolderUpdate.UseVisualStyleBackColor = true;
            Button_Open_FolderUpdate.Click += Button_Open_FolderUpdate_Click;
            // 
            // Button_Switch_Folder
            // 
            Button_Switch_Folder.Dock = DockStyle.Right;
            Button_Switch_Folder.Location = new Point(466, 0);
            Button_Switch_Folder.Name = "Button_Switch_Folder";
            Button_Switch_Folder.Size = new Size(160, 41);
            Button_Switch_Folder.TabIndex = 4;
            Button_Switch_Folder.Text = "<- Switch ->";
            Button_Switch_Folder.UseVisualStyleBackColor = true;
            Button_Switch_Folder.Click += Button_Switch_Folder_Click;
            // 
            // Button_ShowFiles_FolderUpdate
            // 
            Button_ShowFiles_FolderUpdate.Dock = DockStyle.Left;
            Button_ShowFiles_FolderUpdate.Location = new Point(160, 0);
            Button_ShowFiles_FolderUpdate.Name = "Button_ShowFiles_FolderUpdate";
            Button_ShowFiles_FolderUpdate.Size = new Size(160, 41);
            Button_ShowFiles_FolderUpdate.TabIndex = 3;
            Button_ShowFiles_FolderUpdate.Text = "Show Files";
            Button_ShowFiles_FolderUpdate.UseVisualStyleBackColor = true;
            Button_ShowFiles_FolderUpdate.Click += Button_ShowFiles_FolderUpdate_Click;
            // 
            // Button_Folder_Update
            // 
            Button_Folder_Update.Dock = DockStyle.Left;
            Button_Folder_Update.Location = new Point(0, 0);
            Button_Folder_Update.Name = "Button_Folder_Update";
            Button_Folder_Update.Size = new Size(160, 41);
            Button_Folder_Update.TabIndex = 2;
            Button_Folder_Update.Text = "Folder Update";
            Button_Folder_Update.UseVisualStyleBackColor = true;
            Button_Folder_Update.Click += Button_Folder_Update_Click;
            // 
            // panel_buttons_2
            // 
            panel_buttons_2.Controls.Add(panel8);
            panel_buttons_2.Controls.Add(panel6);
            panel_buttons_2.Controls.Add(panel5);
            panel_buttons_2.Dock = DockStyle.Right;
            panel_buttons_2.Location = new Point(626, 0);
            panel_buttons_2.Name = "panel_buttons_2";
            panel_buttons_2.Size = new Size(715, 120);
            panel_buttons_2.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(Button_Free);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 80);
            panel8.Name = "panel8";
            panel8.Size = new Size(715, 40);
            panel8.TabIndex = 14;
            // 
            // Button_Free
            // 
            Button_Free.Dock = DockStyle.Left;
            Button_Free.Location = new Point(0, 0);
            Button_Free.Name = "Button_Free";
            Button_Free.Size = new Size(160, 40);
            Button_Free.TabIndex = 10;
            Button_Free.Text = "Free Button";
            Button_Free.UseVisualStyleBackColor = true;
            Button_Free.Click += Button_Free_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(Button_Delete_Empty_Folders);
            panel6.Controls.Add(Button_Show_Empty_Folders);
            panel6.Controls.Add(Button_Remove_Update_Folder);
            panel6.Controls.Add(Button_Copy_To_Update);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 40);
            panel6.Name = "panel6";
            panel6.Size = new Size(715, 40);
            panel6.TabIndex = 13;
            // 
            // Button_Delete_Empty_Folders
            // 
            Button_Delete_Empty_Folders.Dock = DockStyle.Left;
            Button_Delete_Empty_Folders.Location = new Point(480, 0);
            Button_Delete_Empty_Folders.Name = "Button_Delete_Empty_Folders";
            Button_Delete_Empty_Folders.Size = new Size(160, 40);
            Button_Delete_Empty_Folders.TabIndex = 12;
            Button_Delete_Empty_Folders.Text = "Delete Empty Folders";
            Button_Delete_Empty_Folders.UseVisualStyleBackColor = true;
            Button_Delete_Empty_Folders.Click += Button_Delete_Empty_Folders_Click;
            // 
            // Button_Show_Empty_Folders
            // 
            Button_Show_Empty_Folders.Dock = DockStyle.Left;
            Button_Show_Empty_Folders.Location = new Point(320, 0);
            Button_Show_Empty_Folders.Name = "Button_Show_Empty_Folders";
            Button_Show_Empty_Folders.Size = new Size(160, 40);
            Button_Show_Empty_Folders.TabIndex = 11;
            Button_Show_Empty_Folders.Text = "Show Empty Folders";
            Button_Show_Empty_Folders.UseVisualStyleBackColor = true;
            Button_Show_Empty_Folders.Click += Button_Show_Empty_Folders_Click;
            // 
            // Button_Remove_Update_Folder
            // 
            Button_Remove_Update_Folder.Dock = DockStyle.Left;
            Button_Remove_Update_Folder.Location = new Point(160, 0);
            Button_Remove_Update_Folder.Name = "Button_Remove_Update_Folder";
            Button_Remove_Update_Folder.Size = new Size(160, 40);
            Button_Remove_Update_Folder.TabIndex = 10;
            Button_Remove_Update_Folder.Text = " X--- Remove in Update Folder";
            Button_Remove_Update_Folder.UseVisualStyleBackColor = true;
            Button_Remove_Update_Folder.Click += Button_Remove_Update_Folder_Click;
            // 
            // Button_Copy_To_Update
            // 
            Button_Copy_To_Update.Dock = DockStyle.Left;
            Button_Copy_To_Update.Location = new Point(0, 0);
            Button_Copy_To_Update.Name = "Button_Copy_To_Update";
            Button_Copy_To_Update.Size = new Size(160, 40);
            Button_Copy_To_Update.TabIndex = 9;
            Button_Copy_To_Update.Text = "<--- Copy to Update Folder";
            Button_Copy_To_Update.UseVisualStyleBackColor = true;
            Button_Copy_To_Update.Click += Button_Copy_To_Update_Click;
            Button_Copy_To_Update.ChangeUICues += Button_Copy_To_Update_ChangeUICues;
            // 
            // panel5
            // 
            panel5.Controls.Add(Button_Open_FolderSource);
            panel5.Controls.Add(Button_Compare);
            panel5.Controls.Add(Button_ShowFiles_SourceUpdate);
            panel5.Controls.Add(Button_Folder_Source);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(715, 40);
            panel5.TabIndex = 7;
            // 
            // Button_Open_FolderSource
            // 
            Button_Open_FolderSource.Dock = DockStyle.Left;
            Button_Open_FolderSource.Location = new Point(480, 0);
            Button_Open_FolderSource.Name = "Button_Open_FolderSource";
            Button_Open_FolderSource.Size = new Size(160, 40);
            Button_Open_FolderSource.TabIndex = 7;
            Button_Open_FolderSource.Text = "Open Folder";
            Button_Open_FolderSource.UseVisualStyleBackColor = true;
            Button_Open_FolderSource.Click += Button_Open_FolderSource_Click;
            // 
            // Button_Compare
            // 
            Button_Compare.Dock = DockStyle.Left;
            Button_Compare.Location = new Point(320, 0);
            Button_Compare.Name = "Button_Compare";
            Button_Compare.Size = new Size(160, 40);
            Button_Compare.TabIndex = 6;
            Button_Compare.Text = "Compare";
            Button_Compare.UseVisualStyleBackColor = true;
            Button_Compare.Click += Button_Compare_Click;
            // 
            // Button_ShowFiles_SourceUpdate
            // 
            Button_ShowFiles_SourceUpdate.Dock = DockStyle.Left;
            Button_ShowFiles_SourceUpdate.Location = new Point(160, 0);
            Button_ShowFiles_SourceUpdate.Name = "Button_ShowFiles_SourceUpdate";
            Button_ShowFiles_SourceUpdate.Size = new Size(160, 40);
            Button_ShowFiles_SourceUpdate.TabIndex = 5;
            Button_ShowFiles_SourceUpdate.Text = "Show Files";
            Button_ShowFiles_SourceUpdate.UseVisualStyleBackColor = true;
            Button_ShowFiles_SourceUpdate.Click += Button_ShowFiles_FolderSource_Click;
            // 
            // Button_Folder_Source
            // 
            Button_Folder_Source.Dock = DockStyle.Left;
            Button_Folder_Source.Location = new Point(0, 0);
            Button_Folder_Source.Name = "Button_Folder_Source";
            Button_Folder_Source.Size = new Size(160, 40);
            Button_Folder_Source.TabIndex = 3;
            Button_Folder_Source.Text = "Folder Source";
            Button_Folder_Source.UseVisualStyleBackColor = true;
            Button_Folder_Source.Click += Button_Folder_Source_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(TextBox_Information);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 522);
            panel3.Name = "panel3";
            panel3.Size = new Size(1341, 52);
            panel3.TabIndex = 3;
            // 
            // TextBox_Information
            // 
            TextBox_Information.Dock = DockStyle.Fill;
            TextBox_Information.Location = new Point(0, 0);
            TextBox_Information.Multiline = true;
            TextBox_Information.Name = "TextBox_Information";
            TextBox_Information.ReadOnly = true;
            TextBox_Information.Size = new Size(1341, 52);
            TextBox_Information.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(Textbox_Folder_Source);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(550, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 402);
            panel2.TabIndex = 2;
            // 
            // Textbox_Folder_Source
            // 
            Textbox_Folder_Source.Dock = DockStyle.Fill;
            Textbox_Folder_Source.Location = new Point(0, 0);
            Textbox_Folder_Source.Multiline = true;
            Textbox_Folder_Source.Name = "Textbox_Folder_Source";
            Textbox_Folder_Source.ScrollBars = ScrollBars.Vertical;
            Textbox_Folder_Source.Size = new Size(508, 402);
            Textbox_Folder_Source.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(TextBox_Folder_Update);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 402);
            panel1.TabIndex = 1;
            // 
            // TextBox_Folder_Update
            // 
            TextBox_Folder_Update.Dock = DockStyle.Fill;
            TextBox_Folder_Update.Location = new Point(0, 0);
            TextBox_Folder_Update.Multiline = true;
            TextBox_Folder_Update.Name = "TextBox_Folder_Update";
            TextBox_Folder_Update.ScrollBars = ScrollBars.Vertical;
            TextBox_Folder_Update.Size = new Size(550, 402);
            TextBox_Folder_Update.TabIndex = 0;
            TextBox_Folder_Update.TextChanged += TextBox_Folder_Update_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(1341, 402);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint_1;
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 574);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel_buttons);
            Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "ApplicationForm";
            Text = "Data Compare 2024";
            Load += Form1_Load;
            Resize += Form1_Resize;
            panel_buttons.ResumeLayout(false);
            panel_buttons_1.ResumeLayout(false);
            panel_buttons_2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Panel panel_buttons_2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Textbox_Folder_Source;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBox_Folder_Update;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TextBox_Information;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Button_Compare;
        private System.Windows.Forms.Button Button_ShowFiles_SourceUpdate;
        private System.Windows.Forms.Button Button_Folder_Source;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel_buttons_1;
        private System.Windows.Forms.Button Button_Switch_Folder;
        private System.Windows.Forms.Button Button_ShowFiles_FolderUpdate;
        private System.Windows.Forms.Button Button_Folder_Update;
        private System.Windows.Forms.Button Button_Open_FolderUpdate;
        private System.Windows.Forms.Button Button_Open_FolderSource;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Button_Delete_Empty_Folders;
        private System.Windows.Forms.Button Button_Show_Empty_Folders;
        private System.Windows.Forms.Button Button_Remove_Update_Folder;
        private System.Windows.Forms.Button Button_Copy_To_Update;
        private System.Windows.Forms.Button Button_Free;
    }
}

