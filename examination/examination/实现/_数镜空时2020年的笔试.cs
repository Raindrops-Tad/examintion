using examination.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace examination.实现
{
    class _数镜空时2020年的笔试 : _试卷, 有选择题的, 有填空题的, 有简答题的
    {
        protected 有选择题的 _选择题;
        protected 有填空题的 _填空题;
        protected 有简答题的 _简答题;

        public float 选择题分值 { set => _选择题.选择题分值 = 1; }
        public float 判断题分值 { set => _填空题.判断题分值 = 1; }
        public float 简答题分值 { set => _简答题.简答题分值 = 1; }

        public _数镜空时2020年的笔试(有选择题的 选择题, 有填空题的 填空题, 有简答题的 简答题)
        {
            _选择题 = 选择题;
            _填空题 = 填空题;
            _简答题 = 简答题;
        }

        public override string 名字()
        {
            return "数镜空时2020年的笔试";
        }

        public float 改选择题(string userAnswer, string answer)
        {
            return _选择题.改选择题(userAnswer, answer);
        }

        public float 改填空题(string userAnswer, string answer)
        {
            return _填空题.改填空题(userAnswer, answer);
        }

        public float 改简答题(string userAnswer)
        {
            return _简答题.改简答题(userAnswer);
        }
    }
}
