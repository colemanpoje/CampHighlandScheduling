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

namespace CampHighlandScheduling
{
    partial class Scheduler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public List<Person> personList = new List<Person>();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scheduler));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "GroupNameInput";
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(240, 81);
            this.textBox1.MaxLength = 1024;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 31);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleName = "GroupNameLabel";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "GroupLeaderInput";
            this.textBox2.Location = new System.Drawing.Point(240, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 31);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AccessibleName = "GroupLeaderLabel";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group Leader";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "HostNameInput";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(338, 33);
            this.comboBox1.TabIndex = 4;

            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "ID";

            DatabaseReader();

            // 
            // label3
            // 
            this.label3.AccessibleName = "HostNameLabel";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Host Name";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AccessibleName = "GroupNumberInput";
            this.numericUpDown1.Location = new System.Drawing.Point(240, 310);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(338, 31);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AccessibleName = "GroupNumberLabel";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Group Number";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleName = "ArrivalDateInput";
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 381);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AccessibleName = "DepartureDateInput";
            this.dateTimePicker2.Location = new System.Drawing.Point(240, 438);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AccessibleName = "ArrivalDateLabel";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Arrival Date";
            // 
            // label6
            // 
            this.label6.AccessibleName = "DepartureDateLabel";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Departure Date";
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 993);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scheduler";
            this.Text = "Camp Scheduler v1.0";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        public void DatabaseReader()
        {
            try
            {
                string filePath = "C:\\Users\\drewj\\Documents\\GitHub\\CampHighlandScheduling\\CampHighlandScheduling\\Database\\WorkerDB.csv";
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("uID");
                dataTable.Columns.Add("vcFullName");
                dataTable.Columns.Add("vcType");
                dataTable.Columns.Add("bPutIn");
                dataTable.Columns.Add("bBelay");
                dataTable.Columns.Add("bZip");
                dataTable.Columns.Add("bHarness");
                dataTable.Columns.Add("bSetUp");
                dataTable.Columns.Add("vcGender");
                dataTable.Columns.Add("bStore");
                StreamReader reader = new StreamReader(filePath);
                string[] totalData = new string[File.ReadAllLines(filePath).Length];
                totalData = reader.ReadLine().Split(',');
                while (!reader.EndOfStream)
                {
                    totalData = reader.ReadLine().Split(',');
                    dataTable.Rows.Add(totalData[0], totalData[1], totalData[2], totalData[3], totalData[4], totalData[5], totalData[6], totalData[7], totalData[8], totalData[9]);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["vcType"].ToString() != "VOLN")
                    {
                        comboBox1.Items.Add(new Person(int.Parse(row["uID"].ToString()), row["vcFullName"].ToString(), row["vcType"].ToString(), Convert.ToBoolean(int.Parse(row["bPutIn"].ToString())), Convert.ToBoolean(int.Parse(row["bBelay"].ToString())), Convert.ToBoolean(int.Parse(row["bZip"].ToString())), Convert.ToBoolean(int.Parse(row["bHarness"].ToString())), Convert.ToBoolean(int.Parse(row["bSetUp"].ToString())), row["vcGender"].ToString(), Convert.ToBoolean(int.Parse(row["bStore"].ToString()))));
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
    }

    public class Person
    {
        public int uID { get; set; }
        public string vcFullName { get; set; }
        public string vcType { get; set; }
        public bool bPutIn { get; set; }
        public bool bBelay { get; set; }
        public bool bZip { get; set; }
        public bool bHarness { get; set; }
        public bool bSetUp { get; set; }
        public string vcGender { get; set; }
        public bool bStore { get; set; }

        public Person(int IDIn, string name, string type, bool putIn, bool belay, bool zip, bool harness, bool setup, string gender, bool store)
        {
            uID = IDIn;
            vcFullName = name;
            vcType = type;
            bPutIn = putIn;
            bBelay = belay;
            bZip = zip;
            bHarness = harness;
            bSetUp = setup;
            vcGender = gender;
            bStore = store;
        }

        public string FullName
        {
            get { return vcFullName; }
            set { vcFullName = value; }
        }

        public string ID
        {
            get { return uID.ToString(); }
        }
    }
}