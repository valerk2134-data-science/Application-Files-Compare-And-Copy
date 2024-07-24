namespace WindowsFormsApp3
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
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel_buttons_1 = new System.Windows.Forms.Panel();
            this.Button_Open_FolderUpdate = new System.Windows.Forms.Button();
            this.Button_Switch_Folder = new System.Windows.Forms.Button();
            this.Button_ShowFiles_FolderUpdate = new System.Windows.Forms.Button();
            this.Button_Folder_Update = new System.Windows.Forms.Button();
            this.panel_buttons_2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Button_Open_FolderSource = new System.Windows.Forms.Button();
            this.Button_Compare = new System.Windows.Forms.Button();
            this.Button_ShowFiles_SourceUpdate = new System.Windows.Forms.Button();
            this.Button_Folder_Source = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBox_Information = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Textbox_Folder_Source = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_Folder_Update = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Button_Delete_Empty_Folders = new System.Windows.Forms.Button();
            this.Button_Show_Empty_Folders = new System.Windows.Forms.Button();
            this.Button_Remove_Update_Folder = new System.Windows.Forms.Button();
            this.Button_Copy_To_Update = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Button_Free = new System.Windows.Forms.Button();
            this.panel_buttons.SuspendLayout();
            this.panel_buttons_1.SuspendLayout();
            this.panel_buttons_2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.panel7);
            this.panel_buttons.Controls.Add(this.panel_buttons_1);
            this.panel_buttons.Controls.Add(this.panel_buttons_2);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_buttons.Location = new System.Drawing.Point(0, 0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(1341, 120);
            this.panel_buttons.TabIndex = 0;
            this.panel_buttons.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_buttons_Paint);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(626, 79);
            this.panel7.TabIndex = 4;
            // 
            // panel_buttons_1
            // 
            this.panel_buttons_1.Controls.Add(this.Button_Open_FolderUpdate);
            this.panel_buttons_1.Controls.Add(this.Button_Switch_Folder);
            this.panel_buttons_1.Controls.Add(this.Button_ShowFiles_FolderUpdate);
            this.panel_buttons_1.Controls.Add(this.Button_Folder_Update);
            this.panel_buttons_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_buttons_1.Location = new System.Drawing.Point(0, 0);
            this.panel_buttons_1.Name = "panel_buttons_1";
            this.panel_buttons_1.Size = new System.Drawing.Size(626, 41);
            this.panel_buttons_1.TabIndex = 3;
            // 
            // Button_Open_FolderUpdate
            // 
            this.Button_Open_FolderUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Open_FolderUpdate.Location = new System.Drawing.Point(320, 0);
            this.Button_Open_FolderUpdate.Name = "Button_Open_FolderUpdate";
            this.Button_Open_FolderUpdate.Size = new System.Drawing.Size(160, 41);
            this.Button_Open_FolderUpdate.TabIndex = 5;
            this.Button_Open_FolderUpdate.Text = "Open Folder";
            this.Button_Open_FolderUpdate.UseVisualStyleBackColor = true;
            this.Button_Open_FolderUpdate.Click += new System.EventHandler(this.Button_Open_FolderUpdate_Click);
            // 
            // Button_Switch_Folder
            // 
            this.Button_Switch_Folder.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Switch_Folder.Location = new System.Drawing.Point(466, 0);
            this.Button_Switch_Folder.Name = "Button_Switch_Folder";
            this.Button_Switch_Folder.Size = new System.Drawing.Size(160, 41);
            this.Button_Switch_Folder.TabIndex = 4;
            this.Button_Switch_Folder.Text = "<- Switch ->";
            this.Button_Switch_Folder.UseVisualStyleBackColor = true;
            this.Button_Switch_Folder.Click += new System.EventHandler(this.Button_Switch_Folder_Click);
            // 
            // Button_ShowFiles_FolderUpdate
            // 
            this.Button_ShowFiles_FolderUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_ShowFiles_FolderUpdate.Location = new System.Drawing.Point(160, 0);
            this.Button_ShowFiles_FolderUpdate.Name = "Button_ShowFiles_FolderUpdate";
            this.Button_ShowFiles_FolderUpdate.Size = new System.Drawing.Size(160, 41);
            this.Button_ShowFiles_FolderUpdate.TabIndex = 3;
            this.Button_ShowFiles_FolderUpdate.Text = "Show Files";
            this.Button_ShowFiles_FolderUpdate.UseVisualStyleBackColor = true;
            this.Button_ShowFiles_FolderUpdate.Click += new System.EventHandler(this.Button_ShowFiles_FolderUpdate_Click);
            // 
            // Button_Folder_Update
            // 
            this.Button_Folder_Update.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Folder_Update.Location = new System.Drawing.Point(0, 0);
            this.Button_Folder_Update.Name = "Button_Folder_Update";
            this.Button_Folder_Update.Size = new System.Drawing.Size(160, 41);
            this.Button_Folder_Update.TabIndex = 2;
            this.Button_Folder_Update.Text = "Folder Update";
            this.Button_Folder_Update.UseVisualStyleBackColor = true;
            this.Button_Folder_Update.Click += new System.EventHandler(this.Button_Folder_Update_Click);
            // 
            // panel_buttons_2
            // 
            this.panel_buttons_2.Controls.Add(this.panel8);
            this.panel_buttons_2.Controls.Add(this.panel6);
            this.panel_buttons_2.Controls.Add(this.panel5);
            this.panel_buttons_2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_buttons_2.Location = new System.Drawing.Point(626, 0);
            this.panel_buttons_2.Name = "panel_buttons_2";
            this.panel_buttons_2.Size = new System.Drawing.Size(715, 120);
            this.panel_buttons_2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Button_Open_FolderSource);
            this.panel5.Controls.Add(this.Button_Compare);
            this.panel5.Controls.Add(this.Button_ShowFiles_SourceUpdate);
            this.panel5.Controls.Add(this.Button_Folder_Source);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(715, 40);
            this.panel5.TabIndex = 7;
            // 
            // Button_Open_FolderSource
            // 
            this.Button_Open_FolderSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Open_FolderSource.Location = new System.Drawing.Point(480, 0);
            this.Button_Open_FolderSource.Name = "Button_Open_FolderSource";
            this.Button_Open_FolderSource.Size = new System.Drawing.Size(160, 40);
            this.Button_Open_FolderSource.TabIndex = 7;
            this.Button_Open_FolderSource.Text = "Open Folder";
            this.Button_Open_FolderSource.UseVisualStyleBackColor = true;
            this.Button_Open_FolderSource.Click += new System.EventHandler(this.Button_Open_FolderSource_Click);
            // 
            // Button_Compare
            // 
            this.Button_Compare.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Compare.Location = new System.Drawing.Point(320, 0);
            this.Button_Compare.Name = "Button_Compare";
            this.Button_Compare.Size = new System.Drawing.Size(160, 40);
            this.Button_Compare.TabIndex = 6;
            this.Button_Compare.Text = "Compare";
            this.Button_Compare.UseVisualStyleBackColor = true;
            this.Button_Compare.Click += new System.EventHandler(this.Button_Compare_Click);
            // 
            // Button_ShowFiles_SourceUpdate
            // 
            this.Button_ShowFiles_SourceUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_ShowFiles_SourceUpdate.Location = new System.Drawing.Point(160, 0);
            this.Button_ShowFiles_SourceUpdate.Name = "Button_ShowFiles_SourceUpdate";
            this.Button_ShowFiles_SourceUpdate.Size = new System.Drawing.Size(160, 40);
            this.Button_ShowFiles_SourceUpdate.TabIndex = 5;
            this.Button_ShowFiles_SourceUpdate.Text = "Show Files";
            this.Button_ShowFiles_SourceUpdate.UseVisualStyleBackColor = true;
            this.Button_ShowFiles_SourceUpdate.Click += new System.EventHandler(this.Button_ShowFiles_FolderSource_Click);
            // 
            // Button_Folder_Source
            // 
            this.Button_Folder_Source.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Folder_Source.Location = new System.Drawing.Point(0, 0);
            this.Button_Folder_Source.Name = "Button_Folder_Source";
            this.Button_Folder_Source.Size = new System.Drawing.Size(160, 40);
            this.Button_Folder_Source.TabIndex = 3;
            this.Button_Folder_Source.Text = "Folder Source";
            this.Button_Folder_Source.UseVisualStyleBackColor = true;
            this.Button_Folder_Source.Click += new System.EventHandler(this.Button_Folder_Source_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TextBox_Information);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 522);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1341, 52);
            this.panel3.TabIndex = 3;
            // 
            // TextBox_Information
            // 
            this.TextBox_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Information.Location = new System.Drawing.Point(0, 0);
            this.TextBox_Information.Multiline = true;
            this.TextBox_Information.Name = "TextBox_Information";
            this.TextBox_Information.ReadOnly = true;
            this.TextBox_Information.Size = new System.Drawing.Size(1341, 52);
            this.TextBox_Information.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Textbox_Folder_Source);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(550, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 402);
            this.panel2.TabIndex = 2;
            // 
            // Textbox_Folder_Source
            // 
            this.Textbox_Folder_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox_Folder_Source.Location = new System.Drawing.Point(0, 0);
            this.Textbox_Folder_Source.Multiline = true;
            this.Textbox_Folder_Source.Name = "Textbox_Folder_Source";
            this.Textbox_Folder_Source.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Textbox_Folder_Source.Size = new System.Drawing.Size(508, 402);
            this.Textbox_Folder_Source.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBox_Folder_Update);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 402);
            this.panel1.TabIndex = 1;
            // 
            // TextBox_Folder_Update
            // 
            this.TextBox_Folder_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Folder_Update.Location = new System.Drawing.Point(0, 0);
            this.TextBox_Folder_Update.Multiline = true;
            this.TextBox_Folder_Update.Name = "TextBox_Folder_Update";
            this.TextBox_Folder_Update.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Folder_Update.Size = new System.Drawing.Size(550, 402);
            this.TextBox_Folder_Update.TabIndex = 0;
            this.TextBox_Folder_Update.TextChanged += new System.EventHandler(this.TextBox_Folder_Update_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1341, 402);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Button_Delete_Empty_Folders);
            this.panel6.Controls.Add(this.Button_Show_Empty_Folders);
            this.panel6.Controls.Add(this.Button_Remove_Update_Folder);
            this.panel6.Controls.Add(this.Button_Copy_To_Update);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(715, 40);
            this.panel6.TabIndex = 13;
            // 
            // Button_Delete_Empty_Folders
            // 
            this.Button_Delete_Empty_Folders.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Delete_Empty_Folders.Location = new System.Drawing.Point(480, 0);
            this.Button_Delete_Empty_Folders.Name = "Button_Delete_Empty_Folders";
            this.Button_Delete_Empty_Folders.Size = new System.Drawing.Size(160, 40);
            this.Button_Delete_Empty_Folders.TabIndex = 12;
            this.Button_Delete_Empty_Folders.Text = "Delete Empty Folders";
            this.Button_Delete_Empty_Folders.UseVisualStyleBackColor = true;
            // 
            // Button_Show_Empty_Folders
            // 
            this.Button_Show_Empty_Folders.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Show_Empty_Folders.Location = new System.Drawing.Point(320, 0);
            this.Button_Show_Empty_Folders.Name = "Button_Show_Empty_Folders";
            this.Button_Show_Empty_Folders.Size = new System.Drawing.Size(160, 40);
            this.Button_Show_Empty_Folders.TabIndex = 11;
            this.Button_Show_Empty_Folders.Text = "Show Empty Folders";
            this.Button_Show_Empty_Folders.UseVisualStyleBackColor = true;
            // 
            // Button_Remove_Update_Folder
            // 
            this.Button_Remove_Update_Folder.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Remove_Update_Folder.Location = new System.Drawing.Point(160, 0);
            this.Button_Remove_Update_Folder.Name = "Button_Remove_Update_Folder";
            this.Button_Remove_Update_Folder.Size = new System.Drawing.Size(160, 40);
            this.Button_Remove_Update_Folder.TabIndex = 10;
            this.Button_Remove_Update_Folder.Text = " X--- Remove in Update Folder";
            this.Button_Remove_Update_Folder.UseVisualStyleBackColor = true;
            // 
            // Button_Copy_To_Update
            // 
            this.Button_Copy_To_Update.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Copy_To_Update.Location = new System.Drawing.Point(0, 0);
            this.Button_Copy_To_Update.Name = "Button_Copy_To_Update";
            this.Button_Copy_To_Update.Size = new System.Drawing.Size(160, 40);
            this.Button_Copy_To_Update.TabIndex = 9;
            this.Button_Copy_To_Update.Text = "<--- Copy to Update Folder";
            this.Button_Copy_To_Update.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Button_Free);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(715, 40);
            this.panel8.TabIndex = 14;
            // 
            // Button_Free
            // 
            this.Button_Free.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Free.Location = new System.Drawing.Point(0, 0);
            this.Button_Free.Name = "Button_Free";
            this.Button_Free.Size = new System.Drawing.Size(160, 40);
            this.Button_Free.TabIndex = 10;
            this.Button_Free.Text = "Free Button";
            this.Button_Free.UseVisualStyleBackColor = true;
            this.Button_Free.Click += new System.EventHandler(this.Button_Free_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 574);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_buttons);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ApplicationForm";
            this.Text = "Data Compare 2024";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_buttons.ResumeLayout(false);
            this.panel_buttons_1.ResumeLayout(false);
            this.panel_buttons_2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

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

