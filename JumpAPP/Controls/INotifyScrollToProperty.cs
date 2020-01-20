﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JumpAPP.Controls
{
    public interface INotifyScrollToProperty
    {
        event ScrollToPropertyHandler ScrollToProperty;
    }

    public delegate void ScrollToPropertyHandler(string PropertyName);
}
