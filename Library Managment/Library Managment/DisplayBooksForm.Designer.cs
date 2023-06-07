
namespace Library_Managment
{
    partial class DisplayBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayBooksForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BkDp_Rf = new System.Windows.Forms.Button();
            this.btn_DpBk_Srch = new System.Windows.Forms.Button();
            this.btn_DpBk_Back = new System.Windows.Forms.Button();
            this.btn_DpBk_Update = new System.Windows.Forms.Button();
            this.btn_DpBk_Del = new System.Windows.Forms.Button();
            this.btn_DpBk_Add = new System.Windows.Forms.Button();
            this.txt_DpBk_Srch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgView_BooksRecord = new System.Windows.Forms.DataGridView();
            this.lbl_AddBooks_Top = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_BooksRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_BkDp_Rf);
            this.panel1.Controls.Add(this.btn_DpBk_Srch);
            this.panel1.Controls.Add(this.btn_DpBk_Back);
            this.panel1.Controls.Add(this.btn_DpBk_Update);
            this.panel1.Controls.Add(this.btn_DpBk_Del);
            this.panel1.Controls.Add(this.btn_DpBk_Add);
            this.panel1.Controls.Add(this.txt_DpBk_Srch);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dgView_BooksRecord);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 510);
            this.panel1.TabIndex = 0;
            // 
            // btn_BkDp_Rf
            // 
            this.btn_BkDp_Rf.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_BkDp_Rf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BkDp_Rf.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_BkDp_Rf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_BkDp_Rf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_BkDp_Rf.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_BkDp_Rf.ForeColor = System.Drawing.Color.White;
            this.btn_BkDp_Rf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_BkDp_Rf.Location = new System.Drawing.Point(592, 470);
            this.btn_BkDp_Rf.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BkDp_Rf.Name = "btn_BkDp_Rf";
            this.btn_BkDp_Rf.Size = new System.Drawing.Size(70, 31);
            this.btn_BkDp_Rf.TabIndex = 33;
            this.btn_BkDp_Rf.Text = "Refresh";
            this.btn_BkDp_Rf.UseVisualStyleBackColor = false;
            this.btn_BkDp_Rf.Click += new System.EventHandler(this.btn_BkDp_Rf_Click);
            // 
            // btn_DpBk_Srch
            // 
            this.btn_DpBk_Srch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpBk_Srch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpBk_Srch.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpBk_Srch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpBk_Srch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpBk_Srch.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpBk_Srch.ForeColor = System.Drawing.Color.White;
            this.btn_DpBk_Srch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpBk_Srch.Location = new System.Drawing.Point(383, 470);
            this.btn_DpBk_Srch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpBk_Srch.Name = "btn_DpBk_Srch";
            this.btn_DpBk_Srch.Size = new System.Drawing.Size(79, 31);
            this.btn_DpBk_Srch.TabIndex = 32;
            this.btn_DpBk_Srch.Text = "Search";
            this.btn_DpBk_Srch.UseVisualStyleBackColor = false;
            this.btn_DpBk_Srch.Click += new System.EventHandler(this.btn_DpBk_Srch_Click);
            // 
            // btn_DpBk_Back
            // 
            this.btn_DpBk_Back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpBk_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpBk_Back.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpBk_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpBk_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpBk_Back.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpBk_Back.ForeColor = System.Drawing.Color.White;
            this.btn_DpBk_Back.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpBk_Back.Location = new System.Drawing.Point(521, 470);
            this.btn_DpBk_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpBk_Back.Name = "btn_DpBk_Back";
            this.btn_DpBk_Back.Size = new System.Drawing.Size(67, 31);
            this.btn_DpBk_Back.TabIndex = 31;
            this.btn_DpBk_Back.Text = "Back";
            this.btn_DpBk_Back.UseVisualStyleBackColor = false;
            this.btn_DpBk_Back.Click += new System.EventHandler(this.btn_DpBk_Back_Click);
            // 
            // btn_DpBk_Update
            // 
            this.btn_DpBk_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpBk_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpBk_Update.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpBk_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpBk_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpBk_Update.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpBk_Update.ForeColor = System.Drawing.Color.White;
            this.btn_DpBk_Update.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpBk_Update.Location = new System.Drawing.Point(666, 470);
            this.btn_DpBk_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpBk_Update.Name = "btn_DpBk_Update";
            this.btn_DpBk_Update.Size = new System.Drawing.Size(100, 31);
            this.btn_DpBk_Update.TabIndex = 30;
            this.btn_DpBk_Update.Text = "Update Book";
            this.btn_DpBk_Update.UseVisualStyleBackColor = false;
            this.btn_DpBk_Update.Click += new System.EventHandler(this.btn_DpBk_Update_Click);
            // 
            // btn_DpBk_Del
            // 
            this.btn_DpBk_Del.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpBk_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpBk_Del.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpBk_Del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpBk_Del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpBk_Del.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpBk_Del.ForeColor = System.Drawing.Color.White;
            this.btn_DpBk_Del.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpBk_Del.Location = new System.Drawing.Point(770, 470);
            this.btn_DpBk_Del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpBk_Del.Name = "btn_DpBk_Del";
            this.btn_DpBk_Del.Size = new System.Drawing.Size(98, 31);
            this.btn_DpBk_Del.TabIndex = 29;
            this.btn_DpBk_Del.Text = "Delete Book";
            this.btn_DpBk_Del.UseVisualStyleBackColor = false;
            this.btn_DpBk_Del.Click += new System.EventHandler(this.btn_DpBk_Del_Click);
            // 
            // btn_DpBk_Add
            // 
            this.btn_DpBk_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DpBk_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DpBk_Add.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_DpBk_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_DpBk_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_DpBk_Add.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_DpBk_Add.ForeColor = System.Drawing.Color.White;
            this.btn_DpBk_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DpBk_Add.Location = new System.Drawing.Point(872, 470);
            this.btn_DpBk_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DpBk_Add.Name = "btn_DpBk_Add";
            this.btn_DpBk_Add.Size = new System.Drawing.Size(88, 31);
            this.btn_DpBk_Add.TabIndex = 27;
            this.btn_DpBk_Add.Text = "Add Book";
            this.btn_DpBk_Add.UseVisualStyleBackColor = false;
            this.btn_DpBk_Add.Click += new System.EventHandler(this.btn_DpBk_Add_Click);
            // 
            // txt_DpBk_Srch
            // 
            this.txt_DpBk_Srch.ForeColor = System.Drawing.Color.Gray;
            this.txt_DpBk_Srch.Location = new System.Drawing.Point(98, 474);
            this.txt_DpBk_Srch.Name = "txt_DpBk_Srch";
            this.txt_DpBk_Srch.Size = new System.Drawing.Size(280, 23);
            this.txt_DpBk_Srch.TabIndex = 26;
            this.txt_DpBk_Srch.Text = "Enter Book Title";
            this.txt_DpBk_Srch.Click += new System.EventHandler(this.txt_DpBk_Srch_Click);
            this.txt_DpBk_Srch.Leave += new System.EventHandler(this.txt_DpBk_Srch_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(3, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Search Book";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgView_BooksRecord
            // 
            this.dgView_BooksRecord.AllowUserToAddRows = false;
            this.dgView_BooksRecord.AllowUserToDeleteRows = false;
            this.dgView_BooksRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgView_BooksRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_BooksRecord.GridColor = System.Drawing.Color.Black;
            this.dgView_BooksRecord.Location = new System.Drawing.Point(6, 11);
            this.dgView_BooksRecord.Name = "dgView_BooksRecord";
            this.dgView_BooksRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView_BooksRecord.Size = new System.Drawing.Size(954, 454);
            this.dgView_BooksRecord.TabIndex = 0;
            this.dgView_BooksRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_BooksRecord_CellClick);
            this.dgView_BooksRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_BooksRecord_CellDoubleClick);
            // 
            // lbl_AddBooks_Top
            // 
            this.lbl_AddBooks_Top.AutoSize = true;
            this.lbl_AddBooks_Top.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddBooks_Top.ForeColor = System.Drawing.Color.White;
            this.lbl_AddBooks_Top.Location = new System.Drawing.Point(436, 5);
            this.lbl_AddBooks_Top.Name = "lbl_AddBooks_Top";
            this.lbl_AddBooks_Top.Size = new System.Drawing.Size(119, 23);
            this.lbl_AddBooks_Top.TabIndex = 33;
            this.lbl_AddBooks_Top.Text = "Books Display";
            this.lbl_AddBooks_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(991, 558);
            this.Controls.Add(this.lbl_AddBooks_Top);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Displaying Books";
            this.Load += new System.EventHandler(this.DisplayBooksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_BooksRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgView_BooksRecord;
        private System.Windows.Forms.Button btn_DpBk_Back;
        private System.Windows.Forms.Button btn_DpBk_Update;
        private System.Windows.Forms.Button btn_DpBk_Del;
        private System.Windows.Forms.Button btn_DpBk_Add;
        private System.Windows.Forms.Label lbl_AddBooks_Top;
        private System.Windows.Forms.Button btn_BkDp_Rf;
        private System.Windows.Forms.Button btn_DpBk_Srch;
        private System.Windows.Forms.TextBox txt_DpBk_Srch;
        private System.Windows.Forms.Label label11;
    }
}