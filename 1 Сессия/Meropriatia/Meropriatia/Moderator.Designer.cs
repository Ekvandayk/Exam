namespace Meropriatia
{
    partial class Moderator
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
            this.title_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.napravlenie_label = new System.Windows.Forms.Label();
            this.meropriatie_label = new System.Windows.Forms.Label();
            this.napravlenie_comboBox = new System.Windows.Forms.ComboBox();
            this.meropriatie_comboBox = new System.Windows.Forms.ComboBox();
            this.moder_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addZayavka_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.Location = new System.Drawing.Point(200, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(372, 46);
            this.title_label.TabIndex = 2;
            this.title_label.Text = "Окно модератора";
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome_label.Location = new System.Drawing.Point(272, 70);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(245, 40);
            this.welcome_label.TabIndex = 5;
            this.welcome_label.Text = "Доброе утро/день/вечер!\r\nMs/Mrs Имя";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // napravlenie_label
            // 
            this.napravlenie_label.AutoSize = true;
            this.napravlenie_label.Location = new System.Drawing.Point(42, 140);
            this.napravlenie_label.Name = "napravlenie_label";
            this.napravlenie_label.Size = new System.Drawing.Size(97, 16);
            this.napravlenie_label.TabIndex = 6;
            this.napravlenie_label.Text = "Направление";
            // 
            // meropriatie_label
            // 
            this.meropriatie_label.AutoSize = true;
            this.meropriatie_label.Location = new System.Drawing.Point(42, 176);
            this.meropriatie_label.Name = "meropriatie_label";
            this.meropriatie_label.Size = new System.Drawing.Size(96, 16);
            this.meropriatie_label.TabIndex = 7;
            this.meropriatie_label.Text = "Мероприятие";
            // 
            // napravlenie_comboBox
            // 
            this.napravlenie_comboBox.FormattingEnabled = true;
            this.napravlenie_comboBox.Location = new System.Drawing.Point(145, 137);
            this.napravlenie_comboBox.Name = "napravlenie_comboBox";
            this.napravlenie_comboBox.Size = new System.Drawing.Size(304, 24);
            this.napravlenie_comboBox.TabIndex = 8;
            // 
            // meropriatie_comboBox
            // 
            this.meropriatie_comboBox.FormattingEnabled = true;
            this.meropriatie_comboBox.Location = new System.Drawing.Point(145, 173);
            this.meropriatie_comboBox.Name = "meropriatie_comboBox";
            this.meropriatie_comboBox.Size = new System.Drawing.Size(304, 24);
            this.meropriatie_comboBox.TabIndex = 9;
            // 
            // moder_button
            // 
            this.moder_button.BackColor = System.Drawing.Color.Blue;
            this.moder_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.moder_button.Location = new System.Drawing.Point(647, 40);
            this.moder_button.Name = "moder_button";
            this.moder_button.Size = new System.Drawing.Size(118, 58);
            this.moder_button.TabIndex = 10;
            this.moder_button.Text = "Мои активности";
            this.moder_button.UseVisualStyleBackColor = false;
            this.moder_button.Click += new System.EventHandler(this.moder_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // addZayavka_button
            // 
            this.addZayavka_button.BackColor = System.Drawing.Color.Blue;
            this.addZayavka_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addZayavka_button.Location = new System.Drawing.Point(647, 380);
            this.addZayavka_button.Name = "addZayavka_button";
            this.addZayavka_button.Size = new System.Drawing.Size(118, 58);
            this.addZayavka_button.TabIndex = 12;
            this.addZayavka_button.Text = "Подать заявку";
            this.addZayavka_button.UseVisualStyleBackColor = false;
            // 
            // Moderator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addZayavka_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.moder_button);
            this.Controls.Add(this.meropriatie_comboBox);
            this.Controls.Add(this.napravlenie_comboBox);
            this.Controls.Add(this.meropriatie_label);
            this.Controls.Add(this.napravlenie_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.title_label);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Moderator";
            this.Text = "Окно модератора";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label napravlenie_label;
        private System.Windows.Forms.Label meropriatie_label;
        private System.Windows.Forms.ComboBox napravlenie_comboBox;
        private System.Windows.Forms.ComboBox meropriatie_comboBox;
        private System.Windows.Forms.Button moder_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addZayavka_button;
    }
}