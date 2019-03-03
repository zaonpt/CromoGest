using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{


    public class CadernetaHorizontalModelo : DynamicObject
    {
        public int Id;

        public string Nome;

        public int QuantidadeCromos;

        public int QuantidadeCromosCarteira;

        public decimal CustoCarteira;



        public List<string> Paginas { get; set; } = new List<string>();

        private Dictionary<string, List<CromoModelo>> _properties;

        public CadernetaHorizontalModelo()
        {

        }

        /// <summary>
        /// Retorna a quantidade de cromos que existem por pagina
        /// </summary>
        public int Count { get { return _properties.Count; } }


        /// <summary>
        /// Metodo chamado quando se tenta aceder a uma property que nao existe. Cria uma nova.
        /// </summary>
        /// <param name="binder">categoria do cromo</param>
        /// <param name="value">Lista de Cromos dessa pagina</param>
        /// <returns>Adicao com sucesso</returns>
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (_properties.ContainsKey(binder.Name))
            {
                result = _properties[binder.Name];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Metodo chamado quando se tenta aceder a uma property que nao existe. Cria uma nova.
        /// </summary>
        /// <param name="binder">categoria do cromo (lugar na pagina)</param>
        /// <param name="value">Cromo</param>
        /// <returns>Adicao com sucesso</returns>
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (_properties.ContainsKey(binder.Name) && value.GetType().Equals(typeof(List<CromoModelo>)))
            {
                _properties[binder.Name] = (List<CromoModelo>)value;
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
