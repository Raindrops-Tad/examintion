using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examination.接口;

namespace examination.测试
{
    [TestFixture]
    class 有选择题的测试
    {
        [Inject]
        protected 有选择题的 _选择题;

        public float 改选择题(string userAnswer, string answer)
        {
            return _选择题.改选择题(userAnswer, answer);
        }

        [Test]
        public void 空白测试()
        {

        }
        
        public void 目测正确的测试()
        {
            float num = 1;
            _选择题.选择题分值 = num;
            float sum = 改选择题("a", "a");
            Assert.Greater(num, sum);
        }

        public void 模板(float num,string userAnswer,string answer)
        {
            _选择题.选择题分值 = num;
            float sum = 改选择题(userAnswer,answer);
            Assert.Greater(num, sum);
        }

        public void 测试()
        {
            模板(1,"a","a");
            模板(1, "b", "a");
            模板(1, "a", "b");
            模板(1, "a", "ab");
            模板(1, "a", "abc");
            模板(1, "ab", "ab");
            模板(1, "abc", "ab");
        }
    }
}
