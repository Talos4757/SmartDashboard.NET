// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.MinMaxCategoryRenderer$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.chart.renderer.category
{
  [InnerClass]
  [Implements(new string[] {"javax.swing.Icon"})]
  [SourceFile("MinMaxCategoryRenderer.java")]
  [Modifiers]
  internal sealed class MinMaxCategoryRenderer\u00242 : Object, Icon
  {
    [Modifiers]
    private GeneralPath val\u0024path;
    [Modifiers]
    private bool val\u0024fill;
    [Modifiers]
    private bool val\u0024outline;
    [Modifiers]
    private int val\u0024width;
    [Modifiers]
    private int val\u0024height;
    [Modifiers]
    private MinMaxCategoryRenderer this\u00240;

    [LineNumberTable((ushort) 513)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal MinMaxCategoryRenderer\u00242([In] MinMaxCategoryRenderer obj0, [In] GeneralPath obj1, [In] bool obj2, [In] bool obj3, [In] int obj4, [In] int obj5)
    {
      int num1 = obj2 ? 1 : 0;
      int num2 = obj3 ? 1 : 0;
      base.\u002Ector();
      MinMaxCategoryRenderer\u00242 categoryRenderer2 = this;
      this.this\u00240 = obj0;
      this.val\u0024path = obj1;
      this.val\u0024fill = num1 != 0;
      this.val\u0024outline = num2 != 0;
      this.val\u0024width = obj4;
      this.val\u0024height = obj5;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 145, (byte) 103, (byte) 117, (byte) 104, (byte) 140, (byte) 104, (byte) 140, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintIcon([In] Component obj0, [In] Graphics obj1, [In] int obj2, [In] int obj3)
    {
      Graphics2D graphics2D = (Graphics2D) obj1;
      ((Path2D.Float) this.val\u0024path).transform(AffineTransform.getTranslateInstance((double) obj2, (double) obj3));
      if (this.val\u0024fill)
        graphics2D.fill((Shape) this.val\u0024path);
      if (this.val\u0024outline)
        graphics2D.draw((Shape) this.val\u0024path);
      ((Path2D.Float) this.val\u0024path).transform(AffineTransform.getTranslateInstance((double) -obj2, (double) -obj3));
    }

    public virtual int getIconWidth()
    {
      return this.val\u0024width;
    }

    public virtual int getIconHeight()
    {
      return this.val\u0024height;
    }
  }
}
