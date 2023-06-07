
namespace Library_Managment
{
    partial class SearchStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStudentForm));
            this.lbl_SrBk_Top = new System.Windows.Forms.Label();
            this.btn_SrStu_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SrStu_Clear = new System.Windows.Forms.Button();
            this.btn_SrStu_Card = new System.Windows.Forms.Button();
            this.tab_SrchStu = new System.Windows.Forms.TabControl();
            this.tabPg_SrchStu_Name = new System.Windows.Forms.TabPage();
            this.txt_SrStu_Name = new System.Windows.Forms.TextBox();
            this.btn_SrStu_Name = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPg_SrchStu_Reg = new System.Windows.Forms.TabPage();
            this.txt_SrStu_Reg = new System.Windows.Forms.TextBox();
            this.btn_SrStu_Reg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPg_SrchStu_Ins = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_SrStu_Dept = new System.Windows.Forms.ComboBox();
            this.cmb_SrStu_Sem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_SrStu_Sec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SrStu_Ins = new System.Windows.Forms.Button();
            this.dgView_SrStu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tab_SrchStu.SuspendLayout();
            this.tabPg_SrchStu_Name.SuspendLayout();
            this.tabPg_SrchStu_Reg.SuspendLayout();
            this.tabPg_SrchStu_Ins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_SrStu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SrBk_Top
            // 
            this.lbl_SrBk_Top.AutoSize = true;
            this.lbl_SrBk_Top.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SrBk_Top.ForeColor = System.Drawing.Color.White;
            this.lbl_SrBk_Top.Location = new System.Drawing.Point(304, 5);
            this.lbl_SrBk_Top.Name = "lbl_SrBk_Top";
            this.lbl_SrBk_Top.Size = new System.Drawing.Size(126, 23);
            this.lbl_SrBk_Top.TabIndex = 37;
            this.lbl_SrBk_Top.Text = "Search Student";
            this.lbl_SrBk_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SrStu_Back
            // 
            this.btn_SrStu_Back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrStu_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrStu_Back.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrStu_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrStu_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrStu_Back.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrStu_Back.ForeColor = System.Drawing.Color.White;
            this.btn_SrStu_Back.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrStu_Back.Location = new System.Drawing.Point(510, 292);
            this.btn_SrStu_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrStu_Back.Name = "btn_SrStu_Back";
            this.btn_SrStu_Back.Size = new System.Drawing.Size(71, 31);
            this.btn_SrStu_Back.TabIndex = 33;
            this.btn_SrStu_Back.Text = "Back";
            this.btn_SrStu_Back.UseVisualStyleBackColor = false;
            this.btn_SrStu_Back.Click += new System.EventHandler(this.btn_SrStu_Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_SrStu_Clear);
            this.panel1.Controls.Add(this.btn_SrStu_Card);
            this.panel1.Controls.Add(this.btn_SrStu_Back);
            this.panel1.Controls.Add(this.tab_SrchStu);
            this.panel1.Controls.Add(this.dgView_SrStu);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 330);
            this.panel1.TabIndex = 36;
            // 
            // btn_SrStu_Clear
            // 
            this.btn_SrStu_Clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrStu_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrStu_Clear.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrStu_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrStu_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrStu_Clear.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrStu_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_SrStu_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrStu_Clear.Location = new System.Drawing.Point(510, 292);
            this.btn_SrStu_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrStu_Clear.Name = "btn_SrStu_Clear";
            this.btn_SrStu_Clear.Size = new System.Drawing.Size(71, 31);
            this.btn_SrStu_Clear.TabIndex = 35;
            this.btn_SrStu_Clear.Text = "Clear";
            this.btn_SrStu_Clear.UseVisualStyleBackColor = false;
            this.btn_SrStu_Clear.Click += new System.EventHandler(this.btn_SrStu_Clear_Click);
            // 
            // btn_SrStu_Card
            // 
            this.btn_SrStu_Card.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrStu_Card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrStu_Card.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrStu_Card.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrStu_Card.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrStu_Card.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrStu_Card.ForeColor = System.Drawing.Color.White;
            this.btn_SrStu_Card.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrStu_Card.Location = new System.Drawing.Point(585, 292);
            this.btn_SrStu_Card.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrStu_Card.Name = "btn_SrStu_Card";
            this.btn_SrStu_Card.Size = new System.Drawing.Size(114, 31);
            this.btn_SrStu_Card.TabIndex = 34;
            this.btn_SrStu_Card.Text = "Display Profile";
            this.btn_SrStu_Card.UseVisualStyleBackColor = false;
            this.btn_SrStu_Card.Click += new System.EventHandler(this.btn_SrStu_Card_Click);
            // 
            // tab_SrchStu
            // 
            this.tab_SrchStu.Controls.Add(this.tabPg_SrchStu_Name);
            this.tab_SrchStu.Controls.Add(this.tabPg_SrchStu_Reg);
            this.tab_SrchStu.Controls.Add(this.tabPg_SrchStu_Ins);
            this.tab_SrchStu.Location = new System.Drawing.Point(6, 176);
            this.tab_SrchStu.Name = "tab_SrchStu";
            this.tab_SrchStu.SelectedIndex = 0;
            this.tab_SrchStu.Size = new System.Drawing.Size(697, 111);
            this.tab_SrchStu.TabIndex = 33;
            // 
            // tabPg_SrchStu_Name
            // 
            this.tabPg_SrchStu_Name.Controls.Add(this.txt_SrStu_Name);
            this.tabPg_SrchStu_Name.Controls.Add(this.btn_SrStu_Name);
            this.tabPg_SrchStu_Name.Controls.Add(this.label11);
            this.tabPg_SrchStu_Name.Location = new System.Drawing.Point(4, 25);
            this.tabPg_SrchStu_Name.Name = "tabPg_SrchStu_Name";
            this.tabPg_SrchStu_Name.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_SrchStu_Name.Size = new System.Drawing.Size(689, 82);
            this.tabPg_SrchStu_Name.TabIndex = 0;
            this.tabPg_SrchStu_Name.Text = "Search By Name";
            this.tabPg_SrchStu_Name.UseVisualStyleBackColor = true;
            // 
            // txt_SrStu_Name
            // 
            this.txt_SrStu_Name.ForeColor = System.Drawing.Color.Gray;
            this.txt_SrStu_Name.Location = new System.Drawing.Point(208, 30);
            this.txt_SrStu_Name.Name = "txt_SrStu_Name";
            this.txt_SrStu_Name.Size = new System.Drawing.Size(280, 23);
            this.txt_SrStu_Name.TabIndex = 26;
            this.txt_SrStu_Name.Text = "Enter Student Name";
            this.txt_SrStu_Name.Enter += new System.EventHandler(this.txt_SrStu_Name_Enter);
            this.txt_SrStu_Name.Leave += new System.EventHandler(this.txt_SrStu_Name_Leave);
            // 
            // btn_SrStu_Name
            // 
            this.btn_SrStu_Name.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrStu_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrStu_Name.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrStu_Name.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrStu_Name.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrStu_Name.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrStu_Name.ForeColor = System.Drawing.Color.White;
            this.btn_SrStu_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrStu_Name.Location = new System.Drawing.Point(493, 26);
            this.btn_SrStu_Name.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrStu_Name.Name = "btn_SrStu_Name";
            this.btn_SrStu_Name.Size = new System.Drawing.Size(79, 31);
            this.btn_SrStu_Name.TabIndex = 32;
            this.btn_SrStu_Name.Text = "Search";
            this.btn_SrStu_Name.UseVisualStyleBackColor = false;
            this.btn_SrStu_Name.Click += new System.EventHandler(this.btn_SrStu_Name_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(96, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Search Student";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPg_SrchStu_Reg
            // 
            this.tabPg_SrchStu_Reg.Controls.Add(this.txt_SrStu_Reg);
            this.tabPg_SrchStu_Reg.Controls.Add(this.btn_SrStu_Reg);
            this.tabPg_SrchStu_Reg.Controls.Add(this.label1);
            this.tabPg_SrchStu_Reg.Location = new System.Drawing.Point(4, 25);
            this.tabPg_SrchStu_Reg.Name = "tabPg_SrchStu_Reg";
            this.tabPg_SrchStu_Reg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_SrchStu_Reg.Size = new System.Drawing.Size(689, 82);
            this.tabPg_SrchStu_Reg.TabIndex = 1;
            this.tabPg_SrchStu_Reg.Text = "Search By Registration";
            this.tabPg_SrchStu_Reg.UseVisualStyleBackColor = true;
            // 
            // txt_SrStu_Reg
            // 
            this.txt_SrStu_Reg.ForeColor = System.Drawing.Color.Gray;
            this.txt_SrStu_Reg.Location = new System.Drawing.Point(208, 30);
            this.txt_SrStu_Reg.Name = "txt_SrStu_Reg";
            this.txt_SrStu_Reg.Size = new System.Drawing.Size(280, 23);
            this.txt_SrStu_Reg.TabIndex = 33;
            this.txt_SrStu_Reg.Text = "Enter Student Registration";
            this.txt_SrStu_Reg.Enter += new System.EventHandler(this.txt_SrStu_Reg_Enter);
            this.txt_SrStu_Reg.Leave += new System.EventHandler(this.txt_SrStu_Reg_Leave);
            // 
            // btn_SrStu_Reg
            // 
            this.btn_SrStu_Reg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrStu_Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrStu_Reg.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrStu_Reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrStu_Reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrStu_Reg.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrStu_Reg.ForeColor = System.Drawing.Color.White;
            this.btn_SrStu_Reg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrStu_Reg.Location = new System.Drawing.Point(493, 26);
            this.btn_SrStu_Reg.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrStu_Reg.Name = "btn_SrStu_Reg";
            this.btn_SrStu_Reg.Size = new System.Drawing.Size(79, 31);
            this.btn_SrStu_Reg.TabIndex = 35;
            this.btn_SrStu_Reg.Text = "Search";
            this.btn_SrStu_Reg.UseVisualStyleBackColor = false;
            this.btn_SrStu_Reg.Click += new System.EventHandler(this.btn_SrStu_Reg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(96, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPg_SrchStu_Ins
            // 
            this.tabPg_SrchStu_Ins.Controls.Add(this.label2);
            this.tabPg_SrchStu_Ins.Controls.Add(this.cmb_SrStu_Dept);
            this.tabPg_SrchStu_Ins.Controls.Add(this.cmb_SrStu_Sem);
            this.tabPg_SrchStu_Ins.Controls.Add(this.label3);
            this.tabPg_SrchStu_Ins.Controls.Add(this.cmb_SrStu_Sec);
            this.tabPg_SrchStu_Ins.Controls.Add(this.label4);
            this.tabPg_SrchStu_Ins.Controls.Add(this.btn_SrStu_Ins);
            this.tabPg_SrchStu_Ins.Location = new System.Drawing.Point(4, 25);
            this.tabPg_SrchStu_Ins.Name = "tabPg_SrchStu_Ins";
            this.tabPg_SrchStu_Ins.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_SrchStu_Ins.Size = new System.Drawing.Size(689, 82);
            this.tabPg_SrchStu_Ins.TabIndex = 2;
            this.tabPg_SrchStu_Ins.Text = "Display Students of Section";
            this.tabPg_SrchStu_Ins.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(338, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 126;
            this.label2.Text = "Semester";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_SrStu_Dept
            // 
            this.cmb_SrStu_Dept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_SrStu_Dept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SrStu_Dept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_SrStu_Dept.FormattingEnabled = true;
            this.cmb_SrStu_Dept.Items.AddRange(new object[] {
            "Chemical Engineering",
            "Electrical Engineering",
            "Mechatronics and Control Engineering",
            "Textile Engineering"});
            this.cmb_SrStu_Dept.Location = new System.Drawing.Point(199, 46);
            this.cmb_SrStu_Dept.Name = "cmb_SrStu_Dept";
            this.cmb_SrStu_Dept.Size = new System.Drawing.Size(320, 24);
            this.cmb_SrStu_Dept.Sorted = true;
            this.cmb_SrStu_Dept.TabIndex = 125;
            // 
            // cmb_SrStu_Sem
            // 
            this.cmb_SrStu_Sem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_SrStu_Sem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SrStu_Sem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_SrStu_Sem.FormattingEnabled = true;
            this.cmb_SrStu_Sem.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th"});
            this.cmb_SrStu_Sem.Location = new System.Drawing.Point(412, 12);
            this.cmb_SrStu_Sem.Name = "cmb_SrStu_Sem";
            this.cmb_SrStu_Sem.Size = new System.Drawing.Size(107, 24);
            this.cmb_SrStu_Sem.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(111, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 123;
            this.label3.Text = "Department";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_SrStu_Sec
            // 
            this.cmb_SrStu_Sec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_SrStu_Sec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SrStu_Sec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_SrStu_Sec.FormattingEnabled = true;
            this.cmb_SrStu_Sec.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmb_SrStu_Sec.Location = new System.Drawing.Point(199, 12);
            this.cmb_SrStu_Sec.Name = "cmb_SrStu_Sec";
            this.cmb_SrStu_Sec.Size = new System.Drawing.Size(107, 24);
            this.cmb_SrStu_Sec.TabIndex = 122;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(138, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 121;
            this.label4.Text = "Section";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_SrStu_Ins
            // 
            this.btn_SrStu_Ins.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrStu_Ins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrStu_Ins.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrStu_Ins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrStu_Ins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrStu_Ins.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrStu_Ins.ForeColor = System.Drawing.Color.White;
            this.btn_SrStu_Ins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrStu_Ins.Location = new System.Drawing.Point(524, 25);
            this.btn_SrStu_Ins.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrStu_Ins.Name = "btn_SrStu_Ins";
            this.btn_SrStu_Ins.Size = new System.Drawing.Size(79, 31);
            this.btn_SrStu_Ins.TabIndex = 35;
            this.btn_SrStu_Ins.Text = "Search";
            this.btn_SrStu_Ins.UseVisualStyleBackColor = false;
            this.btn_SrStu_Ins.Click += new System.EventHandler(this.btn_SrStu_Ins_Click);
            // 
            // dgView_SrStu
            // 
            this.dgView_SrStu.AllowUserToAddRows = false;
            this.dgView_SrStu.AllowUserToDeleteRows = false;
            this.dgView_SrStu.BackgroundColor = System.Drawing.Color.White;
            this.dgView_SrStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_SrStu.GridColor = System.Drawing.Color.Black;
            this.dgView_SrStu.Location = new System.Drawing.Point(6, 11);
            this.dgView_SrStu.Name = "dgView_SrStu";
            this.dgView_SrStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView_SrStu.Size = new System.Drawing.Size(697, 159);
            this.dgView_SrStu.TabIndex = 0;
            this.dgView_SrStu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_SrStu_CellClick);
            // 
            // SearchStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(734, 377);
            this.Controls.Add(this.lbl_SrBk_Top);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Student";
            this.Load += new System.EventHandler(this.SearchStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.tab_SrchStu.ResumeLayout(false);
            this.tabPg_SrchStu_Name.ResumeLayout(false);
            this.tabPg_SrchStu_Name.PerformLayout();
            this.tabPg_SrchStu_Reg.ResumeLayout(false);
            this.tabPg_SrchStu_Reg.PerformLayout();
            this.tabPg_SrchStu_Ins.ResumeLayout(false);
            this.tabPg_SrchStu_Ins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_SrStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SrBk_Top;
        private System.Windows.Forms.Button btn_SrStu_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgView_SrStu;
        private System.Windows.Forms.TabControl tab_SrchStu;
        private System.Windows.Forms.TabPage tabPg_SrchStu_Name;
        private System.Windows.Forms.TextBox txt_SrStu_Name;
        private System.Windows.Forms.Button btn_SrStu_Name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPg_SrchStu_Reg;
        private System.Windows.Forms.TextBox txt_SrStu_Reg;
        private System.Windows.Forms.Button btn_SrStu_Reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPg_SrchStu_Ins;
        private System.Windows.Forms.Button btn_SrStu_Ins;
        private System.Windows.Forms.ComboBox cmb_SrStu_Dept;
        private System.Windows.Forms.ComboBox cmb_SrStu_Sem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_SrStu_Sec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SrStu_Card;
        private System.Windows.Forms.Button btn_SrStu_Clear;
    }
}