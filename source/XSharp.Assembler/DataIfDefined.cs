﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XSharp.Assembler
{
    public class DataIfDefined: DataMember, IIfDefined {
        public DataIfDefined(string aSymbol)
            : base("define", new byte[0]) {
            Symbol = aSymbol;
        }

        public string Symbol {
            get;
            set;
        }

        public override void WriteText(XSharp.Assembler.Assembler aAssembler, System.IO.TextWriter aOutput)
        {
            aOutput.Write(this.GetAsText());
        }
    }
}