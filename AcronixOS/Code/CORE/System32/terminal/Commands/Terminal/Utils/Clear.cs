﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcronixOS.Code.CORE.terminal.Commands
{
    public class Clear : Command
    {
        public Clear()
        {
            this.Name = "CLEAR";
            this.Help = "Erases the terminal log";
        }

        public override void Execute(string line, string[] args)
        {
            Console.Clear();
        }
    }
}
