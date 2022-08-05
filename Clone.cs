using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
    public object Clone()
    {
        // Obtenermos una copia superficial del objeto actual
        object copia = this.MemberwiseClone();

        // Recorremos las propiedades del objeto buscando elementos clonables.
        // En caso de encontrar un objeto clonable, realizamos una copia de dicho elemento
        var propiedadesClonables = this.GetType().GetProperties().Where(p => p.PropertyType.GetInterfaces().Contains(typeof(ICloneable)));
    foreach (var propiedad in propiedadesClonables)
    {
        // Obtenemos el nombre de la propiedad (p.e. "TipoRueda")
        var nombrePropiedad = propiedad.Name;

        // Localizamos el método Clone() de la propiedad (TipoRueda.Clone()) y lo
        // invocamos mediante reflection, almacenando el objeto resultante en una variable
        MethodInfo metodoClone = propiedad.PropertyType.GetMethod("Clone");
        var objetoCopia = metodoClone.Invoke(propiedad.GetValue(copia), null);

        // Obtenemos una referencia a la propiedad del objeto clonado (Vehiculo2.TipoRueda)
        PropertyInfo referenciaCopia = this.GetType().GetProperty(nombrePropiedad, BindingFlags.Public | BindingFlags.Instance);

        // Asignamos el valor del objeto clonado a la referencia (Vehiculo2.TipoRueda = Rueda2)
        referenciaCopia.SetValue(copia, objetoCopia, null);
    }
 
    return copia;
}