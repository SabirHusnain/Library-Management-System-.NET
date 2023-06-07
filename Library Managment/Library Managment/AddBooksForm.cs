using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Library_Managment
{
    public partial class AddBooksForm : Form
    {
        public AddBooksForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");

        private int ID = 0;

        private bool _chkRackSpace(string rackRow, string rackCol)
        {
            int preAvailableRackBooks = 0, i = 0;
            int newAddedRackBooks = Convert.ToInt32(txt_BkAdd_Qnt.Text);

            SqlCommand sqlCmd = new SqlCommand("Select Quantity, Issued from tbl_Books_Record where Rack_Row Like '%'+@Rack_Row+'%' and Rack_Col Like '%'+@Rack_Col+'%'", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Rack_Row", rackRow);
            sqlCmd.Parameters.AddWithValue("@Rack_Col", rackCol);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            while (true)
            {
                if (dtbl.Rows.Count > i && dtbl.Rows[i][0] != DBNull.Value)
                {
                    preAvailableRackBooks += Convert.ToInt32(dtbl.Rows[i][0]) - Convert.ToInt32(dtbl.Rows[i][1]);
                    i++;
                }
                else
                    break;
            }

            if ((preAvailableRackBooks + newAddedRackBooks) > Library.getBooksPerRack())
            {
                string message = $"There is no enough sapce in this rack.\nYou can only add {Library.getBooksPerRack() - preAvailableRackBooks} more books.";
                MessageBox.Show(message, "Rack Full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void AddBooksForm_Load(object sender, EventArgs e)
        {
            Library myLibrary = new Library();

            for (int i = 1900; i <= DateTime.Today.Year; i++)
                cmb_BkAdd_PubYr.Items.Add(Convert.ToString(i));

            for (int i = 1; i <= Library.getRackRow(); i++)
                cmb_BkAdd_RkRow.Items.Add(Convert.ToString(i));

            for (int i = 1; i <= Library.getRackCol(); i++)
                cmb_BkAdd_RkCol.Items.Add(Convert.ToString(i));

            txt_BkAdd_Title.Focus();
        }

        private void btn_BkAdd_Rst_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void writeRecord()
        {
            if (_isValid())
            {
                SqlCommand sqlCmd = new SqlCommand("INSERT INTO tbl_Books_Record VALUES (@Title, @Author, @Edition, @Publisher, @Publish_Year, @Quantity, @ISBN, @Rack_Row, @Rack_Col, @Soft_Copy, @Issue_Status, @Preface, @Issued)", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Title", txt_BkAdd_Title.Text);
                sqlCmd.Parameters.AddWithValue("@Author", txt_BkAdd_Author.Text);
                sqlCmd.Parameters.AddWithValue("@Edition", txt_BkAdd_Ed.Text);
                sqlCmd.Parameters.AddWithValue("@Publisher", txt_BkAdd_Pub.Text);
                sqlCmd.Parameters.AddWithValue("@Publish_Year", cmb_BkAdd_PubYr.Text);
                sqlCmd.Parameters.AddWithValue("@Quantity", txt_BkAdd_Qnt.Text);
                sqlCmd.Parameters.AddWithValue("@ISBN", txt_BkAdd_ISBN.Text);
                sqlCmd.Parameters.AddWithValue("@Rack_Row", cmb_BkAdd_RkRow.Text);
                sqlCmd.Parameters.AddWithValue("@Rack_Col", cmb_BkAdd_RkCol.Text);

                if (chk_BkAdd_Soft_Cpy.Checked)
                    sqlCmd.Parameters.AddWithValue("@Soft_Copy", "Available");
                else
                    sqlCmd.Parameters.AddWithValue("@Soft_Copy", "Not Available");
                if (chk_BkAdd_Issue.Checked)
                    sqlCmd.Parameters.AddWithValue("@Issue_Status", "Allowed");
                else
                    sqlCmd.Parameters.AddWithValue("@Issue_Status", "Not Allowed");
                if (txt_BkAdd_Pref.Text != null)
                    sqlCmd.Parameters.AddWithValue("@Preface", txt_BkAdd_Pref.Text);
                else
                    sqlCmd.Parameters.AddWithValue("@Preface", "No Preface");

                sqlCmd.Parameters.AddWithValue("@Issued", "0");


                if (_chkRackSpace(cmb_BkAdd_RkRow.Text, cmb_BkAdd_RkCol.Text))
                {
                    sqlCon.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Data has succefully been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                    txt_BkAdd_Title.Focus();
                }
                else
                    MessageBox.Show("Entries with * are required", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateRecord()
        {
            if (_isValid())
            {
                SqlCommand sqlCmd = new SqlCommand("UPDATE tbl_Books_Record SET Title=@Title, Author=@Author, Edition=@Edition, Publisher=@Publisher, Publish_Year=@Publish_Year, Quantity=@Quantity, ISBN=@ISBN, Rack_Row=@Rack_Row, Rack_Col=@Rack_Col, Soft_Copy=@Soft_Copy, Issue_Status=@Issue_Status, Preface=@Preface WHERE BookID=@BookID", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@BookID", this.ID);
                sqlCmd.Parameters.AddWithValue("@Title", txt_BkAdd_Title.Text);
                sqlCmd.Parameters.AddWithValue("@Author", txt_BkAdd_Author.Text);
                sqlCmd.Parameters.AddWithValue("@Edition", txt_BkAdd_Ed.Text);
                sqlCmd.Parameters.AddWithValue("@Publisher", txt_BkAdd_Pub.Text);
                sqlCmd.Parameters.AddWithValue("@Publish_Year", cmb_BkAdd_PubYr.Text);
                sqlCmd.Parameters.AddWithValue("@Quantity", txt_BkAdd_Qnt.Text);
                sqlCmd.Parameters.AddWithValue("@ISBN", txt_BkAdd_ISBN.Text);
                sqlCmd.Parameters.AddWithValue("@Rack_Row", cmb_BkAdd_RkRow.Text);
                sqlCmd.Parameters.AddWithValue("@Rack_Col", cmb_BkAdd_RkCol.Text);

                if (chk_BkAdd_Soft_Cpy.Checked)
                    sqlCmd.Parameters.AddWithValue("@Soft_Copy", "Available");
                else
                    sqlCmd.Parameters.AddWithValue("@Soft_Copy", "Not Available");
                if (chk_BkAdd_Issue.Checked)
                    sqlCmd.Parameters.AddWithValue("@Issue_Status", "Allowed");
                else
                    sqlCmd.Parameters.AddWithValue("@Issue_Status", "Not Allowed");
                if (txt_BkAdd_Pref.Text != null)
                    sqlCmd.Parameters.AddWithValue("@Preface", txt_BkAdd_Pref.Text);
                else
                    sqlCmd.Parameters.AddWithValue("@Preface", "No Preface");

                if (_chkRackSpace(cmb_BkAdd_RkRow.Text, cmb_BkAdd_RkCol.Text))
                {
                    sqlCon.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Data has succefully been Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_BkAdd_Title.Focus();
                }
            }
            else
                MessageBox.Show("Entries with * are required", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _isValid()
        {
            if (txt_BkAdd_Title.Text == "" || txt_BkAdd_Author.Text == "" || txt_BkAdd_Qnt.Text == "" || txt_BkAdd_ISBN.Text == "" || cmb_BkAdd_RkRow.Text == "" || cmb_BkAdd_RkCol.Text == "")
                return false;
            else
                return true;
        }
        private void clearAll()
        {
            txt_BkAdd_Title.Text = "";
            txt_BkAdd_Author.Text = "";
            txt_BkAdd_Ed.Text = "";
            txt_BkAdd_Pub.Text = "";
            cmb_BkAdd_PubYr.Text = "";
            txt_BkAdd_Qnt.Text = "";
            txt_BkAdd_ISBN.Text = "";
            chk_BkAdd_Soft_Cpy.Checked = false;
            chk_BkAdd_Soft_Cpy.Checked = true;
            cmb_BkAdd_RkRow.Text = "";
            cmb_BkAdd_RkCol.Text = "";
            txt_BkAdd_Pref.Text = "";
            ID = 0;
        }

        public void change_lbl_BkAdd_Head_Text(string myText)
        {
            lbl_BkAdd_Head.Text = myText;
        }

        public void changeRecord_BookData(int id, string ttl, string aut, string ed, string qnt, string isbn)
        {
            this.ID = id;
            txt_BkAdd_Title.Text = ttl;
            txt_BkAdd_Author.Text = aut;
            txt_BkAdd_Ed.Text = ed;
            txt_BkAdd_Qnt.Text = qnt;
            txt_BkAdd_ISBN.Text = isbn;
        }

        public void invokeAdd()
        {
            this.change_lbl_BkAdd_Head_Text("Add Book");
            this.Show();
        }

        public void invokeUpdate()
        {
            this.change_lbl_BkAdd_Head_Text("Update Book");
            this.Show();
        }

        public void changeRecord_PublisherData(string pb, string pbyr)
        {
            txt_BkAdd_Pub.Text = pb;
            cmb_BkAdd_PubYr.Text = pbyr;
        }

        public void changeRecord_Locationata(string rR, string rC)
        {
            cmb_BkAdd_RkRow.Text = rR;
            cmb_BkAdd_RkCol.Text = rC;
        }

        public void changeRecord_OthersData(bool sft, bool iss, string pre)
        {
            chk_BkAdd_Soft_Cpy.Checked = sft;
            chk_BkAdd_Issue.Checked = iss;
            txt_BkAdd_Pref.Text = pre;
        }

        private void btn_BkAdd_Cnfrm_Click(object sender, EventArgs e)
        {
            if (lbl_BkAdd_Head.Text == "Add Book")
                writeRecord();
            else if (lbl_BkAdd_Head.Text == "Update Book")
                updateRecord();
        }

        private void btn_BkAdd_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}