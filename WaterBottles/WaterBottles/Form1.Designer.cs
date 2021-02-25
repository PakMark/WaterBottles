namespace WaterBottles
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usedWaterBottles = new System.Windows.Forms.NumericUpDown();
            this.addedWaterBottles = new System.Windows.Forms.NumericUpDown();
            this.useWaterButton = new System.Windows.Forms.Button();
            this.addWaterButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.hideErrorButton = new System.Windows.Forms.Button();
            this.bottleDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedWaterBottles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedWaterBottles)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(218, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(424, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(630, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 200);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "full / all";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(218, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "full / all";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(424, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "full / all";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(630, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "full / all";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usedWaterBottles
            // 
            this.usedWaterBottles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usedWaterBottles.Location = new System.Drawing.Point(15, 268);
            this.usedWaterBottles.Name = "usedWaterBottles";
            this.usedWaterBottles.ReadOnly = true;
            this.usedWaterBottles.Size = new System.Drawing.Size(50, 20);
            this.usedWaterBottles.TabIndex = 11;
            this.usedWaterBottles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addedWaterBottles
            // 
            this.addedWaterBottles.Location = new System.Drawing.Point(15, 304);
            this.addedWaterBottles.Name = "addedWaterBottles";
            this.addedWaterBottles.ReadOnly = true;
            this.addedWaterBottles.Size = new System.Drawing.Size(50, 20);
            this.addedWaterBottles.TabIndex = 13;
            this.addedWaterBottles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // useWaterButton
            // 
            this.useWaterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useWaterButton.Location = new System.Drawing.Point(71, 262);
            this.useWaterButton.Name = "useWaterButton";
            this.useWaterButton.Size = new System.Drawing.Size(150, 30);
            this.useWaterButton.TabIndex = 15;
            this.useWaterButton.Text = "Израсходовать";
            this.useWaterButton.UseVisualStyleBackColor = true;
            this.useWaterButton.Click += new System.EventHandler(this.useWaterButton_Click);
            // 
            // addWaterButton
            // 
            this.addWaterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWaterButton.Location = new System.Drawing.Point(71, 298);
            this.addWaterButton.Name = "addWaterButton";
            this.addWaterButton.Size = new System.Drawing.Size(150, 30);
            this.addWaterButton.TabIndex = 16;
            this.addWaterButton.Text = "Пополнить";
            this.addWaterButton.UseVisualStyleBackColor = true;
            this.addWaterButton.Click += new System.EventHandler(this.addWaterButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.errorLabel.Location = new System.Drawing.Point(12, 401);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 17;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hideErrorButton
            // 
            this.hideErrorButton.BackColor = System.Drawing.SystemColors.Control;
            this.hideErrorButton.Location = new System.Drawing.Point(15, 418);
            this.hideErrorButton.Name = "hideErrorButton";
            this.hideErrorButton.Size = new System.Drawing.Size(74, 20);
            this.hideErrorButton.TabIndex = 18;
            this.hideErrorButton.Text = "Закрыть";
            this.hideErrorButton.UseVisualStyleBackColor = false;
            this.hideErrorButton.Visible = false;
            this.hideErrorButton.Click += new System.EventHandler(this.hideErrorButton_Click);
            // 
            // bottleDescription
            // 
            this.bottleDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bottleDescription.Location = new System.Drawing.Point(424, 262);
            this.bottleDescription.Name = "bottleDescription";
            this.bottleDescription.Size = new System.Drawing.Size(406, 30);
            this.bottleDescription.TabIndex = 20;
            this.bottleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.bottleDescription);
            this.Controls.Add(this.hideErrorButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.addWaterButton);
            this.Controls.Add(this.useWaterButton);
            this.Controls.Add(this.addedWaterBottles);
            this.Controls.Add(this.usedWaterBottles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Water Bottles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedWaterBottles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedWaterBottles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown usedWaterBottles;
        private System.Windows.Forms.NumericUpDown addedWaterBottles;
        private System.Windows.Forms.Button useWaterButton;
        private System.Windows.Forms.Button addWaterButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button hideErrorButton;
        private System.Windows.Forms.Label bottleDescription;
    }
}

