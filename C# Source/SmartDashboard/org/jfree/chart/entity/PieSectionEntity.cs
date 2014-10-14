// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.PieSectionEntity
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.entity
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class PieSectionEntity : ChartEntity, Serializable.__Interface
  {
    private const long serialVersionUID = 9199892576531984162L;
    private PieDataset dataset;
    private int pieIndex;
    private int sectionIndex;
    private IComparable sectionKey;

    [LineNumberTable(new byte[] {(byte) 52, (byte) 109, (byte) 103, (byte) 103, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PieSectionEntity(Shape area, PieDataset dataset, int pieIndex, int sectionIndex, IComparable sectionKey, string toolTipText, string urlText)
      : base(area, toolTipText, urlText)
    {
      PieSectionEntity pieSectionEntity = this;
      this.dataset = dataset;
      this.pieIndex = pieIndex;
      this.sectionIndex = sectionIndex;
      this.sectionKey = sectionKey;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PieSectionEntity([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PieSectionEntity obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual PieDataset getDataset()
    {
      return this.dataset;
    }

    public virtual void setDataset(PieDataset dataset)
    {
      this.dataset = dataset;
    }

    public virtual int getPieIndex()
    {
      return this.pieIndex;
    }

    public virtual void setPieIndex(int index)
    {
      this.pieIndex = index;
    }

    public virtual int getSectionIndex()
    {
      return this.sectionIndex;
    }

    public virtual void setSectionIndex(int index)
    {
      this.sectionIndex = index;
    }

    public virtual IComparable getSectionKey()
    {
      return this.sectionKey;
    }

    public virtual void setSectionKey(IComparable key)
    {
      this.sectionKey = key;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 94, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is PieSectionEntity))
        return false;
      PieSectionEntity pieSectionEntity = (PieSectionEntity) obj;
      if (!ObjectUtilities.equal((object) this.dataset, (object) pieSectionEntity.dataset) || this.pieIndex != pieSectionEntity.pieIndex || (this.sectionIndex != pieSectionEntity.sectionIndex || !ObjectUtilities.equal((object) this.sectionKey, (object) pieSectionEntity.sectionKey)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 103, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(base.hashCode(), this.pieIndex), this.sectionIndex);
    }

    [LineNumberTable((ushort) 248)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return new StringBuffer().append("PieSection: ").append(this.pieIndex).append(", ").append(this.sectionIndex).append("(").append(Object.instancehelper_toString((object) this.sectionKey)).append(")").toString();
    }
  }
}
