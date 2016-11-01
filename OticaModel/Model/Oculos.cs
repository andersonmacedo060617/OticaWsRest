using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OticaModel.Model
{
   public class Oculos
    {
        public virtual int Id { get; set; }
        public virtual String Lente { get; set; }
        public virtual decimal OlhoDireito { get; set; }
        public virtual decimal OlhoEsquerdo { get; set; }
        public virtual string Cor { get; set; }
        public virtual Grife Grife { get; set; }


    }
}
