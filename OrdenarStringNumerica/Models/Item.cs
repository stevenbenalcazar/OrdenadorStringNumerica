using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarStringNumerica.Models
{
    public class Item : BaseModel
    {
        public override string ToString()
        {
            return $"Id: {Id} \nNome: {Nome} \n";
        }
    }
}
