namespace DBWinFormCRUDProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDiscont = new Button();
            btnLoadAll = new Button();
            btnConTst = new Button();
            btnCntDB = new Button();
            btnExt = new Button();
            btnSrch = new Button();
            btnDlt = new Button();
            btnEdit = new Button();
            btnInsert = new Button();
            pnlAllData = new Panel();
            dataGridAll = new DataGridView();
            panelInsertNewBook = new Panel();
            btnInsertCancel = new Button();
            btnClearNew = new Button();
            btnInsertNew = new Button();
            txtnewBookPrice = new TextBox();
            txtnewBookAuthor = new TextBox();
            txtnewBookTitle = new TextBox();
            txtnewBookISBN = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelEditBook = new Panel();
            btncancelEdit = new Button();
            btnClrEdit = new Button();
            btnEditBook = new Button();
            txtEditBookPrice = new TextBox();
            txtEditBookAuthor = new TextBox();
            txtEditBookTitle = new TextBox();
            txtEditBookISBN = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            pnlAllData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAll).BeginInit();
            panelInsertNewBook.SuspendLayout();
            panelEditBook.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDiscont);
            panel1.Controls.Add(btnLoadAll);
            panel1.Controls.Add(btnConTst);
            panel1.Controls.Add(btnCntDB);
            panel1.Controls.Add(btnExt);
            panel1.Controls.Add(btnSrch);
            panel1.Controls.Add(btnDlt);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnInsert);
            panel1.Location = new Point(63, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 159);
            panel1.TabIndex = 0;
            // 
            // btnDiscont
            // 
            btnDiscont.Enabled = false;
            btnDiscont.ForeColor = Color.Red;
            btnDiscont.Location = new Point(301, 16);
            btnDiscont.Name = "btnDiscont";
            btnDiscont.Size = new Size(219, 44);
            btnDiscont.TabIndex = 9;
            btnDiscont.Text = "Disconnect from Database";
            btnDiscont.UseVisualStyleBackColor = true;
            btnDiscont.Click += btnDiscont_Click;
            // 
            // btnLoadAll
            // 
            btnLoadAll.Enabled = false;
            btnLoadAll.Location = new Point(549, 16);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(124, 44);
            btnLoadAll.TabIndex = 8;
            btnLoadAll.Text = "Load All Data";
            btnLoadAll.UseVisualStyleBackColor = true;
            btnLoadAll.Click += btnLoadAll_Click;
            // 
            // btnConTst
            // 
            btnConTst.Location = new Point(30, 16);
            btnConTst.Name = "btnConTst";
            btnConTst.Size = new Size(124, 44);
            btnConTst.TabIndex = 7;
            btnConTst.Text = "Test Connection";
            btnConTst.UseVisualStyleBackColor = true;
            btnConTst.Click += btnConTst_Click;
            // 
            // btnCntDB
            // 
            btnCntDB.ForeColor = Color.Lime;
            btnCntDB.Location = new Point(160, 16);
            btnCntDB.Name = "btnCntDB";
            btnCntDB.Size = new Size(124, 44);
            btnCntDB.TabIndex = 6;
            btnCntDB.Text = "Connect To DB";
            btnCntDB.UseVisualStyleBackColor = true;
            btnCntDB.Click += btnCntDB_Click;
            // 
            // btnExt
            // 
            btnExt.Location = new Point(549, 85);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(124, 44);
            btnExt.TabIndex = 5;
            btnExt.Text = "Exit";
            btnExt.UseVisualStyleBackColor = true;
            btnExt.Click += btnExt_Click;
            // 
            // btnSrch
            // 
            btnSrch.Enabled = false;
            btnSrch.Location = new Point(419, 85);
            btnSrch.Name = "btnSrch";
            btnSrch.Size = new Size(124, 44);
            btnSrch.TabIndex = 4;
            btnSrch.Text = "Search";
            btnSrch.UseVisualStyleBackColor = true;
            // 
            // btnDlt
            // 
            btnDlt.Enabled = false;
            btnDlt.Location = new Point(289, 85);
            btnDlt.Name = "btnDlt";
            btnDlt.Size = new Size(124, 44);
            btnDlt.TabIndex = 3;
            btnDlt.Text = "Delete";
            btnDlt.UseVisualStyleBackColor = true;
            btnDlt.Click += btnDlt_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(160, 85);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 44);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnInsert
            // 
            btnInsert.Enabled = false;
            btnInsert.Location = new Point(30, 85);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(124, 44);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // pnlAllData
            // 
            pnlAllData.Controls.Add(dataGridAll);
            pnlAllData.Location = new Point(63, 21);
            pnlAllData.Name = "pnlAllData";
            pnlAllData.Size = new Size(521, 206);
            pnlAllData.TabIndex = 1;
            // 
            // dataGridAll
            // 
            dataGridAll.AllowUserToAddRows = false;
            dataGridAll.AllowUserToDeleteRows = false;
            dataGridAll.AllowUserToResizeColumns = false;
            dataGridAll.AllowUserToResizeRows = false;
            dataGridAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAll.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridAll.Location = new Point(0, 0);
            dataGridAll.Name = "dataGridAll";
            dataGridAll.RowHeadersWidth = 51;
            dataGridAll.Size = new Size(521, 242);
            dataGridAll.TabIndex = 0;
            // 
            // panelInsertNewBook
            // 
            panelInsertNewBook.BackColor = SystemColors.ControlLight;
            panelInsertNewBook.Controls.Add(btnInsertCancel);
            panelInsertNewBook.Controls.Add(btnClearNew);
            panelInsertNewBook.Controls.Add(btnInsertNew);
            panelInsertNewBook.Controls.Add(txtnewBookPrice);
            panelInsertNewBook.Controls.Add(txtnewBookAuthor);
            panelInsertNewBook.Controls.Add(txtnewBookTitle);
            panelInsertNewBook.Controls.Add(txtnewBookISBN);
            panelInsertNewBook.Controls.Add(label5);
            panelInsertNewBook.Controls.Add(label4);
            panelInsertNewBook.Controls.Add(label3);
            panelInsertNewBook.Controls.Add(label2);
            panelInsertNewBook.Controls.Add(label1);
            panelInsertNewBook.Location = new Point(785, 21);
            panelInsertNewBook.Name = "panelInsertNewBook";
            panelInsertNewBook.Size = new Size(332, 437);
            panelInsertNewBook.TabIndex = 2;
            panelInsertNewBook.Visible = false;
            // 
            // btnInsertCancel
            // 
            btnInsertCancel.Location = new Point(123, 365);
            btnInsertCancel.Name = "btnInsertCancel";
            btnInsertCancel.Size = new Size(111, 47);
            btnInsertCancel.TabIndex = 11;
            btnInsertCancel.Text = "Cancel";
            btnInsertCancel.UseVisualStyleBackColor = true;
            btnInsertCancel.Click += btnInsertCancel_Click;
            // 
            // btnClearNew
            // 
            btnClearNew.Location = new Point(178, 310);
            btnClearNew.Name = "btnClearNew";
            btnClearNew.Size = new Size(111, 47);
            btnClearNew.TabIndex = 10;
            btnClearNew.Text = "Clear";
            btnClearNew.UseVisualStyleBackColor = true;
            btnClearNew.Click += btnClearNew_Click;
            // 
            // btnInsertNew
            // 
            btnInsertNew.Location = new Point(45, 310);
            btnInsertNew.Name = "btnInsertNew";
            btnInsertNew.Size = new Size(111, 47);
            btnInsertNew.TabIndex = 9;
            btnInsertNew.Text = "Insert";
            btnInsertNew.UseVisualStyleBackColor = true;
            btnInsertNew.Click += btnInsertNew_Click;
            // 
            // txtnewBookPrice
            // 
            txtnewBookPrice.Location = new Point(151, 262);
            txtnewBookPrice.Name = "txtnewBookPrice";
            txtnewBookPrice.Size = new Size(150, 27);
            txtnewBookPrice.TabIndex = 8;
            // 
            // txtnewBookAuthor
            // 
            txtnewBookAuthor.Location = new Point(151, 205);
            txtnewBookAuthor.Name = "txtnewBookAuthor";
            txtnewBookAuthor.Size = new Size(150, 27);
            txtnewBookAuthor.TabIndex = 7;
            // 
            // txtnewBookTitle
            // 
            txtnewBookTitle.Location = new Point(151, 150);
            txtnewBookTitle.Name = "txtnewBookTitle";
            txtnewBookTitle.Size = new Size(150, 27);
            txtnewBookTitle.TabIndex = 6;
            // 
            // txtnewBookISBN
            // 
            txtnewBookISBN.Location = new Point(151, 98);
            txtnewBookISBN.Name = "txtnewBookISBN";
            txtnewBookISBN.Size = new Size(150, 27);
            txtnewBookISBN.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 258);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 4;
            label5.Text = "Book Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 201);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 3;
            label4.Text = "Book Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 150);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Book Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 94);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 1;
            label2.Text = "Book ISBN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 33);
            label1.Name = "label1";
            label1.Size = new Size(124, 31);
            label1.TabIndex = 0;
            label1.Text = "New Book";
            // 
            // panelEditBook
            // 
            panelEditBook.BackColor = SystemColors.GradientInactiveCaption;
            panelEditBook.Controls.Add(btncancelEdit);
            panelEditBook.Controls.Add(btnClrEdit);
            panelEditBook.Controls.Add(btnEditBook);
            panelEditBook.Controls.Add(txtEditBookPrice);
            panelEditBook.Controls.Add(txtEditBookAuthor);
            panelEditBook.Controls.Add(txtEditBookTitle);
            panelEditBook.Controls.Add(txtEditBookISBN);
            panelEditBook.Controls.Add(label6);
            panelEditBook.Controls.Add(label7);
            panelEditBook.Controls.Add(label8);
            panelEditBook.Controls.Add(label9);
            panelEditBook.Controls.Add(label10);
            panelEditBook.Location = new Point(792, 32);
            panelEditBook.Name = "panelEditBook";
            panelEditBook.Size = new Size(315, 417);
            panelEditBook.TabIndex = 12;
            panelEditBook.Visible = false;
            // 
            // btncancelEdit
            // 
            btncancelEdit.Location = new Point(123, 365);
            btncancelEdit.Name = "btncancelEdit";
            btncancelEdit.Size = new Size(111, 47);
            btncancelEdit.TabIndex = 11;
            btncancelEdit.Text = "Cancel";
            btncancelEdit.UseVisualStyleBackColor = true;
            btncancelEdit.Click += btncancelEdit_Click;
            // 
            // btnClrEdit
            // 
            btnClrEdit.Location = new Point(178, 310);
            btnClrEdit.Name = "btnClrEdit";
            btnClrEdit.Size = new Size(111, 47);
            btnClrEdit.TabIndex = 10;
            btnClrEdit.Text = "Clear";
            btnClrEdit.UseVisualStyleBackColor = true;
            btnClrEdit.Click += btnClrEdit_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Location = new Point(45, 310);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(111, 47);
            btnEditBook.TabIndex = 9;
            btnEditBook.Text = "Edit";
            btnEditBook.UseVisualStyleBackColor = true;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // txtEditBookPrice
            // 
            txtEditBookPrice.Location = new Point(151, 262);
            txtEditBookPrice.Name = "txtEditBookPrice";
            txtEditBookPrice.Size = new Size(150, 27);
            txtEditBookPrice.TabIndex = 8;
            // 
            // txtEditBookAuthor
            // 
            txtEditBookAuthor.Location = new Point(151, 205);
            txtEditBookAuthor.Name = "txtEditBookAuthor";
            txtEditBookAuthor.Size = new Size(150, 27);
            txtEditBookAuthor.TabIndex = 7;
            // 
            // txtEditBookTitle
            // 
            txtEditBookTitle.Location = new Point(151, 150);
            txtEditBookTitle.Name = "txtEditBookTitle";
            txtEditBookTitle.Size = new Size(150, 27);
            txtEditBookTitle.TabIndex = 6;
            // 
            // txtEditBookISBN
            // 
            txtEditBookISBN.Location = new Point(151, 98);
            txtEditBookISBN.Name = "txtEditBookISBN";
            txtEditBookISBN.Size = new Size(150, 27);
            txtEditBookISBN.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 258);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 4;
            label6.Text = "Book Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 201);
            label7.Name = "label7";
            label7.Size = new Size(123, 28);
            label7.TabIndex = 3;
            label7.Text = "Book Author";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 150);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 2;
            label8.Text = "Book Title:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 94);
            label9.Name = "label9";
            label9.Size = new Size(108, 28);
            label9.TabIndex = 1;
            label9.Text = "Book ISBN:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(110, 33);
            label10.Name = "label10";
            label10.Size = new Size(118, 31);
            label10.TabIndex = 0;
            label10.Text = "Edit Book";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 461);
            Controls.Add(panelEditBook);
            Controls.Add(panelInsertNewBook);
            Controls.Add(pnlAllData);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            pnlAllData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAll).EndInit();
            panelInsertNewBook.ResumeLayout(false);
            panelInsertNewBook.PerformLayout();
            panelEditBook.ResumeLayout(false);
            panelEditBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExt;
        private Button btnSrch;
        private Button btnDlt;
        private Button btnEdit;
        private Button btnInsert;
        private Button btnLoadAll;
        private Button btnConTst;
        private Button btnCntDB;
        private Button btnDiscont;
        private Panel pnlAllData;
        private DataGridView dataGridAll;
        private Panel panelInsertNewBook;
        private TextBox txtnewBookPrice;
        private TextBox txtnewBookAuthor;
        private TextBox txtnewBookTitle;
        private TextBox txtnewBookISBN;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnInsertCancel;
        private Button btnClearNew;
        private Button btnInsertNew;
        private Panel panelEditBook;
        private Button btncancelEdit;
        private Button btnClrEdit;
        private Button btnEditBook;
        private TextBox txtEditBookPrice;
        private TextBox txtEditBookAuthor;
        private TextBox txtEditBookTitle;
        private TextBox txtEditBookISBN;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
