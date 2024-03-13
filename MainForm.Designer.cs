namespace AC22005Assignment3
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CreateATM = new System.Windows.Forms.Button();
            this.OutputWindow = new System.Windows.Forms.Label();
            this.btn_raceConditionToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateATM
            // 
            this.btn_CreateATM.Location = new System.Drawing.Point(100, 400);
            this.btn_CreateATM.Name = "btn_CreateATM";
            this.btn_CreateATM.Size = new System.Drawing.Size(129, 52);
            this.btn_CreateATM.TabIndex = 0;
            this.btn_CreateATM.Text = "Create New ATM";
            this.btn_CreateATM.UseVisualStyleBackColor = true;
            this.btn_CreateATM.Click += new System.EventHandler(this.btn_CreateATM_Click);
            // 
            // OutputWindow
            // 
            this.OutputWindow.AutoSize = true;
            this.OutputWindow.BackColor = System.Drawing.SystemColors.Desktop;
            this.OutputWindow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputWindow.ForeColor = System.Drawing.Color.Lime;
            this.OutputWindow.Location = new System.Drawing.Point(100, 50);
            this.OutputWindow.MaximumSize = new System.Drawing.Size(400, 300);
            this.OutputWindow.MinimumSize = new System.Drawing.Size(400, 300);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(400, 300);
            this.OutputWindow.TabIndex = 1;
            // 
            // btn_raceConditionToggle
            // 
            this.btn_raceConditionToggle.Location = new System.Drawing.Point(361, 400);
            this.btn_raceConditionToggle.Name = "btn_raceConditionToggle";
            this.btn_raceConditionToggle.Size = new System.Drawing.Size(139, 52);
            this.btn_raceConditionToggle.TabIndex = 2;
            this.btn_raceConditionToggle.Text = "enable race condition fix";
            this.btn_raceConditionToggle.UseVisualStyleBackColor = true;
            this.btn_raceConditionToggle.Click += new System.EventHandler(this.btn_raceConditionToggle_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btn_raceConditionToggle);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.btn_CreateATM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "ATM Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_CreateATM;
        private Label OutputWindow;
        private Button btn_raceConditionToggle;
    }
}