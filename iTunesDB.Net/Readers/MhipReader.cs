﻿using System;
using iTunesDB.Net.Database;

namespace iTunesDB.Net.Readers
{
    internal class MhipReader : iTunesReader
    {
        public override string ObjectID { get { return "mhip"; } }
        public override string[] ChildIDs { get { return new string[] { "mhod" }; } }
        public override Type DatabaseType { get { return typeof(MhipObject); } }
    }
}

