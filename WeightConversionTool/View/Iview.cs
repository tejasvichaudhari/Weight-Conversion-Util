﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3
{
    public interface IView
    {
        String LabelWord { get; set; }
        String TextforWordRev { get; set; }
        String TextBoxRevWord { get; set; }

        String UnitTo { get; }
        String UnitFrom { get; }

    }
}
