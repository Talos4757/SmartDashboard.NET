// Decompiled with JetBrains decompiler
// Type: org.jfree.data.KeyedObjects2D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class KeyedObjects2D : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -1015873563138522374L;
    private List rowKeys;
    private List columnKeys;
    private List rows;

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 107, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyedObjects2D()
    {
      base.\u002Ector();
      KeyedObjects2D keyedObjects2D = this;
      this.rowKeys = (List) new ArrayList();
      this.columnKeys = (List) new ArrayList();
      this.rows = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected KeyedObjects2D([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] KeyedObjects2D obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] KeyedObjects2D obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 109, (byte) 100, (byte) 180, (byte) 109, (byte) 102, (byte) 141, (byte) 104, (byte) 109, (byte) 100, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setObject(object @object, IComparable rowKey, IComparable columnKey)
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
      else
      {
        int num = this.rowKeys.indexOf((object) rowKey);
        KeyedObjects keyedObjects;
        if (num >= 0)
        {
          keyedObjects = (KeyedObjects) this.rows.get(num);
        }
        else
        {
          this.rowKeys.add((object) rowKey);
          keyedObjects = new KeyedObjects();
          this.rows.add((object) keyedObjects);
        }
        keyedObjects.setObject(columnKey, @object);
        if (this.columnKeys.indexOf((object) columnKey) >= 0)
          return;
        this.columnKeys.add((object) columnKey);
      }
    }

    [LineNumberTable(new byte[] {(byte) 100, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowIndex(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return this.rowKeys.indexOf((object) key);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 99, (byte) 144})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 254, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRow(int rowIndex)
    {
      this.rowKeys.remove(rowIndex);
      this.rows.remove(rowIndex);
    }

    [LineNumberTable((ushort) 177)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getColumnKey(int column)
    {
      return (IComparable) this.columnKeys.get(column);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 104, (byte) 100, (byte) 191, (byte) 16, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 100, (byte) 135, (byte) 98, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeColumn(IComparable columnKey)
    {
      if (this.getColumnIndex(columnKey) < 0)
      {
        string message = new StringBuffer().append("Column key (").append((object) columnKey).append(") not recognised.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
      {
        Iterator iterator = this.rows.iterator();
        while (iterator.hasNext())
        {
          KeyedObjects keyedObjects = (KeyedObjects) iterator.next();
          int index = keyedObjects.getIndex(columnKey);
          if (index >= 0)
            keyedObjects.removeValue(index);
        }
        this.columnKeys.remove((object) columnKey);
      }
    }

    [LineNumberTable((ushort) 164)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getRowKeys()
    {
      return Collections.unmodifiableList(this.rowKeys);
    }

    [LineNumberTable((ushort) 205)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getColumnKeys()
    {
      return Collections.unmodifiableList(this.columnKeys);
    }

    [LineNumberTable((ushort) 87)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.rowKeys.size();
    }

    [LineNumberTable((ushort) 98)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnCount()
    {
      return this.columnKeys.size();
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 98, (byte) 114, (byte) 99, (byte) 114, (byte) 99, (byte) 104, (byte) 100, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getObject(int row, int column)
    {
      object obj = (object) null;
      KeyedObjects keyedObjects = (KeyedObjects) this.rows.get(row);
      if (keyedObjects != null)
      {
        IComparable key = (IComparable) this.columnKeys.get(column);
        if (key != null && keyedObjects.getIndex(key) >= 0)
          obj = keyedObjects.getObject(key);
      }
      return obj;
    }

    [LineNumberTable((ushort) 136)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getRowKey(int row)
    {
      return (IComparable) this.rowKeys.get(row);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 109, (byte) 100, (byte) 191, (byte) 16, (byte) 109, (byte) 100, (byte) 191, (byte) 16, (byte) 114, (byte) 104, (byte) 100, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getObject(IComparable rowKey, IComparable columnKey)
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
      else
      {
        int num = this.rowKeys.indexOf((object) rowKey);
        if (num < 0)
        {
          string message = new StringBuffer().append("Row key (").append((object) rowKey).append(") not recognised.").toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new UnknownKeyException(message);
        }
        else if (this.columnKeys.indexOf((object) columnKey) < 0)
        {
          string message = new StringBuffer().append("Column key (").append((object) columnKey).append(") not recognised.").toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new UnknownKeyException(message);
        }
        else
        {
          KeyedObjects keyedObjects = (KeyedObjects) this.rows.get(num);
          int index = keyedObjects.getIndex(columnKey);
          if (index < 0)
            return (object) null;
          return keyedObjects.getObject(index);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 143, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addObject(object @object, IComparable rowKey, IComparable columnKey)
    {
      this.setObject(@object, rowKey, columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 104, (byte) 100, (byte) 191, (byte) 16, (byte) 104, (byte) 100, (byte) 191, (byte) 16, (byte) 169, (byte) 98, (byte) 146, (byte) 145, (byte) 106, (byte) 98, (byte) 226, (byte) 61, (byte) 232, (byte) 71, (byte) 99, (byte) 109, (byte) 205, (byte) 130, (byte) 150, (byte) 115, (byte) 105, (byte) 111, (byte) 98, (byte) 226, (byte) 59, (byte) 232, (byte) 73, (byte) 99, (byte) 150, (byte) 115, (byte) 105, (byte) 101, (byte) 232, (byte) 60, (byte) 232, (byte) 71, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeObject(IComparable rowKey, IComparable columnKey)
    {
      int rowIndex = this.getRowIndex(rowKey);
      if (rowIndex < 0)
      {
        string message = new StringBuffer().append("Row key (").append((object) rowKey).append(") not recognised.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else if (this.getColumnIndex(columnKey) < 0)
      {
        string message = new StringBuffer().append("Column key (").append((object) columnKey).append(") not recognised.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
      {
        this.setObject((object) null, rowKey, columnKey);
        int num1 = 1;
        KeyedObjects keyedObjects1 = (KeyedObjects) this.rows.get(rowIndex);
        int num2 = 0;
        for (int itemCount = keyedObjects1.getItemCount(); num2 < itemCount; ++num2)
        {
          if (keyedObjects1.getObject(num2) != null)
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
          KeyedObjects keyedObjects2 = (KeyedObjects) this.rows.get(num4);
          int index2 = keyedObjects2.getIndex(columnKey);
          if (index2 >= 0 && keyedObjects2.getObject(index2) != null)
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
          KeyedObjects keyedObjects2 = (KeyedObjects) this.rows.get(num5);
          int index2 = keyedObjects2.getIndex(columnKey);
          if (index2 >= 0)
            keyedObjects2.removeValue(index2);
        }
        this.columnKeys.remove((object) columnKey);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 12, (byte) 104, (byte) 100, (byte) 191, (byte) 16, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRow(IComparable rowKey)
    {
      int rowIndex = this.getRowIndex(rowKey);
      if (rowIndex < 0)
      {
        string message = new StringBuffer().append("Row key (").append((object) rowKey).append(") not recognised.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
        this.removeRow(rowIndex);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 28, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeColumn(int columnIndex)
    {
      this.removeColumn(this.getColumnKey(columnIndex));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 64, (byte) 107, (byte) 107, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.rowKeys.clear();
      this.columnKeys.clear();
      this.rows.clear();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 77, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 103, (byte) 105, (byte) 130, (byte) 103, (byte) 105, (byte) 130, (byte) 105, (byte) 104, (byte) 107, (byte) 107, (byte) 100, (byte) 100, (byte) 194, (byte) 107, (byte) 226, (byte) 54, (byte) 40, (byte) 233, (byte) 80})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is KeyedObjects2D))
        return false;
      KeyedObjects2D keyedObjects2D = (KeyedObjects2D) obj;
      if (!Object.instancehelper_equals((object) this.getRowKeys(), (object) keyedObjects2D.getRowKeys()) || !Object.instancehelper_equals((object) this.getColumnKeys(), (object) keyedObjects2D.getColumnKeys()))
        return false;
      int rowCount = this.getRowCount();
      if (rowCount != keyedObjects2D.getRowCount())
        return false;
      int columnCount = this.getColumnCount();
      if (columnCount != keyedObjects2D.getColumnCount())
        return false;
      for (int row = 0; row < rowCount; ++row)
      {
        for (int column = 0; column < columnCount; ++column)
        {
          object object1 = this.getObject(row, column);
          object object2 = keyedObjects2D.getObject(row, column);
          if (object1 == null)
          {
            if (object2 != null)
              return false;
          }
          else if (!Object.instancehelper_equals(object1, object2))
            return false;
        }
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 125, (byte) 108, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * (29 * Object.instancehelper_hashCode((object) this.rowKeys) + Object.instancehelper_hashCode((object) this.columnKeys)) + Object.instancehelper_hashCode((object) this.rows);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 140, (byte) 108, (byte) 113, (byte) 113, (byte) 118, (byte) 108, (byte) 104, (byte) 108, (byte) 114, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      KeyedObjects2D keyedObjects2D = (KeyedObjects2D) base.clone();
      keyedObjects2D.columnKeys = (List) new ArrayList((Collection) this.columnKeys);
      keyedObjects2D.rowKeys = (List) new ArrayList((Collection) this.rowKeys);
      keyedObjects2D.rows = (List) new ArrayList(this.rows.size());
      Iterator iterator = this.rows.iterator();
      while (iterator.hasNext())
      {
        KeyedObjects keyedObjects = (KeyedObjects) iterator.next();
        keyedObjects2D.rows.add(keyedObjects.clone());
      }
      return (object) keyedObjects2D;
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
