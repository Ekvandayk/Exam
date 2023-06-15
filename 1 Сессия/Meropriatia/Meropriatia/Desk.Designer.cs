namespace Meropriatia
{
    partial class Desk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desk));
            this.activity_pictureBox = new System.Windows.Forms.PictureBox();
            this.meropriatie_label = new System.Windows.Forms.Label();
            this.meropriatie_comboBox = new System.Windows.Forms.ComboBox();
            this.pdf_button = new System.Windows.Forms.Button();
            this.desk_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activity_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // activity_pictureBox
            // 
            this.activity_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("activity_pictureBox.Image")));
            this.activity_pictureBox.Location = new System.Drawing.Point(53, 145);
            this.activity_pictureBox.Name = "activity_pictureBox";
            this.activity_pictureBox.Size = new System.Drawing.Size(711, 301);
            this.activity_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.activity_pictureBox.TabIndex = 0;
            this.activity_pictureBox.TabStop = false;
            // 
            // meropriatie_label
            // 
            this.meropriatie_label.AutoSize = true;
            this.meropriatie_label.Location = new System.Drawing.Point(50, 51);
            this.meropriatie_label.Name = "meropriatie_label";
            this.meropriatie_label.Size = new System.Drawing.Size(96, 16);
            this.meropriatie_label.TabIndex = 1;
            this.meropriatie_label.Text = "Мероприятие";
            // 
            // meropriatie_comboBox
            // 
            this.meropriatie_comboBox.FormattingEnabled = true;
            this.meropriatie_comboBox.Location = new System.Drawing.Point(152, 51);
            this.meropriatie_comboBox.Name = "meropriatie_comboBox";
            this.meropriatie_comboBox.Size = new System.Drawing.Size(366, 24);
            this.meropriatie_comboBox.TabIndex = 2;
            // 
            // pdf_button
            // 
            this.pdf_button.BackColor = System.Drawing.Color.Blue;
            this.pdf_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pdf_button.Location = new System.Drawing.Point(620, 42);
            this.pdf_button.Name = "pdf_button";
            this.pdf_button.Size = new System.Drawing.Size(119, 41);
            this.pdf_button.TabIndex = 28;
            this.pdf_button.Text = "pdf";
            this.pdf_button.UseVisualStyleBackColor = false;
            // 
            // desk_label
            // 
            this.desk_label.AutoSize = true;
            this.desk_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.desk_label.Location = new System.Drawing.Point(303, 6);
            this.desk_label.Name = "desk_label";
            this.desk_label.Size = new System.Drawing.Size(127, 42);
            this.desk_label.TabIndex = 29;
            this.desk_label.Text = "Доска";
            // 
            // Desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(778, 464);
            this.Controls.Add(this.desk_label);
            this.Controls.Add(this.pdf_button);
            this.Controls.Add(this.meropriatie_comboBox);
            this.Controls.Add(this.meropriatie_label);
            this.Controls.Add(this.activity_pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(796, 511);
            this.MinimumSize = new System.Drawing.Size(796, 511);
            this.Name = "Desk";
            this.Text = "Доска";
            ((System.ComponentModel.ISupportInitialize)(this.activity_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox activity_pictureBox;
        private System.Windows.Forms.Label meropriatie_label;
        private System.Windows.Forms.ComboBox meropriatie_comboBox;
        private System.Windows.Forms.Button pdf_button;
        private System.Windows.Forms.Label desk_label;
    }
}