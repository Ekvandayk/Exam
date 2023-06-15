namespace Meropriatia
{
    partial class ViewMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMembers));
            this.kolichestvo_label = new System.Windows.Forms.Label();
            this.spisok_dataGridView = new System.Windows.Forms.DataGridView();
            this.poisk_button = new System.Windows.Forms.Button();
            this.meropriatie_comboBox = new System.Windows.Forms.ComboBox();
            this.familia_comboBox = new System.Windows.Forms.ComboBox();
            this.meropriatie_label = new System.Windows.Forms.Label();
            this.fio_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.regMembers_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spisok_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kolichestvo_label
            // 
            this.kolichestvo_label.AutoSize = true;
            this.kolichestvo_label.Location = new System.Drawing.Point(39, 413);
            this.kolichestvo_label.Name = "kolichestvo_label";
            this.kolichestvo_label.Size = new System.Drawing.Size(88, 16);
            this.kolichestvo_label.TabIndex = 18;
            this.kolichestvo_label.Text = "Количество:";
            // 
            // spisok_dataGridView
            // 
            this.spisok_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spisok_dataGridView.Location = new System.Drawing.Point(32, 204);
            this.spisok_dataGridView.Name = "spisok_dataGridView";
            this.spisok_dataGridView.RowHeadersWidth = 51;
            this.spisok_dataGridView.RowTemplate.Height = 24;
            this.spisok_dataGridView.Size = new System.Drawing.Size(737, 178);
            this.spisok_dataGridView.TabIndex = 17;
            // 
            // poisk_button
            // 
            this.poisk_button.BackColor = System.Drawing.Color.Blue;
            this.poisk_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.poisk_button.Location = new System.Drawing.Point(395, 151);
            this.poisk_button.Name = "poisk_button";
            this.poisk_button.Size = new System.Drawing.Size(124, 35);
            this.poisk_button.TabIndex = 14;
            this.poisk_button.Text = "Поиск";
            this.poisk_button.UseVisualStyleBackColor = false;
            // 
            // meropriatie_comboBox
            // 
            this.meropriatie_comboBox.FormattingEnabled = true;
            this.meropriatie_comboBox.Location = new System.Drawing.Point(144, 157);
            this.meropriatie_comboBox.Name = "meropriatie_comboBox";
            this.meropriatie_comboBox.Size = new System.Drawing.Size(229, 24);
            this.meropriatie_comboBox.TabIndex = 12;
            // 
            // familia_comboBox
            // 
            this.familia_comboBox.FormattingEnabled = true;
            this.familia_comboBox.Location = new System.Drawing.Point(144, 113);
            this.familia_comboBox.Name = "familia_comboBox";
            this.familia_comboBox.Size = new System.Drawing.Size(229, 24);
            this.familia_comboBox.TabIndex = 11;
            // 
            // meropriatie_label
            // 
            this.meropriatie_label.AutoSize = true;
            this.meropriatie_label.Location = new System.Drawing.Point(39, 160);
            this.meropriatie_label.Name = "meropriatie_label";
            this.meropriatie_label.Size = new System.Drawing.Size(99, 16);
            this.meropriatie_label.TabIndex = 16;
            this.meropriatie_label.Text = "Мероприятие:";
            // 
            // fio_label
            // 
            this.fio_label.AutoSize = true;
            this.fio_label.Location = new System.Drawing.Point(69, 116);
            this.fio_label.Name = "fio_label";
            this.fio_label.Size = new System.Drawing.Size(69, 16);
            this.fio_label.TabIndex = 15;
            this.fio_label.Text = "Фамилия:";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.Location = new System.Drawing.Point(306, 18);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(224, 46);
            this.title_label.TabIndex = 13;
            this.title_label.Text = "Участники";
            // 
            // regMembers_button
            // 
            this.regMembers_button.BackColor = System.Drawing.Color.Blue;
            this.regMembers_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.regMembers_button.Location = new System.Drawing.Point(598, 56);
            this.regMembers_button.Name = "regMembers_button";
            this.regMembers_button.Size = new System.Drawing.Size(151, 76);
            this.regMembers_button.TabIndex = 19;
            this.regMembers_button.Text = "Регистрация участника";
            this.regMembers_button.UseVisualStyleBackColor = false;
            this.regMembers_button.Click += new System.EventHandler(this.regMembers_button_Click);
            // 
            // ViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regMembers_button);
            this.Controls.Add(this.kolichestvo_label);
            this.Controls.Add(this.spisok_dataGridView);
            this.Controls.Add(this.poisk_button);
            this.Controls.Add(this.meropriatie_comboBox);
            this.Controls.Add(this.familia_comboBox);
            this.Controls.Add(this.meropriatie_label);
            this.Controls.Add(this.fio_label);
            this.Controls.Add(this.title_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewMembers";
            this.Text = "Просмотр участников";
            ((System.ComponentModel.ISupportInitialize)(this.spisok_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kolichestvo_label;
        private System.Windows.Forms.DataGridView spisok_dataGridView;
        private System.Windows.Forms.Button poisk_button;
        private System.Windows.Forms.ComboBox meropriatie_comboBox;
        private System.Windows.Forms.ComboBox familia_comboBox;
        private System.Windows.Forms.Label meropriatie_label;
        private System.Windows.Forms.Label fio_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button regMembers_button;
    }
}