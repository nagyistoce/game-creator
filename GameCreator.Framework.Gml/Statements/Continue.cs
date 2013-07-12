﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameCreator.Framework.Gml
{
    class Continue : Statement
    {
        public Continue(int l, int c) : base(l, c) { }

        public override string ToString()
        {
            return "continue";
        }

        public override StatementKind Kind
        {
            get { return StatementKind.Continue; }
        }
    }
}