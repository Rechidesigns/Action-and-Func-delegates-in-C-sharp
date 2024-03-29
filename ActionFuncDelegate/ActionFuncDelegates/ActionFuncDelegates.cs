﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFuncDelegate.ActionFuncDelegates
{
    public class ActionFuncDelegates
    {

        public class ActionAndFucntionDelegate
        {
            public class DelegateResults
            {
                public int AddResult { get; set; }
                public int IncrementedNumber { get; set; }
            }

            public DelegateResults RunDelegate(int x, int y)
            {
                Func<int, int, int> add = (a, b) => a + b;
                var addResult = add(x, y);

                var number = 5;
                Action<int> increment = n => { number += n; };
                increment(10);

                return new DelegateResults
                {
                    AddResult = addResult,
                    IncrementedNumber = number
                };
            }
        }

    }
}







public class ActionAndFucntionDelegate
{
    public class DelegateResults
    {
        public int AddResult { get; set; }
        public int IncrementedNumber { get; set; }
    }

    public DelegateResults RunDelegate(int x, int y)
    {
        Func<int, int, int> add = (a, b) => a + b;
        var addResult = add(x, y);

        var number = 5;
        Action<int> increment = n => { number += n; };
        increment(10);

        return new DelegateResults
        {
            AddResult = addResult,
            IncrementedNumber = number
        };
    }
}
