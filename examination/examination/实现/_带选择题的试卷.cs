using examination.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace examination.实现
{
    class _带选择题的试卷 : _试卷, 有选择题的
    {
        public float 选择题分值 { set => throw new NotImplementedException(); }

        public float 改选择题(string userAnswer, string answer)
        {
            throw new NotImplementedException();
        }
    }
}
