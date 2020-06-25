using System;
using System.Collections.Generic;
using System.Text;

namespace examination.接口
{
    interface 有选择题的
    {
        float 选择题分值
        {
            set;
        }
        float 改选择题(String userAnswer, String answer);
    }
}
