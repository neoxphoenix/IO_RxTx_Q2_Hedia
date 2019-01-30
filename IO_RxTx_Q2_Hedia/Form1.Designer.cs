namespace IO_RxTx_Q2_Hedia
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.tbEmission = new System.Windows.Forms.TextBox();
            this.tbReception = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnvoi = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblInfos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBaud = new System.Windows.Forms.Label();
            this.tbBauds = new System.Windows.Forms.TextBox();
            this.timerRX = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInfos = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnClear);
            this.gb1.Controls.Add(this.btnEnvoi);
            this.gb1.Controls.Add(this.tbEmission);
            this.gb1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(12, 59);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(260, 104);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Transmission TX";
            // 
            // tbEmission
            // 
            this.tbEmission.Location = new System.Drawing.Point(6, 19);
            this.tbEmission.Multiline = true;
            this.tbEmission.Name = "tbEmission";
            this.tbEmission.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEmission.Size = new System.Drawing.Size(248, 52);
            this.tbEmission.TabIndex = 1;
            // 
            // tbReception
            // 
            this.tbReception.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReception.Location = new System.Drawing.Point(6, 19);
            this.tbReception.Multiline = true;
            this.tbReception.Name = "tbReception";
            this.tbReception.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReception.Size = new System.Drawing.Size(248, 43);
            this.tbReception.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbReception);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reception TX";
            // 
            // btnEnvoi
            // 
            this.btnEnvoi.Location = new System.Drawing.Point(6, 77);
            this.btnEnvoi.Name = "btnEnvoi";
            this.btnEnvoi.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoi.TabIndex = 3;
            this.btnEnvoi.Text = "Envoi";
            this.btnEnvoi.UseVisualStyleBackColor = true;
            this.btnEnvoi.Click += new System.EventHandler(this.btnEnvoi_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(82, 7);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(130, 21);
            this.cbPorts.TabIndex = 3;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port(s) :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(218, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(54, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblInfos
            // 
            this.lblInfos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblInfos.Location = new System.Drawing.Point(56, 247);
            this.lblInfos.MaximumSize = new System.Drawing.Size(190, 13);
            this.lblInfos.MinimumSize = new System.Drawing.Size(190, 13);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(190, 13);
            this.lblInfos.TabIndex = 6;
            this.lblInfos.Text = "Selectionner un des ports disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status:";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(51, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(69, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaud.Location = new System.Drawing.Point(158, 37);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(56, 14);
            this.lblBaud.TabIndex = 10;
            this.lblBaud.Text = "Bauds :";
            // 
            // tbBauds
            // 
            this.tbBauds.Location = new System.Drawing.Point(220, 34);
            this.tbBauds.Name = "tbBauds";
            this.tbBauds.Size = new System.Drawing.Size(52, 20);
            this.tbBauds.TabIndex = 11;
            this.tbBauds.Text = "9600";
            // 
            // timerRX
            // 
            this.timerRX.Interval = 1000;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(179, 75);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInfos
            // 
            this.btnInfos.BackColor = System.Drawing.Color.Transparent;
            this.btnInfos.BackgroundImage = global::IO_RxTx_Q2_Hedia.Properties.Resources.info2;
            this.btnInfos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfos.Location = new System.Drawing.Point(252, 238);
            this.btnInfos.Name = "btnInfos";
            this.btnInfos.Size = new System.Drawing.Size(30, 30);
            this.btnInfos.TabIndex = 12;
            this.btnInfos.UseVisualStyleBackColor = false;
            this.btnInfos.Click += new System.EventHandler(this.btnInfos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.btnInfos);
            this.Controls.Add(this.tbBauds);
            this.Controls.Add(this.lblBaud);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfos);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Projet TX RX";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnEnvoi;
        private System.Windows.Forms.TextBox tbEmission;
        private System.Windows.Forms.TextBox tbReception;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblInfos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.TextBox tbBauds;
        private System.Windows.Forms.Timer timerRX;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInfos;
    }
}

