using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests.Pages
{
    public class StadiumPage : PageBase
    {
        public Func<AppQuery, AppQuery> StadiumPageId => (e) => e.Marked("StadiumPage");

        public void StadiumPageOpens()
        {
            WaitFor(StadiumPageId);
            Back();
        }
    }
}
