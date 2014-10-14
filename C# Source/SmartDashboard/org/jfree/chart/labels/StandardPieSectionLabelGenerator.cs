// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.StandardPieSectionLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.PieSectionLabelGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardPieSectionLabelGenerator : AbstractPieItemLabelGenerator, PieSectionLabelGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 3064190563760203668L;
    public const string DEFAULT_SECTION_LABEL_FORMAT = "{0}";
    private ObjectList attributedLabels;

    [LineNumberTable(new byte[] {(byte) 54, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieSectionLabelGenerator(Locale locale)
      : this("{0}", locale)
    {
    }

    [LineNumberTable(new byte[] {(byte) 42, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieSectionLabelGenerator()
      : this("{0}", NumberFormat.getNumberInstance(), NumberFormat.getPercentInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieSectionLabelGenerator(string labelFormat, NumberFormat numberFormat, NumberFormat percentFormat)
      : base(labelFormat, numberFormat, percentFormat)
    {
      StandardPieSectionLabelGenerator sectionLabelGenerator = this;
      this.attributedLabels = new ObjectList();
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 149})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieSectionLabelGenerator(string labelFormat, Locale locale)
      : this(labelFormat, NumberFormat.getNumberInstance(locale), NumberFormat.getPercentInstance(locale))
    {
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieSectionLabelGenerator(string labelFormat)
      : this(labelFormat, NumberFormat.getNumberInstance(), NumberFormat.getPercentInstance())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardPieSectionLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardPieSectionLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardPieSectionLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 156)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AttributedString getAttributedLabel(int section)
    {
      return (AttributedString) this.attributedLabels.get(section);
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAttributedLabel(int section, AttributedString label)
    {
      this.attributedLabels.set(section, (object) label);
    }

    [LineNumberTable((ushort) 178)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string generateSectionLabel(PieDataset dataset, IComparable key)
    {
      return base.generateSectionLabel(dataset, key);
    }

    [LineNumberTable((ushort) 210)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AttributedString generateAttributedSectionLabel(PieDataset dataset, IComparable key)
    {
      return this.getAttributedLabel(dataset.getIndex(key));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 115, (byte) 130, (byte) 105, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || obj is StandardPieSectionLabelGenerator && this.attributedLabels.equals((object) ((StandardPieSectionLabelGenerator) obj).attributedLabels) && base.equals(obj);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 246)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
