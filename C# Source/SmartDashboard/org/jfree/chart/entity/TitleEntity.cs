// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.TitleEntity
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.title;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.entity
{
  [Serializable]
  public class TitleEntity : ChartEntity
  {
    private const long serialVersionUID = -4445994133561919083L;
    private Title title;

    [LineNumberTable(new byte[] {(byte) 37, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TitleEntity(Shape area, Title title, string toolTipText)
      : this(area, title, toolTipText, (string) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 108, (byte) 99, (byte) 176, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TitleEntity(Shape area, Title title, string toolTipText, string urlText)
      : base(area, toolTipText, urlText)
    {
      TitleEntity titleEntity = this;
      if (title == null)
      {
        string str = "Null 'title' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.title = title;
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TitleEntity(Shape area, Title title)
      : this(area, title, (string) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TitleEntity([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual Title getTitle()
    {
      return this.title;
    }

    [LineNumberTable(new byte[] {(byte) 75, (byte) 107, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      StringBuffer stringBuffer = new StringBuffer("TitleEntity: ");
      stringBuffer.append("tooltip = ");
      stringBuffer.append(this.getToolTipText());
      return stringBuffer.toString();
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TitleEntity))
        return false;
      TitleEntity titleEntity = (TitleEntity) obj;
      return Object.instancehelper_equals((object) this.getArea(), (object) titleEntity.getArea()) && ObjectUtilities.equal((object) this.getToolTipText(), (object) titleEntity.getToolTipText()) && (ObjectUtilities.equal((object) this.getURLText(), (object) titleEntity.getURLText()) && this.title.equals((object) titleEntity.title));
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 99, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(41, this.getToolTipText()), this.getURLText());
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 182)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.getArea(), obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.setArea(SerialUtilities.readShape(obj0));
    }
  }
}
