namespace SportingMall
{
    partial class LOGIN
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
            components = new System.ComponentModel.Container();
            lblMemberCode = new Label();
            txtMemberCode = new TextBox();
            lblPassWord = new Label();
            txtPassWord = new TextBox();
            btnLogin = new Button();
            timerEmptyCheck = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblMemberCode
            // 
            lblMemberCode.AutoSize = true;
            lblMemberCode.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblMemberCode.ForeColor = Color.Navy;
            lblMemberCode.Location = new Point(65, 45);
            lblMemberCode.Name = "lblMemberCode";
            lblMemberCode.Size = new Size(55, 15);
            lblMemberCode.TabIndex = 0;
            lblMemberCode.Text = "会員番号";
            // 
            // txtMemberCode
            // 
            txtMemberCode.ImeMode = ImeMode.Disable;
            txtMemberCode.Location = new Point(65, 62);
            txtMemberCode.Margin = new Padding(3, 2, 3, 2);
            txtMemberCode.MaxLength = 8;
            txtMemberCode.Name = "txtMemberCode";
            txtMemberCode.Size = new Size(250, 23);
            txtMemberCode.TabIndex = 1;
            txtMemberCode.KeyPress += NumericalInputControl;
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblPassWord.ForeColor = Color.Navy;
            lblPassWord.Location = new Point(65, 114);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(52, 15);
            lblPassWord.TabIndex = 2;
            lblPassWord.Text = "パスワード";
            // 
            // txtPassWord
            // 
            txtPassWord.ImeMode = ImeMode.Disable;
            txtPassWord.Location = new Point(65, 138);
            txtPassWord.Margin = new Padding(3, 2, 3, 2);
            txtPassWord.MaxLength = 10;
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(250, 23);
            txtPassWord.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SlateGray;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Enabled = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(65, 211);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ログイン";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // timerEmptyCheck
            // 
            timerEmptyCheck.Interval = 500;
            timerEmptyCheck.Tick += timerEmptyCheck_Tick;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(384, 311);
            Controls.Add(btnLogin);
            Controls.Add(txtPassWord);
            Controls.Add(lblPassWord);
            Controls.Add(txtMemberCode);
            Controls.Add(lblMemberCode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ログイン画面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMemberCode;
        private TextBox txtMemberCode;
        private Label lblPassWord;
        private TextBox txtPassWord;
        private Button btnLogin;
        private System.Windows.Forms.Timer timerEmptyCheck;
    }
}
