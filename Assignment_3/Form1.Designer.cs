namespace Assignment_3
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
            this.mainDataView = new System.Windows.Forms.DataGridView();
            this.CSVFindButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataView
            // 
            this.mainDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.mainDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataView.Location = new System.Drawing.Point(368, 12);
            this.mainDataView.Name = "mainDataView";
            this.mainDataView.Size = new System.Drawing.Size(420, 426);
            this.mainDataView.TabIndex = 0;
            this.mainDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataView_CellContentClick);
            // 
            // CSVFindButton
            // 
            this.CSVFindButton.Location = new System.Drawing.Point(125, 83);
            this.CSVFindButton.Name = "CSVFindButton";
            this.CSVFindButton.Size = new System.Drawing.Size(75, 23);
            this.CSVFindButton.TabIndex = 1;
            this.CSVFindButton.Text = "Open File";
            this.CSVFindButton.UseVisualStyleBackColor = true;
            this.CSVFindButton.Click += new System.EventHandler(this.CSVFindButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CSVFindButton);
            this.Controls.Add(this.mainDataView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataView;
        private System.Windows.Forms.Button CSVFindButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

