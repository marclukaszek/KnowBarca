using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests.Pages
{
    public class AlertBox : PageBase
    {
        public Func<AppQuery, AppQuery> OKButton  => (e) => e.Marked("button2");

        public void PressOK()
        {
            WaitFor(OKButton);
            Tap(OKButton);
        }
    }

}
