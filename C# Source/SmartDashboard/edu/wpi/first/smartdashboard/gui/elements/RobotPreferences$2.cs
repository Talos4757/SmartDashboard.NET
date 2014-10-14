// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.RobotPreferences$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.RobotPreferences", "init", "()V")]
  [SourceFile("RobotPreferences.java")]
  [Modifiers]
  internal sealed class RobotPreferences\u00242 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal RobotPreferences this\u00240;

    [LineNumberTable((ushort) 45)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal RobotPreferences\u00242([In] RobotPreferences obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 114, (byte) 149, (byte) 127, (byte) 2, (byte) 99, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      if (RobotPreferences.access\u0024200(this.this\u00240).isEditing())
        ((CellEditor) RobotPreferences.access\u0024200(this.this\u00240).getCellEditor()).cancelCellEditing();
      Map.Entry row = RobotPreferences.access\u0024100(this.this\u00240).getRow(RobotPreferences.access\u0024200(this.this\u00240).getSelectedRow());
      if (row == null)
        return;
      RobotPreferences.access\u0024100(this.this\u00240).delete((string) row.getKey());
    }
  }
}
