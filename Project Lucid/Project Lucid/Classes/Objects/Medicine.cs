using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Objects
{
    /// <summary>
    /// Medicine class, cannot be inherited
    /// </summary>
    internal sealed class Medicine : Item
    {
        internal Medicine(String Data) : base(Data)
        {
            //
        }
    }
}
