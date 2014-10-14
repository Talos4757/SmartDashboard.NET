// Decompiled with JetBrains decompiler
// Type: org.jfree.data.DefaultKeyedValues2D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data
{
  [Implements(new string[] {"org.jfree.data.KeyedValues2D", "org.jfree.util.PublicCloneable", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class DefaultKeyedValues2D : Object, KeyedValues2D, Values2D, PublicCloneable, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -5514169970951994748L;
    private List rowKeys;
    private List columnKeys;
    private List rows;
    private bool sortRowKeys;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 117, (byte) 162, (byte) 104, (byte) 107, (byte) 107, (byte) 107, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultKeyedValues2D(bool sortRowKeys)
    {
      int num = sortRowKeys ? 1 : 0;
      base.\u002Ector();
      DefaultKeyedValues2D defaultKeyedValues2D = this;
      this.rowKeys = (List) new ArrayList();
      this.columnKeys = (List) new ArrayList();
      this.rows = (List) new ArrayList();
      this.sortRowKeys = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultKeyedValues2D()
      : this(false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultKeyedValues2D([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultKeyedValues2D obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DefaultKeyedValues2D obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 99, (byte) 144, (byte) 104, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowIndex(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (this.sortRowKeys)
        return Collections.binarySearch(this.rowKeys, (object) key);
      else
        return this.rowKeys.indexOf((object) key);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 136, (byte) 100, (byte) 180, (byte) 102, (byte) 104, (byte) 101, (byte) 109, (byte) 175, (byte) 109, (byte) 173, (byte) 136, (byte) 109, (byte) 100, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(Number value, IComparable rowKey, IComparable columnKey)
    {
      int rowIndex = this.getRowIndex(rowKey);
      DefaultKeyedValues defaultKeyedValues;
      if (rowIndex >= 0)
      {
        defaultKeyedValues = (DefaultKeyedValues) this.rows.get(rowIndex);
      }
      else
      {
        defaultKeyedValues = new DefaultKeyedValues();
        if (this.sortRowKeys)
        {
          int num = -rowIndex - 1;
          this.rowKeys.add(num, (object) rowKey);
          this.rows.add(num, (object) defaultKeyedValues);
        }
        else
        {
          this.rowKeys.add((object) rowKey);
          this.rows.add((object) defaultKeyedValues);
        }
      }
      defaultKeyedValues.setValue(columnKey, value);
      if (this.columnKeys.indexOf((object) columnKey) >= 0)
        return;
      this.columnKeys.add((object) columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRow(int rowIndex)
    {
      this.rowKeys.remove(rowIndex);
      this.rows.remove(rowIndex);
    }

    [LineNumberTable((ushort) 216)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getColumnKey(int column)
    {
      return (IComparable) this.columnKeys.get(column);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 97, (byte) 99, (byte) 144, (byte) 110, (byte) 159, (byte) 6, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 100, (byte) 135, (byte) 98, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeColumn(IComparable columnKey)
    {
      if (columnKey == null)
      {
        string str = "Null 'columnKey' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (!this.columnKeys.contains((object) columnKey))
      {
        string message = new StringBuffer().append("Unknown key: ").append((object) columnKey).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
      {
        Iterator iterator = this.rows.iterator();
        while (iterator.hasNext())
        {
          DefaultKeyedValues defaultKeyedValues = (DefaultKeyedValues) iterator.next();
          if (defaultKeyedValues.getIndex(columnKey) >= 0)
            defaultKeyedValues.removeValue(columnKey);
        }
        this.columnKeys.remove((object) columnKey);
      }
    }

    [LineNumberTable((ushort) 201)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getRowKeys()
    {
      return Collections.unmodifiableList(this.rowKeys);
    }

    [LineNumberTable((ushort) 244)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getColumnKeys()
    {
      return Collections.unmodifiableList(this.columnKeys);
    }

    [LineNumberTable((ushort) 118)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.rowKeys.size();
    }

    [LineNumberTable((ushort) 129)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnCount()
    {
      return this.columnKeys.size();
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 98, (byte) 114, (byte) 99, (byte) 178, (byte) 104, (byte) 100, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int row, int column)
    {
      Number number = (Number) null;
      DefaultKeyedValues defaultKeyedValues = (DefaultKeyedValues) this.rows.get(row);
      if (defaultKeyedValues != null)
      {
        IComparable key = (IComparable) this.columnKeys.get(column);
        int index = defaultKeyedValues.getIndex(key);
        if (index >= 0)
          number = defaultKeyedValues.getValue(index);
      }
      return number;
    }

    [LineNumberTable((ushort) 168)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getRowKey(int row)
    {
      return (IComparable) this.rowKeys.get(row);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 116, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnIndex(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return this.columnKeys.indexOf((object) key);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 147, (byte) 99, (byte) 144, (byte) 99, (byte) 208, (byte) 110, (byte) 255, (byte) 6, (byte) 71, (byte) 104, (byte) 100, (byte) 146, (byte) 104, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable rowKey, IComparable columnKey)
    {
      if (rowKey == null)
      {
        string str = "Null 'rowKey' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (columnKey == null)
      {
        string str = "Null 'columnKey' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (!this.columnKeys.contains((object) columnKey))
      {
        string message = new StringBuffer().append("Unrecognised columnKey: ").append((object) columnKey).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
      {
        int rowIndex = this.getRowIndex(rowKey);
        if (rowIndex >= 0)
        {
          DefaultKeyedValues defaultKeyedValues = (DefaultKeyedValues) this.rows.get(rowIndex);
          int index = defaultKeyedValues.getIndex(columnKey);
          if (index >= 0)
            return defaultKeyedValues.getValue(index);
          else
            return (Number) null;
        }
        else
        {
          string message = new StringBuffer().append("Unrecognised rowKey: ").append((object) rowKey).toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new UnknownKeyException(message);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 189, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addValue(Number value, IComparable rowKey, IComparable columnKey)
    {
      this.setValue(value, rowKey, columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 242, (byte) 169, (byte) 98, (byte) 104, (byte) 146, (byte) 143, (byte) 105, (byte) 98, (byte) 226, (byte) 61, (byte) 230, (byte) 71, (byte) 99, (byte) 109, (byte) 205, (byte) 162, (byte) 148, (byte) 114, (byte) 105, (byte) 111, (byte) 98, (byte) 226, (byte) 59, (byte) 230, (byte) 73, (byte) 99, (byte) 148, (byte) 114, (byte) 105, (byte) 101, (byte) 232, (byte) 60, (byte) 230, (byte) 71, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeValue(IComparable rowKey, IComparable columnKey)
    {
      this.setValue((Number) null, rowKey, columnKey);
      int num1 = 1;
      int rowIndex = this.getRowIndex(rowKey);
      DefaultKeyedValues defaultKeyedValues1 = (DefaultKeyedValues) this.rows.get(rowIndex);
      int num2 = 0;
      for (int itemCount = defaultKeyedValues1.getItemCount(); num2 < itemCount; ++num2)
      {
        if (defaultKeyedValues1.getValue(num2) != null)
        {
          num1 = 0;
          break;
        }
      }
      if (num1 != 0)
      {
        this.rowKeys.remove(rowIndex);
        this.rows.remove(rowIndex);
      }
      int num3 = 1;
      int num4 = 0;
      for (int index1 = this.rows.size(); num4 < index1; ++num4)
      {
        DefaultKeyedValues defaultKeyedValues2 = (DefaultKeyedValues) this.rows.get(num4);
        int index2 = defaultKeyedValues2.getIndex(columnKey);
        if (index2 >= 0 && defaultKeyedValues2.getValue(index2) != null)
        {
          num3 = 0;
          break;
        }
      }
      if (num3 == 0)
        return;
      int num5 = 0;
      for (int index1 = this.rows.size(); num5 < index1; ++num5)
      {
        DefaultKeyedValues defaultKeyedValues2 = (DefaultKeyedValues) this.rows.get(num5);
        int index2 = defaultKeyedValues2.getIndex(columnKey);
        if (index2 >= 0)
          defaultKeyedValues2.removeValue(index2);
      }
      this.columnKeys.remove((object) columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 58, (byte) 99, (byte) 144, (byte) 104, (byte) 100, (byte) 169, (byte) 159, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRow(IComparable rowKey)
    {
      if (rowKey == null)
      {
        string str = "Null 'rowKey' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int rowIndex = this.getRowIndex(rowKey);
        if (rowIndex >= 0)
        {
          this.removeRow(rowIndex);
        }
        else
        {
          string message = new StringBuffer().append("Unknown key: ").append((object) rowKey).toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new UnknownKeyException(message);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 79, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeColumn(int columnIndex)
    {
      this.removeColumn(this.getColumnKey(columnIndex));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 118, (byte) 107, (byte) 107, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.rowKeys.clear();
      this.columnKeys.clear();
      this.rows.clear();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 132, (byte) 99, (byte) 130, (byte) 100, (byte) 162, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 103, (byte) 105, (byte) 162, (byte) 103, (byte) 105, (byte) 162, (byte) 105, (byte) 104, (byte) 107, (byte) 107, (byte) 100, (byte) 100, (byte) 194, (byte) 107, (byte) 226, (byte) 54, (byte) 40, (byte) 233, (byte) 80})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      if (o == null)
        return false;
      if (o == this)
        return true;
      if (!(o is KeyedValues2D))
        return false;
      KeyedValues2D keyedValues2D = (KeyedValues2D) o;
      if (!Object.instancehelper_equals((object) this.getRowKeys(), (object) keyedValues2D.getRowKeys()) || !Object.instancehelper_equals((object) this.getColumnKeys(), (object) keyedValues2D.getColumnKeys()))
        return false;
      int rowCount = this.getRowCount();
      if (rowCount != keyedValues2D.getRowCount())
        return false;
      int columnCount = this.getColumnCount();
      if (columnCount != keyedValues2D.getColumnCount())
        return false;
      for (int index1 = 0; index1 < rowCount; ++index1)
      {
        for (int index2 = 0; index2 < columnCount; ++index2)
        {
          Number number1 = this.getValue(index1, index2);
          Number number2 = keyedValues2D.getValue(index1, index2);
          if (number1 == null)
          {
            if (number2 != null)
              return false;
          }
          else if (!Object.instancehelper_equals((object) number1, (object) number2))
            return false;
        }
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 185, (byte) 108, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * (29 * Object.instancehelper_hashCode((object) this.rowKeys) + Object.instancehelper_hashCode((object) this.columnKeys)) + Object.instancehelper_hashCode((object) this.rows);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 200, (byte) 172, (byte) 113, (byte) 177, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      DefaultKeyedValues2D defaultKeyedValues2D = (DefaultKeyedValues2D) base.clone();
      defaultKeyedValues2D.columnKeys = (List) new ArrayList((Collection) this.columnKeys);
      defaultKeyedValues2D.rowKeys = (List) new ArrayList((Collection) this.rowKeys);
      defaultKeyedValues2D.rows = (List) ObjectUtilities.deepClone((Collection) this.rows);
      return (object) defaultKeyedValues2D;
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
