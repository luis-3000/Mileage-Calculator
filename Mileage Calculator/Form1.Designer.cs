namespace Mileage_Calculator
{
    partial class MileageCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartingMileage = new System.Windows.Forms.NumericUpDown();
            this.EndingMileage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DisplayMilesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartingMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Mileage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ending Mileage";
            // 
            // StartingMileage
            // 
            this.StartingMileage.Location = new System.Drawing.Point(167, 27);
            this.StartingMileage.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.StartingMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingMileage.Name = "StartingMileage";
            this.StartingMileage.Size = new System.Drawing.Size(198, 26);
            this.StartingMileage.TabIndex = 2;
            this.StartingMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndingMileage
            // 
            this.EndingMileage.Location = new System.Drawing.Point(170, 91);
            this.EndingMileage.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.EndingMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndingMileage.Name = "EndingMileage";
            this.EndingMileage.Size = new System.Drawing.Size(194, 26);
            this.EndingMileage.TabIndex = 3;
            this.EndingMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Owed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayMilesButton
            // 
            this.DisplayMilesButton.Location = new System.Drawing.Point(226, 236);
            this.DisplayMilesButton.Name = "DisplayMilesButton";
            this.DisplayMilesButton.Size = new System.Drawing.Size(223, 38);
            this.DisplayMilesButton.TabIndex = 7;
            this.DisplayMilesButton.Text = "Display Miles Driven";
            this.DisplayMilesButton.UseVisualStyleBackColor = true;
            this.DisplayMilesButton.Click += new System.EventHandler(this.DisplayMilesButton_Click);
            // 
            // MileageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 325);
            this.Controls.Add(this.DisplayMilesButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndingMileage);
            this.Controls.Add(this.StartingMileage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MileageCalculator";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.StartingMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown StartingMileage;
        private System.Windows.Forms.NumericUpDown EndingMileage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DisplayMilesButton;
    }
}

