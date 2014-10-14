// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.StrokeChooserPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Serializable]
  public class StrokeChooserPanel : JPanel
  {
    private JComboBox selector;

    [HideFromJava]
    static StrokeChooserPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 104, (byte) 203, (byte) 102, (byte) 103, (byte) 46, (byte) 166, (byte) 108, (byte) 113, (byte) 113, (byte) 141, (byte) 243, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StrokeChooserPanel(StrokeSample current, StrokeSample[] available)
    {
      base.\u002Ector();
      StrokeChooserPanel strokeChooserPanel = this;
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      DefaultComboBoxModel defaultComboBoxModel = new DefaultComboBoxModel();
      for (int index = 0; index < available.Length; ++index)
        defaultComboBoxModel.addElement((object) available[index].getStroke());
      this.selector = new JComboBox((ComboBoxModel) defaultComboBoxModel);
      this.selector.setSelectedItem((object) current.getStroke());
      this.selector.setRenderer((ListCellRenderer) new StrokeSample((Stroke) null));
      ((Container) this).add((Component) this.selector);
      this.selector.addActionListener((ActionListener) new StrokeChooserPanel\u00241(this));
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StrokeChooserPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    protected internal JComboBox getSelector()
    {
      return this.selector;
    }

    [LineNumberTable((ushort) 112)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke getSelectedStroke()
    {
      return (Stroke) this.selector.getSelectedItem();
    }
  }
}
