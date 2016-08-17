using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_SET.Animals.Domain
{
    /// <summary>
    /// for Mammal animals
    /// </summary>
    interface IMammal
    {
        string VertebrateType { get; }    // spine or bones
        int NbOfBreasts { get; }  

        string FeedOffSpring();
    }
}
