// Decompiled with JetBrains decompiler
// Type: org.jfree.util.StrokeList
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
  public class StrokeList : AbstractObjectList
  {
    [LineNumberTable(new byte[] {(byte) 13, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StrokeList()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StrokeList([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 74)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke getStroke(int index)
    {
      return (Stroke) this.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStroke(int index, Stroke stroke)
    {
      this.set(index, (object) stroke);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 95)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 99, (byte) 162, (byte) 100, (byte) 162, (byte) 104, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object o)
    {
      if (o == null)
        return false;
      if (o == this)
        return true;
      if (!(o is StrokeList))
        return false;
      return (base.equals(o) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 129)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 91, (byte) 102, (byte) 103, (byte) 103, (byte) 102, (byte) 104, (byte) 99, (byte) 103, (byte) 169, (byte) 231, (byte) 57, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      int num = this.size();
      obj0.writeInt(num);
      for (int index = 0; index < num; ++index)
      {
        Stroke stroke = this.getStroke(index);
        if (stroke != null)
        {
          obj0.writeInt(index);
          SerialUtilities.writeStroke(stroke, obj0);
        }
        else
          obj0.writeInt(-1);
      }
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 117, (byte) 102, (byte) 103, (byte) 102, (byte) 103, (byte) 100, (byte) 237, (byte) 61, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      int num = obj0.readInt();
      for (int index1 = 0; index1 < num; ++index1)
      {
        int index2 = obj0.readInt();
        if (index2 != -1)
          this.setStroke(index2, SerialUtilities.readStroke(obj0));
      }
    }
  }
}
