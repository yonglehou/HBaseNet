/**
 * Autogenerated by Thrift Compiler (0.7.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Text;
using Thrift.Protocol;

namespace Thrift.HBase
{
    [Serializable]
    public class Mutation : TBase
    {
        public Isset __isset;
        private byte[] _column;
        private bool _isDelete;
        private byte[] _value;

        public Mutation()
        {
            this._isDelete = false;
        }

        public bool IsDelete
        {
            get { return this._isDelete; }
            set
            {
                this.__isset.isDelete = true;
                this._isDelete = value;
            }
        }

        public byte[] Column
        {
            get { return this._column; }
            set
            {
                this.__isset.column = true;
                this._column = value;
            }
        }

        public byte[] Value
        {
            get { return this._value; }
            set
            {
                this.__isset.value = true;
                this._value = value;
            }
        }

        #region TBase Members

        public void Read(TProtocol iprot)
        {
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == TType.Bool)
                        {
                            this.IsDelete = iprot.ReadBool();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 2:
                        if (field.Type == TType.String)
                        {
                            this.Column = iprot.ReadBinary();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 3:
                        if (field.Type == TType.String)
                        {
                            this.Value = iprot.ReadBinary();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    default:
                        TProtocolUtil.Skip(iprot, field.Type);
                        break;
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
        }

        public void Write(TProtocol oprot)
        {
            var struc = new TStruct("Mutation");
            oprot.WriteStructBegin(struc);
            var field = new TField();
            if (this.__isset.isDelete)
            {
                field.Name = "isDelete";
                field.Type = TType.Bool;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                oprot.WriteBool(this.IsDelete);
                oprot.WriteFieldEnd();
            }
            if (this.Column != null && this.__isset.column)
            {
                field.Name = "column";
                field.Type = TType.String;
                field.ID = 2;
                oprot.WriteFieldBegin(field);
                oprot.WriteBinary(this.Column);
                oprot.WriteFieldEnd();
            }
            if (this.Value != null && this.__isset.value)
            {
                field.Name = "value";
                field.Type = TType.String;
                field.ID = 3;
                oprot.WriteFieldBegin(field);
                oprot.WriteBinary(this.Value);
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        #endregion

        public override string ToString()
        {
            var sb = new StringBuilder("Mutation(");
            sb.Append("IsDelete: ");
            sb.Append(this.IsDelete);
            sb.Append(",Column: ");
            sb.Append(this.Column);
            sb.Append(",Value: ");
            sb.Append(this.Value);
            sb.Append(")");
            return sb.ToString();
        }

        #region Nested type: Isset

        [Serializable]
        public struct Isset
        {
            public bool column;
            public bool isDelete;
            public bool value;
        }

        #endregion
    }
}