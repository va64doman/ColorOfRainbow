namespace ColorsOfRainbow
{
    partial class RainbowForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonTextFile = new System.Windows.Forms.Button();
            this.flowLayoutColorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.listColourBox = new System.Windows.Forms.ListBox();
            this.textBoxTextFile = new System.Windows.Forms.TextBox();
            this.labelTextFile = new System.Windows.Forms.Label();
            this.labelJSONText = new System.Windows.Forms.Label();
            this.textBoxJsonFile = new System.Windows.Forms.TextBox();
            this.buttonJsonFile = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTextFile
            // 
            this.buttonTextFile.Location = new System.Drawing.Point(15, 40);
            this.buttonTextFile.Name = "buttonTextFile";
            this.buttonTextFile.Size = new System.Drawing.Size(188, 23);
            this.buttonTextFile.TabIndex = 0;
            this.buttonTextFile.Text = "Read Text File and Show Color Data";
            this.buttonTextFile.UseVisualStyleBackColor = true;
            this.buttonTextFile.Click += new System.EventHandler(this.buttonTextFile_Click);
            // 
            // flowLayoutColorPanel
            // 
            this.flowLayoutColorPanel.Location = new System.Drawing.Point(12, 189);
            this.flowLayoutColorPanel.Name = "flowLayoutColorPanel";
            this.flowLayoutColorPanel.Size = new System.Drawing.Size(872, 173);
            this.flowLayoutColorPanel.TabIndex = 1;
            // 
            // listColourBox
            // 
            this.listColourBox.FormattingEnabled = true;
            this.listColourBox.Location = new System.Drawing.Point(12, 88);
            this.listColourBox.Name = "listColourBox";
            this.listColourBox.Size = new System.Drawing.Size(872, 95);
            this.listColourBox.TabIndex = 3;
            // 
            // textBoxTextFile
            // 
            this.textBoxTextFile.Location = new System.Drawing.Point(93, 14);
            this.textBoxTextFile.Name = "textBoxTextFile";
            this.textBoxTextFile.Size = new System.Drawing.Size(151, 20);
            this.textBoxTextFile.TabIndex = 4;
            // 
            // labelTextFile
            // 
            this.labelTextFile.AutoSize = true;
            this.labelTextFile.Location = new System.Drawing.Point(12, 17);
            this.labelTextFile.Name = "labelTextFile";
            this.labelTextFile.Size = new System.Drawing.Size(75, 13);
            this.labelTextFile.TabIndex = 5;
            this.labelTextFile.Text = "Enter Text File";
            // 
            // labelJSONText
            // 
            this.labelJSONText.AutoSize = true;
            this.labelJSONText.Location = new System.Drawing.Point(444, 17);
            this.labelJSONText.Name = "labelJSONText";
            this.labelJSONText.Size = new System.Drawing.Size(82, 13);
            this.labelJSONText.TabIndex = 8;
            this.labelJSONText.Text = "Enter JSON File";
            // 
            // textBoxJsonFile
            // 
            this.textBoxJsonFile.Location = new System.Drawing.Point(532, 14);
            this.textBoxJsonFile.Name = "textBoxJsonFile";
            this.textBoxJsonFile.Size = new System.Drawing.Size(163, 20);
            this.textBoxJsonFile.TabIndex = 7;
            // 
            // buttonJsonFile
            // 
            this.buttonJsonFile.Location = new System.Drawing.Point(447, 40);
            this.buttonJsonFile.Name = "buttonJsonFile";
            this.buttonJsonFile.Size = new System.Drawing.Size(202, 23);
            this.buttonJsonFile.TabIndex = 6;
            this.buttonJsonFile.Text = "Read From JSON and Show Color Data";
            this.buttonJsonFile.UseVisualStyleBackColor = true;
            this.buttonJsonFile.Click += new System.EventHandler(this.buttonJsonFile_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RainbowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 371);
            this.Controls.Add(this.labelJSONText);
            this.Controls.Add(this.textBoxJsonFile);
            this.Controls.Add(this.buttonJsonFile);
            this.Controls.Add(this.labelTextFile);
            this.Controls.Add(this.textBoxTextFile);
            this.Controls.Add(this.listColourBox);
            this.Controls.Add(this.flowLayoutColorPanel);
            this.Controls.Add(this.buttonTextFile);
            this.Name = "RainbowForm";
            this.Text = "Colour Of Rainbow";
            this.Load += new System.EventHandler(this.RainbowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTextFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutColorPanel;
        private System.Windows.Forms.ListBox listColourBox;
        private System.Windows.Forms.TextBox textBoxTextFile;
        private System.Windows.Forms.Label labelTextFile;
        private System.Windows.Forms.Label labelJSONText;
        private System.Windows.Forms.TextBox textBoxJsonFile;
        private System.Windows.Forms.Button buttonJsonFile;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

