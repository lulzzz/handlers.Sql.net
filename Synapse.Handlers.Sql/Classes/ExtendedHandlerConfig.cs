﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

using Synapse.Core;

using YamlDotNet.Serialization;

using Synapse.Core.Utilities;

namespace Synapse.Handlers.Sql
{
    public class ExtendedHandlerConfig : HandlerConfig
    {
        [XmlElement]
        public string User { get; set; }
        [XmlElement]
        public string Password { get; set; }
        [XmlElement]
        public string DataSource { get; set; }
    }

}
