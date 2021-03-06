// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 1.1.4322.2032
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

//
//This source code was auto-generated by MonoXSD
//



public class MonkeyDataSet : System.Data.DataSet, System.Xml.Serialization.IXmlSerializable
{
    public delegate void MonkeyTableRowChangedEventHandler(object o, MonkeyTableRowChangedEventArgs e);

    private MonkeyTableDataTable __tableMonkeyTable;

    public MonkeyDataSet()
    {
        InitializeClass();
        System.ComponentModel.CollectionChangeEventHandler handler = new System.ComponentModel.CollectionChangeEventHandler(new System.ComponentModel.CollectionChangeEventHandler(SchemaChanged));
        Tables.CollectionChanged += handler;
        Relations.CollectionChanged += handler;
    }

    protected MonkeyDataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx)
    {
        throw new System.NotImplementedException();
    }

    public virtual MonkeyTableDataTable MonkeyTable
    {
        get
        {
            return __tableMonkeyTable;
        }
    }

    public override System.Data.DataSet Clone()
    {
        MonkeyDataSet set = ((MonkeyDataSet)(base.Clone()));
        set.InitializeFields();
        return set;
    }

    protected override System.Xml.Schema.XmlSchema GetSchemaSerializable()
    {
        System.IO.StringWriter sw = new System.IO.StringWriter();
        WriteXmlSchema(sw);
        return System.Xml.Schema.XmlSchema.Read(new System.Xml.XmlTextReader(new System.IO.StringReader(sw.ToString())), null);
    }

    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
    {
        return GetSchemaSerializable();
    }

    internal void InitializeClass()
    {
        DataSetName = "MonkeyDataSet";
        Prefix = "";
        Namespace = "";
        Locale = new System.Globalization.CultureInfo("ja-JP");
        CaseSensitive = false;
        EnforceConstraints = true;
        __tableMonkeyTable = new MonkeyTableDataTable();
        Tables.Add(__tableMonkeyTable);
    }

    internal void InitializeFields()
    {
        __tableMonkeyTable.InitializeFields();
    }

    private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e)
    {
        if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove))
        {
            InitializeFields();
        }
    }

    public class MonkeyTableDataTable : System.Data.DataTable, System.Collections.IEnumerable
    {
        private System.Data.DataColumn __columnID;

        private System.Data.DataColumn __columnName;

        private System.Data.DataColumn __columnAge;

        private System.Data.DataColumn __columnExists;

        internal MonkeyTableDataTable() :
                base("MonkeyTable")
        {
            InitializeClass();
            InitializeFields();
        }

        internal MonkeyTableDataTable(System.Data.DataTable tableMonkeyTable) :
                base(tableMonkeyTable.TableName)
        {
            throw new System.NotImplementedException();
        }

        public virtual int Count
        {
            get
            {
                return Rows.Count;
            }
        }

        public virtual MonkeyTableRow this[int i]
        {
            get
            {
                return ((MonkeyTableRow)(Rows[i]));
            }
        }

        internal System.Data.DataColumn IDColumn
        {
            get
            {
                return __columnID;
            }
        }

        internal System.Data.DataColumn NameColumn
        {
            get
            {
                return __columnName;
            }
        }

        internal System.Data.DataColumn AgeColumn
        {
            get
            {
                return __columnAge;
            }
        }

        internal System.Data.DataColumn ExistsColumn
        {
            get
            {
                return __columnExists;
            }
        }

        public event MonkeyTableRowChangedEventHandler MonkeyTableRowChanging;

        public event MonkeyTableRowChangedEventHandler MonkeyTableRowChanged;

        public event MonkeyTableRowChangedEventHandler MonkeyTableRowDeleting;

        public event MonkeyTableRowChangedEventHandler MonkeyTableRowDeleted;

        private void InitializeClass()
        {
            Columns.Add(new System.Data.DataColumn("ID", typeof(System.Guid)));
            Columns.Add(new System.Data.DataColumn("Name", typeof(string)));
            Columns.Add(new System.Data.DataColumn("Age", typeof(int)));
            Columns.Add(new System.Data.DataColumn("Exists", typeof(bool)));
        }

        internal void InitializeFields()
        {
            __columnID = Columns["ID"];
            __columnName = Columns["Name"];
            __columnAge = Columns["Age"];
            __columnExists = Columns["Exists"];
        }

        public virtual System.Collections.IEnumerator GetEnumerator()
        {
            return Rows.GetEnumerator();
        }

        public override System.Data.DataTable Clone()
        {
            MonkeyTableDataTable t = ((MonkeyTableDataTable)(base.Clone()));
            t.InitializeFields();
            return t;
        }

        protected override System.Data.DataTable CreateInstance()
        {
            return new MonkeyTableDataTable();
        }

        public virtual void AddMonkeyTableRow(MonkeyTableRow row)
        {
            Rows.Add(row);
        }

        public virtual MonkeyTableRow AddMonkeyTableRow(System.Guid ID, string Name, int Age, bool Exists)
        {
            MonkeyTableRow row = NewMonkeyTableRow();
            row["ID"] = ID;
            row["Name"] = Name;
            row["Age"] = Age;
            row["Exists"] = Exists;
            Rows.Add(row);
            return row;
        }

        public virtual MonkeyTableRow NewMonkeyTableRow()
        {
            return ((MonkeyTableRow)(NewRow()));
        }

        protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder)
        {
            return new MonkeyTableRow(builder);
        }

        public virtual void RemoveMonkeyTableRow(MonkeyTableRow row)
        {
            Rows.Remove(row);
        }

        protected override System.Type GetRowType()
        {
            return typeof(MonkeyTableRow);
        }

        protected override void OnRowChanging(System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanging(e);
            if ((MonkeyTableRowChanging != null))
            {
                MonkeyTableRowChanging(this, new MonkeyTableRowChangedEventArgs(((MonkeyTableRow)(e.Row)), e.Action));
            }
        }

        protected override void OnRowChanged(System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowChanged(e);
            if ((MonkeyTableRowChanged != null))
            {
                MonkeyTableRowChanged(this, new MonkeyTableRowChangedEventArgs(((MonkeyTableRow)(e.Row)), e.Action));
            }
        }

        protected override void OnRowDeleting(System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleting(e);
            if ((MonkeyTableRowDeleting != null))
            {
                MonkeyTableRowDeleting(this, new MonkeyTableRowChangedEventArgs(((MonkeyTableRow)(e.Row)), e.Action));
            }
        }

        protected override void OnRowDeleted(System.Data.DataRowChangeEventArgs e)
        {
            base.OnRowDeleted(e);
            if ((MonkeyTableRowDeleted != null))
            {
                MonkeyTableRowDeleted(this, new MonkeyTableRowChangedEventArgs(((MonkeyTableRow)(e.Row)), e.Action));
            }
        }
    }

    public class MonkeyTableRow : System.Data.DataRow
    {
        private MonkeyTableDataTable _tableMonkeyTable;

        internal MonkeyTableRow(System.Data.DataRowBuilder builder) :
                base(builder)
        {
            _tableMonkeyTable = ((MonkeyTableDataTable)(Table));
        }

        public virtual System.Guid ID
        {
            get
            {
                object ret = this[_tableMonkeyTable.IDColumn];
                if ((ret == System.DBNull.Value))
                {
                    throw new System.Data.StrongTypingException("Cannot get strong typed value since it is DB null.", null);
                }
                else
                {
                    return ((System.Guid)(ret));
                }
            }
            set
            {
                this[_tableMonkeyTable.IDColumn] = value;
            }
        }

        public virtual string Name
        {
            get
            {
                object ret = this[_tableMonkeyTable.NameColumn];
                if ((ret == System.DBNull.Value))
                {
                    throw new System.Data.StrongTypingException("Cannot get strong typed value since it is DB null.", null);
                }
                else
                {
                    return ((string)(ret));
                }
            }
            set
            {
                this[_tableMonkeyTable.NameColumn] = value;
            }
        }

        public virtual int Age
        {
            get
            {
                object ret = this[_tableMonkeyTable.AgeColumn];
                if ((ret == System.DBNull.Value))
                {
                    throw new System.Data.StrongTypingException("Cannot get strong typed value since it is DB null.", null);
                }
                else
                {
                    return ((int)(ret));
                }
            }
            set
            {
                this[_tableMonkeyTable.AgeColumn] = value;
            }
        }

        public virtual bool Exists
        {
            get
            {
                object ret = this[_tableMonkeyTable.ExistsColumn];
                if ((ret == System.DBNull.Value))
                {
                    throw new System.Data.StrongTypingException("Cannot get strong typed value since it is DB null.", null);
                }
                else
                {
                    return ((bool)(ret));
                }
            }
            set
            {
                this[_tableMonkeyTable.ExistsColumn] = value;
            }
        }

        public virtual bool IsIDNull()
        {
            return IsNull(_tableMonkeyTable.IDColumn);
        }

        public virtual void SetIDNull()
        {
            this[_tableMonkeyTable.IDColumn] = System.DBNull.Value;
        }

        public virtual bool IsNameNull()
        {
            return IsNull(_tableMonkeyTable.NameColumn);
        }

        public virtual void SetNameNull()
        {
            this[_tableMonkeyTable.NameColumn] = System.DBNull.Value;
        }

        public virtual bool IsAgeNull()
        {
            return IsNull(_tableMonkeyTable.AgeColumn);
        }

        public virtual void SetAgeNull()
        {
            this[_tableMonkeyTable.AgeColumn] = System.DBNull.Value;
        }

        public virtual bool IsExistsNull()
        {
            return IsNull(_tableMonkeyTable.ExistsColumn);
        }

        public virtual void SetExistsNull()
        {
            this[_tableMonkeyTable.ExistsColumn] = System.DBNull.Value;
        }
    }

    public class MonkeyTableRowChangedEventArgs : System.EventArgs
    {
        private MonkeyTableRow _eventRow;

        private System.Data.DataRowAction _eventAction;

        public MonkeyTableRowChangedEventArgs(MonkeyTableRow r, System.Data.DataRowAction a)
        {
            _eventRow = r;
            _eventAction = a;
        }

        public MonkeyTableRow Row
        {
            get
            {
                return _eventRow;
            }
        }

        public System.Data.DataRowAction Action
        {
            get
            {
                return _eventAction;
            }
        }
    }
}
