// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.CategoryTick
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Serializable]
  public class CategoryTick : Tick
  {
    private IComparable category;
    private TextBlock label;
    private TextBlockAnchor labelAnchor;

    [LineNumberTable(new byte[] {(byte) 28, (byte) 119, (byte) 103, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryTick(IComparable category, TextBlock label, TextBlockAnchor labelAnchor, TextAnchor rotationAnchor, double angle)
      : base("", TextAnchor.__\u003C\u003ECENTER, rotationAnchor, angle)
    {
      CategoryTick categoryTick = this;
      this.category = category;
      this.label = label;
      this.labelAnchor = labelAnchor;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryTick([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual IComparable getCategory()
    {
      return this.category;
    }

    public virtual TextBlock getLabel()
    {
      return this.label;
    }

    public virtual TextBlockAnchor getLabelAnchor()
    {
      return this.labelAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 100, (byte) 130, (byte) 113, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (this == obj)
        return true;
      if (!(obj is CategoryTick) || !base.equals(obj))
        return false;
      CategoryTick categoryTick = (CategoryTick) obj;
      return ObjectUtilities.equal((object) this.category, (object) categoryTick.category) && ObjectUtilities.equal((object) this.label, (object) categoryTick.label) && ObjectUtilities.equal((object) this.labelAnchor, (object) categoryTick.labelAnchor);
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 99, (byte) 113, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * (37 * (37 * 41 + Object.instancehelper_hashCode((object) this.category)) + this.label.hashCode()) + this.labelAnchor.hashCode();
    }
  }
}
