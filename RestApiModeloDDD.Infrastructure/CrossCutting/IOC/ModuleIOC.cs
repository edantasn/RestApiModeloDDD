﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}
