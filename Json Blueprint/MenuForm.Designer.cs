namespace Json_Blueprint
{
    partial class MenuForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuItemHowIt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumAttr = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNextStage2 = new System.Windows.Forms.Button();
            this.lblDebugName = new System.Windows.Forms.Label();
            this.lblDebugType = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemHowIt,
            this.mnuItemAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(707, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuItemHowIt
            // 
            this.mnuItemHowIt.Name = "mnuItemHowIt";
            this.mnuItemHowIt.Size = new System.Drawing.Size(88, 20);
            this.mnuItemHowIt.Text = "How it works";
            // 
            // mnuItemAbout
            // 
            this.mnuItemAbout.Name = "mnuItemAbout";
            this.mnuItemAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuItemAbout.Text = "About";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(136, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of attributes per object:";
            // 
            // txtNumAttr
            // 
            this.txtNumAttr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumAttr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtNumAttr.Location = new System.Drawing.Point(487, 38);
            this.txtNumAttr.Name = "txtNumAttr";
            this.txtNumAttr.Size = new System.Drawing.Size(48, 32);
            this.txtNumAttr.TabIndex = 2;
            this.txtNumAttr.TextChanged += new System.EventHandler(this.txtNumAttr_TextChanged);
            this.txtNumAttr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberRestriction_KeyPress);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(211, 352);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 47);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 97);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(683, 222);
            this.flowLayoutPanel.TabIndex = 5;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // btnNextStage2
            // 
            this.btnNextStage2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextStage2.Location = new System.Drawing.Point(324, 352);
            this.btnNextStage2.Name = "btnNextStage2";
            this.btnNextStage2.Size = new System.Drawing.Size(98, 47);
            this.btnNextStage2.TabIndex = 6;
            this.btnNextStage2.Text = "Next";
            this.btnNextStage2.UseVisualStyleBackColor = true;
            this.btnNextStage2.Visible = false;
            this.btnNextStage2.Click += new System.EventHandler(this.btnNextStage2_Click);
            // 
            // lblDebugName
            // 
            this.lblDebugName.AutoSize = true;
            this.lblDebugName.Location = new System.Drawing.Point(575, 24);
            this.lblDebugName.Name = "lblDebugName";
            this.lblDebugName.Size = new System.Drawing.Size(37, 13);
            this.lblDebugName.TabIndex = 7;
            this.lblDebugName.Text = "debug";
            // 
            // lblDebugType
            // 
            this.lblDebugType.AutoSize = true;
            this.lblDebugType.Location = new System.Drawing.Point(575, 41);
            this.lblDebugType.Name = "lblDebugType";
            this.lblDebugType.Size = new System.Drawing.Size(37, 13);
            this.lblDebugType.TabIndex = 8;
            this.lblDebugType.Text = "debug";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(707, 411);
            this.Controls.Add(this.lblDebugType);
            this.Controls.Add(this.lblDebugName);
            this.Controls.Add(this.btnNextStage2);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtNumAttr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Json Blueprint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHowIt;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumAttr;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnNextStage2;
        private System.Windows.Forms.Label lblDebugName;
        private System.Windows.Forms.Label lblDebugType;
    }
}

