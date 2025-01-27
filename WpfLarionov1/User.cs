using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Тут происходит то же самое что и в другом классе (ну а как иначе будет)

namespace WpfLarionov1
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
