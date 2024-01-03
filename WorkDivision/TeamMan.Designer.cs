namespace WorkDivision
{
    partial class TeamMan
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
            this.listBox_team = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_cover.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_team
            // 
            this.listBox_team.FormattingEnabled = true;
            this.listBox_team.ItemHeight = 21;
            this.listBox_team.Location = new System.Drawing.Point(12, 12);
            this.listBox_team.Name = "listBox_team";
            this.listBox_team.Size = new System.Drawing.Size(602, 613);
            this.listBox_team.TabIndex = 0;
            this.listBox_team.SelectedIndexChanged += new System.EventHandler(this.listBox_team_SelectedIndexChanged);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(624, 73);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(218, 110);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "<--增加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(624, 189);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(218, 110);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "删除-->";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(620, 515);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(218, 110);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名：";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(624, 36);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(214, 31);
            this.textBox_name.TabIndex = 5;
            // 
            // panel_cover
            // 
            this.panel_cover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_cover.Controls.Add(this.label2);
            this.panel_cover.Location = new System.Drawing.Point(171, 151);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(544, 251);
            this.panel_cover.TabIndex = 6;
            this.panel_cover.Visible = false;
            this.panel_cover.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cover_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(65, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 74);
            this.label2.TabIndex = 0;
            this.label2.Text = "无法找到可用的data.txt\r\n请手动于根目录创建。";
            // 
            // TeamMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 639);
            this.Controls.Add(this.panel_cover);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_team);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TeamMan";
            this.Text = "成员管理";
            this.Load += new System.EventHandler(this.TeamMan_Load);
            this.panel_cover.ResumeLayout(false);
            this.panel_cover.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_team;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Label label2;
    }
}