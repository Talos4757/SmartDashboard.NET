// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ObjectTable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.util
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class ObjectTable : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -3968322452944912066L;
    private int rows;
    private int columns;
    [NonSerialized]
    private object[][] data;
    private int rowIncrement;
    private int columnIncrement;

    [LineNumberTable(new byte[] {(byte) 68, (byte) 104, (byte) 132, (byte) 176, (byte) 132, (byte) 176, (byte) 103, (byte) 103, (byte) 103, (byte) 135, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectTable(int rowIncrement, int colIncrement)
    {
      base.\u002Ector();
      ObjectTable objectTable = this;
      if (rowIncrement < 1)
      {
        string str = "Increment must be positive.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (colIncrement < 1)
      {
        string str = "Increment must be positive.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rows = 0;
        this.columns = 0;
        this.rowIncrement = rowIncrement;
        this.columnIncrement = colIncrement;
        this.data = new object[rowIncrement][];
      }
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectTable()
      : this(5, 5)
    {
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectTable(int increment)
      : this(increment, increment)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ObjectTable([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ObjectTable obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 170, (byte) 110, (byte) 181, (byte) 135})]
    protected internal virtual void ensureRowCapacity(int row)
    {
      if (row < this.data.Length)
        return;
      object[][] objArray = new object[row + this.rowIncrement][];
      ByteCodeHelper.arraycopy((object) this.data, 0, (object) objArray, 0, this.data.Length);
      this.data = objArray;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 73, (byte) 132, (byte) 159, (byte) 6, (byte) 132, (byte) 191, (byte) 6, (byte) 135, (byte) 105, (byte) 131, (byte) 148, (byte) 105, (byte) 98, (byte) 133, (byte) 110, (byte) 107, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ensureCapacity(int row, int column)
    {
      if (row < 0)
      {
        string str = new StringBuffer().append("Row is invalid. ").append(row).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IndexOutOfBoundsException(str);
      }
      else if (column < 0)
      {
        string str = new StringBuffer().append("Column is invalid. ").append(column).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IndexOutOfBoundsException(str);
      }
      else
      {
        this.ensureRowCapacity(row);
        object[] objArray1 = this.data[row];
        if (objArray1 == null)
        {
          object[] objArray2 = new object[Math.max(column + 1, this.columnIncrement)];
          this.data[row] = objArray2;
        }
        else
        {
          if (column < objArray1.Length)
            return;
          object[] objArray2 = new object[column + this.columnIncrement];
          ByteCodeHelper.arraycopy((object) objArray1, 0, (object) objArray2, 0, objArray1.Length);
          this.data[row] = objArray2;
        }
      }
    }

    public virtual int getRowCount()
    {
      return this.rows;
    }

    public virtual int getColumnCount()
    {
      return this.columns;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 132, (byte) 138, (byte) 105, (byte) 131, (byte) 130, (byte) 133, (byte) 164})]
    protected internal virtual object getObject(int row, int column)
    {
      if (row < this.data.Length)
      {
        object[] objArray = this.data[row];
        if (objArray == null)
          return (object) null;
        if (column < objArray.Length)
          return objArray[column];
      }
      return (object) null;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 13, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void writeSerializedData(ObjectOutputStream stream, object o)
    {
      stream.writeObject(o);
    }

    [Throws(new string[] {"java.lang.ClassNotFoundException", "java.io.IOException"})]
    [LineNumberTable((ushort) 427)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object readSerializedData(ObjectInputStream stream)
    {
      return stream.readObject();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 136, (byte) 107, (byte) 116, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setObject(int row, int column, object @object)
    {
      this.ensureCapacity(row, column);
      this.data[row][column] = @object;
      this.rows = Math.max(this.rows, row + 1);
      this.columns = Math.max(this.columns, column + 1);
    }

    public virtual int getColumnIncrement()
    {
      return this.columnIncrement;
    }

    public virtual int getRowIncrement()
    {
      return this.rowIncrement;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 177, (byte) 131, (byte) 162, (byte) 132, (byte) 162, (byte) 136, (byte) 162, (byte) 103, (byte) 142, (byte) 162, (byte) 142, (byte) 162, (byte) 139, (byte) 139, (byte) 183, (byte) 226, (byte) 59, (byte) 6, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      if (o == null)
        return false;
      if (this == o)
        return true;
      if (!(o is ObjectTable))
        return false;
      ObjectTable objectTable = (ObjectTable) o;
      if (this.getRowCount() != objectTable.getRowCount() || this.getColumnCount() != objectTable.getColumnCount())
        return false;
      for (int row = 0; row < this.getRowCount(); ++row)
      {
        for (int column = 0; column < this.getColumnCount(); ++column)
        {
          if (!ObjectUtilities.equal(this.getObject(row, column), objectTable.getObject(row, column)))
            return false;
        }
      }
      return true;
    }

    public virtual int hashCode()
    {
      return 29 * this.rows + this.columns;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 239, (byte) 102, (byte) 104, (byte) 103, (byte) 137, (byte) 105, (byte) 109, (byte) 131, (byte) 99, (byte) 103, (byte) 136, (byte) 11, (byte) 232, (byte) 56, (byte) 233, (byte) 78})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      int length1 = this.data.Length;
      obj0.writeInt(length1);
      for (int index1 = 0; index1 < length1; ++index1)
      {
        object[] objArray = this.data[index1];
        obj0.writeBoolean(objArray != null);
        if (objArray != null)
        {
          int length2 = objArray.Length;
          obj0.writeInt(length2);
          for (int index2 = 0; index2 < length2; ++index2)
            this.writeSerializedData(obj0, objArray[index2]);
        }
      }
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 26, (byte) 102, (byte) 103, (byte) 108, (byte) 134, (byte) 103, (byte) 131, (byte) 103, (byte) 104, (byte) 106, (byte) 136, (byte) 12, (byte) 232, (byte) 56, (byte) 233, (byte) 78})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      int length1 = obj0.readInt();
      this.data = new object[length1][];
      for (int index1 = 0; index1 < length1; ++index1)
      {
        if (obj0.readBoolean())
        {
          int length2 = obj0.readInt();
          object[] objArray = new object[length2];
          this.data[index1] = objArray;
          for (int index2 = 0; index2 < length2; ++index2)
            objArray[index2] = this.readSerializedData(obj0);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 103, (byte) 103, (byte) 140, (byte) 138, (byte) 238, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.rows = 0;
      this.columns = 0;
      for (int index = 0; index < this.data.Length; ++index)
      {
        if (this.data[index] != null)
          Arrays.fill(this.data[index], (object) null);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 84, (byte) 139, (byte) 16, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void copyColumn(int oldColumn, int newColumn)
    {
      for (int row = 0; row < this.getRowCount(); ++row)
        this.setObject(row, newColumn, this.getObject(row, oldColumn));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 99, (byte) 109, (byte) 105, (byte) 131, (byte) 105, (byte) 131, (byte) 135, (byte) 162, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void copyRow(int oldRow, int newRow)
    {
      this.ensureCapacity(newRow, this.getColumnCount());
      object[] objArray1 = this.data[oldRow];
      if (objArray1 == null)
      {
        object[] objArray2 = this.data[newRow];
        if (objArray2 == null)
          return;
        Arrays.fill(objArray2, (object) null);
      }
      else
        this.data[newRow] = (object[]) objArray1.Clone();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 123, (byte) 99, (byte) 139, (byte) 100, (byte) 171, (byte) 103, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setData(object[][] data, int colCount)
    {
      if (data == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else if (colCount < 0)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IndexOutOfBoundsException();
      }
      else
      {
        this.data = data;
        this.rows = data.Length;
        this.columns = colCount;
      }
    }

    protected internal virtual object[][] getData()
    {
      return this.data;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
