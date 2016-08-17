namespace Guest_Name_Editor
    {
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.newTextBox = new System.Windows.Forms.TextBox();
            this.originalTextLabel = new System.Windows.Forms.Label();
            this.newTextLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.setButton = new System.Windows.Forms.Button();
            this.beforeText = new System.Windows.Forms.TextBox();
            this.afterText = new System.Windows.Forms.TextBox();
            this.beforeLabel = new System.Windows.Forms.Label();
            this.afterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(377, 12);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(130, 41);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select...";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(49, 23);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(322, 20);
            this.pathTextBox.TabIndex = 2;
            this.pathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(487, 95);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ReadOnly = true;
            this.originalTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.originalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalTextBox.Size = new System.Drawing.Size(425, 452);
            this.originalTextBox.TabIndex = 3;
            this.originalTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // newTextBox
            // 
            this.newTextBox.AllowDrop = true;
            this.newTextBox.Location = new System.Drawing.Point(50, 95);
            this.newTextBox.Multiline = true;
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newTextBox.Size = new System.Drawing.Size(425, 452);
            this.newTextBox.TabIndex = 3;
            this.newTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // originalTextLabel
            // 
            this.originalTextLabel.AutoSize = true;
            this.originalTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalTextLabel.Location = new System.Drawing.Point(832, 61);
            this.originalTextLabel.Name = "originalTextLabel";
            this.originalTextLabel.Size = new System.Drawing.Size(80, 20);
            this.originalTextLabel.TabIndex = 4;
            this.originalTextLabel.Text = "النص الاصلي";
            // 
            // newTextLabel
            // 
            this.newTextLabel.AutoSize = true;
            this.newTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTextLabel.Location = new System.Drawing.Point(405, 61);
            this.newTextLabel.Name = "newTextLabel";
            this.newTextLabel.Size = new System.Drawing.Size(70, 20);
            this.newTextLabel.TabIndex = 4;
            this.newTextLabel.Text = "النص الجديد";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(514, 12);
            this.convertButton.Name = "convertButton";
            this.convertButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.convertButton.Size = new System.Drawing.Size(127, 41);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(648, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 41);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(742, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 41);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CreatePrompt = true;
            this.saveFileDialog.Title = "Save Text";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(377, 555);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 8;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // beforeText
            // 
            this.beforeText.Location = new System.Drawing.Point(103, 553);
            this.beforeText.Name = "beforeText";
            this.beforeText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.beforeText.Size = new System.Drawing.Size(100, 20);
            this.beforeText.TabIndex = 9;
            this.beforeText.TextChanged += new System.EventHandler(this.beforeText_TextChanged);
            // 
            // afterText
            // 
            this.afterText.Location = new System.Drawing.Point(250, 555);
            this.afterText.Name = "afterText";
            this.afterText.Size = new System.Drawing.Size(100, 20);
            this.afterText.TabIndex = 10;
            this.afterText.TextChanged += new System.EventHandler(this.afterText_TextChanged);
            // 
            // beforeLabel
            // 
            this.beforeLabel.AutoSize = true;
            this.beforeLabel.Location = new System.Drawing.Point(59, 558);
            this.beforeLabel.Name = "beforeLabel";
            this.beforeLabel.Size = new System.Drawing.Size(38, 13);
            this.beforeLabel.TabIndex = 11;
            this.beforeLabel.Text = "Before";
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Location = new System.Drawing.Point(215, 558);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(29, 13);
            this.afterLabel.TabIndex = 12;
            this.afterLabel.Text = "After";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 608);
            this.Controls.Add(this.afterLabel);
            this.Controls.Add(this.beforeLabel);
            this.Controls.Add(this.afterText);
            this.Controls.Add(this.beforeText);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.newTextLabel);
            this.Controls.Add(this.originalTextLabel);
            this.Controls.Add(this.newTextBox);
            this.Controls.Add(this.originalTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.selectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Editor by Hadi";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.TextBox newTextBox;
        private System.Windows.Forms.Label originalTextLabel;
        private System.Windows.Forms.Label newTextLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox beforeText;
        private System.Windows.Forms.TextBox afterText;
        private System.Windows.Forms.Label beforeLabel;
        private System.Windows.Forms.Label afterLabel;
        }
    }

