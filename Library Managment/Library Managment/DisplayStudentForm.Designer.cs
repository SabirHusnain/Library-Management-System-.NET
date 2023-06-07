
namespace Library_Managment
{
    partial class DisplayStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayStudentForm));
            this.dgView_StudentsRecord = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DpStu_Card = new System.Windows.Forms.Button();
            this.btn_BkStu_Rf = new System.Windows.Forms.Button();
            this.btn_DpStu_Srch = new System.Windows.Forms.Button();
            this.btn_DpStu_Back = new System.Windows.Forms.Button();
            this.btn_DpStu_Update = new System.Windows.Forms.Button();
            this.btn_DpStu_Del = new System.Windows.Forms.Button();
            this.btn_DpStu_Add = new System.Windows.Forms.Button();
            this.txt_DpStu_Srch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_DpStu_Head = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_StudentsRecord)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgView_StudentsRecord
            // 
            this.dgView_StudentsRecord.AllowUserToAddRows = false;
            this.dgView_StudentsRecord.AllowUserToDeleteRows = false;
            this.dgView_StudentsRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgView_StudentsRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_StudentsRecord.GridColor = System.Drawing.Color.Black;
            this.dgView_StudentsRecord.Location = new System.Drawing.Point(6, 11);
            this.dgView_StudentsRecord.Name = "dgView_StudentsRecord";
            this.dgView_StudentsRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView_StudentsRecord.Size = new System.Drawing.Size(623, 361);
            this.dgView_StudentsRecord.TabIndex = 0;
            this.dgView_StudentsRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_StudentsRecord_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_DpStu_Card);
            this.panel1.Controls.Add(this.btn_BkStu_Rf);
            this.panel1.Controls.Add(this.btn_DpStu_Srch);
            this.panel1.Controls.Add(this.btn_DpStu_Back);
            this.panel1.Controls.Add(this.btn_DpStu_Update);
            this.panel1.Controls.Add(this.btn_DpStu_Del);
            this.panel1.Controls.Add(this.btn_DpStu_Add);
            this.panel1.Controls.Add(this.txt_DpStu_Srch);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dgView_StudentsRecord);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 449);
            this.panel1.TabIndex = 34;
            // 
            // btn_DpStu_Card
            // 
            this.btn_DpStu_Card.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpStu_Card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpStu_Card.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpStu_Card.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpStu_Card.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpStu_Card.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpStu_Card.ForeColor = System.Drawing.Color.White;
            this.btn_DpStu_Card.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpStu_Card.Location = new System.Drawing.Point(517, 377);
            this.btn_DpStu_Card.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpStu_Card.Name = "btn_DpStu_Card";
            this.btn_DpStu_Card.Size = new System.Drawing.Size(112, 31);
            this.btn_DpStu_Card.TabIndex = 34;
            this.btn_DpStu_Card.Text = "Dispaly Profile";
            this.btn_DpStu_Card.UseVisualStyleBackColor = false;
            this.btn_DpStu_Card.Click += new System.EventHandler(this.btn_DpStu_Card_Click);
            // 
            // btn_BkStu_Rf
            // 
            this.btn_BkStu_Rf.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_BkStu_Rf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BkStu_Rf.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_BkStu_Rf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_BkStu_Rf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_BkStu_Rf.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_BkStu_Rf.ForeColor = System.Drawing.Color.White;
            this.btn_BkStu_Rf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_BkStu_Rf.Location = new System.Drawing.Point(187, 412);
            this.btn_BkStu_Rf.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BkStu_Rf.Name = "btn_BkStu_Rf";
            this.btn_BkStu_Rf.Size = new System.Drawing.Size(70, 31);
            this.btn_BkStu_Rf.TabIndex = 33;
            this.btn_BkStu_Rf.Text = "Refresh";
            this.btn_BkStu_Rf.UseVisualStyleBackColor = false;
            this.btn_BkStu_Rf.Click += new System.EventHandler(this.btn_BkStu_Rf_Click);
            // 
            // btn_DpStu_Srch
            // 
            this.btn_DpStu_Srch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpStu_Srch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpStu_Srch.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpStu_Srch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpStu_Srch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpStu_Srch.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpStu_Srch.ForeColor = System.Drawing.Color.White;
            this.btn_DpStu_Srch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpStu_Srch.Location = new System.Drawing.Point(400, 377);
            this.btn_DpStu_Srch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpStu_Srch.Name = "btn_DpStu_Srch";
            this.btn_DpStu_Srch.Size = new System.Drawing.Size(79, 31);
            this.btn_DpStu_Srch.TabIndex = 32;
            this.btn_DpStu_Srch.Text = "Search";
            this.btn_DpStu_Srch.UseVisualStyleBackColor = false;
            this.btn_DpStu_Srch.Click += new System.EventHandler(this.btn_DpStu_Srch_Click);
            // 
            // btn_DpStu_Back
            // 
            this.btn_DpStu_Back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpStu_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpStu_Back.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpStu_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpStu_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpStu_Back.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpStu_Back.ForeColor = System.Drawing.Color.White;
            this.btn_DpStu_Back.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpStu_Back.Location = new System.Drawing.Point(116, 412);
            this.btn_DpStu_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpStu_Back.Name = "btn_DpStu_Back";
            this.btn_DpStu_Back.Size = new System.Drawing.Size(67, 31);
            this.btn_DpStu_Back.TabIndex = 31;
            this.btn_DpStu_Back.Text = "Back";
            this.btn_DpStu_Back.UseVisualStyleBackColor = false;
            this.btn_DpStu_Back.Click += new System.EventHandler(this.btn_DpStu_Back_Click);
            // 
            // btn_DpStu_Update
            // 
            this.btn_DpStu_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpStu_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpStu_Update.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpStu_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpStu_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpStu_Update.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpStu_Update.ForeColor = System.Drawing.Color.White;
            this.btn_DpStu_Update.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpStu_Update.Location = new System.Drawing.Point(261, 412);
            this.btn_DpStu_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpStu_Update.Name = "btn_DpStu_Update";
            this.btn_DpStu_Update.Size = new System.Drawing.Size(126, 31);
            this.btn_DpStu_Update.TabIndex = 30;
            this.btn_DpStu_Update.Text = "Update Student";
            this.btn_DpStu_Update.UseVisualStyleBackColor = false;
            this.btn_DpStu_Update.Click += new System.EventHandler(this.btn_DpStu_Update_Click);
            // 
            // btn_DpStu_Del
            // 
            this.btn_DpStu_Del.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpStu_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpStu_Del.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpStu_Del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpStu_Del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpStu_Del.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpStu_Del.ForeColor = System.Drawing.Color.White;
            this.btn_DpStu_Del.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpStu_Del.Location = new System.Drawing.Point(391, 412);
            this.btn_DpStu_Del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpStu_Del.Name = "btn_DpStu_Del";
            this.btn_DpStu_Del.Size = new System.Drawing.Size(122, 31);
            this.btn_DpStu_Del.TabIndex = 29;
            this.btn_DpStu_Del.Text = "Delete Student";
            this.btn_DpStu_Del.UseVisualStyleBackColor = false;
            this.btn_DpStu_Del.Click += new System.EventHandler(this.btn_DpStu_Del_Click);
            // 
            // btn_DpStu_Add
            // 
            this.btn_DpStu_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpStu_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpStu_Add.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpStu_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpStu_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpStu_Add.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpStu_Add.ForeColor = System.Drawing.Color.White;
            this.btn_DpStu_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpStu_Add.Location = new System.Drawing.Point(517, 412);
            this.btn_DpStu_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpStu_Add.Name = "btn_DpStu_Add";
            this.btn_DpStu_Add.Size = new System.Drawing.Size(112, 31);
            this.btn_DpStu_Add.TabIndex = 27;
            this.btn_DpStu_Add.Text = "Add Student";
            this.btn_DpStu_Add.UseVisualStyleBackColor = false;
            this.btn_DpStu_Add.Click += new System.EventHandler(this.btn_DpStu_Add_Click);
            // 
            // txt_DpStu_Srch
            // 
            this.txt_DpStu_Srch.ForeColor = System.Drawing.Color.Gray;
            this.txt_DpStu_Srch.Location = new System.Drawing.Point(115, 383);
            this.txt_DpStu_Srch.Name = "txt_DpStu_Srch";
            this.txt_DpStu_Srch.Size = new System.Drawing.Size(280, 20);
            this.txt_DpStu_Srch.TabIndex = 26;
            this.txt_DpStu_Srch.Text = "Enter Student\'s Registration";
            this.txt_DpStu_Srch.Click += new System.EventHandler(this.txt_DpStu_Srch_Click);
            this.txt_DpStu_Srch.Leave += new System.EventHandler(this.txt_DpStu_Srch_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(3, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Search Student";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DpStu_Head
            // 
            this.lbl_DpStu_Head.AutoSize = true;
            this.lbl_DpStu_Head.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DpStu_Head.ForeColor = System.Drawing.Color.White;
            this.lbl_DpStu_Head.Location = new System.Drawing.Point(260, 5);
            this.lbl_DpStu_Head.Name = "lbl_DpStu_Head";
            this.lbl_DpStu_Head.Size = new System.Drawing.Size(138, 23);
            this.lbl_DpStu_Head.TabIndex = 35;
            this.lbl_DpStu_Head.Text = "Students Display";
            this.lbl_DpStu_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(660, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_DpStu_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Students";
            this.Load += new System.EventHandler(this.DisplayStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView_StudentsRecord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView_StudentsRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_BkStu_Rf;
        private System.Windows.Forms.Button btn_DpStu_Srch;
        private System.Windows.Forms.Button btn_DpStu_Back;
        private System.Windows.Forms.Button btn_DpStu_Update;
        private System.Windows.Forms.Button btn_DpStu_Del;
        private System.Windows.Forms.Button btn_DpStu_Add;
        private System.Windows.Forms.TextBox txt_DpStu_Srch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_DpStu_Head;
        private System.Windows.Forms.Button btn_DpStu_Card;
    }
}