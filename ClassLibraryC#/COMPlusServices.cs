using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.EnterpriseServices;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ApplicationName("ComPlusExample")]
[assembly: AssemblyKeyFile("bin/ComPlusExample.snk")]
namespace ClassLibraryC_
{
    [ComVisible(true)]
    [Transaction(TransactionOption.Required)]
    public class COMPlusServices : ServicedComponent
    {

        public COMPlusServices() : base() { 
    
        }

        [AutoComplete()]
        public string DoTransaction()
        {
            return "COM+ funciona correctamente";
        }

    }
}
