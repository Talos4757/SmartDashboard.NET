// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.StrokeSample
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Implements(new string[] {"javax.swing.ListCellRenderer"})]
  [Serializable]
  public class StrokeSample : JComponent, ListCellRenderer
  {
    private Stroke stroke;
    private Dimension preferredSize;

    [HideFromJava]
    static StrokeSample()
    {
      JComponent.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 103, (byte) 111, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StrokeSample(Stroke stroke)
    {
      base.\u002Ector();
      StrokeSample strokeSample = this;
      this.stroke = stroke;
      this.preferredSize = new Dimension(80, 18);
      this.setPreferredSize(this.preferredSize);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StrokeSample([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual Stroke getStroke()
    {
      return this.stroke;
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStroke(Stroke stroke)
    {
      this.stroke = stroke;
      ((Component) this).repaint();
    }

    public virtual Dimension getPreferredSize()
    {
      return this.preferredSize;
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 103, (byte) 144, (byte) 103, (byte) 103, (byte) 104, (byte) 105, (byte) 121, (byte) 185, (byte) 159, (byte) 2, (byte) 159, (byte) 5, (byte) 159, (byte) 28, (byte) 223, (byte) 28, (byte) 104, (byte) 104, (byte) 104, (byte) 168, (byte) 107, (byte) 104, (byte) 108, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintComponent(Graphics g)
    {
      Graphics2D graphics2D = (Graphics2D) g;
      graphics2D.setRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING, (object) RenderingHints.VALUE_ANTIALIAS_ON);
      Dimension size = ((Component) this).getSize();
      Insets insets = this.getInsets();
      double num1 = (double) insets.left;
      double num2 = (double) insets.top;
      double num3 = size.getWidth() - (double) insets.left - (double) insets.right;
      double num4 = size.getHeight() - (double) insets.top - (double) insets.bottom;
      Point2D.Double double1 = new Point2D.Double(num1 + 6.0, num2 + num4 / 2.0);
      Point2D.Double double2 = new Point2D.Double(num1 + num3 - 6.0, num2 + num4 / 2.0);
      Ellipse2D.Double double3 = new Ellipse2D.Double(((Point2D) double1).getX() - 5.0, ((Point2D) double1).getY() - 5.0, 10.0, 10.0);
      Ellipse2D.Double double4 = new Ellipse2D.Double(((Point2D) double2).getX() - 6.0, ((Point2D) double2).getY() - 5.0, 10.0, 10.0);
      graphics2D.draw((Shape) double3);
      graphics2D.fill((Shape) double3);
      graphics2D.draw((Shape) double4);
      graphics2D.fill((Shape) double4);
      Line2D.Double double5 = new Line2D.Double((Point2D) double1, (Point2D) double2);
      if (this.stroke == null)
        return;
      graphics2D.setStroke(this.stroke);
      graphics2D.draw((Shape) double5);
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 104, (byte) 174, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Component getListCellRendererComponent(JList list, object value, int index, bool isSelected, bool cellHasFocus)
    {
      if (value is Stroke)
        this.setStroke((Stroke) value);
      else
        this.setStroke((Stroke) null);
      return (Component) this;
    }
  }
}
