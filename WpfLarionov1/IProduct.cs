using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// В это интерфейсе у всех классов, которые будут брать этот интерфейс, будет два свойства - имя (или же название, как удобно говорить) продукта и его же цена

namespace WpfLarionov1
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }
}
