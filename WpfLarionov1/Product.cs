using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLarionov1
{
    public class Product : IProduct
    {
        public string Name { get; set; } // Делаем явные реализации, чтобы не было конфликтов и тем самым сохраняем контракт с вышеуказанным интерфейсом, не забываем за инкапсуляцию
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price:C}"; // Как будет отображаться наш товар в отладке
        }
    }
}
