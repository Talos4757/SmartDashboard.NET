// Decompiled with JetBrains decompiler
// Type: org.jfree.util.PaintList
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
  public class PaintList : AbstractObjectList
  {
    [LineNumberTable(new byte[] {(byte) 14, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PaintList()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PaintList([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 75)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getPaint(int index)
    {
      return (Paint) this.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(int index, Paint paint)
    {
      this.set(index, (object) paint);
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 99, (byte) 130, (byte) 100, (byte) 130, (byte) 104, (byte) 103, (byte) 103, (byte) 102, (byte) 117, (byte) 2, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == null)
        return false;
      if (obj == this || !(obj is PaintList))
        return true;
      PaintList paintList = (PaintList) obj;
      int num = this.size();
      for (int index = 0; index < num; ++index)
      {
        if (!PaintUtilities.equal(this.getPaint(index), paintList.getPaint(index)))
          return false;
      }
      return true;
    }

    [LineNumberTable((ushort) 120)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 82, (byte) 102, (byte) 103, (byte) 103, (byte) 102, (byte) 104, (byte) 99, (byte) 103, (byte) 169, (byte) 231, (byte) 57, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      int num = this.size();
      obj0.writeInt(num);
      for (int index = 0; index < num; ++index)
      {
        Paint paint = this.getPaint(index);
        if (paint != null)
        {
          obj0.writeInt(index);
          SerialUtilities.writePaint(paint, obj0);
        }
        else
          obj0.writeInt(-1);
      }
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 108, (byte) 102, (byte) 103, (byte) 102, (byte) 103, (byte) 100, (byte) 237, (byte) 61, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      int num = obj0.readInt();
      for (int index1 = 0; index1 < num; ++index1)
      {
        int index2 = obj0.readInt();
        if (index2 != -1)
          this.setPaint(index2, SerialUtilities.readPaint(obj0));
      }
    }
  }
}
