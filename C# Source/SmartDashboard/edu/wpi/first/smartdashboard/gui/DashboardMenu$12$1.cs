// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu$12$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardMenu$12", "menuSelected", "(Ljavax.swing.event.MenuEvent;)V")]
  [SourceFile("DashboardMenu.java")]
  [Modifiers]
  [Serializable]
  internal sealed class DashboardMenu\u002412\u00241 : AbstractAction
  {
    [Modifiers]
    internal string val\u0024field;
    [Modifiers]
    internal DashboardMenu\u002412 this\u00241;

    [LineNumberTable((ushort) 206)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu\u002412\u00241([In] DashboardMenu\u002412 obj0, [In] string obj1, [In] string obj2)
    {
      base.\u002Ector(obj1);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DashboardMenu\u002412\u00241([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 94, (byte) 127, (byte) 4})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      MainPanel mainPanel = this.this\u00241.val\u0024mainPanel;
      MainPanel.getPanel("SmartDashboard").addField(this.val\u0024field);
    }
  }
}
