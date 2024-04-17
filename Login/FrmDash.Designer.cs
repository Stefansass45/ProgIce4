namespace Login
{
    partial class FrmDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDash));
            lblUserGreeting = new Label();
            lblSettings = new Label();
            lblDebtors = new Label();
            lblStock = new Label();
            lblLedger = new Label();
            SuspendLayout();
            // 
            // lblUserGreeting
            // 
            lblUserGreeting.AutoSize = true;
            lblUserGreeting.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblUserGreeting.Location = new Point(12, 9);
            lblUserGreeting.Name = "lblUserGreeting";
            lblUserGreeting.Size = new Size(215, 37);
            lblUserGreeting.TabIndex = 0;
            lblUserGreeting.Text = "Greetings User!";
            // 
            // lblSettings
            // 
            lblSettings.BorderStyle = BorderStyle.FixedSingle;
            lblSettings.Font = new Font("Lucida Console", 14F);
            lblSettings.Location = new Point(12, 263);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(612, 77);
            lblSettings.TabIndex = 3;
            lblSettings.Text = "Settings";
            lblSettings.TextAlign = ContentAlignment.MiddleCenter;
            lblSettings.Click += NotImplemented_Click;
            // 
            // lblDebtors
            // 
            lblDebtors.BorderStyle = BorderStyle.FixedSingle;
            lblDebtors.Font = new Font("Lucida Console", 14F);
            lblDebtors.Location = new Point(12, 57);
            lblDebtors.Name = "lblDebtors";
            lblDebtors.Size = new Size(200, 200);
            lblDebtors.TabIndex = 1;
            lblDebtors.Text = "Debtors";
            lblDebtors.TextAlign = ContentAlignment.MiddleCenter;
            lblDebtors.Click += NotImplemented_Click;
            // 
            // lblStock
            // 
            lblStock.BorderStyle = BorderStyle.FixedSingle;
            lblStock.Font = new Font("Lucida Console", 14F);
            lblStock.Location = new Point(218, 57);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(200, 200);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            lblStock.Click += NotImplemented_Click;
            // 
            // lblLedger
            // 
            lblLedger.BorderStyle = BorderStyle.FixedSingle;
            lblLedger.Font = new Font("Lucida Console", 14F);
            lblLedger.Location = new Point(424, 57);
            lblLedger.Name = "lblLedger";
            lblLedger.Size = new Size(200, 200);
            lblLedger.TabIndex = 5;
            lblLedger.Text = "Ledger";
            lblLedger.TextAlign = ContentAlignment.MiddleCenter;
            lblLedger.Click += NotImplemented_Click;
            // 
            // FrmDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 366);
            Controls.Add(lblLedger);
            Controls.Add(lblStock);
            Controls.Add(lblDebtors);
            Controls.Add(lblSettings);
            Controls.Add(lblUserGreeting);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDash";
            Text = "Dashboard";
            Load += FrmDash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserGreeting;
        private Label lblSettings;
        private Label lblDebtors;
        private Label lblStock;
        private Label lblLedger;
    }
}