using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurator.Tests
{
    public class SampleConfig : Config
    {
        public double DoubleConfig { get; set; }

        public int IntConfig { get; set; }

        public char CharConfig { get; set; }

        public string StringConfig { get; set; }
    }
}