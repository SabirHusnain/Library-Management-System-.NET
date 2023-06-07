
namespace Library_Managment
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Admin_BookList = new System.Windows.Forms.Panel();
            this.lbl_Student_BookList_Head = new System.Windows.Forms.Label();
            this.dgView_Student_BooksList = new System.Windows.Forms.DataGridView();
            this.pnl_Student_ReturnBook = new System.Windows.Forms.Panel();
            this.pnl_Admin_Users = new System.Windows.Forms.Panel();
            this.lbl_StudentForm_User_Display_Reg = new System.Windows.Forms.Label();
            this.lbl_StudentForm_User_Display_Name = new System.Windows.Forms.Label();
            this.pBox_StudentForm_User_Display = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Student_SrStu = new System.Windows.Forms.Panel();
            this.pnl_Student_BkIssue = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnl_Admin_BookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Student_BooksList)).BeginInit();
            this.pnl_Admin_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_StudentForm_User_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.searchBookToolStripMenuItem.Text = "&Search Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayProfileToolStripMenuItem,
            this.displayBooksToolStripMenuItem,
            this.searchBookToolStripMenuItem,
            this.issueBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayProfileToolStripMenuItem
            // 
            this.displayProfileToolStripMenuItem.Name = "displayProfileToolStripMenuItem";
            this.displayProfileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.displayProfileToolStripMenuItem.Text = "&Display Profile";
            this.displayProfileToolStripMenuItem.Click += new System.EventHandler(this.displayProfileToolStripMenuItem_Click);
            // 
            // displayBooksToolStripMenuItem
            // 
            this.displayBooksToolStripMenuItem.Name = "displayBooksToolStripMenuItem";
            this.displayBooksToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.displayBooksToolStripMenuItem.Text = "Display Books";
            this.displayBooksToolStripMenuItem.Click += new System.EventHandler(this.displayBooksToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.issueBookToolStripMenuItem.Text = "&Issue Book";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.returnBookToolStripMenuItem.Text = "&Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // pnl_Admin_BookList
            // 
            this.pnl_Admin_BookList.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_Admin_BookList.Controls.Add(this.lbl_Student_BookList_Head);
            this.pnl_Admin_BookList.Controls.Add(this.dgView_Student_BooksList);
            this.pnl_Admin_BookList.Location = new System.Drawing.Point(1173, 29);
            this.pnl_Admin_BookList.Name = "pnl_Admin_BookList";
            this.pnl_Admin_BookList.Size = new System.Drawing.Size(179, 662);
            this.pnl_Admin_BookList.TabIndex = 47;
            // 
            // lbl_Student_BookList_Head
            // 
            this.lbl_Student_BookList_Head.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Student_BookList_Head.ForeColor = System.Drawing.Color.White;
            this.lbl_Student_BookList_Head.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Student_BookList_Head.Location = new System.Drawing.Point(20, 4);
            this.lbl_Student_BookList_Head.Name = "lbl_Student_BookList_Head";
            this.lbl_Student_BookList_Head.Size = new System.Drawing.Size(139, 23);
            this.lbl_Student_BookList_Head.TabIndex = 35;
            this.lbl_Student_BookList_Head.Text = "Book List";
            this.lbl_Student_BookList_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgView_Student_BooksList
            // 
            this.dgView_Student_BooksList.AllowUserToAddRows = false;
            this.dgView_Student_BooksList.AllowUserToDeleteRows = false;
            this.dgView_Student_BooksList.AllowUserToResizeColumns = false;
            this.dgView_Student_BooksList.AllowUserToResizeRows = false;
            this.dgView_Student_BooksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgView_Student_BooksList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgView_Student_BooksList.BackgroundColor = System.Drawing.Color.White;
            this.dgView_Student_BooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Student_BooksList.GridColor = System.Drawing.Color.Black;
            this.dgView_Student_BooksList.Location = new System.Drawing.Point(3, 30);
            this.dgView_Student_BooksList.Name = "dgView_Student_BooksList";
            this.dgView_Student_BooksList.Size = new System.Drawing.Size(173, 629);
            this.dgView_Student_BooksList.TabIndex = 0;
            // 
            // pnl_Student_ReturnBook
            // 
            this.pnl_Student_ReturnBook.Font = new System.Drawing.Font("Arial", 10F);
            this.pnl_Student_ReturnBook.Location = new System.Drawing.Point(433, 29);
            this.pnl_Student_ReturnBook.Name = "pnl_Student_ReturnBook";
            this.pnl_Student_ReturnBook.Size = new System.Drawing.Size(734, 279);
            this.pnl_Student_ReturnBook.TabIndex = 46;
            // 
            // pnl_Admin_Users
            // 
            this.pnl_Admin_Users.Controls.Add(this.lbl_StudentForm_User_Display_Reg);
            this.pnl_Admin_Users.Controls.Add(this.lbl_StudentForm_User_Display_Name);
            this.pnl_Admin_Users.Controls.Add(this.pBox_StudentForm_User_Display);
            this.pnl_Admin_Users.Controls.Add(this.label1);
            this.pnl_Admin_Users.Location = new System.Drawing.Point(12, 29);
            this.pnl_Admin_Users.Name = "pnl_Admin_Users";
            this.pnl_Admin_Users.Size = new System.Drawing.Size(415, 120);
            this.pnl_Admin_Users.TabIndex = 45;
            // 
            // lbl_StudentForm_User_Display_Reg
            // 
            this.lbl_StudentForm_User_Display_Reg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StudentForm_User_Display_Reg.Font = new System.Drawing.Font("Arial Narrow", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_StudentForm_User_Display_Reg.Location = new System.Drawing.Point(98, 74);
            this.lbl_StudentForm_User_Display_Reg.Name = "lbl_StudentForm_User_Display_Reg";
            this.lbl_StudentForm_User_Display_Reg.Size = new System.Drawing.Size(314, 23);
            this.lbl_StudentForm_User_Display_Reg.TabIndex = 3;
            this.lbl_StudentForm_User_Display_Reg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_StudentForm_User_Display_Name
            // 
            this.lbl_StudentForm_User_Display_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StudentForm_User_Display_Name.Font = new System.Drawing.Font("Arial Narrow", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_StudentForm_User_Display_Name.Location = new System.Drawing.Point(98, 41);
            this.lbl_StudentForm_User_Display_Name.Name = "lbl_StudentForm_User_Display_Name";
            this.lbl_StudentForm_User_Display_Name.Size = new System.Drawing.Size(314, 23);
            this.lbl_StudentForm_User_Display_Name.TabIndex = 2;
            this.lbl_StudentForm_User_Display_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBox_StudentForm_User_Display
            // 
            this.pBox_StudentForm_User_Display.Location = new System.Drawing.Point(3, 3);
            this.pBox_StudentForm_User_Display.Name = "pBox_StudentForm_User_Display";
            this.pBox_StudentForm_User_Display.Size = new System.Drawing.Size(89, 114);
            this.pBox_StudentForm_User_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_StudentForm_User_Display.TabIndex = 0;
            this.pBox_StudentForm_User_Display.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "User (Student)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Student_SrStu
            // 
            this.pnl_Student_SrStu.Location = new System.Drawing.Point(433, 314);
            this.pnl_Student_SrStu.Name = "pnl_Student_SrStu";
            this.pnl_Student_SrStu.Size = new System.Drawing.Size(734, 377);
            this.pnl_Student_SrStu.TabIndex = 44;
            // 
            // pnl_Student_BkIssue
            // 
            this.pnl_Student_BkIssue.Location = new System.Drawing.Point(12, 155);
            this.pnl_Student_BkIssue.Name = "pnl_Student_BkIssue";
            this.pnl_Student_BkIssue.Size = new System.Drawing.Size(415, 536);
            this.pnl_Student_BkIssue.TabIndex = 43;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 706);
            this.Controls.Add(this.pnl_Admin_BookList);
            this.Controls.Add(this.pnl_Student_ReturnBook);
            this.Controls.Add(this.pnl_Admin_Users);
            this.Controls.Add(this.pnl_Student_SrStu);
            this.Controls.Add(this.pnl_Student_BkIssue);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Managment System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Admin_BookList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Student_BooksList)).EndInit();
            this.pnl_Admin_Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_StudentForm_User_Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Admin_BookList;
        private System.Windows.Forms.Label lbl_Student_BookList_Head;
        private System.Windows.Forms.DataGridView dgView_Student_BooksList;
        private System.Windows.Forms.Panel pnl_Student_ReturnBook;
        private System.Windows.Forms.Panel pnl_Admin_Users;
        private System.Windows.Forms.Label lbl_StudentForm_User_Display_Reg;
        private System.Windows.Forms.Label lbl_StudentForm_User_Display_Name;
        private System.Windows.Forms.PictureBox pBox_StudentForm_User_Display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Student_SrStu;
        private System.Windows.Forms.Panel pnl_Student_BkIssue;
    }
}