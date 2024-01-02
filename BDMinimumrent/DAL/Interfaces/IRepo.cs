﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DAL.Interfaces
    {
        public interface IRepo<Type, ID, RET>
        {
            RET Create(Type obj);
            List<Type> Read();
            Type Read(ID obj);
            RET Update(Type obj);
            bool Delete(ID id);
        }
    }
}
