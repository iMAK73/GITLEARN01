using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_git_learn01
{
    interface INTF_sample
    {
        Int32 Id { get;}
        String Name { get; set; }
        void Method1();
        void Method2(Int32 param);
    }

    interface INTF_sample2
    {
        void Method_is2(String param);
        void Method2_is2();

    }
}
