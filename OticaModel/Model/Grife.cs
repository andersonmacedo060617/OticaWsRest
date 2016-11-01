using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OticaModel.Model
{
    public class Grife
    {
        public virtual int Id { get; set; }
        public virtual String Descricao{ get; set; }
        public virtual double Preco { get; set; }
        public virtual IList<Oculos> LstOculos { get; set; }

        public Grife()
        {
            this.LstOculos = new List<Oculos>();
        }
        
    }
}
