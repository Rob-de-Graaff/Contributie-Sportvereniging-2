namespace Contributie
{
    partial class Form1
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.listBoxMembers = new System.Windows.Forms.ListBox();
            this.buttonRemoveSport = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listBoxSports = new System.Windows.Forms.ListBox();
            this.buttonAddSport = new System.Windows.Forms.Button();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.panelLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.listBoxMembers);
            this.panelLayout.Controls.Add(this.buttonRemoveSport);
            this.panelLayout.Controls.Add(this.buttonReset);
            this.panelLayout.Controls.Add(this.listBoxSports);
            this.panelLayout.Controls.Add(this.buttonAddSport);
            this.panelLayout.Controls.Add(this.listBoxSelected);
            this.panelLayout.Controls.Add(this.buttonCalculate);
            this.panelLayout.Controls.Add(this.labelTicketsTotal);
            this.panelLayout.Controls.Add(this.labelPriceTotal);
            this.panelLayout.Location = new System.Drawing.Point(12, 32);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(776, 387);
            this.panelLayout.TabIndex = 30;
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.ItemHeight = 16;
            this.listBoxMembers.Location = new System.Drawing.Point(182, 3);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(173, 68);
            this.listBoxMembers.TabIndex = 63;
            // 
            // buttonRemoveSport
            // 
            this.buttonRemoveSport.Location = new System.Drawing.Point(3, 218);
            this.buttonRemoveSport.Name = "buttonRemoveSport";
            this.buttonRemoveSport.Size = new System.Drawing.Size(115, 27);
            this.buttonRemoveSport.TabIndex = 62;
            this.buttonRemoveSport.Text = "Remove Sport";
            this.buttonRemoveSport.UseVisualStyleBackColor = true;
            this.buttonRemoveSport.Click += new System.EventHandler(this.ButtonRemoveSport_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(698, 351);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 33);
            this.buttonReset.TabIndex = 60;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // listBoxSports
            // 
            this.listBoxSports.FormattingEnabled = true;
            this.listBoxSports.ItemHeight = 16;
            this.listBoxSports.Location = new System.Drawing.Point(3, 3);
            this.listBoxSports.Name = "listBoxSports";
            this.listBoxSports.Size = new System.Drawing.Size(173, 68);
            this.listBoxSports.TabIndex = 59;
            // 
            // buttonAddSport
            // 
            this.buttonAddSport.Location = new System.Drawing.Point(3, 111);
            this.buttonAddSport.Name = "buttonAddSport";
            this.buttonAddSport.Size = new System.Drawing.Size(89, 27);
            this.buttonAddSport.TabIndex = 57;
            this.buttonAddSport.Text = "Add Sport";
            this.buttonAddSport.UseVisualStyleBackColor = true;
            this.buttonAddSport.Click += new System.EventHandler(this.ButtonAddSport_Click);
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 16;
            this.listBoxSelected.Location = new System.Drawing.Point(3, 144);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(770, 68);
            this.listBoxSelected.TabIndex = 57;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(10, 351);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 33);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "show price";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(7, 314);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 22;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(7, 331);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 21;
            this.labelPriceTotal.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.Button buttonRemoveSport;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListBox listBoxSports;
        private System.Windows.Forms.Button buttonAddSport;
        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
        private System.Windows.Forms.ListBox listBoxMembers;
    }
}

