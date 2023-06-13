namespace Meropriatia
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.meropriatia_dataGridView = new System.Windows.Forms.DataGridView();
            this.login_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meropriatia_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // meropriatia_dataGridView
            // 
            this.meropriatia_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meropriatia_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.meropriatia_dataGridView.Name = "meropriatia_dataGridView";
            this.meropriatia_dataGridView.RowHeadersWidth = 51;
            this.meropriatia_dataGridView.Size = new System.Drawing.Size(559, 240);
            this.meropriatia_dataGridView.TabIndex = 0;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Blue;
            this.login_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_button.Location = new System.Drawing.Point(67, 282);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(167, 74);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "Авторизация";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // info_button
            // 
            this.info_button.BackColor = System.Drawing.Color.Blue;
            this.info_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info_button.Location = new System.Drawing.Point(317, 282);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(167, 74);
            this.info_button.TabIndex = 2;
            this.info_button.Text = "Подробная информация";
            this.info_button.UseVisualStyleBackColor = false;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 368);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.meropriatia_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(609, 415);
            this.MinimumSize = new System.Drawing.Size(609, 415);
            this.Name = "MainMenu";
            this.Text = "Meropriatia";
            ((System.ComponentModel.ISupportInitialize)(this.meropriatia_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView meropriatia_dataGridView;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button info_button;
    }
}

