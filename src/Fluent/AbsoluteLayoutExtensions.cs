﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class AbsoluteLayoutExtensions
    {
        public static AbsoluteLayout Children(this AbsoluteLayout layout, Func<AbsoluteLayout.IAbsoluteList<View>> views)
        {
            if (views is null)
                return layout;

            views.Invoke().ForEach(x => layout.Children.Add(x));
            return layout;
        }
    }
}