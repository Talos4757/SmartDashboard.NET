// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.BooleanProperty$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using javax.swing;
using javax.swing.table;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.properties
{
  [InnerClass]
  [Implements(new string[] {"javax.swing.table.TableCellRenderer"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.properties.BooleanProperty", null, null)]
  [SourceFile("BooleanProperty.java")]
  [Modifiers]
  internal sealed class BooleanProperty\u00241 : Object, TableCellRenderer
  {
    [Modifiers]
    internal BooleanProperty this\u00240;

    [LineNumberTable((ushort) 19)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BooleanProperty\u00241([In] BooleanProperty obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 21)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Component getTableCellRendererComponent([In] JTable obj0, [In] object obj1, [In] bool obj2, [In] bool obj3, [In] int obj4, [In] int obj5)
    {
      return (Component) BooleanProperty.access\u0024000(this.this\u00240);
    }
  }
}
