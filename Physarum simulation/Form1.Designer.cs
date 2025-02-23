namespace Physarum_simulation
{
    partial class Physarum
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WorldVisualisation = new System.Windows.Forms.PictureBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.MaxStepAngleBox = new System.Windows.Forms.TextBox();
            this.SetMaxStepAngle = new System.Windows.Forms.Button();
            this.IterationTimer = new System.Windows.Forms.Timer(this.components);
            this.MinStepAngleBox = new System.Windows.Forms.TextBox();
            this.SetMinStepAngle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxStepLengthBox = new System.Windows.Forms.TextBox();
            this.MinStepLengthBox = new System.Windows.Forms.TextBox();
            this.SetMaxStepLength = new System.Windows.Forms.Button();
            this.SetMinStepLength = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WobblingBox = new System.Windows.Forms.TextBox();
            this.NecessaryTurnBox = new System.Windows.Forms.TextBox();
            this.SetWobbling = new System.Windows.Forms.Button();
            this.SetNecessaryTurn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WorldVisualisation)).BeginInit();
            this.SuspendLayout();
            // 
            // WorldVisualisation
            // 
            this.WorldVisualisation.Location = new System.Drawing.Point(-141, -299);
            this.WorldVisualisation.Name = "WorldVisualisation";
            this.WorldVisualisation.Size = new System.Drawing.Size(1920, 1080);
            this.WorldVisualisation.TabIndex = 0;
            this.WorldVisualisation.TabStop = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(1627, 905);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(200, 50);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate new rules";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // MaxStepAngleBox
            // 
            this.MaxStepAngleBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxStepAngleBox.Location = new System.Drawing.Point(5, 939);
            this.MaxStepAngleBox.Name = "MaxStepAngleBox";
            this.MaxStepAngleBox.Size = new System.Drawing.Size(100, 35);
            this.MaxStepAngleBox.TabIndex = 12;
            this.MaxStepAngleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetMaxStepAngle
            // 
            this.SetMaxStepAngle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetMaxStepAngle.Location = new System.Drawing.Point(107, 938);
            this.SetMaxStepAngle.Name = "SetMaxStepAngle";
            this.SetMaxStepAngle.Size = new System.Drawing.Size(60, 40);
            this.SetMaxStepAngle.TabIndex = 14;
            this.SetMaxStepAngle.Text = "Set";
            this.SetMaxStepAngle.UseVisualStyleBackColor = true;
            // 
            // MinStepAngleBox
            // 
            this.MinStepAngleBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinStepAngleBox.Location = new System.Drawing.Point(5, 981);
            this.MinStepAngleBox.Name = "MinStepAngleBox";
            this.MinStepAngleBox.Size = new System.Drawing.Size(100, 35);
            this.MinStepAngleBox.TabIndex = 12;
            this.MinStepAngleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetMinStepAngle
            // 
            this.SetMinStepAngle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetMinStepAngle.Location = new System.Drawing.Point(107, 981);
            this.SetMinStepAngle.Name = "SetMinStepAngle";
            this.SetMinStepAngle.Size = new System.Drawing.Size(60, 40);
            this.SetMinStepAngle.TabIndex = 14;
            this.SetMinStepAngle.Text = "Set";
            this.SetMinStepAngle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 906);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "StepAngle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // MaxStepLengthBox
            // 
            this.MaxStepLengthBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxStepLengthBox.Location = new System.Drawing.Point(175, 939);
            this.MaxStepLengthBox.Name = "MaxStepLengthBox";
            this.MaxStepLengthBox.Size = new System.Drawing.Size(100, 35);
            this.MaxStepLengthBox.TabIndex = 12;
            this.MaxStepLengthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinStepLengthBox
            // 
            this.MinStepLengthBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinStepLengthBox.Location = new System.Drawing.Point(175, 981);
            this.MinStepLengthBox.Name = "MinStepLengthBox";
            this.MinStepLengthBox.Size = new System.Drawing.Size(100, 35);
            this.MinStepLengthBox.TabIndex = 12;
            this.MinStepLengthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetMaxStepLength
            // 
            this.SetMaxStepLength.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetMaxStepLength.Location = new System.Drawing.Point(277, 938);
            this.SetMaxStepLength.Name = "SetMaxStepLength";
            this.SetMaxStepLength.Size = new System.Drawing.Size(60, 40);
            this.SetMaxStepLength.TabIndex = 14;
            this.SetMaxStepLength.Text = "Set";
            this.SetMaxStepLength.UseVisualStyleBackColor = true;
            // 
            // SetMinStepLength
            // 
            this.SetMinStepLength.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetMinStepLength.Location = new System.Drawing.Point(277, 981);
            this.SetMinStepLength.Name = "SetMinStepLength";
            this.SetMinStepLength.Size = new System.Drawing.Size(60, 40);
            this.SetMinStepLength.TabIndex = 14;
            this.SetMinStepLength.Text = "Set";
            this.SetMinStepLength.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 906);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "StepLength";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // WobblingBox
            // 
            this.WobblingBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WobblingBox.Location = new System.Drawing.Point(5, 866);
            this.WobblingBox.Name = "WobblingBox";
            this.WobblingBox.Size = new System.Drawing.Size(100, 35);
            this.WobblingBox.TabIndex = 12;
            this.WobblingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NecessaryTurnBox
            // 
            this.NecessaryTurnBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NecessaryTurnBox.Location = new System.Drawing.Point(175, 866);
            this.NecessaryTurnBox.Name = "NecessaryTurnBox";
            this.NecessaryTurnBox.Size = new System.Drawing.Size(100, 35);
            this.NecessaryTurnBox.TabIndex = 12;
            this.NecessaryTurnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetWobbling
            // 
            this.SetWobbling.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetWobbling.Location = new System.Drawing.Point(107, 866);
            this.SetWobbling.Name = "SetWobbling";
            this.SetWobbling.Size = new System.Drawing.Size(60, 40);
            this.SetWobbling.TabIndex = 14;
            this.SetWobbling.Text = "Set";
            this.SetWobbling.UseVisualStyleBackColor = true;
            this.SetWobbling.Click += new System.EventHandler(this.SetWobbling_Click);
            // 
            // SetNecessaryTurn
            // 
            this.SetNecessaryTurn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetNecessaryTurn.Location = new System.Drawing.Point(277, 866);
            this.SetNecessaryTurn.Name = "SetNecessaryTurn";
            this.SetNecessaryTurn.Size = new System.Drawing.Size(60, 40);
            this.SetNecessaryTurn.TabIndex = 14;
            this.SetNecessaryTurn.Text = "Set";
            this.SetNecessaryTurn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 833);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Wobbling";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 833);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "NecessaryTurn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Physarum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetMinStepLength);
            this.Controls.Add(this.SetMinStepAngle);
            this.Controls.Add(this.SetNecessaryTurn);
            this.Controls.Add(this.SetMaxStepLength);
            this.Controls.Add(this.SetWobbling);
            this.Controls.Add(this.SetMaxStepAngle);
            this.Controls.Add(this.MinStepLengthBox);
            this.Controls.Add(this.NecessaryTurnBox);
            this.Controls.Add(this.MinStepAngleBox);
            this.Controls.Add(this.WobblingBox);
            this.Controls.Add(this.MaxStepLengthBox);
            this.Controls.Add(this.MaxStepAngleBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.WorldVisualisation);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Physarum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.WorldVisualisation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox WobblingBox;
        private System.Windows.Forms.TextBox NecessaryTurnBox;
        private System.Windows.Forms.Button SetWobbling;
        private System.Windows.Forms.Button SetNecessaryTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox MaxStepLengthBox;
        private System.Windows.Forms.TextBox MinStepLengthBox;
        private System.Windows.Forms.Button SetMaxStepLength;
        private System.Windows.Forms.Button SetMinStepLength;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox MinStepAngleBox;
        private System.Windows.Forms.Button SetMinStepAngle;

        #endregion

        private System.Windows.Forms.PictureBox WorldVisualisation;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox MaxStepAngleBox;
        private System.Windows.Forms.Button SetMaxStepAngle;
        private System.Windows.Forms.Timer IterationTimer;
    }
}

