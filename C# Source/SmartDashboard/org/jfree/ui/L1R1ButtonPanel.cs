// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.L1R1ButtonPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Serializable]
  public class L1R1ButtonPanel : JPanel
  {
    private JButton left;
    private JButton right;

    [HideFromJava]
    static L1R1ButtonPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 136, (byte) 107, (byte) 108, (byte) 108, (byte) 113, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public L1R1ButtonPanel(string leftLabel, string rightLabel)
    {
      base.\u002Ector();
      L1R1ButtonPanel l1R1ButtonPanel = this;
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      this.left = new JButton(leftLabel);
      this.right = new JButton(rightLabel);
      ((Container) this).add((Component) this.left, (object) "West");
      ((Container) this).add((Component) this.right, (object) "East");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected L1R1ButtonPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual JButton getLeftButton()
    {
      return this.left;
    }

    public virtual JButton getRightButton()
    {
      return this.right;
    }
  }
}
