using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace UITestCalc
{
    public interface ICalcScreen
    {
        Func<AppQuery, AppQuery> btn1 { get; }
        Func<AppQuery, AppQuery> btn2 { get; }
        Func<AppQuery, AppQuery> btn3 { get; }
        Func<AppQuery, AppQuery> btn4 { get; }
        Func<AppQuery, AppQuery> btn5 { get; }
        Func<AppQuery, AppQuery> btn6 { get; }
        Func<AppQuery, AppQuery> btn7 { get; }
        Func<AppQuery, AppQuery> btn8 { get; }
        Func<AppQuery, AppQuery> btn9 { get; }
        Func<AppQuery, AppQuery> btn0 { get; }
        Func<AppQuery, AppQuery> btnAdd { get; }
        Func<AppQuery, AppQuery> btnSub { get; }
        Func<AppQuery, AppQuery> btnMul { get; }
        Func<AppQuery, AppQuery> btnDiv { get; }
        Func<AppQuery, AppQuery> btnClean { get; }
        Func<AppQuery, AppQuery> btnCount { get; }
        Func<AppQuery, AppQuery> Screen { get; }

    }
}
