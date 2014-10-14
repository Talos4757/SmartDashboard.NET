// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.editor.PaletteSample
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using javax.swing;
using org.jfree.chart.plot;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.editor
{
  [Implements(new string[] {"javax.swing.ListCellRenderer"})]
  [Obsolete]
  [Serializable]
  public class PaletteSample : JComponent, ListCellRenderer
  {
    private ColorPalette palette;
    private Dimension preferredSize;

    [HideFromJava]
    static PaletteSample()
    {
      JComponent.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 104, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PaletteSample(ColorPalette palette)
    {
      base.\u002Ector();
      PaletteSample paletteSample = this;
      this.palette = palette;
      this.preferredSize = new Dimension(80, 18);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PaletteSample([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual ColorPalette getPalette()
    {
      return this.palette;
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPalette(ColorPalette palette)
    {
      this.palette = palette;
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 104, (byte) 103, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Component getListCellRendererComponent(JList list, object value, int index, bool isSelected, bool cellHasFocus)
    {
      if (value is PaletteSample)
        this.setPalette(((PaletteSample) value).getPalette());
      return (Component) this;
    }

    public virtual Dimension getPreferredSize()
    {
      return this.preferredSize;
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 103, (byte) 176, (byte) 103, (byte) 103, (byte) 120, (byte) 153, (byte) 144, (byte) 105, (byte) 104, (byte) 105, (byte) 103, (byte) 99, (byte) 109, (byte) 102, (byte) 111, (byte) 115, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintComponent(Graphics g)
    {
      Graphics2D graphics2D = (Graphics2D) g;
      graphics2D.setRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING, (object) RenderingHints.VALUE_ANTIALIAS_OFF);
      Dimension size = ((Component) this).getSize();
      Insets insets = this.getInsets();
      double num1 = size.getWidth() - (double) insets.left - (double) insets.right;
      double num2 = size.getHeight() - (double) insets.top - (double) insets.bottom;
      graphics2D.setStroke((Stroke) new BasicStroke(1f));
      double num3 = (double) insets.top;
      double num4 = num3 + num2;
      double num5 = (double) insets.left;
      Line2D.Double @double = new Line2D.Double();
      int izV = 0;
      for (; num5 <= (double) insets.left + num1; ++num5)
      {
        ++izV;
        ((Line2D) @double).setLine(num5, num3, num5, num4);
        graphics2D.setPaint((Paint) this.palette.getColor(izV));
        graphics2D.draw((Shape) @double);
      }
    }
  }
}
