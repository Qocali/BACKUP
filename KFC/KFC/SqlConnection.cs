﻿using System;

namespace KFC
{
    internal class SqlConnection
    {
        private string v;

        public SqlConnection(string v)
        {
            this.v = v;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}