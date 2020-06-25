using System;
using System.Collections.Generic;
using System.Text;

namespace examination.接口
{
    interface 有简答题的
    {
        float 简答题分值
        {

            set;
        }
        float 改简答题(String userAnswer);
    }
}
