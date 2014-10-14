// Decompiled with JetBrains decompiler
// Type: org.jfree.data.KeyedValueComparator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.data
{
  [Implements(new string[] {"java.util.Comparator"})]
  public class KeyedValueComparator : Object, Comparator
  {
    private KeyedValueComparatorType type;
    private SortOrder order;

    [LineNumberTable(new byte[] {(byte) 19, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyedValueComparator(KeyedValueComparatorType type, SortOrder order)
    {
      base.\u002Ector();
      KeyedValueComparator keyedValueComparator = this;
      if (order == null)
      {
        string str = "Null 'order' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.type = type;
        this.order = order;
      }
    }

    public virtual KeyedValueComparatorType getType()
    {
      return this.type;
    }

    public virtual SortOrder getOrder()
    {
      return this.order;
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 99, (byte) 130, (byte) 99, (byte) 226, (byte) 69, (byte) 103, (byte) 135, (byte) 109, (byte) 114, (byte) 151, (byte) 114, (byte) 183, (byte) 176, (byte) 112, (byte) 103, (byte) 104, (byte) 100, (byte) 130, (byte) 99, (byte) 130, (byte) 105, (byte) 106, (byte) 114, (byte) 102, (byte) 135, (byte) 102, (byte) 164, (byte) 164, (byte) 114, (byte) 102, (byte) 132, (byte) 102, (byte) 164, (byte) 196, (byte) 144, (byte) 130, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compare(object o1, object o2)
    {
      if (o2 == null)
        return -1;
      if (o1 == null)
        return 1;
      KeyedValue keyedValue1 = (KeyedValue) o1;
      KeyedValue keyedValue2 = (KeyedValue) o2;
      if (this.type == KeyedValueComparatorType.__\u003C\u003EBY_KEY)
      {
        if (this.order.equals((object) SortOrder.__\u003C\u003EASCENDING))
          return Comparable.__Helper.compareTo(keyedValue1.getKey(), (object) keyedValue2.getKey());
        if (this.order.equals((object) SortOrder.__\u003C\u003EDESCENDING))
          return Comparable.__Helper.compareTo(keyedValue2.getKey(), (object) keyedValue1.getKey());
        string str = "Unrecognised sort order.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (this.type == KeyedValueComparatorType.__\u003C\u003EBY_VALUE)
      {
        Number number1 = keyedValue1.getValue();
        Number number2 = keyedValue2.getValue();
        if (number2 == null)
          return -1;
        if (number1 == null)
          return 1;
        double num1 = number1.doubleValue();
        double num2 = number2.doubleValue();
        if (this.order.equals((object) SortOrder.__\u003C\u003EASCENDING))
        {
          if (num1 > num2)
            return 1;
          return num1 < num2 ? -1 : 0;
        }
        else if (this.order.equals((object) SortOrder.__\u003C\u003EDESCENDING))
        {
          if (num1 > num2)
            return -1;
          return num1 < num2 ? 1 : 0;
        }
        else
        {
          string str = "Unrecognised sort order.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
      }
      else
      {
        string str = "Unrecognised type.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    [HideFromJava]
    bool Comparator.java\u002Eutil\u002EComparator\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029Zequals([In] object obj0)
    {
      return Object.instancehelper_equals((object) this, obj0);
    }
  }
}
