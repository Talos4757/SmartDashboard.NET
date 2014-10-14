// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.ContributorsPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.util;
using javax.swing;
using javax.swing.table;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.about
{
  [Serializable]
  public class ContributorsPanel : JPanel
  {
    private JTable table;
    private TableModel model;

    [HideFromJava]
    static ContributorsPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 136, (byte) 107, (byte) 108, (byte) 118, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContributorsPanel(List contributors)
    {
      base.\u002Ector();
      ContributorsPanel contributorsPanel = this;
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      this.model = (TableModel) new ContributorsTableModel(contributors);
      JTable.__\u003Cclinit\u003E();
      this.table = new JTable(this.model);
      JScrollPane.__\u003Cclinit\u003E();
      ((Container) this).add((Component) new JScrollPane((Component) this.table));
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ContributorsPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }
  }
}
