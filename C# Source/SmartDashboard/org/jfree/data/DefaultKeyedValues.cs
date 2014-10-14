// Decompiled with JetBrains decompiler
// Type: org.jfree.data.DefaultKeyedValues
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
  [Implements(new string[] {"org.jfree.data.KeyedValues", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class DefaultKeyedValues : Object, KeyedValues, Values, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 8468154364608194797L;
    private ArrayList keys;
    private ArrayList values;
    private HashMap indexMap;

    [LineNumberTable(new byte[] {(byte) 47, (byte) 104, (byte) 107, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultKeyedValues()
    {
      base.\u002Ector();
      DefaultKeyedValues defaultKeyedValues = this;
      this.keys = new ArrayList();
      this.values = new ArrayList();
      this.indexMap = new HashMap();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultKeyedValues([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultKeyedValues obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DefaultKeyedValues obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 94, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addValue(IComparable key, Number value)
    {
      this.setValue(key, value);
    }

    [LineNumberTable(new byte[] {(byte) 99, (byte) 99, (byte) 144, (byte) 114, (byte) 99, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getIndex(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Integer integer = (Integer) this.indexMap.get((object) key);
        if (integer == null)
          return -1;
        return integer.intValue();
      }
    }

    [LineNumberTable((ushort) 122)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int item)
    {
      return (Number) this.values.get(item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 114, (byte) 99, (byte) 144, (byte) 104, (byte) 100, (byte) 110, (byte) 176, (byte) 109, (byte) 109, (byte) 159, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(IComparable key, Number value)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int index = this.getIndex(key);
        if (index >= 0)
        {
          this.keys.set(index, (object) key);
          this.values.set(index, (object) value);
        }
        else
        {
          this.keys.add((object) key);
          this.values.add((object) value);
          HashMap hashMap = this.indexMap;
          IComparable comparable = key;
          Integer.__\u003Cclinit\u003E();
          Integer integer = new Integer(this.keys.size() - 1);
          hashMap.put((object) comparable, (object) integer);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 109, (byte) 144, (byte) 99, (byte) 144, (byte) 104, (byte) 100, (byte) 110, (byte) 176, (byte) 100, (byte) 109, (byte) 173, (byte) 109, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void insertValue(int position, IComparable key, Number value)
    {
      if (position < 0 || position > this.getItemCount())
      {
        string str = "'position' out of bounds.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int index = this.getIndex(key);
        if (index == position)
        {
          this.keys.set(index, (object) key);
          this.values.set(index, (object) value);
        }
        else
        {
          if (index >= 0)
          {
            this.keys.remove(index);
            this.values.remove(index);
          }
          this.keys.add(position, (object) key);
          this.values.add(position, (object) value);
          this.rebuildIndex();
        }
      }
    }

    [LineNumberTable((ushort) 109)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      return this.indexMap.size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 107, (byte) 112, (byte) 109, (byte) 19, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rebuildIndex()
    {
      this.indexMap.clear();
      for (int index = 0; index < this.keys.size(); ++index)
        this.indexMap.put(this.keys.get(index), (object) new Integer(index));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 201, (byte) 109, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeValue(int index)
    {
      this.keys.remove(index);
      this.values.remove(index);
      this.rebuildIndex();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 230, (byte) 107, (byte) 107, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.keys.clear();
      this.values.clear();
      this.indexMap.clear();
    }

    [LineNumberTable((ushort) 135)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getKey(int index)
    {
      return (IComparable) this.keys.get(index);
    }

    [LineNumberTable((ushort) 165)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getKeys()
    {
      return (List) this.keys.clone();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 104, (byte) 100, (byte) 159, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable key)
    {
      int index = this.getIndex(key);
      if (index < 0)
      {
        string message = new StringBuffer().append("Key not found: ").append((object) key).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
        return this.getValue(index);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 82, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addValue(IComparable key, double value)
    {
      this.addValue(key, (Number) new Double(value));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 104, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(IComparable key, double value)
    {
      this.setValue(key, (Number) new Double(value));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 141, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void insertValue(int position, IComparable key, double value)
    {
      this.insertValue(position, key, (Number) new Double(value));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 216, (byte) 104, (byte) 100, (byte) 191, (byte) 16, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeValue(IComparable key)
    {
      int index = this.getIndex(key);
      if (index < 0)
      {
        string message = new StringBuffer().append("The key (").append((object) key).append(") is not recognised.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
        this.removeValue(index);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 241, (byte) 108, (byte) 135, (byte) 102, (byte) 63, (byte) 11, (byte) 230, (byte) 69, (byte) 140, (byte) 103, (byte) 134, (byte) 105, (byte) 102, (byte) 20, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sortByKeys(SortOrder order)
    {
      int length = this.keys.size();
      DefaultKeyedValue[] defaultKeyedValueArray = new DefaultKeyedValue[length];
      for (int index = 0; index < length; ++index)
        defaultKeyedValueArray[index] = new DefaultKeyedValue((IComparable) this.keys.get(index), (Number) this.values.get(index));
      KeyedValueComparator keyedValueComparator = new KeyedValueComparator(KeyedValueComparatorType.__\u003C\u003EBY_KEY, order);
      Arrays.sort((object[]) defaultKeyedValueArray, (Comparator) keyedValueComparator);
      this.clear();
      for (int index = 0; index < defaultKeyedValueArray.Length; ++index)
      {
        DefaultKeyedValue defaultKeyedValue = defaultKeyedValueArray[index];
        this.addValue(defaultKeyedValue.getKey(), defaultKeyedValue.getValue());
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 12, (byte) 108, (byte) 103, (byte) 102, (byte) 63, (byte) 11, (byte) 230, (byte) 69, (byte) 140, (byte) 135, (byte) 102, (byte) 105, (byte) 102, (byte) 20, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sortByValues(SortOrder order)
    {
      int length = this.keys.size();
      DefaultKeyedValue[] defaultKeyedValueArray = new DefaultKeyedValue[length];
      for (int index = 0; index < length; ++index)
        defaultKeyedValueArray[index] = new DefaultKeyedValue((IComparable) this.keys.get(index), (Number) this.values.get(index));
      KeyedValueComparator keyedValueComparator = new KeyedValueComparator(KeyedValueComparatorType.__\u003C\u003EBY_VALUE, order);
      Arrays.sort((object[]) defaultKeyedValueArray, (Comparator) keyedValueComparator);
      this.clear();
      for (int index = 0; index < defaultKeyedValueArray.Length; ++index)
      {
        DefaultKeyedValue defaultKeyedValue = defaultKeyedValueArray[index];
        this.addValue(defaultKeyedValue.getKey(), defaultKeyedValue.getValue());
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 38, (byte) 100, (byte) 162, (byte) 104, (byte) 162, (byte) 103, (byte) 103, (byte) 105, (byte) 162, (byte) 105, (byte) 104, (byte) 105, (byte) 106, (byte) 130, (byte) 105, (byte) 105, (byte) 100, (byte) 100, (byte) 194, (byte) 107, (byte) 226, (byte) 49, (byte) 233, (byte) 83})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is KeyedValues))
        return false;
      KeyedValues keyedValues = (KeyedValues) obj;
      int itemCount = this.getItemCount();
      if (itemCount != keyedValues.getItemCount())
        return false;
      for (int index = 0; index < itemCount; ++index)
      {
        if (!Object.instancehelper_equals((object) this.getKey(index), (object) keyedValues.getKey(index)))
          return false;
        Number number1 = this.getValue(index);
        Number number2 = keyedValues.getValue(index);
        if (number1 == null)
        {
          if (number2 != null)
            return false;
        }
        else if (!Object.instancehelper_equals((object) number1, (object) number2))
          return false;
      }
      return true;
    }

    [LineNumberTable((ushort) 450)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.keys != null)
        return ((AbstractList) this.keys).hashCode();
      else
        return 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 108, (byte) 118, (byte) 118, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      DefaultKeyedValues defaultKeyedValues = (DefaultKeyedValues) base.clone();
      defaultKeyedValues.keys = (ArrayList) this.keys.clone();
      defaultKeyedValues.values = (ArrayList) this.values.clone();
      defaultKeyedValues.indexMap = (HashMap) this.indexMap.clone();
      return (object) defaultKeyedValues;
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
