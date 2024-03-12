namespace AC22005Assignment3
{
    partial class ATMForm
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
            this.btn_right1 = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn_left4 = new System.Windows.Forms.Button();
            this.btn_left3 = new System.Windows.Forms.Button();
            this.btn_left2 = new System.Windows.Forms.Button();
            this.btn_left1 = new System.Windows.Forms.Button();
            this.btn_right4 = new System.Windows.Forms.Button();
            this.btn_right3 = new System.Windows.Forms.Button();
            this.btn_right2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_right1
            // 
            this.btn_right1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_right1.Location = new System.Drawing.Point(485, 40);
            this.btn_right1.Name = "btn_right1";
            this.btn_right1.Size = new System.Drawing.Size(60, 40);
            this.btn_right1.TabIndex = 0;
            this.btn_right1.UseVisualStyleBackColor = true;
            this.btn_right1.Click += new System.EventHandler(this.sideButtonsClicked);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Enter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Enter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Enter.Location = new System.Drawing.Point(133, 139);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(60, 40);
            this.btn_Enter.TabIndex = 1;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cancel.Location = new System.Drawing.Point(1, 139);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(60, 40);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.NumpadClicked);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(67, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumpadClicked);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(133, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumpadClicked);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(1, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumpadClicked);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(133, 47);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumpadClicked);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(67, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumpadClicked);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(1, 93);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 40);
            this.button10.TabIndex = 9;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.NumpadClicked);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(133, 93);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 40);
            this.button11.TabIndex = 10;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.NumpadClicked);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(67, 93);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 40);
            this.button12.TabIndex = 11;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.NumpadClicked);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(67, 139);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 40);
            this.button13.TabIndex = 12;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.NumpadClicked);
            // 
            // btn_left4
            // 
            this.btn_left4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_left4.Location = new System.Drawing.Point(40, 220);
            this.btn_left4.Name = "btn_left4";
            this.btn_left4.Size = new System.Drawing.Size(60, 40);
            this.btn_left4.TabIndex = 13;
            this.btn_left4.UseVisualStyleBackColor = true;
            this.btn_left4.Click += new System.EventHandler(this.sideButtonsClicked);
            // 
            // btn_left3
            // 
            this.btn_left3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_left3.Location = new System.Drawing.Point(40, 160);
            this.btn_left3.Name = "btn_left3";
            this.btn_left3.Size = new System.Drawing.Size(60, 40);
            this.btn_left3.TabIndex = 14;
            this.btn_left3.UseVisualStyleBackColor = true;
            this.btn_left3.Click += new System.EventHandler(this.sideButtonsClicked);
            // 
            // btn_left2
            // 
            this.btn_left2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_left2.Location = new System.Drawing.Point(40, 100);
            this.btn_left2.Name = "btn_left2";
            this.btn_left2.Size = new System.Drawing.Size(60, 40);
            this.btn_left2.TabIndex = 15;
            this.btn_left2.UseVisualStyleBackColor = true;
            this.btn_left2.Click += new System.EventHandler(this.sideButtonsClicked);
            // 
            // btn_left1
            // 
            this.btn_left1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_left1.Location = new System.Drawing.Point(40, 40);
            this.btn_left1.Name = "btn_left1";
            this.btn_left1.Size = new System.Drawing.Size(60, 40);
            this.btn_left1.TabIndex = 16;
            this.btn_left1.UseVisualStyleBackColor = true;
            this.btn_left1.Click += new System.EventHandler(this.sideButtonsClicked);
            // 
            // btn_right4
            // 
            this.btn_right4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_right4.Location = new System.Drawing.Point(485, 220);
            this.btn_right4.Name = "btn_right4";
            this.btn_right4.Size = new System.Drawing.Size(60, 40);
            this.btn_right4.TabIndex = 17;
            this.btn_right4.UseVisualStyleBackColor = true;
            this.btn_right4.Click += new System.EventHandler(this.sideButtonsClicked);
            // 
            // btn_right3
            // 
            this.btn_right3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_right3.Location = new System.Drawing.Point(485, 160);
            this.btn_right3.Name = "btn_right3";
            this.btn_right3.Size = new System.Drawing.Size(60, 40);
            this.btn_right3.TabIndex = 18;
            this.btn_right3.UseVisualStyleBackColor = true;
            this.btn_right3.Click += new System.EventHandler(this.sideButtonsClicked);
            // 
            // btn_right2
            // 
            this.btn_right2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_right2.Location = new System.Drawing.Point(485, 100);
            this.btn_right2.Name = "btn_right2";
            this.btn_right2.Size = new System.Drawing.Size(60, 40);
            this.btn_right2.TabIndex = 19;
            this.btn_right2.UseVisualStyleBackColor = true;
            this.btn_right2.Click += new System.EventHandler(this.sideButtonsClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Enter);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Location = new System.Drawing.Point(190, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 182);
            this.panel2.TabIndex = 21;
            // 
            // displayBox
            // 
            this.displayBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayBox.Location = new System.Drawing.Point(134, 40);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.Size = new System.Drawing.Size(318, 220);
            this.displayBox.TabIndex = 23;
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ATMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_right2);
            this.Controls.Add(this.btn_right3);
            this.Controls.Add(this.btn_right4);
            this.Controls.Add(this.btn_left1);
            this.Controls.Add(this.btn_left2);
            this.Controls.Add(this.btn_left3);
            this.Controls.Add(this.btn_left4);
            this.Controls.Add(this.btn_right1);
            this.Name = "ATMForm";
            this.Text = "ATM";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_right1;
        private Button btn_Enter;
        private Button btn_Cancel;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button btn_left4;
        private Button btn_left3;
        private Button btn_left2;
        private Button btn_left1;
        private Button btn_right4;
        private Button btn_right3;
        private Button btn_right2;
        private Panel panel2;
        private TextBox displayBox;
    }
}