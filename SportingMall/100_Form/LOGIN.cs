
namespace SportingMall
{
    public partial class LOGIN : Form
    {
        /// <summary>
        ///    �R���X�g���N�^
        /// </summary>
        public LOGIN()
        {
            InitializeComponent();

            //�����͍��ڊĎ��N��
            timerEmptyCheck.Start();
        }

        /// <summary>
        ///    ���O�C�����s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //DB�ڑ��p�N���X��p��
                SQLiteUtil sqlite = new SQLiteUtil();

                //���O�C���F�؎��{
                if (sqlite.Login(this.txtMemberCode.Text, this.txtPassWord.Text) == true)
                {
                    //���i�w����ʂ�\��
                    Form order = new ORDER();
                    order.ShowDialog();
                }
                else
                {
                    //�G���[���b�Z�[�W�\��
                    ErrorUtil.ShowError(MessageResource.ERR009);
                }
            }
            catch (Exception ex)
            {
                //��O�G���[����
                ErrorUtil.ExceptionError(ex);
            }
        }

        /// <summary>
        ///    �����͍��ڊĎ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEmptyCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                //�����͍��ڂ����݂���ꍇ�̓��O�C���{�^���𖳌���
                if (string.IsNullOrEmpty(this.txtMemberCode.Text) == true || string.IsNullOrEmpty(this.txtPassWord.Text) == true)
                {
                    this.btnLogin.Enabled = false;
                }
                else
                {
                    this.btnLogin.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                //��O�G���[����
                ErrorUtil.ExceptionError(ex);
            }
        }

        /// <summary>
        ///    ���l���͐���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericalInputControl(object sender, KeyPressEventArgs e)
        {
            //�o�b�N�X�y�[�X�ADelete�L�[�������ꂽ���͓��͗L��
            if (e.KeyChar.Equals('\b') == true)
            {
                return;
            }

            //���l0�`9�ȊO�������ꂽ���͓��͖���
            if (e.KeyChar < '0' == true || '9' < e.KeyChar == true)
            {
                e.Handled = true;
            }
        }
    }
}
