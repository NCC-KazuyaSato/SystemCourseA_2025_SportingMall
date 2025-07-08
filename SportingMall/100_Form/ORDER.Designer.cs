namespace SportingMall
{
    partial class ORDER
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
            grbDelivery = new GroupBox();
            txtDeliveryTel = new TextBox();
            lblDeliveryTel = new Label();
            txtDeliveryPostal = new TextBox();
            lblDeliveryPostal = new Label();
            txtDeliveryAddress = new TextBox();
            lblDeliveryAddress = new Label();
            lblDeliveryName = new Label();
            txtDeliveryName = new TextBox();
            grbBillType = new GroupBox();
            cbxBillType = new ComboBox();
            grbDeadLine = new GroupBox();
            dtpDeadLine = new DateTimePicker();
            grbBill = new GroupBox();
            txtBillTel = new TextBox();
            lblBillTel = new Label();
            txtBillPostal = new TextBox();
            lblBillPostal = new Label();
            txtBillAddress = new TextBox();
            lblBillAddress = new Label();
            lblBillName = new Label();
            txtBillName = new TextBox();
            grbOrder = new GroupBox();
            nudItem10 = new NumericUpDown();
            nudItem5 = new NumericUpDown();
            nudItem8 = new NumericUpDown();
            nudItem3 = new NumericUpDown();
            nudItem9 = new NumericUpDown();
            nudItem7 = new NumericUpDown();
            nudItem4 = new NumericUpDown();
            nudItem6 = new NumericUpDown();
            nudItem2 = new NumericUpDown();
            lblItem10 = new Label();
            nudItem1 = new NumericUpDown();
            label17 = new Label();
            lblItem5 = new Label();
            lblOrderCntColumn2 = new Label();
            lblItem3 = new Label();
            lblItem9 = new Label();
            lblOrderCntColumn1 = new Label();
            lblItem7 = new Label();
            lblItem4 = new Label();
            cbxItem10 = new ComboBox();
            lblItem2 = new Label();
            cbxItem8 = new ComboBox();
            cbxItem5 = new ComboBox();
            cbxItem9 = new ComboBox();
            cbxItem3 = new ComboBox();
            lblItemColumn2 = new Label();
            cbxItem4 = new ComboBox();
            cbxItem7 = new ComboBox();
            lblItemColumn1 = new Label();
            lblItem6 = new Label();
            cbxItem2 = new ComboBox();
            cbxItem6 = new ComboBox();
            lblItem1 = new Label();
            cbxItem1 = new ComboBox();
            btnOrder = new Button();
            grbDelivery.SuspendLayout();
            grbBillType.SuspendLayout();
            grbDeadLine.SuspendLayout();
            grbBill.SuspendLayout();
            grbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudItem1).BeginInit();
            SuspendLayout();
            // 
            // grbDelivery
            // 
            grbDelivery.BackColor = Color.Azure;
            grbDelivery.Controls.Add(txtDeliveryTel);
            grbDelivery.Controls.Add(lblDeliveryTel);
            grbDelivery.Controls.Add(txtDeliveryPostal);
            grbDelivery.Controls.Add(lblDeliveryPostal);
            grbDelivery.Controls.Add(txtDeliveryAddress);
            grbDelivery.Controls.Add(lblDeliveryAddress);
            grbDelivery.Controls.Add(lblDeliveryName);
            grbDelivery.Controls.Add(txtDeliveryName);
            grbDelivery.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            grbDelivery.ForeColor = Color.Navy;
            grbDelivery.Location = new Point(32, 23);
            grbDelivery.Name = "grbDelivery";
            grbDelivery.Size = new Size(420, 310);
            grbDelivery.TabIndex = 1;
            grbDelivery.TabStop = false;
            grbDelivery.Text = "届け先情報 [必須]";
            // 
            // txtDeliveryTel
            // 
            txtDeliveryTel.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtDeliveryTel.ImeMode = ImeMode.Disable;
            txtDeliveryTel.Location = new Point(30, 256);
            txtDeliveryTel.MaxLength = 15;
            txtDeliveryTel.Name = "txtDeliveryTel";
            txtDeliveryTel.ShortcutsEnabled = false;
            txtDeliveryTel.Size = new Size(180, 23);
            txtDeliveryTel.TabIndex = 9;
            txtDeliveryTel.KeyPress += NumericalInputControl;
            // 
            // lblDeliveryTel
            // 
            lblDeliveryTel.AutoSize = true;
            lblDeliveryTel.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblDeliveryTel.Location = new Point(27, 233);
            lblDeliveryTel.Name = "lblDeliveryTel";
            lblDeliveryTel.Size = new Size(55, 15);
            lblDeliveryTel.TabIndex = 8;
            lblDeliveryTel.Text = "電話番号";
            // 
            // txtDeliveryPostal
            // 
            txtDeliveryPostal.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtDeliveryPostal.ImeMode = ImeMode.Disable;
            txtDeliveryPostal.Location = new Point(30, 124);
            txtDeliveryPostal.MaxLength = 7;
            txtDeliveryPostal.Name = "txtDeliveryPostal";
            txtDeliveryPostal.ShortcutsEnabled = false;
            txtDeliveryPostal.Size = new Size(120, 23);
            txtDeliveryPostal.TabIndex = 5;
            txtDeliveryPostal.KeyPress += NumericalInputControl;
            // 
            // lblDeliveryPostal
            // 
            lblDeliveryPostal.AutoSize = true;
            lblDeliveryPostal.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblDeliveryPostal.Location = new Point(27, 101);
            lblDeliveryPostal.Name = "lblDeliveryPostal";
            lblDeliveryPostal.Size = new Size(55, 15);
            lblDeliveryPostal.TabIndex = 4;
            lblDeliveryPostal.Text = "郵便番号";
            // 
            // txtDeliveryAddress
            // 
            txtDeliveryAddress.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtDeliveryAddress.Location = new Point(30, 189);
            txtDeliveryAddress.MaxLength = 100;
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.Size = new Size(350, 23);
            txtDeliveryAddress.TabIndex = 7;
            // 
            // lblDeliveryAddress
            // 
            lblDeliveryAddress.AutoSize = true;
            lblDeliveryAddress.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblDeliveryAddress.Location = new Point(27, 166);
            lblDeliveryAddress.Name = "lblDeliveryAddress";
            lblDeliveryAddress.Size = new Size(31, 15);
            lblDeliveryAddress.TabIndex = 6;
            lblDeliveryAddress.Text = "住所";
            // 
            // lblDeliveryName
            // 
            lblDeliveryName.AutoSize = true;
            lblDeliveryName.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblDeliveryName.Location = new Point(27, 37);
            lblDeliveryName.Name = "lblDeliveryName";
            lblDeliveryName.Size = new Size(31, 15);
            lblDeliveryName.TabIndex = 2;
            lblDeliveryName.Text = "宛名";
            // 
            // txtDeliveryName
            // 
            txtDeliveryName.BackColor = Color.White;
            txtDeliveryName.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtDeliveryName.ImeMode = ImeMode.NoControl;
            txtDeliveryName.Location = new Point(30, 60);
            txtDeliveryName.MaxLength = 30;
            txtDeliveryName.Name = "txtDeliveryName";
            txtDeliveryName.Size = new Size(180, 23);
            txtDeliveryName.TabIndex = 3;
            // 
            // grbBillType
            // 
            grbBillType.Controls.Add(cbxBillType);
            grbBillType.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            grbBillType.ForeColor = Color.Navy;
            grbBillType.Location = new Point(32, 355);
            grbBillType.Name = "grbBillType";
            grbBillType.Size = new Size(420, 77);
            grbBillType.TabIndex = 10;
            grbBillType.TabStop = false;
            grbBillType.Text = "請求先区分";
            // 
            // cbxBillType
            // 
            cbxBillType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBillType.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxBillType.FormattingEnabled = true;
            cbxBillType.Items.AddRange(new object[] { "届け先と同じ", "指定する" });
            cbxBillType.Location = new Point(30, 33);
            cbxBillType.Name = "cbxBillType";
            cbxBillType.Size = new Size(121, 23);
            cbxBillType.TabIndex = 11;
            cbxBillType.SelectedIndexChanged += BillTypeChange;
            // 
            // grbDeadLine
            // 
            grbDeadLine.Controls.Add(dtpDeadLine);
            grbDeadLine.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            grbDeadLine.ForeColor = Color.Navy;
            grbDeadLine.Location = new Point(475, 355);
            grbDeadLine.Name = "grbDeadLine";
            grbDeadLine.Size = new Size(420, 77);
            grbDeadLine.TabIndex = 12;
            grbDeadLine.TabStop = false;
            grbDeadLine.Text = "希望納期";
            // 
            // dtpDeadLine
            // 
            dtpDeadLine.CustomFormat = "yyyy/MM/dd";
            dtpDeadLine.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDeadLine.Format = DateTimePickerFormat.Custom;
            dtpDeadLine.Location = new Point(30, 33);
            dtpDeadLine.Name = "dtpDeadLine";
            dtpDeadLine.Size = new Size(133, 23);
            dtpDeadLine.TabIndex = 13;
            dtpDeadLine.Value = new DateTime(2025, 5, 29, 20, 20, 2, 0);
            // 
            // grbBill
            // 
            grbBill.Controls.Add(txtBillTel);
            grbBill.Controls.Add(lblBillTel);
            grbBill.Controls.Add(txtBillPostal);
            grbBill.Controls.Add(lblBillPostal);
            grbBill.Controls.Add(txtBillAddress);
            grbBill.Controls.Add(lblBillAddress);
            grbBill.Controls.Add(lblBillName);
            grbBill.Controls.Add(txtBillName);
            grbBill.Enabled = false;
            grbBill.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            grbBill.ForeColor = Color.Navy;
            grbBill.Location = new Point(475, 23);
            grbBill.Name = "grbBill";
            grbBill.Size = new Size(420, 310);
            grbBill.TabIndex = 14;
            grbBill.TabStop = false;
            grbBill.Text = "請求先情報";
            // 
            // txtBillTel
            // 
            txtBillTel.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtBillTel.ImeMode = ImeMode.Disable;
            txtBillTel.Location = new Point(30, 256);
            txtBillTel.MaxLength = 15;
            txtBillTel.Name = "txtBillTel";
            txtBillTel.ShortcutsEnabled = false;
            txtBillTel.Size = new Size(180, 23);
            txtBillTel.TabIndex = 22;
            txtBillTel.KeyPress += NumericalInputControl;
            // 
            // lblBillTel
            // 
            lblBillTel.AutoSize = true;
            lblBillTel.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblBillTel.Location = new Point(27, 233);
            lblBillTel.Name = "lblBillTel";
            lblBillTel.Size = new Size(55, 15);
            lblBillTel.TabIndex = 21;
            lblBillTel.Text = "電話番号";
            // 
            // txtBillPostal
            // 
            txtBillPostal.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtBillPostal.ImeMode = ImeMode.Disable;
            txtBillPostal.Location = new Point(30, 124);
            txtBillPostal.MaxLength = 7;
            txtBillPostal.Name = "txtBillPostal";
            txtBillPostal.ShortcutsEnabled = false;
            txtBillPostal.Size = new Size(120, 23);
            txtBillPostal.TabIndex = 18;
            txtBillPostal.KeyPress += NumericalInputControl;
            // 
            // lblBillPostal
            // 
            lblBillPostal.AutoSize = true;
            lblBillPostal.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblBillPostal.Location = new Point(27, 101);
            lblBillPostal.Name = "lblBillPostal";
            lblBillPostal.Size = new Size(55, 15);
            lblBillPostal.TabIndex = 17;
            lblBillPostal.Text = "郵便番号";
            // 
            // txtBillAddress
            // 
            txtBillAddress.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtBillAddress.Location = new Point(30, 189);
            txtBillAddress.MaxLength = 100;
            txtBillAddress.Name = "txtBillAddress";
            txtBillAddress.Size = new Size(350, 23);
            txtBillAddress.TabIndex = 20;
            // 
            // lblBillAddress
            // 
            lblBillAddress.AutoSize = true;
            lblBillAddress.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblBillAddress.Location = new Point(27, 166);
            lblBillAddress.Name = "lblBillAddress";
            lblBillAddress.Size = new Size(31, 15);
            lblBillAddress.TabIndex = 19;
            lblBillAddress.Text = "住所";
            // 
            // lblBillName
            // 
            lblBillName.AutoSize = true;
            lblBillName.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblBillName.Location = new Point(27, 37);
            lblBillName.Name = "lblBillName";
            lblBillName.Size = new Size(31, 15);
            lblBillName.TabIndex = 15;
            lblBillName.Text = "宛名";
            // 
            // txtBillName
            // 
            txtBillName.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtBillName.ImeMode = ImeMode.NoControl;
            txtBillName.Location = new Point(30, 60);
            txtBillName.MaxLength = 30;
            txtBillName.Name = "txtBillName";
            txtBillName.Size = new Size(180, 23);
            txtBillName.TabIndex = 16;
            // 
            // grbOrder
            // 
            grbOrder.Controls.Add(nudItem10);
            grbOrder.Controls.Add(nudItem5);
            grbOrder.Controls.Add(nudItem8);
            grbOrder.Controls.Add(nudItem3);
            grbOrder.Controls.Add(nudItem9);
            grbOrder.Controls.Add(nudItem7);
            grbOrder.Controls.Add(nudItem4);
            grbOrder.Controls.Add(nudItem6);
            grbOrder.Controls.Add(nudItem2);
            grbOrder.Controls.Add(lblItem10);
            grbOrder.Controls.Add(nudItem1);
            grbOrder.Controls.Add(label17);
            grbOrder.Controls.Add(lblItem5);
            grbOrder.Controls.Add(lblOrderCntColumn2);
            grbOrder.Controls.Add(lblItem3);
            grbOrder.Controls.Add(lblItem9);
            grbOrder.Controls.Add(lblOrderCntColumn1);
            grbOrder.Controls.Add(lblItem7);
            grbOrder.Controls.Add(lblItem4);
            grbOrder.Controls.Add(cbxItem10);
            grbOrder.Controls.Add(lblItem2);
            grbOrder.Controls.Add(cbxItem8);
            grbOrder.Controls.Add(cbxItem5);
            grbOrder.Controls.Add(cbxItem9);
            grbOrder.Controls.Add(cbxItem3);
            grbOrder.Controls.Add(lblItemColumn2);
            grbOrder.Controls.Add(cbxItem4);
            grbOrder.Controls.Add(cbxItem7);
            grbOrder.Controls.Add(lblItemColumn1);
            grbOrder.Controls.Add(lblItem6);
            grbOrder.Controls.Add(cbxItem2);
            grbOrder.Controls.Add(cbxItem6);
            grbOrder.Controls.Add(lblItem1);
            grbOrder.Controls.Add(cbxItem1);
            grbOrder.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            grbOrder.ForeColor = Color.Navy;
            grbOrder.Location = new Point(32, 461);
            grbOrder.Name = "grbOrder";
            grbOrder.Size = new Size(673, 224);
            grbOrder.TabIndex = 23;
            grbOrder.TabStop = false;
            grbOrder.Text = "注文情報 [必須]";
            // 
            // nudItem10
            // 
            nudItem10.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudItem10.Location = new Point(587, 177);
            nudItem10.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudItem10.Name = "nudItem10";
            nudItem10.Size = new Size(50, 23);
            nudItem10.TabIndex = 57;
            nudItem10.KeyPress += NumericalInputControl;
            // 
            // nudItem5
            // 
            nudItem5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudItem5.Location = new Point(253, 176);
            nudItem5.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudItem5.Name = "nudItem5";
            nudItem5.Size = new Size(50, 23);
            nudItem5.TabIndex = 40;
            nudItem5.KeyPress += NumericalInputControl;
            // 
            // nudItem8
            // 
            nudItem8.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudItem8.Location = new Point(587, 117);
            nudItem8.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudItem8.Name = "nudItem8";
            nudItem8.Size = new Size(50, 23);
            nudItem8.TabIndex = 51;
            nudItem8.KeyPress += NumericalInputControl;
            // 
            // nudItem3
            // 
            nudItem3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudItem3.Location = new Point(253, 116);
            nudItem3.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudItem3.Name = "nudItem3";
            nudItem3.Size = new Size(50, 23);
            nudItem3.TabIndex = 34;
            nudItem3.KeyPress += NumericalInputControl;
            // 
            // nudItem9
            // 
            nudItem9.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudItem9.Location = new Point(587, 148);
            nudItem9.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudItem9.Name = "nudItem9";
            nudItem9.Size = new Size(50, 23);
            nudItem9.TabIndex = 54;
            nudItem9.KeyPress += NumericalInputControl;
            // 
            // nudItem7
            // 
            nudItem7.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudItem7.Location = new Point(587, 88);
            nudItem7.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudItem7.Name = "nudItem7";
            nudItem7.Size = new Size(50, 23);
            nudItem7.TabIndex = 48;
            nudItem7.KeyPress += NumericalInputControl;
            // 
            // nudItem4
            // 
            nudItem4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudItem4.Location = new Point(253, 147);
            nudItem4.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudItem4.Name = "nudItem4";
            nudItem4.Size = new Size(50, 23);
            nudItem4.TabIndex = 37;
            nudItem4.KeyPress += NumericalInputControl;
            // 
            // nudItem6
            // 
            nudItem6.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudItem6.Location = new Point(587, 59);
            nudItem6.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudItem6.Name = "nudItem6";
            nudItem6.Size = new Size(50, 23);
            nudItem6.TabIndex = 45;
            nudItem6.KeyPress += NumericalInputControl;
            // 
            // nudItem2
            // 
            nudItem2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudItem2.Location = new Point(253, 87);
            nudItem2.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudItem2.Name = "nudItem2";
            nudItem2.Size = new Size(50, 23);
            nudItem2.TabIndex = 31;
            nudItem2.KeyPress += NumericalInputControl;
            // 
            // lblItem10
            // 
            lblItem10.AutoSize = true;
            lblItem10.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItem10.Location = new Point(353, 180);
            lblItem10.Name = "lblItem10";
            lblItem10.Size = new Size(19, 15);
            lblItem10.TabIndex = 55;
            lblItem10.Text = "⑩";
            // 
            // nudItem1
            // 
            nudItem1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudItem1.Location = new Point(253, 58);
            nudItem1.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudItem1.Name = "nudItem1";
            nudItem1.Size = new Size(50, 23);
            nudItem1.TabIndex = 28;
            nudItem1.KeyPress += NumericalInputControl;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label17.Location = new Point(353, 120);
            label17.Name = "label17";
            label17.Size = new Size(19, 15);
            label17.TabIndex = 49;
            label17.Text = "⑧";
            // 
            // lblItem5
            // 
            lblItem5.AutoSize = true;
            lblItem5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItem5.Location = new Point(19, 179);
            lblItem5.Name = "lblItem5";
            lblItem5.Size = new Size(19, 15);
            lblItem5.TabIndex = 38;
            lblItem5.Text = "⑤";
            // 
            // lblOrderCntColumn2
            // 
            lblOrderCntColumn2.AutoSize = true;
            lblOrderCntColumn2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblOrderCntColumn2.Location = new Point(587, 41);
            lblOrderCntColumn2.Name = "lblOrderCntColumn2";
            lblOrderCntColumn2.Size = new Size(43, 15);
            lblOrderCntColumn2.TabIndex = 42;
            lblOrderCntColumn2.Text = "注文数";
            // 
            // lblItem3
            // 
            lblItem3.AutoSize = true;
            lblItem3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItem3.Location = new Point(19, 119);
            lblItem3.Name = "lblItem3";
            lblItem3.Size = new Size(19, 15);
            lblItem3.TabIndex = 32;
            lblItem3.Text = "③";
            // 
            // lblItem9
            // 
            lblItem9.AutoSize = true;
            lblItem9.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItem9.Location = new Point(353, 151);
            lblItem9.Name = "lblItem9";
            lblItem9.Size = new Size(19, 15);
            lblItem9.TabIndex = 52;
            lblItem9.Text = "⑨";
            // 
            // lblOrderCntColumn1
            // 
            lblOrderCntColumn1.AutoSize = true;
            lblOrderCntColumn1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblOrderCntColumn1.Location = new Point(253, 40);
            lblOrderCntColumn1.Name = "lblOrderCntColumn1";
            lblOrderCntColumn1.Size = new Size(43, 15);
            lblOrderCntColumn1.TabIndex = 25;
            lblOrderCntColumn1.Text = "注文数";
            // 
            // lblItem7
            // 
            lblItem7.AutoSize = true;
            lblItem7.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItem7.Location = new Point(353, 91);
            lblItem7.Name = "lblItem7";
            lblItem7.Size = new Size(19, 15);
            lblItem7.TabIndex = 46;
            lblItem7.Text = "⑦";
            // 
            // lblItem4
            // 
            lblItem4.AutoSize = true;
            lblItem4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItem4.Location = new Point(19, 150);
            lblItem4.Name = "lblItem4";
            lblItem4.Size = new Size(19, 15);
            lblItem4.TabIndex = 35;
            lblItem4.Text = "④";
            // 
            // cbxItem10
            // 
            cbxItem10.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItem10.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxItem10.FormattingEnabled = true;
            cbxItem10.IntegralHeight = false;
            cbxItem10.Location = new Point(388, 177);
            cbxItem10.MaxDropDownItems = 5;
            cbxItem10.Name = "cbxItem10";
            cbxItem10.Size = new Size(183, 23);
            cbxItem10.TabIndex = 56;
            cbxItem10.SelectedIndexChanged += OrderItemChange;
            // 
            // lblItem2
            // 
            lblItem2.AutoSize = true;
            lblItem2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItem2.Location = new Point(19, 90);
            lblItem2.Name = "lblItem2";
            lblItem2.Size = new Size(19, 15);
            lblItem2.TabIndex = 29;
            lblItem2.Text = "②";
            // 
            // cbxItem8
            // 
            cbxItem8.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItem8.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxItem8.FormattingEnabled = true;
            cbxItem8.IntegralHeight = false;
            cbxItem8.Location = new Point(388, 117);
            cbxItem8.MaxDropDownItems = 5;
            cbxItem8.Name = "cbxItem8";
            cbxItem8.Size = new Size(183, 23);
            cbxItem8.TabIndex = 50;
            cbxItem8.SelectedIndexChanged += OrderItemChange;
            // 
            // cbxItem5
            // 
            cbxItem5.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItem5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxItem5.FormattingEnabled = true;
            cbxItem5.IntegralHeight = false;
            cbxItem5.ItemHeight = 15;
            cbxItem5.Location = new Point(54, 176);
            cbxItem5.MaxDropDownItems = 5;
            cbxItem5.Name = "cbxItem5";
            cbxItem5.Size = new Size(183, 23);
            cbxItem5.TabIndex = 39;
            cbxItem5.SelectedIndexChanged += OrderItemChange;
            // 
            // cbxItem9
            // 
            cbxItem9.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItem9.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxItem9.FormattingEnabled = true;
            cbxItem9.IntegralHeight = false;
            cbxItem9.Location = new Point(388, 148);
            cbxItem9.MaxDropDownItems = 5;
            cbxItem9.Name = "cbxItem9";
            cbxItem9.Size = new Size(183, 23);
            cbxItem9.TabIndex = 53;
            cbxItem9.SelectedIndexChanged += OrderItemChange;
            // 
            // cbxItem3
            // 
            cbxItem3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItem3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxItem3.FormattingEnabled = true;
            cbxItem3.IntegralHeight = false;
            cbxItem3.ItemHeight = 15;
            cbxItem3.Location = new Point(54, 116);
            cbxItem3.MaxDropDownItems = 5;
            cbxItem3.Name = "cbxItem3";
            cbxItem3.Size = new Size(183, 23);
            cbxItem3.TabIndex = 33;
            cbxItem3.SelectedIndexChanged += OrderItemChange;
            // 
            // lblItemColumn2
            // 
            lblItemColumn2.AutoSize = true;
            lblItemColumn2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItemColumn2.Location = new Point(453, 41);
            lblItemColumn2.Name = "lblItemColumn2";
            lblItemColumn2.Size = new Size(31, 15);
            lblItemColumn2.TabIndex = 41;
            lblItemColumn2.Text = "商品";
            // 
            // cbxItem4
            // 
            cbxItem4.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItem4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxItem4.FormattingEnabled = true;
            cbxItem4.IntegralHeight = false;
            cbxItem4.ItemHeight = 15;
            cbxItem4.Location = new Point(54, 147);
            cbxItem4.MaxDropDownItems = 5;
            cbxItem4.Name = "cbxItem4";
            cbxItem4.Size = new Size(183, 23);
            cbxItem4.TabIndex = 36;
            cbxItem4.SelectedIndexChanged += OrderItemChange;
            // 
            // cbxItem7
            // 
            cbxItem7.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItem7.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxItem7.FormattingEnabled = true;
            cbxItem7.IntegralHeight = false;
            cbxItem7.ItemHeight = 15;
            cbxItem7.Location = new Point(388, 88);
            cbxItem7.MaxDropDownItems = 5;
            cbxItem7.Name = "cbxItem7";
            cbxItem7.Size = new Size(183, 23);
            cbxItem7.TabIndex = 47;
            cbxItem7.SelectedIndexChanged += OrderItemChange;
            // 
            // lblItemColumn1
            // 
            lblItemColumn1.AutoSize = true;
            lblItemColumn1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItemColumn1.Location = new Point(120, 40);
            lblItemColumn1.Name = "lblItemColumn1";
            lblItemColumn1.Size = new Size(31, 15);
            lblItemColumn1.TabIndex = 24;
            lblItemColumn1.Text = "商品";
            // 
            // lblItem6
            // 
            lblItem6.AutoSize = true;
            lblItem6.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItem6.Location = new Point(353, 62);
            lblItem6.Name = "lblItem6";
            lblItem6.Size = new Size(19, 15);
            lblItem6.TabIndex = 43;
            lblItem6.Text = "⑥";
            // 
            // cbxItem2
            // 
            cbxItem2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItem2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxItem2.FormattingEnabled = true;
            cbxItem2.IntegralHeight = false;
            cbxItem2.ItemHeight = 15;
            cbxItem2.Location = new Point(54, 87);
            cbxItem2.MaxDropDownItems = 5;
            cbxItem2.Name = "cbxItem2";
            cbxItem2.Size = new Size(183, 23);
            cbxItem2.TabIndex = 30;
            cbxItem2.SelectedIndexChanged += OrderItemChange;
            // 
            // cbxItem6
            // 
            cbxItem6.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItem6.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxItem6.FormattingEnabled = true;
            cbxItem6.IntegralHeight = false;
            cbxItem6.ItemHeight = 15;
            cbxItem6.Location = new Point(388, 59);
            cbxItem6.MaxDropDownItems = 5;
            cbxItem6.Name = "cbxItem6";
            cbxItem6.Size = new Size(183, 23);
            cbxItem6.TabIndex = 44;
            cbxItem6.SelectedIndexChanged += OrderItemChange;
            // 
            // lblItem1
            // 
            lblItem1.AutoSize = true;
            lblItem1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblItem1.Location = new Point(19, 61);
            lblItem1.Name = "lblItem1";
            lblItem1.Size = new Size(19, 15);
            lblItem1.TabIndex = 26;
            lblItem1.Text = "①";
            // 
            // cbxItem1
            // 
            cbxItem1.BackColor = Color.White;
            cbxItem1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItem1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbxItem1.ForeColor = SystemColors.WindowText;
            cbxItem1.FormattingEnabled = true;
            cbxItem1.IntegralHeight = false;
            cbxItem1.ItemHeight = 15;
            cbxItem1.Location = new Point(54, 58);
            cbxItem1.MaxDropDownItems = 5;
            cbxItem1.Name = "cbxItem1";
            cbxItem1.Size = new Size(183, 23);
            cbxItem1.TabIndex = 27;
            cbxItem1.SelectedIndexChanged += OrderItemChange;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.SlateGray;
            btnOrder.BackgroundImageLayout = ImageLayout.None;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(745, 622);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(150, 63);
            btnOrder.TabIndex = 58;
            btnOrder.Text = "注文する";
            btnOrder.UseMnemonic = false;
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += CheckOrder;
            // 
            // ORDER
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Azure;
            ClientSize = new Size(932, 725);
            Controls.Add(btnOrder);
            Controls.Add(grbBill);
            Controls.Add(grbDeadLine);
            Controls.Add(grbOrder);
            Controls.Add(grbBillType);
            Controls.Add(grbDelivery);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ORDER";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "商品購入画面";
            Load += ORDER_Load;
            grbDelivery.ResumeLayout(false);
            grbDelivery.PerformLayout();
            grbBillType.ResumeLayout(false);
            grbDeadLine.ResumeLayout(false);
            grbBill.ResumeLayout(false);
            grbBill.PerformLayout();
            grbOrder.ResumeLayout(false);
            grbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDelivery;
        private Label lblDeliveryName;
        private TextBox txtDeliveryName;
        private TextBox txtDeliveryPostal;
        private Label lblDeliveryPostal;
        private TextBox txtDeliveryAddress;
        private Label lblDeliveryAddress;
        private TextBox txtDeliveryTel;
        private Label lblDeliveryTel;
        private GroupBox grbBillType;
        private ComboBox cbxBillType;
        private GroupBox grbDeadLine;
        private DateTimePicker dtpDeadLine;
        private GroupBox grbBill;
        private TextBox txtBillTel;
        private Label lblBillTel;
        private TextBox txtBillPostal;
        private Label lblBillPostal;
        private TextBox txtBillAddress;
        private Label lblBillAddress;
        private Label lblBillName;
        private TextBox txtBillName;
        private GroupBox grbOrder;
        private Label lblItem1;
        private ComboBox cbxItem1;
        private Label lblItemColumn1;
        private NumericUpDown nudItem1;
        private Label lblOrderCntColumn1;
        private NumericUpDown nudItem3;
        private NumericUpDown nudItem2;
        private Label lblItem3;
        private Label lblItem2;
        private ComboBox cbxItem3;
        private ComboBox cbxItem2;
        private NumericUpDown nudItem5;
        private NumericUpDown nudItem4;
        private Label lblItem5;
        private Label lblItem4;
        private ComboBox cbxItem5;
        private ComboBox cbxItem4;
        private NumericUpDown nudItem10;
        private NumericUpDown nudItem8;
        private NumericUpDown nudItem9;
        private NumericUpDown nudItem7;
        private NumericUpDown nudItem6;
        private Label lblItem10;
        private Label label17;
        private Label lblOrderCntColumn2;
        private Label lblItem9;
        private Label lblItem7;
        private ComboBox cbxItem10;
        private ComboBox cbxItem8;
        private ComboBox cbxItem9;
        private Label lblItemColumn2;
        private ComboBox cbxItem7;
        private Label lblItem6;
        private ComboBox cbxItem6;
        private Button btnOrder;
    }
}
