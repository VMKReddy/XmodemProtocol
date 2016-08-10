﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XModemProtocol {
    /// <summary>
    /// The mode of the XModemCommunicator instance.
    /// </summary>
    public enum XModemMode {
        /// <summary>
        /// Have XModemCommunicator automatically select mode.
        /// </summary>
        Auto,
        /// <summary>
        /// Normal XModem mode.
        /// </summary>
        Checksum,
    }
}