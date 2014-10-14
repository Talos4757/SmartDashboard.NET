// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.ArrowPanel
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
  [Serializable]
  public class ArrowPanel : JPanel
  {
    public const int UP = 0;
    public const int DOWN = 1;
    private int type;
    private Rectangle2D available;

    [HideFromJava]
    static ArrowPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 232, (byte) 54, (byte) 167, (byte) 235, (byte) 72, (byte) 103, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArrowPanel(int type)
    {
      base.\u002Ector();
      ArrowPanel arrowPanel = this;
      this.type = 0;
      this.available = (Rectangle2D) new Rectangle2D.Float();
      this.type = type;
      ((JComponent) this).setPreferredSize(new Dimension(14, 9));
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ArrowPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 114, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Shape getArrow([In] int obj0)
    {
      int num1 = obj0;
      int num2 = 0;
      if (num1 == num2)
      {
        return this.getUpArrow();
      }
      else
      {
        int num3 = 1;
        if (num1 == num3)
          return this.getDownArrow();
        else
          return this.getUpArrow();
      }
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 102, (byte) 104, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Shape getUpArrow()
    {
      Polygon polygon = new Polygon();
      polygon.addPoint(7, 2);
      polygon.addPoint(2, 7);
      polygon.addPoint(12, 7);
      return (Shape) polygon;
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 102, (byte) 104, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Shape getDownArrow()
    {
      Polygon polygon = new Polygon();
      polygon.addPoint(7, 7);
      polygon.addPoint(2, 2);
      polygon.addPoint(12, 2);
      return (Shape) polygon;
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 103, (byte) 167, (byte) 103, (byte) 103, (byte) 191, (byte) 38, (byte) 114, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintComponent(Graphics g)
    {
      ((JComponent) this).paintComponent(g);
      Graphics2D graphics2D = (Graphics2D) g;
      Dimension size = ((Component) this).getSize();
      Insets insets = ((JComponent) this).getInsets();
      this.available.setRect((double) insets.left, (double) insets.top, size.getWidth() - (double) insets.left - (double) insets.right, size.getHeight() - (double) insets.top - (double) insets.bottom);
      graphics2D.translate((int) insets.left, (int) insets.top);
      graphics2D.fill(this.getArrow(this.type));
    }
  }
}
