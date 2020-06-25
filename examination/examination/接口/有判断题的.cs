using System;
using System.Collections.Generic;
using System.Text;

namespace examination.接口
{
    interface 有判断题的
    {
        float 判断题分值
        {
            set;
        }
        float 改判断题(String userAnswer, String answer);
    }
}
