namespace SchoolManagementSystem
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.navigtionMenu1 = new Kimtoo.NavigtionMenu();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(223, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 50);
            this.panel1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.CustomClick = true;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(608, 8);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.CustomClick = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(659, 8);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.CustomClick = true;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(710, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.Location = new System.Drawing.Point(223, 60);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(769, 398);
            this.ControlPanel.TabIndex = 1;
            // 
            // navigtionMenu1
            // 
            this.navigtionMenu1.AutoScroll = true;
            this.navigtionMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(61)))));
            this.navigtionMenu1.BackColor_Click = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.navigtionMenu1.BackColor_Hover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.navigtionMenu1.BackColor_Selected = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(104)))), ((int)(((byte)(240)))));
            this.navigtionMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigtionMenu1.DisableToggling = new string[0];
            this.navigtionMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigtionMenu1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigtionMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.navigtionMenu1.ForeColor_Selected = System.Drawing.Color.Empty;
            this.navigtionMenu1.IsExpandable = true;
            this.navigtionMenu1.IsExpanded = true;
            this.navigtionMenu1.ItemHeight = 40;
            this.navigtionMenu1.ItemImageSize = new System.Drawing.Size(20, 20);
            this.navigtionMenu1.ItemPadding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.navigtionMenu1.ItemRightImageMargin = 20;
            this.navigtionMenu1.ItemRightImageSize = new System.Drawing.Size(15, 15);
            this.navigtionMenu1.Items = new Kimtoo.ButtonItem[] {
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items1"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items2"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items3"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items4"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items5"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("navigtionMenu1.Items6")))};
            this.navigtionMenu1.ItemTextMargin = 8;
            this.navigtionMenu1.Location = new System.Drawing.Point(0, 0);
            this.navigtionMenu1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.navigtionMenu1.Name = "navigtionMenu1";
            this.navigtionMenu1.Size = new System.Drawing.Size(217, 568);
            this.navigtionMenu1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 568);
            this.Controls.Add(this.navigtionMenu1);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ControlPanel;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Kimtoo.NavigtionMenu navigtionMenu1;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}