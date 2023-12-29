using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID,RET>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RET Insert(CLASS obj);
        RET Update(CLASS obj);
        RET Delete(ID id);
    }
}
