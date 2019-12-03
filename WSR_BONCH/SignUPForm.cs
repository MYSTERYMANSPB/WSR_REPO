using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSR_BONCH.Models;
using WSR_BONCH.Utils;

namespace WSR_BONCH
{
    public partial class SignUPForm : Form
    {
        private LogINForm m_logINForm;
        private User m_user;
        public SignUPForm(LogINForm logINForm)
        {
            InitializeComponent();
            this.m_logINForm = logINForm;
            m_user = new User();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_logINForm.Show();
        }

        private void BtnSignUP_Click(object sender, EventArgs e)
        {
            m_user.UserLogin = inpLogin.Text.ToString();
            m_user.UserPassword = inpPassword.Text.ToString();
            //Console.WriteLine(m_user.UserLogin);
            if (string.IsNullOrEmpty(m_user.UserLogin) || string.IsNullOrEmpty(m_user.UserPassword) || string.IsNullOrWhiteSpace(m_user.UserLogin) || string.IsNullOrWhiteSpace(m_user.UserPassword))
            {
                MessageBox.Show(Errors.errorText[(int)Errors.ErrorMssage.NO_INPUT_LOGIN_OR_PASSWORD], "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!m_user.CheckUserLogin())
            {
                MessageBox.Show(Errors.errorText[(int)Errors.ErrorMssage.WRONG_USER_LOGIN_FORMAT], "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!m_user.CheckUserPassword())
            {
                MessageBox.Show(Errors.errorText[(int)Errors.ErrorMssage.WRONG_USER_PASSWORD_FORMAT], "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
            if (!m_user.SignUPUser())
            {
                MessageBox.Show(Errors.errorText[(int)Errors.ErrorMssage.ERROR_CREATE_NEW_USER], "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Поздравляем! Вы успешно зарегистрировались в системе. Теперь вы можете авторизоваться.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
