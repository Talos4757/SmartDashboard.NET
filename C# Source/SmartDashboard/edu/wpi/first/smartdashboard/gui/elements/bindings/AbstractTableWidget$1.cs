// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.bindings.AbstractTableWidget$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui.elements.bindings
{
  [InnerClass]
  [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.Widget$MultiTypeBindable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.bindings.AbstractTableWidget", "getTableEntryBindable", "(Ljava.lang.String;)Ledu.wpi.first.smartdashboard.gui.Widget$MultiTypeBindable;")]
  [SourceFile("AbstractTableWidget.java")]
  [Modifiers]
  internal sealed class AbstractTableWidget\u00241 : Object, Widget.MultiTypeBindable, BooleanBindable, NumberBindable, StringBindable
  {
    [Modifiers]
    internal string val\u0024key;
    [Modifiers]
    internal AbstractTableWidget this\u00240;

    [LineNumberTable((ushort) 96)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal AbstractTableWidget\u00241([In] AbstractTableWidget obj0, [In] string obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 118, (byte) 162, (byte) 109, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBindableValue([In] bool obj0)
    {
      int num = obj0 ? 1 : 0;
      if (this.this\u00240.table == null)
        return;
      this.this\u00240.table.putBoolean(this.val\u0024key, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 54, (byte) 109, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBindableValue([In] double obj0)
    {
      if (this.this\u00240.table == null)
        return;
      this.this\u00240.table.putNumber(this.val\u0024key, obj0);
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 109, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBindableValue([In] string obj0)
    {
      if (this.this\u00240.table == null)
        return;
      this.this\u00240.table.putString(this.val\u0024key, obj0);
    }
  }
}
