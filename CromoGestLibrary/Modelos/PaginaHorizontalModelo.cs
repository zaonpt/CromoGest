using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class PaginaHorizontalModelo : DynamicObject
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public int IdCaderneta { get; set; }

        private Dictionary<string, object> _properties;

        public PaginaHorizontalModelo() { }

        public PaginaHorizontalModelo(int id, string nome, int quantidade, int idCaderneta)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            IdCaderneta = idCaderneta;
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
            if (_properties.ContainsKey(binder.Name))
            {
                _properties[binder.Name] = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static class ExpandoObjectHelper
        {
            public static bool HasProperty(ExpandoObject obj, string propertyName)
            {
                return ((IDictionary<String, object>)obj).ContainsKey(propertyName);
            }
        }
    }
}
