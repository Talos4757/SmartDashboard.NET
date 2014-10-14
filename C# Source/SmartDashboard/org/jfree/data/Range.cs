// Decompiled with JetBrains decompiler
// Type: org.jfree.data.Range
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class Range : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -906333695431863380L;
    private double lower;
    private double upper;

    [Modifiers]
    [LineNumberTable(new byte[] {(byte) 36, (byte) 104, (byte) 102, (byte) 159, (byte) 24, (byte) 140, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Range(double lower, double upper)
    {
      base.\u002Ector();
      Range range = this;
      if (lower > upper)
      {
        string str = new StringBuffer().append("Range(double, double): require lower (").append(lower).append(") <= upper (").append(upper).append(").").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.lower = lower;
        this.upper = upper;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Range([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Range obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getLowerBound()
    {
      return this.lower;
    }

    public virtual double getLength()
    {
      return this.upper - this.lower;
    }

    public virtual double getUpperBound()
    {
      return this.upper;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 99, (byte) 144, (byte) 105, (byte) 112, (byte) 112, (byte) 100, (byte) 124, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range expand(Range range, double lowerMargin, double upperMargin)
    {
      if (range == null)
      {
        string str = "Null 'range' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double length = range.getLength();
        double lower = range.getLowerBound() - length * lowerMargin;
        double upper = range.getUpperBound() + length * upperMargin;
        if (lower > upper)
        {
          lower = lower / 2.0 + upper / 2.0;
          upper = lower;
        }
        return new Range(lower, upper);
      }
    }

    public virtual double getCentralValue()
    {
      return this.lower / 2.0 + this.upper / 2.0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 2, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (!(obj is Range))
        return false;
      Range range = (Range) obj;
      return this.lower == range.lower && this.upper == range.upper;
    }

    public virtual bool contains(double value)
    {
      return value >= this.lower && value <= this.upper;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 99, (byte) 106, (byte) 106, (byte) 137, (byte) 106, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double constrain(double value)
    {
      double num = value;
      if (!this.contains(value))
      {
        if (value > this.upper)
          num = this.upper;
        else if (value < this.lower)
          num = this.lower;
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 65, (byte) 66, (byte) 99, (byte) 144, (byte) 99, (byte) 222})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range shift(Range @base, double delta, bool allowZeroCrossing)
    {
      int num = allowZeroCrossing ? 1 : 0;
      if (@base == null)
      {
        string str = "Null 'base' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (num != 0)
        return new Range(@base.getLowerBound() + delta, @base.getUpperBound() + delta);
      else
        return new Range(Range.shiftWithNoZeroCrossing(@base.getLowerBound(), delta), Range.shiftWithNoZeroCrossing(@base.getUpperBound(), delta));
    }

    [LineNumberTable((ushort) 292)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range shift(Range @base, double delta)
    {
      return Range.shift(@base, delta, false);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 99, (byte) 162, (byte) 99, (byte) 162, (byte) 150, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range combine(Range range1, Range range2)
    {
      if (range1 == null)
        return range2;
      if (range2 == null)
        return range1;
      return new Range(Math.min(range1.getLowerBound(), range2.getLowerBound()), Math.max(range1.getUpperBound(), range2.getUpperBound()));
    }

    public virtual bool intersects(double b0, double b1)
    {
      if (b0 <= this.lower)
        return b1 > this.lower;
      return b0 < this.upper && b1 >= b0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 129, (byte) 99, (byte) 140, (byte) 107, (byte) 145, (byte) 107, (byte) 177})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range expandToInclude(Range range, double value)
    {
      if (range == null)
        return new Range(value, value);
      else if (value < range.getLowerBound())
      {
        return new Range(value, range.getUpperBound());
      }
      else
      {
        if (value <= range.getUpperBound())
          return range;
        return new Range(range.getLowerBound(), value);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 218, (byte) 105, (byte) 148, (byte) 105, (byte) 180})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double shiftWithNoZeroCrossing([In] double obj0, [In] double obj1)
    {
      if (obj0 > 0.0)
      {
        return Math.max(obj0 + obj1, 0.0);
      }
      else
      {
        if (obj0 >= 0.0)
          return obj0 + obj1;
        return Math.min(obj0 + obj1, 0.0);
      }
    }

    [LineNumberTable((ushort) 173)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool intersects(Range range)
    {
      return (this.intersects(range.getLowerBound(), range.getUpperBound()) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 240, (byte) 99, (byte) 144, (byte) 105, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range scale(Range @base, double factor)
    {
      if (@base == null)
      {
        string str = "Null 'base' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (factor < 0.0)
      {
        string str = "Negative 'factor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return new Range(@base.getLowerBound() * factor, @base.getUpperBound() * factor);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 23, (byte) 108, (byte) 104, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      long num1 = Double.doubleToLongBits(this.lower);
      int num2 = (int) (num1 ^ (long) ((ulong) num1 >> 32));
      long num3 = Double.doubleToLongBits(this.upper);
      return 29 * num2 + (int) (num3 ^ (long) ((ulong) num3 >> 32));
    }

    [LineNumberTable((ushort) 407)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("Range[").append(this.lower).append(",").append(this.upper).append("]").toString();
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
