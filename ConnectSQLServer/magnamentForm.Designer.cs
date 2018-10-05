namespace ConnectSQLServer
{
    partial class magnamentForm
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
            this.dbList = new System.Windows.Forms.ListBox();
            this.tablesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.insert = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.querytxt = new System.Windows.Forms.RichTextBox();
            this.MSG = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbList
            // 
            this.dbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbList.FormattingEnabled = true;
            this.dbList.ItemHeight = 16;
            this.dbList.Location = new System.Drawing.Point(12, 29);
            this.dbList.Name = "dbList";
            this.dbList.Size = new System.Drawing.Size(127, 244);
            this.dbList.TabIndex = 0;
            this.dbList.SelectedValueChanged += new System.EventHandler(this.dbList_SelectedValueChanged);
            // 
            // tablesList
            // 
            this.tablesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesList.FormattingEnabled = true;
            this.tablesList.ItemHeight = 16;
            this.tablesList.Location = new System.Drawing.Point(145, 29);
            this.tablesList.Name = "tablesList";
            this.tablesList.Size = new System.Drawing.Size(137, 244);
            this.tablesList.TabIndex = 1;
            this.tablesList.SelectedIndexChanged += new System.EventHandler(this.tablesList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data bases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tables";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.insert);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(288, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 263);
            this.tabControl1.TabIndex = 4;
            // 
            // insert
            // 
            this.insert.AutoScroll = true;
            this.insert.Location = new System.Drawing.Point(4, 22);
            this.insert.Name = "insert";
            this.insert.Padding = new System.Windows.Forms.Padding(3);
            this.insert.Size = new System.Drawing.Size(497, 237);
            this.insert.TabIndex = 0;
            this.insert.Text = "Insertar";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.querytxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transact-SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(485, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Execute Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // querytxt
            // 
            this.querytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.querytxt.Location = new System.Drawing.Point(6, 6);
            this.querytxt.Name = "querytxt";
            this.querytxt.Size = new System.Drawing.Size(485, 201);
            this.querytxt.TabIndex = 5;
            this.querytxt.Text = "";
            // 
            // MSG
            // 
            this.MSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSG.Location = new System.Drawing.Point(12, 295);
            this.MSG.Name = "MSG";
            this.MSG.Size = new System.Drawing.Size(777, 157);
            this.MSG.TabIndex = 6;
            this.MSG.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Messages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(480, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Note: The database is put automatically in the  Transact-SQL query";
            // 
            // magnamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 478);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MSG);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablesList);
            this.Controls.Add(this.dbList);
            this.Name = "magnamentForm";
            this.Text = "Jdev Magnament";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.magnamentForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dbList;
        private System.Windows.Forms.ListBox tablesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage insert;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox querytxt;
        private System.Windows.Forms.RichTextBox MSG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}