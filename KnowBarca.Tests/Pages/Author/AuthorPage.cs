﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests.Pages
{
    public class AuthorPage : PageBase
    {
        public Func<AppQuery, AppQuery> AuthorPageId => (e) => e.Marked("AuthorPage");

        public void AuthorPageOpens()
        {
            WaitFor(AuthorPageId);
            Back();
        }
    }
}
