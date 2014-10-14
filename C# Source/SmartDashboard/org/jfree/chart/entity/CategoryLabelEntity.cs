// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.CategoryLabelEntity
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using org.jfree.chart;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.entity
{
  [Serializable]
  public class CategoryLabelEntity : TickLabelEntity
  {
    private IComparable key;

    [LineNumberTable(new byte[] {(byte) 20, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryLabelEntity(IComparable key, Shape area, string toolTipText, string urlText)
      : base(area, toolTipText, urlText)
    {
      CategoryLabelEntity categoryLabelEntity = this;
      this.key = key;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryLabelEntity([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual IComparable getKey()
    {
      return this.key;
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CategoryLabelEntity) || !ObjectUtilities.equal((object) this.key, (object) ((CategoryLabelEntity) obj).key))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(base.hashCode(), this.key);
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 107, (byte) 108, (byte) 109, (byte) 127, (byte) 7, (byte) 127, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      StringBuffer stringBuffer = new StringBuffer("CategoryLabelEntity: ");
      stringBuffer.append("category=");
      stringBuffer.append((object) this.key);
      stringBuffer.append(new StringBuffer().append(", tooltip=").append(this.getToolTipText()).toString());
      stringBuffer.append(new StringBuffer().append(", url=").append(this.getURLText()).toString());
      return stringBuffer.toString();
    }
  }
}
