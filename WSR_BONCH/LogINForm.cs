using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSR_BONCH.Utils;
using WSR_BONCH.Models;

namespace WSR_BONCH
{
    public partial class LogINForm : Form
    {
        private SignUPForm m_signUPForm;
        private User m_user;
        public LogINForm()
        {
            InitializeComponent();
            m_signUPForm = new SignUPForm(this);
            m_user = new User();
        }

        private void BtnLogIN_Click(object sender, EventArgs e)
        {
            m_user.UserLogin = inpLogin.Text.ToString();
            m_user.UserPassword = inpPassword.Text.ToString();
            if (string.IsNullOrEmpty(m_user.UserLogin) || string.IsNullOrEmpty(m_user.UserPassword) || string.IsNullOrWhiteSpace(m_user.UserLogin) || string.IsNullOrWhiteSpace(m_user.UserPassword))
            {
                MessageBox.Show(Errors.errorText[(int)Errors.ErrorMssage.NO_INPUT_LOGIN_OR_PASSWORD], "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!m_user.LogINUser())
            {
                MessageBox.Show(Errors.errorText[(int)Errors.ErrorMssage.ERROR_LOGIN_IN_SYSTEM], "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

            }
        }

        private void BtnSingUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_signUPForm.Show();
        }

        private void LogINForm_Load(object sender, EventArgs e)
        {

        }
    }
}
