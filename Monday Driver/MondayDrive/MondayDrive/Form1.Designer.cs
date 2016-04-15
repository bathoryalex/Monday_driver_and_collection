namespace MondayDrive
{
    partial class editingForm
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
            this.driveLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.driveComboBox = new System.Windows.Forms.ComboBox();
            this.openButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driveLabel
            // 
            this.driveLabel.AutoSize = true;
            this.driveLabel.Location = new System.Drawing.Point(14, 12);
            this.driveLabel.Name = "driveLabel";
            this.driveLabel.Size = new System.Drawing.Size(32, 13);
            this.driveLabel.TabIndex = 0;
            this.driveLabel.Text = "Drive";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(14, 34);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Path";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(48, 55);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(384, 95);
            this.listBox.TabIndex = 2;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(48, 32);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(384, 20);
            this.pathTextBox.TabIndex = 3;
            this.pathTextBox.TextChanged += new System.EventHandler(this.pathTextBox_TextChanged);
            // 
            // driveComboBox
            // 
            this.driveComboBox.FormattingEnabled = true;
            this.driveComboBox.Location = new System.Drawing.Point(48, 8);
            this.driveComboBox.Name = "driveComboBox";
            this.driveComboBox.Size = new System.Drawing.Size(384, 21);
            this.driveComboBox.TabIndex = 4;
            this.driveComboBox.SelectedIndexChanged += new System.EventHandler(this.driveComboBox_SelectedIndexChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(47, 152);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(127, 152);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 178);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.driveComboBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.driveLabel);
            this.MaximizeBox = false;
            this.Name = "editingForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "Editing";
            this.Load += new System.EventHandler(this.editingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label driveLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.ComboBox driveComboBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

