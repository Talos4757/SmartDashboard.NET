// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.editor.PaletteChooserPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using javax.swing;
using org.jfree.chart.plot;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.editor
{
  [Obsolete]
  [Modifiers]
  [Serializable]
  internal sealed class PaletteChooserPanel : JPanel
  {
    private JComboBox selector;

    [HideFromJava]
    static PaletteChooserPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 107, (byte) 108, (byte) 108, (byte) 122, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PaletteChooserPanel([In] PaletteSample obj0, [In] PaletteSample[] obj1)
    {
      base.\u002Ector();
      PaletteChooserPanel paletteChooserPanel = this;
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      this.selector = new JComboBox((object[]) obj1);
      this.selector.setSelectedItem((object) obj0);
      JComboBox jcomboBox = this.selector;
      PaletteSample.__\u003Cclinit\u003E();
      PaletteSample paletteSample = new PaletteSample((ColorPalette) new RainbowPalette());
      jcomboBox.setRenderer((ListCellRenderer) paletteSample);
      ((Container) this).add((Component) this.selector);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PaletteChooserPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ColorPalette getSelectedPalette()
    {
      return ((PaletteSample) this.selector.getSelectedItem()).getPalette();
    }
  }
}
