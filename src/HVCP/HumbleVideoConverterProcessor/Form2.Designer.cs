namespace HumbleVideoConverterProcessor
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txb_sh = new System.Windows.Forms.TextBox();
            this.txb_sm = new System.Windows.Forms.TextBox();
            this.txb_sc = new System.Windows.Forms.TextBox();
            this.txb_eh = new System.Windows.Forms.TextBox();
            this.txb_em = new System.Windows.Forms.TextBox();
            this.txb_es = new System.Windows.Forms.TextBox();
            this.txb_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(510, 268);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Start,
            this.End,
            this.Sub_Text});
            this.dataGridView1.Location = new System.Drawing.Point(1, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1017, 278);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txb_sh
            // 
            this.txb_sh.Location = new System.Drawing.Point(47, 302);
            this.txb_sh.Name = "txb_sh";
            this.txb_sh.Size = new System.Drawing.Size(40, 20);
            this.txb_sh.TabIndex = 2;
            // 
            // txb_sm
            // 
            this.txb_sm.Location = new System.Drawing.Point(93, 302);
            this.txb_sm.Name = "txb_sm";
            this.txb_sm.Size = new System.Drawing.Size(39, 20);
            this.txb_sm.TabIndex = 3;
            // 
            // txb_sc
            // 
            this.txb_sc.Location = new System.Drawing.Point(138, 302);
            this.txb_sc.Name = "txb_sc";
            this.txb_sc.Size = new System.Drawing.Size(43, 20);
            this.txb_sc.TabIndex = 4;
            // 
            // txb_eh
            // 
            this.txb_eh.Location = new System.Drawing.Point(47, 328);
            this.txb_eh.Name = "txb_eh";
            this.txb_eh.Size = new System.Drawing.Size(40, 20);
            this.txb_eh.TabIndex = 5;
            this.txb_eh.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txb_em
            // 
            this.txb_em.Location = new System.Drawing.Point(93, 328);
            this.txb_em.Name = "txb_em";
            this.txb_em.Size = new System.Drawing.Size(39, 20);
            this.txb_em.TabIndex = 6;
            // 
            // txb_es
            // 
            this.txb_es.Location = new System.Drawing.Point(138, 328);
            this.txb_es.Name = "txb_es";
            this.txb_es.Size = new System.Drawing.Size(43, 20);
            this.txb_es.TabIndex = 7;
            this.txb_es.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txb_text
            // 
            this.txb_text.Location = new System.Drawing.Point(207, 302);
            this.txb_text.Multiline = true;
            this.txb_text.Name = "txb_text";
            this.txb_text.Size = new System.Drawing.Size(730, 46);
            this.txb_text.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Text";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(943, 325);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(943, 638);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(75, 23);
            this.btn_write.TabIndex = 16;
            this.btn_write.Text = "Write2File";
            this.btn_write.UseVisualStyleBackColor = true;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.Width = 50;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.Width = 120;
            // 
            // End
            // 
            this.End.HeaderText = "End";
            this.End.Name = "End";
            this.End.Width = 120;
            // 
            // Sub_Text
            // 
            this.Sub_Text.HeaderText = "Text";
            this.Sub_Text.Name = "Sub_Text";
            this.Sub_Text.Width = 685;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 667);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_text);
            this.Controls.Add(this.txb_es);
            this.Controls.Add(this.txb_em);
            this.Controls.Add(this.txb_eh);
            this.Controls.Add(this.txb_sc);
            this.Controls.Add(this.txb_sm);
            this.Controls.Add(this.txb_sh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form2";
            this.Text = "HVCP - Subtitle Editor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txb_sh;
        private System.Windows.Forms.TextBox txb_sm;
        private System.Windows.Forms.TextBox txb_sc;
        private System.Windows.Forms.TextBox txb_eh;
        private System.Windows.Forms.TextBox txb_em;
        private System.Windows.Forms.TextBox txb_es;
        private System.Windows.Forms.TextBox txb_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Text;
    }
}