using examination.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace examination.实现
{
    class _带简答题的试卷 : _试卷, 有简答题的
    {
        public float 简答题分值 { set => throw new NotImplementedException(); }

        public float 改简答题(string userAnswer)
        {
            throw new NotImplementedException();
        }
    }
}
