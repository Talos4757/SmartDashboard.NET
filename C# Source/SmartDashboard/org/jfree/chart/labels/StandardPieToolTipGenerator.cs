// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.StandardPieToolTipGenerator
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
  [Implements(new string[] {"org.jfree.chart.labels.PieToolTipGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardPieToolTipGenerator : AbstractPieItemLabelGenerator, PieToolTipGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 2995304200445733779L;
    public const string DEFAULT_TOOLTIP_FORMAT = "{0}: ({1}, {2})";
    [Obsolete]
    public const string DEFAULT_SECTION_LABEL_FORMAT = "{0} = {1}";

    [LineNumberTable(new byte[] {(byte) 59, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieToolTipGenerator(Locale locale)
      : this("{0}: ({1}, {2})", locale)
    {
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieToolTipGenerator()
      : this("{0}: ({1}, {2})")
    {
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieToolTipGenerator(string labelFormat)
      : this(labelFormat, Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 149})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieToolTipGenerator(string labelFormat, Locale locale)
      : this(labelFormat, NumberFormat.getNumberInstance(locale), NumberFormat.getPercentInstance(locale))
    {
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardPieToolTipGenerator(string labelFormat, NumberFormat numberFormat, NumberFormat percentFormat)
      : base(labelFormat, numberFormat, percentFormat)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardPieToolTipGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardPieToolTipGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardPieToolTipGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 158)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateToolTip(PieDataset dataset, IComparable key)
    {
      return this.generateSectionLabel(dataset, key);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 169)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
