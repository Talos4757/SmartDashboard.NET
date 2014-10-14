// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.LookupPaintScale
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using java.util;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.renderer
{
  [Implements(new string[] {"org.jfree.chart.renderer.PaintScale", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class LookupPaintScale : Object, PaintScale, PublicCloneable, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = -5239384246251042006L;
    private double lowerBound;
    private double upperBound;
    [NonSerialized]
    private Paint defaultPaint;
    private List lookupTable;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 104, (byte) 102, (byte) 176, (byte) 99, (byte) 144, (byte) 105, (byte) 105, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LookupPaintScale(double lowerBound, double upperBound, Paint defaultPaint)
    {
      base.\u002Ector();
      LookupPaintScale lookupPaintScale = this;
      if (lowerBound >= upperBound)
      {
        string str = "Requires lowerBound < upperBound.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (defaultPaint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        this.defaultPaint = defaultPaint;
        this.lookupTable = (List) new ArrayList();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 67, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LookupPaintScale()
      : this(0.0, 1.0, (Paint) Color.lightGray)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LookupPaintScale([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LookupPaintScale obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LookupPaintScale obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 149, (byte) 105, (byte) 109, (byte) 100, (byte) 176, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double value, Paint paint)
    {
      LookupPaintScale.PaintItem paintItem = new LookupPaintScale.PaintItem(value, paint);
      int num = Collections.binarySearch(this.lookupTable, (object) paintItem);
      if (num >= 0)
        this.lookupTable.set(num, (object) paintItem);
      else
        this.lookupTable.add(-(num + 1), (object) paintItem);
    }

    public virtual Paint getDefaultPaint()
    {
      return this.defaultPaint;
    }

    public virtual double getLowerBound()
    {
      return this.lowerBound;
    }

    public virtual double getUpperBound()
    {
      return this.upperBound;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 135, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Number value, Paint paint)
    {
      this.add(value.doubleValue(), paint);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 171, (byte) 106, (byte) 135, (byte) 106, (byte) 167, (byte) 108, (byte) 99, (byte) 199, (byte) 114, (byte) 106, (byte) 199, (byte) 98, (byte) 110, (byte) 102, (byte) 103, (byte) 115, (byte) 106, (byte) 165, (byte) 131, (byte) 98, (byte) 100, (byte) 114, (byte) 106, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getPaint(double value)
    {
      if (value < this.lowerBound || value > this.upperBound || this.lookupTable.size() == 0)
        return this.defaultPaint;
      LookupPaintScale.PaintItem paintItem = (LookupPaintScale.PaintItem) this.lookupTable.get(0);
      if (value < paintItem.value)
        return this.defaultPaint;
      int num1 = 0;
      int num2 = this.lookupTable.size() - 1;
      while (num2 - num1 > 1)
      {
        int num3 = (num1 + num2) / 2;
        paintItem = (LookupPaintScale.PaintItem) this.lookupTable.get(num3);
        if (value >= paintItem.value)
          num1 = num3;
        else
          num2 = num3;
      }
      if (num2 > num1)
      {
        paintItem = (LookupPaintScale.PaintItem) this.lookupTable.get(num2);
        if (value < paintItem.value)
          paintItem = (LookupPaintScale.PaintItem) this.lookupTable.get(num1);
      }
      if (paintItem != null)
        return paintItem.paint;
      else
        return this.defaultPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 220, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LookupPaintScale))
        return false;
      LookupPaintScale lookupPaintScale = (LookupPaintScale) obj;
      return this.lowerBound == lookupPaintScale.lowerBound && this.upperBound == lookupPaintScale.upperBound && (PaintUtilities.equal(this.defaultPaint, lookupPaintScale.defaultPaint) && Object.instancehelper_equals((object) this.lookupTable, (object) lookupPaintScale.lookupTable));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      LookupPaintScale lookupPaintScale = (LookupPaintScale) base.clone();
      lookupPaintScale.lookupTable = (List) new ArrayList((Collection) this.lookupTable);
      return (object) lookupPaintScale;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 8, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.defaultPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 22, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.defaultPaint = SerialUtilities.readPaint(obj0);
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    [InnerClass]
    [Implements(new string[] {"java.lang.Comparable", "java.io.Serializable"})]
    [SourceFile("LookupPaintScale.java")]
    [Modifiers]
    [Serializable]
    internal sealed class PaintItem : Object, Comparable, Serializable.__Interface, ISerializable
    {
      internal const long serialVersionUID = 698920578512361570L;
      internal double value;
      [NonSerialized]
      internal Paint paint;

      [LineNumberTable(new byte[] {(byte) 39, (byte) 104, (byte) 105, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public PaintItem([In] double obj0, [In] Paint obj1)
      {
        base.\u002Ector();
        LookupPaintScale.PaintItem paintItem = this;
        this.value = obj0;
        this.paint = obj1;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected PaintItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector();
        Serialization.readObject((object) this, obj0);
      }

      [LineNumberTable(new byte[] {(byte) 48, (byte) 103, (byte) 103, (byte) 103, (byte) 100, (byte) 130, (byte) 100, (byte) 130})]
      public virtual int compareTo([In] object obj0)
      {
        LookupPaintScale.PaintItem paintItem = (LookupPaintScale.PaintItem) obj0;
        double num1 = this.value;
        double num2 = paintItem.value;
        if (num1 > num2)
          return 1;
        return num1 < num2 ? -1 : 0;
      }

      [LineNumberTable(new byte[] {(byte) 68, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool equals([In] object obj0)
      {
        if (obj0 == this)
          return true;
        if (!(obj0 is LookupPaintScale.PaintItem))
          return false;
        LookupPaintScale.PaintItem paintItem = (LookupPaintScale.PaintItem) obj0;
        return this.value == paintItem.value && PaintUtilities.equal(this.paint, paintItem.paint);
      }

      [Throws(new string[] {"java.io.IOException"})]
      [LineNumberTable(new byte[] {(byte) 92, (byte) 102, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void writeObject([In] ObjectOutputStream obj0)
      {
        obj0.defaultWriteObject();
        SerialUtilities.writePaint(this.paint, obj0);
      }

      [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
      [LineNumberTable(new byte[] {(byte) 106, (byte) 102, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void readObject([In] ObjectInputStream obj0)
      {
        obj0.defaultReadObject();
        this.paint = SerialUtilities.readPaint(obj0);
      }

      [HideFromJava]
      int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
      {
        return this.compareTo(obj0);
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
}
