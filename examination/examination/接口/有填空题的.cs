using System;
using System.Collections.Generic;
using System.Text;

namespace examination.接口
{
    interface 有填空题的
    {
        float 判断题分值
        {
            set;
        }
        float 改填空题(String userAnswer, String answer);
    }
}
