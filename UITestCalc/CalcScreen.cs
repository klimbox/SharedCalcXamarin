using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace UITestCalc
{
    public class CalcScreen : ICalcScreen
    {
        public Func<AppQuery, AppQuery> btn1 { get; } = c => c.Id("btnNum1");

        public Func<AppQuery, AppQuery> btn2 { get; } = c => c.Id("btnNum2");

        public Func<AppQuery, AppQuery> btn3 { get; } = c => c.Id("btnNum3");

        public Func<AppQuery, AppQuery> btn4 { get; } = c => c.Id("btnNum4");

        public Func<AppQuery, AppQuery> btn5 { get; } = c => c.Id("btnNum5");

        public Func<AppQuery, AppQuery> btn6 { get; } = c => c.Id("btnNum6");

        public Func<AppQuery, AppQuery> btn7 { get; } = c => c.Id("btnNum7");

        public Func<AppQuery, AppQuery> btn8 { get; } = c => c.Id("btnNum8");

        public Func<AppQuery, AppQuery> btn9 { get; } = c => c.Id("btnNum9");

        public Func<AppQuery, AppQuery> btn0 { get; } = c => c.Id("btnNum0");

        public Func<AppQuery, AppQuery> btnAdd { get; } = c => c.Id("btnPlus");

        public Func<AppQuery, AppQuery> btnSub { get; } = c => c.Id("btnMin");

        public Func<AppQuery, AppQuery> btnMul { get; } = c => c.Id("btnMul");

        public Func<AppQuery, AppQuery> btnDiv { get; } = c => c.Id("btnDiv");

        public Func<AppQuery, AppQuery> btnClean { get; } = c => c.Id("btnClear");

        public Func<AppQuery, AppQuery> btnCount { get; } = c => c.Id("btnCount");

        public Func<AppQuery, AppQuery> Screen { get; } = c => c.Id("tbScreen");
    }
}
