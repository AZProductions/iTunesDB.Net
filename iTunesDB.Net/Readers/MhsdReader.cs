﻿using System;
using System.IO;
using iTunesDB.Net.Database;
using iTunesDB.Net.Enumerations;

namespace iTunesDB.Net.Readers
{
    internal class MhsdReader : iTunesReader
    {
        public override string ObjectID { get { return "mhsd"; } }
        public override string[] ChildIDs { get { return new string[] { "mhlt", "mhlp" }; } }
        public override Type DatabaseType { get { return typeof(ListContainer); } }

        protected override bool ParseiTunesObject(BinaryReader Reader)
        {
            var listContainer = (ListContainer)DbObject;
            var db = (iTunesDb)ParentDbObject;

            listContainer.ListType = ReadEnum<ListTypes>(Reader);
            db.ListContainers.Add(listContainer);
            return true;
        }
    }
}
