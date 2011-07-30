﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HBaseNet
{
    public class HBaseDatabase : IDisposable
    {
        public HBaseDatabase(IHBaseConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection", "A connection is required.");
            }

            if (!connection.IsOpen)
            {
                connection.Open();
            }

            Connection = connection;
        }

        public IHBaseConnection Connection { get; set; }

        public IList<IHBaseTable> GetTables()
        {
            return Connection.GetTables().Select(t => (IHBaseTable)new HBaseTable(t)).ToList();
        }

        public void Close()
        {
            Connection.Close();
        }

        public void Dispose()
        {
            this.Connection.Dispose();
        }
    }
}