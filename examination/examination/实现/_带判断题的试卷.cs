using examination.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace examination.实现
{
    class _带判断题的试卷 : _试卷, 有判断题的
    {
        public float 判断题分值 { set => throw new NotImplementedException(); }

        public float 改判断题(string userAnswer, string answer)
        {
            throw new NotImplementedException();
        }
    }
}
