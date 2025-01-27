using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLarionov1
{
    public interface IUser
    {
        // Этот интерфейс определяет какие будут свойства у тех классов, которые будут брать данный класс. А это значит что у классы будут иметь только два свойства - логин (username) и пароль соответственно
        string Username { get; set; }
        string Password { get; set; }
    }
}
