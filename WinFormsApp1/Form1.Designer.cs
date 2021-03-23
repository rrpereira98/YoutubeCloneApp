
namespace WinFormsApp1
{
    partial class Form1
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonIcon = new System.Windows.Forms.Button();
            this.buttonHamburguer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.buttonSubs = new System.Windows.Forms.Button();
            this.buttonExplore = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelTop.Controls.Add(this.buttonIcon);
            this.panelTop.Controls.Add(this.buttonHamburguer);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1366, 64);
            this.panelTop.TabIndex = 0;
            // 
            // buttonIcon
            // 
            this.buttonIcon.FlatAppearance.BorderSize = 0;
            this.buttonIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIcon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIcon.ForeColor = System.Drawing.Color.White;
            this.buttonIcon.Image = global::WinFormsApp1.Properties.Resources.icons8_play_button_48px;
            this.buttonIcon.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonIcon.Location = new System.Drawing.Point(88, 3);
            this.buttonIcon.Name = "buttonIcon";
            this.buttonIcon.Size = new System.Drawing.Size(129, 58);
            this.buttonIcon.TabIndex = 1;
            this.buttonIcon.Text = "YouTube";
            this.buttonIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonIcon.UseVisualStyleBackColor = true;
            this.buttonIcon.Click += new System.EventHandler(this.buttonIcon_Click);
            // 
            // buttonHamburguer
            // 
            this.buttonHamburguer.FlatAppearance.BorderSize = 0;
            this.buttonHamburguer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHamburguer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHamburguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHamburguer.Image = global::WinFormsApp1.Properties.Resources.icons8_menu_30px;
            this.buttonHamburguer.Location = new System.Drawing.Point(14, 11);
            this.buttonHamburguer.Name = "buttonHamburguer";
            this.buttonHamburguer.Size = new System.Drawing.Size(48, 38);
            this.buttonHamburguer.TabIndex = 1;
            this.buttonHamburguer.UseVisualStyleBackColor = true;
            this.buttonHamburguer.Click += new System.EventHandler(this.buttonHamburguer_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.textBox1.Location = new System.Drawing.Point(584, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "  Search";
            this.textBox1.Size = new System.Drawing.Size(418, 23);
            this.textBox1.TabIndex = 0;
            // 
            // panelSide
            // 
            this.panelSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelSide.Controls.Add(this.buttonSubs);
            this.panelSide.Controls.Add(this.buttonExplore);
            this.panelSide.Controls.Add(this.buttonHome);
            this.panelSide.Location = new System.Drawing.Point(0, 64);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(240, 613);
            this.panelSide.TabIndex = 1;
            // 
            // buttonSubs
            // 
            this.buttonSubs.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubs.FlatAppearance.BorderSize = 0;
            this.buttonSubs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubs.ForeColor = System.Drawing.Color.White;
            this.buttonSubs.Image = global::WinFormsApp1.Properties.Resources.icons8_play_button_30px;
            this.buttonSubs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubs.Location = new System.Drawing.Point(0, 94);
            this.buttonSubs.Name = "buttonSubs";
            this.buttonSubs.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonSubs.Size = new System.Drawing.Size(240, 47);
            this.buttonSubs.TabIndex = 0;
            this.buttonSubs.Text = "     Subscriptions";
            this.buttonSubs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSubs.UseVisualStyleBackColor = true;
            // 
            // buttonExplore
            // 
            this.buttonExplore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExplore.FlatAppearance.BorderSize = 0;
            this.buttonExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExplore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExplore.ForeColor = System.Drawing.Color.White;
            this.buttonExplore.Image = global::WinFormsApp1.Properties.Resources.icons8_compass_32px;
            this.buttonExplore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExplore.Location = new System.Drawing.Point(0, 47);
            this.buttonExplore.Name = "buttonExplore";
            this.buttonExplore.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonExplore.Size = new System.Drawing.Size(240, 47);
            this.buttonExplore.TabIndex = 0;
            this.buttonExplore.Text = "    Explore";
            this.buttonExplore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExplore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExplore.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = global::WinFormsApp1.Properties.Resources.icons8_home_30px;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(240, 47);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "     Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.Location = new System.Drawing.Point(240, 64);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1126, 613);
            this.panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1366, 675);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonIcon;
        private System.Windows.Forms.Button buttonHamburguer;
        private System.Windows.Forms.Button buttonSubs;
        private System.Windows.Forms.Button buttonExplore;
        private System.Windows.Forms.Button buttonHome;
    }
}

