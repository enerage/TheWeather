namespace TheWeather
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.OneDayFromToday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TwoDayFromToday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreeDayFromToday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FourDayFromToday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiveDayFromToday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            label2.Text = "Forecast for London";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(50, 15);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(234, 22);
            this.cityTextBox.TabIndex = 1;
            this.cityTextBox.Text = "London";
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "City:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView2
            // 

            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OneDayFromToday,
            this.TwoDayFromToday,
            this.ThreeDayFromToday,
            this.FourDayFromToday,
            this.FiveDayFromToday});
            this.dataGridView2.Location = new System.Drawing.Point(12, 190);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1228, 183);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // OneDayFromToday
            // 
            this.OneDayFromToday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OneDayFromToday.HeaderText = "OneDayFromToday";
            this.OneDayFromToday.Name = "OneDayFromToday";
            this.OneDayFromToday.ReadOnly = true;
            
            // 
            // TwoDayFromToday
            // 
            this.TwoDayFromToday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TwoDayFromToday.HeaderText = "TwoDayFromToday";
            this.TwoDayFromToday.Name = "TwoDayFromToday";
            this.TwoDayFromToday.ReadOnly = true;
            // 
            // ThreeDayFromToday
            // 
            this.ThreeDayFromToday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThreeDayFromToday.HeaderText = "ThreeDayFromToday";
            this.ThreeDayFromToday.Name = "ThreeDayFromToday";
            this.ThreeDayFromToday.ReadOnly = true;
            // 
            // FourDayFromToday
            // 
            this.FourDayFromToday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FourDayFromToday.HeaderText = "FourDayFromToday";
            this.FourDayFromToday.Name = "FourDayFromToday";
            this.FourDayFromToday.ReadOnly = true;
            // 
            // FiveDayFromToday
            // 
            this.FiveDayFromToday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FiveDayFromToday.HeaderText = "FiveDayFromToday";
            this.FiveDayFromToday.Name = "FiveDayFromToday";
            this.FiveDayFromToday.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Forecast for ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OneDayFromToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn TwoDayFromToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreeDayFromToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn FourDayFromToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiveDayFromToday;


    }
}

