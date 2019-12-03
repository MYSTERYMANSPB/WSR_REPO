using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_BONCH.Utils
{
    public class Errors
    {
        public enum ErrorMssage : byte
        {
            NO_INPUT_LOGIN_OR_PASSWORD = 0,
            WRONG_USER_LOGIN_FORMAT,
            WRONG_USER_PASSWORD_FORMAT,
            USER_LOGIN_IS_NOT_FREE,
            NO_DATABASE_CONNECTION,
            ERROR_CREATE_NEW_USER,
            ERROR_LOGIN_IN_SYSTEM
        };

        public static string[] errorText =
        {
            @"Поле ""Логин"" или ""Пароль"" не заполнено.",
            "Неверный формат логина. Логин может состоять из строчных и заглавных букв латинского алафавивта. Длина от 8 до 32 символов.",
            "Неверный формат пароля. Требуется: одна заглавная буква, одна строчная буква и одна цифра. Длина от 8 до 32 символов.",
            "Пользователь с таким логином уже зарегистрирован в системе",
            "Неудалось подключиться к базе данных. Работа приложения невозможна.",
            "Неудалось произвести регистрацию в системе",
            "Неудалось атворизоваться в системе"
        };
    }
}
