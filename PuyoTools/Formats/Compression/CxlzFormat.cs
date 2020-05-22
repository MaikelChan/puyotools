﻿using PuyoTools.Modules.Compression;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuyoTools.Formats.Compression
{
    /// <inheritdoc/>
    internal class CxlzFormat : ICompressionFormat
    {
        private CxlzFormat() { }

        /// <summary>
        /// Gets the current instance.
        /// </summary>
        internal static CxlzFormat Instance { get; } = new CxlzFormat();

        public string Name => "CXLZ";

        public CompressionBase GetCodec() => new CxlzCompression();

        public bool Identify(Stream source, string filename) => GetCodec().Is(source, filename);
    }
}
