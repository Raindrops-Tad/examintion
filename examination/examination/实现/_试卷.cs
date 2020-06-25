using examination.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace examination.实现
{
    class _试卷:试卷
    {
        public virtual string 名字()
        {
            return "试卷";
        }
    }
}
