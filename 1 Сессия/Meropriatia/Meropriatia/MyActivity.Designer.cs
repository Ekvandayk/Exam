namespace Meropriatia
{
    partial class MyActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyActivity));
            this.title_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.activity1_button = new System.Windows.Forms.Button();
            this.activity2_button = new System.Windows.Forms.Button();
            this.activity3_button = new System.Windows.Forms.Button();
            this.info_groupBox = new System.Windows.Forms.GroupBox();
            this.addFile_button = new System.Windows.Forms.Button();
            this.kanban_button = new System.Windows.Forms.Button();
            this.resursi_button = new System.Windows.Forms.Button();
            this.members_button = new System.Windows.Forms.Button();
            this.info_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_label.Location = new System.Drawing.Point(198, 18);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(330, 46);
            this.title_label.TabIndex = 3;
            this.title_label.Text = "Мои активности";
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome_label.Location = new System.Drawing.Point(241, 105);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(245, 40);
            this.welcome_label.TabIndex = 6;
            this.welcome_label.Text = "Доброе утро/день/вечер!\r\nMs/Mrs Имя";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activity1_button
            // 
            this.activity1_button.BackColor = System.Drawing.Color.Blue;
            this.activity1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activity1_button.Location = new System.Drawing.Point(37, 172);
            this.activity1_button.Name = "activity1_button";
            this.activity1_button.Size = new System.Drawing.Size(264, 79);
            this.activity1_button.TabIndex = 7;
            this.activity1_button.Text = "Активность 1, время";
            this.activity1_button.UseVisualStyleBackColor = false;
            // 
            // activity2_button
            // 
            this.activity2_button.BackColor = System.Drawing.Color.Blue;
            this.activity2_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activity2_button.Location = new System.Drawing.Point(37, 257);
            this.activity2_button.Name = "activity2_button";
            this.activity2_button.Size = new System.Drawing.Size(264, 79);
            this.activity2_button.TabIndex = 8;
            this.activity2_button.Text = "Активность 2";
            this.activity2_button.UseVisualStyleBackColor = false;
            // 
            // activity3_button
            // 
            this.activity3_button.BackColor = System.Drawing.Color.Blue;
            this.activity3_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activity3_button.Location = new System.Drawing.Point(37, 342);
            this.activity3_button.Name = "activity3_button";
            this.activity3_button.Size = new System.Drawing.Size(264, 79);
            this.activity3_button.TabIndex = 9;
            this.activity3_button.Text = "Активность 3";
            this.activity3_button.UseVisualStyleBackColor = false;
            // 
            // info_groupBox
            // 
            this.info_groupBox.Controls.Add(this.addFile_button);
            this.info_groupBox.Controls.Add(this.kanban_button);
            this.info_groupBox.Controls.Add(this.resursi_button);
            this.info_groupBox.Controls.Add(this.members_button);
            this.info_groupBox.Location = new System.Drawing.Point(307, 172);
            this.info_groupBox.Name = "info_groupBox";
            this.info_groupBox.Size = new System.Drawing.Size(481, 266);
            this.info_groupBox.TabIndex = 10;
            this.info_groupBox.TabStop = false;
            // 
            // addFile_button
            // 
            this.addFile_button.BackColor = System.Drawing.Color.Blue;
            this.addFile_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addFile_button.Location = new System.Drawing.Point(369, 213);
            this.addFile_button.Name = "addFile_button";
            this.addFile_button.Size = new System.Drawing.Size(99, 47);
            this.addFile_button.TabIndex = 12;
            this.addFile_button.Text = "Добавить файл";
            this.addFile_button.UseVisualStyleBackColor = false;
            // 
            // kanban_button
            // 
            this.kanban_button.BackColor = System.Drawing.Color.Blue;
            this.kanban_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kanban_button.Location = new System.Drawing.Point(264, 213);
            this.kanban_button.Name = "kanban_button";
            this.kanban_button.Size = new System.Drawing.Size(99, 47);
            this.kanban_button.TabIndex = 11;
            this.kanban_button.Text = "Kanban";
            this.kanban_button.UseVisualStyleBackColor = false;
            // 
            // resursi_button
            // 
            this.resursi_button.BackColor = System.Drawing.Color.Blue;
            this.resursi_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resursi_button.Location = new System.Drawing.Point(134, 9);
            this.resursi_button.Name = "resursi_button";
            this.resursi_button.Size = new System.Drawing.Size(137, 35);
            this.resursi_button.TabIndex = 10;
            this.resursi_button.Text = "Ресурсы";
            this.resursi_button.UseVisualStyleBackColor = false;
            // 
            // members_button
            // 
            this.members_button.BackColor = System.Drawing.Color.Blue;
            this.members_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.members_button.Location = new System.Drawing.Point(0, 9);
            this.members_button.Name = "members_button";
            this.members_button.Size = new System.Drawing.Size(137, 35);
            this.members_button.TabIndex = 9;
            this.members_button.Text = "Участники";
            this.members_button.UseVisualStyleBackColor = false;
            // 
            // MyActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info_groupBox);
            this.Controls.Add(this.activity3_button);
            this.Controls.Add(this.activity2_button);
            this.Controls.Add(this.activity1_button);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.title_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MyActivity";
            this.Text = "Мои активности";
            this.info_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button activity1_button;
        private System.Windows.Forms.Button activity2_button;
        private System.Windows.Forms.Button activity3_button;
        private System.Windows.Forms.GroupBox info_groupBox;
        private System.Windows.Forms.Button addFile_button;
        private System.Windows.Forms.Button kanban_button;
        private System.Windows.Forms.Button resursi_button;
        private System.Windows.Forms.Button members_button;
    }
}