using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLCNG.LogicLayer
{
    public static class ExtensionLogic
    {
        /// <summary>
        /// Verifica si la colección no es nula o vacia
        /// </summary>
        /// <typeparam name="T">Tipo de objeto que almacena la colección</typeparam>
        /// <param name="collection">Objeto de tipo IEnumerable</param>
        /// <returns></returns>
        public static bool NotNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return (collection != null && collection.Count() > 0);
        }

        public static string To_String(this object obj)
        {
            return (obj != null) ? obj.ToString() : "";
        }

        public static int To_Int(this string number)
        {

            return (!string.IsNullOrEmpty(number) && int.TryParse(number, out int res)) ? res : 0;
        }
    }


}
