namespace Meropriatia
{
    partial class Organizator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizator));
            this.organizator_label = new System.Windows.Forms.Label();
            this.photo_pictureBox = new System.Windows.Forms.PictureBox();
            this.myProfile_pictureBox = new System.Windows.Forms.PictureBox();
            this.welcome_label = new System.Windows.Forms.Label();
            this.meropriatia_button = new System.Windows.Forms.Button();
            this.member_button = new System.Windows.Forms.Button();
            this.juri_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myProfile_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // organizator_label
            // 
            this.organizator_label.AutoSize = true;
            this.organizator_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organizator_label.Location = new System.Drawing.Point(129, 20);
            this.organizator_label.Name = "organizator_label";
            this.organizator_label.Size = new System.Drawing.Size(400, 46);
            this.organizator_label.TabIndex = 1;
            this.organizator_label.Text = "Окно организатора";
            // 
            // photo_pictureBox
            // 
            this.photo_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("photo_pictureBox.Image")));
            this.photo_pictureBox.Location = new System.Drawing.Point(41, 85);
            this.photo_pictureBox.Name = "photo_pictureBox";
            this.photo_pictureBox.Size = new System.Drawing.Size(150, 231);
            this.photo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo_pictureBox.TabIndex = 2;
            this.photo_pictureBox.TabStop = false;
            // 
            // myProfile_pictureBox
            // 
            this.myProfile_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("myProfile_pictureBox.Image")));
            this.myProfile_pictureBox.Location = new System.Drawing.Point(56, 347);
            this.myProfile_pictureBox.Name = "myProfile_pictureBox";
            this.myProfile_pictureBox.Size = new System.Drawing.Size(121, 70);
            this.myProfile_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myProfile_pictureBox.TabIndex = 3;
            this.myProfile_pictureBox.TabStop = false;
            this.myProfile_pictureBox.Click += new System.EventHandler(this.myProfile_pictureBox_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome_label.Location = new System.Drawing.Point(339, 102);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(245, 40);
            this.welcome_label.TabIndex = 4;
            this.welcome_label.Text = "Доброе утро/день/вечер!\r\nMs/Mrs Имя";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meropriatia_button
            // 
            this.meropriatia_button.BackColor = System.Drawing.Color.Blue;
            this.meropriatia_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.meropriatia_button.Location = new System.Drawing.Point(331, 165);
            this.meropriatia_button.Name = "meropriatia_button";
            this.meropriatia_button.Size = new System.Drawing.Size(264, 79);
            this.meropriatia_button.TabIndex = 5;
            this.meropriatia_button.Text = "Мероприятия";
            this.meropriatia_button.UseVisualStyleBackColor = false;
            this.meropriatia_button.Click += new System.EventHandler(this.meropriatia_button_Click);
            // 
            // member_button
            // 
            this.member_button.BackColor = System.Drawing.Color.Blue;
            this.member_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.member_button.Location = new System.Drawing.Point(331, 250);
            this.member_button.Name = "member_button";
            this.member_button.Size = new System.Drawing.Size(264, 79);
            this.member_button.TabIndex = 6;
            this.member_button.Text = "Участники";
            this.member_button.UseVisualStyleBackColor = false;
            // 
            // juri_button
            // 
            this.juri_button.BackColor = System.Drawing.Color.Blue;
            this.juri_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.juri_button.Location = new System.Drawing.Point(331, 338);
            this.juri_button.Name = "juri_button";
            this.juri_button.Size = new System.Drawing.Size(264, 79);
            this.juri_button.TabIndex = 7;
            this.juri_button.Text = "Жюри";
            this.juri_button.UseVisualStyleBackColor = false;
            // 
            // Organizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 432);
            this.Controls.Add(this.juri_button);
            this.Controls.Add(this.member_button);
            this.Controls.Add(this.meropriatia_button);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.myProfile_pictureBox);
            this.Controls.Add(this.photo_pictureBox);
            this.Controls.Add(this.organizator_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(915, 479);
            this.MinimumSize = new System.Drawing.Size(915, 479);
            this.Name = "Organizator";
            this.Text = "Организатор";
            ((System.ComponentModel.ISupportInitialize)(this.photo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myProfile_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label organizator_label;
        private System.Windows.Forms.PictureBox photo_pictureBox;
        private System.Windows.Forms.PictureBox myProfile_pictureBox;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button meropriatia_button;
        private System.Windows.Forms.Button member_button;
        private System.Windows.Forms.Button juri_button;
    }
}