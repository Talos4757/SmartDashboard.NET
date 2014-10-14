// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ShapeList
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using org.jfree.io;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.util
{
  [Serializable]
  public class ShapeList : AbstractObjectList
  {
    [LineNumberTable(new byte[] {(byte) 13, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShapeList()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ShapeList([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 74)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Shape getShape(int index)
    {
      return (Shape) this.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShape(int index, Shape shape)
    {
      this.set(index, (object) shape);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 97)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 103, (byte) 102, (byte) 127, (byte) 0, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ShapeList))
        return false;
      ShapeList shapeList = (ShapeList) obj;
      int num = this.size();
      for (int index = 0; index < num; ++index)
      {
        if (!ShapeUtilities.equal((Shape) this.get(index), (Shape) shapeList.get(index)))
          return false;
      }
      return true;
    }

    [LineNumberTable((ushort) 132)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 94, (byte) 102, (byte) 103, (byte) 103, (byte) 102, (byte) 104, (byte) 99, (byte) 103, (byte) 169, (byte) 231, (byte) 57, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      int num = this.size();
      obj0.writeInt(num);
      for (int index = 0; index < num; ++index)
      {
        Shape shape = this.getShape(index);
        if (shape != null)
        {
          obj0.writeInt(index);
          SerialUtilities.writeShape(shape, obj0);
        }
        else
          obj0.writeInt(-1);
      }
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 120, (byte) 102, (byte) 103, (byte) 102, (byte) 103, (byte) 100, (byte) 237, (byte) 61, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      int num = obj0.readInt();
      for (int index1 = 0; index1 < num; ++index1)
      {
        int index2 = obj0.readInt();
        if (index2 != -1)
          this.setShape(index2, SerialUtilities.readShape(obj0));
      }
    }
  }
}
