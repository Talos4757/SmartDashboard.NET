// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.PaintSample
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
  public class PaintSample : JComponent
  {
    private Paint paint;
    private Dimension preferredSize;

    [HideFromJava]
    static PaintSample()
    {
      JComponent.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PaintSample(Paint paint)
    {
      base.\u002Ector();
      PaintSample paintSample = this;
      this.paint = paint;
      this.preferredSize = new Dimension(80, 12);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PaintSample([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(Paint paint)
    {
      this.paint = paint;
      ((Component) this).repaint();
    }

    public virtual Dimension getPreferredSize()
    {
      return this.preferredSize;
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 105, (byte) 127, (byte) 0, (byte) 127, (byte) 0, (byte) 110, (byte) 108, (byte) 104, (byte) 107, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintComponent(Graphics g)
    {
      Graphics2D graphics2D = (Graphics2D) g;
      Dimension size = ((Component) this).getSize();
      Insets insets = this.getInsets();
      Rectangle2D.Double @double = new Rectangle2D.Double((double) insets.left, (double) insets.top, size.getWidth() - (double) insets.left - (double) insets.right - 1.0, size.getHeight() - (double) insets.top - (double) insets.bottom - 1.0);
      graphics2D.setPaint(this.paint);
      graphics2D.fill((Shape) @double);
      graphics2D.setPaint((Paint) Color.black);
      graphics2D.draw((Shape) @double);
    }
  }
}
