
namespace Library_Managment
{
    partial class SearchBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBookForm));
            this.dgView_SrBk = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SrBk_Back = new System.Windows.Forms.Button();
            this.tab_SrchBk = new System.Windows.Forms.TabControl();
            this.tabPg_SrchBk_Title = new System.Windows.Forms.TabPage();
            this.txt_SrBk_Title = new System.Windows.Forms.TextBox();
            this.btn_SrBk_Title = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPg_SrchBk_Author = new System.Windows.Forms.TabPage();
            this.txt_SrBk_Auth = new System.Windows.Forms.TextBox();
            this.btn_SrBk_Auth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPg_SrchBk_Publisher = new System.Windows.Forms.TabPage();
            this.txt_SrBk_Pub = new System.Windows.Forms.TextBox();
            this.btn_SrBk_Pub = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPg_SrBk_Location = new System.Windows.Forms.TabPage();
            this.btn_SrBk_Rack = new System.Windows.Forms.Button();
            this.gb_Rack_Lacation = new System.Windows.Forms.GroupBox();
            this.cmb_SrBk_RkCol = new System.Windows.Forms.ComboBox();
            this.cmb_SrBk_RkRow = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_SrBk_Top = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_SrBk)).BeginInit();
            this.panel1.SuspendLayout();
            this.tab_SrchBk.SuspendLayout();
            this.tabPg_SrchBk_Title.SuspendLayout();
            this.tabPg_SrchBk_Author.SuspendLayout();
            this.tabPg_SrchBk_Publisher.SuspendLayout();
            this.tabPg_SrBk_Location.SuspendLayout();
            this.gb_Rack_Lacation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgView_SrBk
            // 
            this.dgView_SrBk.AllowUserToAddRows = false;
            this.dgView_SrBk.AllowUserToDeleteRows = false;
            this.dgView_SrBk.BackgroundColor = System.Drawing.Color.White;
            this.dgView_SrBk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_SrBk.GridColor = System.Drawing.Color.Black;
            this.dgView_SrBk.Location = new System.Drawing.Point(6, 11);
            this.dgView_SrBk.Name = "dgView_SrBk";
            this.dgView_SrBk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView_SrBk.Size = new System.Drawing.Size(697, 162);
            this.dgView_SrBk.TabIndex = 0;
            this.dgView_SrBk.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_SrBk_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_SrBk_Back);
            this.panel1.Controls.Add(this.tab_SrchBk);
            this.panel1.Controls.Add(this.dgView_SrBk);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 330);
            this.panel1.TabIndex = 1;
            // 
            // btn_SrBk_Back
            // 
            this.btn_SrBk_Back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrBk_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrBk_Back.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrBk_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrBk_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrBk_Back.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrBk_Back.ForeColor = System.Drawing.Color.White;
            this.btn_SrBk_Back.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrBk_Back.Location = new System.Drawing.Point(571, 293);
            this.btn_SrBk_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrBk_Back.Name = "btn_SrBk_Back";
            this.btn_SrBk_Back.Size = new System.Drawing.Size(64, 31);
            this.btn_SrBk_Back.TabIndex = 33;
            this.btn_SrBk_Back.Text = "Back";
            this.btn_SrBk_Back.UseVisualStyleBackColor = false;
            this.btn_SrBk_Back.Click += new System.EventHandler(this.btn_SrBk_Back_Click);
            // 
            // tab_SrchBk
            // 
            this.tab_SrchBk.Controls.Add(this.tabPg_SrchBk_Title);
            this.tab_SrchBk.Controls.Add(this.tabPg_SrchBk_Author);
            this.tab_SrchBk.Controls.Add(this.tabPg_SrchBk_Publisher);
            this.tab_SrchBk.Controls.Add(this.tabPg_SrBk_Location);
            this.tab_SrchBk.Location = new System.Drawing.Point(6, 179);
            this.tab_SrchBk.Name = "tab_SrchBk";
            this.tab_SrchBk.SelectedIndex = 0;
            this.tab_SrchBk.Size = new System.Drawing.Size(697, 111);
            this.tab_SrchBk.TabIndex = 33;
            // 
            // tabPg_SrchBk_Title
            // 
            this.tabPg_SrchBk_Title.Controls.Add(this.txt_SrBk_Title);
            this.tabPg_SrchBk_Title.Controls.Add(this.btn_SrBk_Title);
            this.tabPg_SrchBk_Title.Controls.Add(this.label11);
            this.tabPg_SrchBk_Title.Location = new System.Drawing.Point(4, 25);
            this.tabPg_SrchBk_Title.Name = "tabPg_SrchBk_Title";
            this.tabPg_SrchBk_Title.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_SrchBk_Title.Size = new System.Drawing.Size(689, 82);
            this.tabPg_SrchBk_Title.TabIndex = 0;
            this.tabPg_SrchBk_Title.Text = "Search By Title";
            this.tabPg_SrchBk_Title.UseVisualStyleBackColor = true;
            // 
            // txt_SrBk_Title
            // 
            this.txt_SrBk_Title.ForeColor = System.Drawing.Color.Gray;
            this.txt_SrBk_Title.Location = new System.Drawing.Point(208, 30);
            this.txt_SrBk_Title.Name = "txt_SrBk_Title";
            this.txt_SrBk_Title.Size = new System.Drawing.Size(280, 23);
            this.txt_SrBk_Title.TabIndex = 26;
            this.txt_SrBk_Title.Text = "Enter Book Title";
            this.txt_SrBk_Title.Click += new System.EventHandler(this.txt_SrBk_Title_Srch_Click);
            this.txt_SrBk_Title.Leave += new System.EventHandler(this.txt_SrBk_Title_Srch_Leave);
            // 
            // btn_SrBk_Title
            // 
            this.btn_SrBk_Title.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrBk_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrBk_Title.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrBk_Title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrBk_Title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrBk_Title.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrBk_Title.ForeColor = System.Drawing.Color.White;
            this.btn_SrBk_Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrBk_Title.Location = new System.Drawing.Point(493, 26);
            this.btn_SrBk_Title.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrBk_Title.Name = "btn_SrBk_Title";
            this.btn_SrBk_Title.Size = new System.Drawing.Size(79, 31);
            this.btn_SrBk_Title.TabIndex = 32;
            this.btn_SrBk_Title.Text = "Search";
            this.btn_SrBk_Title.UseVisualStyleBackColor = false;
            this.btn_SrBk_Title.Click += new System.EventHandler(this.btn_SrBk_Title_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(113, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Search Book";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPg_SrchBk_Author
            // 
            this.tabPg_SrchBk_Author.Controls.Add(this.txt_SrBk_Auth);
            this.tabPg_SrchBk_Author.Controls.Add(this.btn_SrBk_Auth);
            this.tabPg_SrchBk_Author.Controls.Add(this.label1);
            this.tabPg_SrchBk_Author.Location = new System.Drawing.Point(4, 25);
            this.tabPg_SrchBk_Author.Name = "tabPg_SrchBk_Author";
            this.tabPg_SrchBk_Author.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_SrchBk_Author.Size = new System.Drawing.Size(689, 82);
            this.tabPg_SrchBk_Author.TabIndex = 1;
            this.tabPg_SrchBk_Author.Text = "Search By Author";
            this.tabPg_SrchBk_Author.UseVisualStyleBackColor = true;
            // 
            // txt_SrBk_Auth
            // 
            this.txt_SrBk_Auth.ForeColor = System.Drawing.Color.Gray;
            this.txt_SrBk_Auth.Location = new System.Drawing.Point(208, 30);
            this.txt_SrBk_Auth.Name = "txt_SrBk_Auth";
            this.txt_SrBk_Auth.Size = new System.Drawing.Size(280, 23);
            this.txt_SrBk_Auth.TabIndex = 33;
            this.txt_SrBk_Auth.Text = "Enter Book Author";
            this.txt_SrBk_Auth.Click += new System.EventHandler(this.txt_SrBk_Auth_Click);
            this.txt_SrBk_Auth.Leave += new System.EventHandler(this.txt_SrBk_Auth_Leave);
            // 
            // btn_SrBk_Auth
            // 
            this.btn_SrBk_Auth.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrBk_Auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrBk_Auth.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrBk_Auth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrBk_Auth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrBk_Auth.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrBk_Auth.ForeColor = System.Drawing.Color.White;
            this.btn_SrBk_Auth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrBk_Auth.Location = new System.Drawing.Point(493, 26);
            this.btn_SrBk_Auth.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrBk_Auth.Name = "btn_SrBk_Auth";
            this.btn_SrBk_Auth.Size = new System.Drawing.Size(79, 31);
            this.btn_SrBk_Auth.TabIndex = 35;
            this.btn_SrBk_Auth.Text = "Search";
            this.btn_SrBk_Auth.UseVisualStyleBackColor = false;
            this.btn_SrBk_Auth.Click += new System.EventHandler(this.btn_SrBk_Auth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(113, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPg_SrchBk_Publisher
            // 
            this.tabPg_SrchBk_Publisher.Controls.Add(this.txt_SrBk_Pub);
            this.tabPg_SrchBk_Publisher.Controls.Add(this.btn_SrBk_Pub);
            this.tabPg_SrchBk_Publisher.Controls.Add(this.label2);
            this.tabPg_SrchBk_Publisher.Location = new System.Drawing.Point(4, 25);
            this.tabPg_SrchBk_Publisher.Name = "tabPg_SrchBk_Publisher";
            this.tabPg_SrchBk_Publisher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_SrchBk_Publisher.Size = new System.Drawing.Size(689, 82);
            this.tabPg_SrchBk_Publisher.TabIndex = 2;
            this.tabPg_SrchBk_Publisher.Text = "Search By Publisher";
            this.tabPg_SrchBk_Publisher.UseVisualStyleBackColor = true;
            // 
            // txt_SrBk_Pub
            // 
            this.txt_SrBk_Pub.ForeColor = System.Drawing.Color.Gray;
            this.txt_SrBk_Pub.Location = new System.Drawing.Point(208, 30);
            this.txt_SrBk_Pub.Name = "txt_SrBk_Pub";
            this.txt_SrBk_Pub.Size = new System.Drawing.Size(280, 23);
            this.txt_SrBk_Pub.TabIndex = 33;
            this.txt_SrBk_Pub.Text = "Enter Book Publisher";
            this.txt_SrBk_Pub.Click += new System.EventHandler(this.txt_SrBk_Pub_Click);
            this.txt_SrBk_Pub.Leave += new System.EventHandler(this.txt_SrBk_Pub_Leave);
            // 
            // btn_SrBk_Pub
            // 
            this.btn_SrBk_Pub.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrBk_Pub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrBk_Pub.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrBk_Pub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrBk_Pub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrBk_Pub.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrBk_Pub.ForeColor = System.Drawing.Color.White;
            this.btn_SrBk_Pub.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrBk_Pub.Location = new System.Drawing.Point(493, 26);
            this.btn_SrBk_Pub.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrBk_Pub.Name = "btn_SrBk_Pub";
            this.btn_SrBk_Pub.Size = new System.Drawing.Size(79, 31);
            this.btn_SrBk_Pub.TabIndex = 35;
            this.btn_SrBk_Pub.Text = "Search";
            this.btn_SrBk_Pub.UseVisualStyleBackColor = false;
            this.btn_SrBk_Pub.Click += new System.EventHandler(this.btn_SrBk_Pub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(113, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Search Book";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPg_SrBk_Location
            // 
            this.tabPg_SrBk_Location.Controls.Add(this.btn_SrBk_Rack);
            this.tabPg_SrBk_Location.Controls.Add(this.gb_Rack_Lacation);
            this.tabPg_SrBk_Location.Location = new System.Drawing.Point(4, 25);
            this.tabPg_SrBk_Location.Name = "tabPg_SrBk_Location";
            this.tabPg_SrBk_Location.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg_SrBk_Location.Size = new System.Drawing.Size(689, 82);
            this.tabPg_SrBk_Location.TabIndex = 3;
            this.tabPg_SrBk_Location.Text = "Display Books of a Rack";
            this.tabPg_SrBk_Location.UseVisualStyleBackColor = true;
            // 
            // btn_SrBk_Rack
            // 
            this.btn_SrBk_Rack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SrBk_Rack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SrBk_Rack.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SrBk_Rack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_SrBk_Rack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_SrBk_Rack.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_SrBk_Rack.ForeColor = System.Drawing.Color.White;
            this.btn_SrBk_Rack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SrBk_Rack.Location = new System.Drawing.Point(523, 30);
            this.btn_SrBk_Rack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SrBk_Rack.Name = "btn_SrBk_Rack";
            this.btn_SrBk_Rack.Size = new System.Drawing.Size(79, 31);
            this.btn_SrBk_Rack.TabIndex = 48;
            this.btn_SrBk_Rack.Text = "Search";
            this.btn_SrBk_Rack.UseVisualStyleBackColor = false;
            this.btn_SrBk_Rack.Click += new System.EventHandler(this.btn_SrBk_Rack_Click);
            // 
            // gb_Rack_Lacation
            // 
            this.gb_Rack_Lacation.Controls.Add(this.cmb_SrBk_RkCol);
            this.gb_Rack_Lacation.Controls.Add(this.cmb_SrBk_RkRow);
            this.gb_Rack_Lacation.Controls.Add(this.label7);
            this.gb_Rack_Lacation.Controls.Add(this.label6);
            this.gb_Rack_Lacation.Location = new System.Drawing.Point(77, 13);
            this.gb_Rack_Lacation.Name = "gb_Rack_Lacation";
            this.gb_Rack_Lacation.Size = new System.Drawing.Size(441, 56);
            this.gb_Rack_Lacation.TabIndex = 47;
            this.gb_Rack_Lacation.TabStop = false;
            this.gb_Rack_Lacation.Text = "Rack Location";
            // 
            // cmb_SrBk_RkCol
            // 
            this.cmb_SrBk_RkCol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_SrBk_RkCol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SrBk_RkCol.FormattingEnabled = true;
            this.cmb_SrBk_RkCol.Location = new System.Drawing.Point(283, 21);
            this.cmb_SrBk_RkCol.Name = "cmb_SrBk_RkCol";
            this.cmb_SrBk_RkCol.Size = new System.Drawing.Size(107, 24);
            this.cmb_SrBk_RkCol.TabIndex = 11;
            // 
            // cmb_SrBk_RkRow
            // 
            this.cmb_SrBk_RkRow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_SrBk_RkRow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_SrBk_RkRow.FormattingEnabled = true;
            this.cmb_SrBk_RkRow.Location = new System.Drawing.Point(86, 21);
            this.cmb_SrBk_RkRow.Name = "cmb_SrBk_RkRow";
            this.cmb_SrBk_RkRow.Size = new System.Drawing.Size(107, 24);
            this.cmb_SrBk_RkRow.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(221, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Column";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(45, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Row";
            // 
            // lbl_SrBk_Top
            // 
            this.lbl_SrBk_Top.AutoSize = true;
            this.lbl_SrBk_Top.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SrBk_Top.ForeColor = System.Drawing.Color.White;
            this.lbl_SrBk_Top.Location = new System.Drawing.Point(314, 6);
            this.lbl_SrBk_Top.Name = "lbl_SrBk_Top";
            this.lbl_SrBk_Top.Size = new System.Drawing.Size(107, 23);
            this.lbl_SrBk_Top.TabIndex = 35;
            this.lbl_SrBk_Top.Text = "Search Book";
            this.lbl_SrBk_Top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Clear.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(639, 293);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(64, 31);
            this.btn_Clear.TabIndex = 34;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // SearchBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(735, 377);
            this.Controls.Add(this.lbl_SrBk_Top);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchBook";
            this.Load += new System.EventHandler(this.searchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView_SrBk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tab_SrchBk.ResumeLayout(false);
            this.tabPg_SrchBk_Title.ResumeLayout(false);
            this.tabPg_SrchBk_Title.PerformLayout();
            this.tabPg_SrchBk_Author.ResumeLayout(false);
            this.tabPg_SrchBk_Author.PerformLayout();
            this.tabPg_SrchBk_Publisher.ResumeLayout(false);
            this.tabPg_SrchBk_Publisher.PerformLayout();
            this.tabPg_SrBk_Location.ResumeLayout(false);
            this.gb_Rack_Lacation.ResumeLayout(false);
            this.gb_Rack_Lacation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView_SrBk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SrBk_Title;
        private System.Windows.Forms.TextBox txt_SrBk_Title;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_SrBk_Top;
        private System.Windows.Forms.Button btn_SrBk_Back;
        private System.Windows.Forms.TabControl tab_SrchBk;
        private System.Windows.Forms.TabPage tabPg_SrchBk_Title;
        private System.Windows.Forms.TabPage tabPg_SrchBk_Author;
        private System.Windows.Forms.TextBox txt_SrBk_Auth;
        private System.Windows.Forms.Button btn_SrBk_Auth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPg_SrchBk_Publisher;
        private System.Windows.Forms.TextBox txt_SrBk_Pub;
        private System.Windows.Forms.Button btn_SrBk_Pub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPg_SrBk_Location;
        private System.Windows.Forms.Button btn_SrBk_Rack;
        private System.Windows.Forms.GroupBox gb_Rack_Lacation;
        private System.Windows.Forms.ComboBox cmb_SrBk_RkCol;
        private System.Windows.Forms.ComboBox cmb_SrBk_RkRow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Clear;
    }
}