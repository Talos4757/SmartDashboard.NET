// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.L1R3ButtonPanel
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
  public class L1R3ButtonPanel : JPanel
  {
    private JButton left;
    private JButton right1;
    private JButton right2;
    private JButton right3;

    [HideFromJava]
    static L1R3ButtonPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 136, (byte) 171, (byte) 112, (byte) 112, (byte) 108, (byte) 108, (byte) 108, (byte) 173, (byte) 113, (byte) 113, (byte) 108, (byte) 113, (byte) 108, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public L1R3ButtonPanel(string label1, string label2, string label3, string label4)
    {
      base.\u002Ector();
      L1R3ButtonPanel l1R3ButtonPanel = this;
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new BorderLayout());
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel2 = new JPanel((LayoutManager) new BorderLayout());
      this.left = new JButton(label1);
      this.right1 = new JButton(label2);
      this.right2 = new JButton(label3);
      this.right3 = new JButton(label4);
      ((Container) jpanel1).add((Component) this.left, (object) "West");
      ((Container) jpanel2).add((Component) this.right1, (object) "East");
      ((Container) jpanel1).add((Component) jpanel2, (object) "Center");
      ((Container) jpanel1).add((Component) this.right2, (object) "East");
      ((Container) this).add((Component) jpanel1, (object) "Center");
      ((Container) this).add((Component) this.right3, (object) "East");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected L1R3ButtonPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
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

    public virtual JButton getRightButton1()
    {
      return this.right1;
    }

    public virtual JButton getRightButton2()
    {
      return this.right2;
    }

    public virtual JButton getRightButton3()
    {
      return this.right3;
    }
  }
}
