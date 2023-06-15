namespace Meropriatia
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
            this.addZayavky_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myActivity_button = new System.Windows.Forms.Button();
            this.meropriatie_comboBox = new System.Windows.Forms.ComboBox();
            this.napravlenie_comboBox = new System.Windows.Forms.ComboBox();
            this.meropriatie_label = new System.Windows.Forms.Label();
            this.mapravlenia_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addZayavky_button
            // 
            this.addZayavky_button.BackColor = System.Drawing.Color.Blue;
            this.addZayavky_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addZayavky_button.Location = new System.Drawing.Point(654, 394);
            this.addZayavky_button.Name = "addZayavky_button";
            this.addZayavky_button.Size = new System.Drawing.Size(119, 46);
            this.addZayavky_button.TabIndex = 21;
            this.addZayavky_button.Text = "Подать заявку";
            this.addZayavky_button.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 158);
            this.dataGridView1.TabIndex = 20;
            // 
            // myActivity_button
            // 
            this.myActivity_button.BackColor = System.Drawing.Color.Blue;
            this.myActivity_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myActivity_button.Location = new System.Drawing.Point(654, 48);
            this.myActivity_button.Name = "myActivity_button";
            this.myActivity_button.Size = new System.Drawing.Size(119, 46);
            this.myActivity_button.TabIndex = 19;
            this.myActivity_button.Text = "Мои активности";
            this.myActivity_button.UseVisualStyleBackColor = false;
            // 
            // meropriatie_comboBox
            // 
            this.meropriatie_comboBox.FormattingEnabled = true;
            this.meropriatie_comboBox.Location = new System.Drawing.Point(182, 182);
            this.meropriatie_comboBox.Name = "meropriatie_comboBox";
            this.meropriatie_comboBox.Size = new System.Drawing.Size(251, 24);
            this.meropriatie_comboBox.TabIndex = 18;
            // 
            // napravlenie_comboBox
            // 
            this.napravlenie_comboBox.FormattingEnabled = true;
            this.napravlenie_comboBox.Location = new System.Drawing.Point(182, 133);
            this.napravlenie_comboBox.Name = "napravlenie_comboBox";
            this.napravlenie_comboBox.Size = new System.Drawing.Size(251, 24);
            this.napravlenie_comboBox.TabIndex = 17;
            // 
            // meropriatie_label
            // 
            this.meropriatie_label.AutoSize = true;
            this.meropriatie_label.Location = new System.Drawing.Point(69, 182);
            this.meropriatie_label.Name = "meropriatie_label";
            this.meropriatie_label.Size = new System.Drawing.Size(96, 16);
            this.meropriatie_label.TabIndex = 16;
            this.meropriatie_label.Text = "Мероприятие";
            // 
            // mapravlenia_label
            // 
            this.mapravlenia_label.AutoSize = true;
            this.mapravlenia_label.Location = new System.Drawing.Point(69, 133);
            this.mapravlenia_label.Name = "mapravlenia_label";
            this.mapravlenia_label.Size = new System.Drawing.Size(97, 16);
            this.mapravlenia_label.TabIndex = 15;
            this.mapravlenia_label.Text = "Направление";
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome_label.Location = new System.Drawing.Point(276, 66);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(245, 40);
            this.welcome_label.TabIndex = 14;
            this.welcome_label.Text = "Доброе утро/день/вечер!\r\nMs/Mrs Имя";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.Location = new System.Drawing.Point(199, 11);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(372, 46);
            this.title_label.TabIndex = 13;
            this.title_label.Text = "Окно модератора";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addZayavky_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.myActivity_button);
            this.Controls.Add(this.meropriatie_comboBox);
            this.Controls.Add(this.napravlenie_comboBox);
            this.Controls.Add(this.meropriatie_label);
            this.Controls.Add(this.mapravlenia_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.title_label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addZayavky_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button myActivity_button;
        private System.Windows.Forms.ComboBox meropriatie_comboBox;
        private System.Windows.Forms.ComboBox napravlenie_comboBox;
        private System.Windows.Forms.Label meropriatie_label;
        private System.Windows.Forms.Label mapravlenia_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label title_label;
    }
}