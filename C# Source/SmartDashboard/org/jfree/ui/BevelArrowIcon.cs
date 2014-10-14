// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.BevelArrowIcon
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.ui
{
  [Implements(new string[] {"javax.swing.Icon"})]
  public class BevelArrowIcon : Object, Icon
  {
    public const int UP = 0;
    public const int DOWN = 1;
    private const int DEFAULT_SIZE = 11;
    private Color edge1;
    private Color edge2;
    private Color fill;
    private int size;
    private int direction;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 119, (byte) 164, (byte) 104, (byte) 99, (byte) 99, (byte) 255, (byte) 13, (byte) 70, (byte) 255, (byte) 10, (byte) 71, (byte) 99, (byte) 255, (byte) 10, (byte) 70, (byte) 255, (byte) 10, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BevelArrowIcon(int direction, bool isRaisedView, bool isPressedView)
    {
      int num1 = isRaisedView ? 1 : 0;
      int num2 = isPressedView ? 1 : 0;
      base.\u002Ector();
      BevelArrowIcon bevelArrowIcon = this;
      if (num1 != 0)
      {
        if (num2 != 0)
          this.init(UIManager.getColor((object) "controlLtHighlight"), UIManager.getColor((object) "controlDkShadow"), UIManager.getColor((object) "controlShadow"), 11, direction);
        else
          this.init(UIManager.getColor((object) "controlHighlight"), UIManager.getColor((object) "controlShadow"), UIManager.getColor((object) "control"), 11, direction);
      }
      else if (num2 != 0)
        this.init(UIManager.getColor((object) "controlDkShadow"), UIManager.getColor((object) "controlLtHighlight"), UIManager.getColor((object) "controlShadow"), 11, direction);
      else
        this.init(UIManager.getColor((object) "controlShadow"), UIManager.getColor((object) "controlHighlight"), UIManager.getColor((object) "control"), 11, direction);
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 104, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BevelArrowIcon(Color edge1, Color edge2, Color fill, int size, int direction)
    {
      base.\u002Ector();
      BevelArrowIcon bevelArrowIcon = this;
      this.init(edge1, edge2, fill, size, direction);
    }

    private void init([In] Color obj0, [In] Color obj1, [In] Color obj2, [In] int obj3, [In] int obj4)
    {
      this.edge1 = obj0;
      this.edge2 = obj1;
      this.fill = obj2;
      this.size = obj3;
      this.direction = obj4;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 108, (byte) 115, (byte) 119, (byte) 108, (byte) 127, (byte) 1, (byte) 100, (byte) 100, (byte) 105, (byte) 112, (byte) 108, (byte) 108, (byte) 112, (byte) 100, (byte) 108, (byte) 112, (byte) 148, (byte) 108, (byte) 114, (byte) 118, (byte) 100, (byte) 100, (byte) 138, (byte) 108, (byte) 191, (byte) 17})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawDownArrow([In] Graphics obj0, [In] int obj1, [In] int obj2)
    {
      obj0.setColor(this.edge1);
      obj0.drawLine(obj1, obj2, obj1 + this.size - 1, obj2);
      obj0.drawLine(obj1, obj2 + 1, obj1 + this.size - 3, obj2 + 1);
      obj0.setColor(this.edge2);
      obj0.drawLine(obj1 + this.size - 2, obj2 + 1, obj1 + this.size - 1, obj2 + 1);
      int num1 = obj1 + 1;
      int num2 = obj2 + 2;
      int num3 = this.size - 6;
      while (num2 + 1 < obj2 + this.size)
      {
        obj0.setColor(this.edge1);
        obj0.drawLine(num1, num2, num1 + 1, num2);
        obj0.drawLine(num1, num2 + 1, num1 + 1, num2 + 1);
        if (0 < num3)
        {
          obj0.setColor(this.fill);
          obj0.drawLine(num1 + 2, num2, num1 + 1 + num3, num2);
          obj0.drawLine(num1 + 2, num2 + 1, num1 + 1 + num3, num2 + 1);
        }
        obj0.setColor(this.edge2);
        obj0.drawLine(num1 + num3 + 2, num2, num1 + num3 + 3, num2);
        obj0.drawLine(num1 + num3 + 2, num2 + 1, num1 + num3 + 3, num2 + 1);
        ++num1;
        num2 += 2;
        num3 += -2;
      }
      obj0.setColor(this.edge1);
      obj0.drawLine(obj1 + this.size / 2, obj2 + this.size - 1, obj1 + this.size / 2, obj2 + this.size - 1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 131, (byte) 108, (byte) 107, (byte) 106, (byte) 100, (byte) 100, (byte) 98, (byte) 112, (byte) 108, (byte) 108, (byte) 112, (byte) 100, (byte) 108, (byte) 112, (byte) 148, (byte) 108, (byte) 114, (byte) 118, (byte) 100, (byte) 100, (byte) 137, (byte) 108, (byte) 126, (byte) 108, (byte) 127, (byte) 8, (byte) 127, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawUpArrow([In] Graphics obj0, [In] int obj1, [In] int obj2)
    {
      obj0.setColor(this.edge1);
      int num1 = obj1 + this.size / 2;
      obj0.drawLine(num1, obj2, num1, obj2);
      int num2 = num1 - 1;
      int num3 = obj2 + 1;
      int num4 = 0;
      while (num3 + 3 < obj2 + this.size)
      {
        obj0.setColor(this.edge1);
        obj0.drawLine(num2, num3, num2 + 1, num3);
        obj0.drawLine(num2, num3 + 1, num2 + 1, num3 + 1);
        if (0 < num4)
        {
          obj0.setColor(this.fill);
          obj0.drawLine(num2 + 2, num3, num2 + 1 + num4, num3);
          obj0.drawLine(num2 + 2, num3 + 1, num2 + 1 + num4, num3 + 1);
        }
        obj0.setColor(this.edge2);
        obj0.drawLine(num2 + num4 + 2, num3, num2 + num4 + 3, num3);
        obj0.drawLine(num2 + num4 + 2, num3 + 1, num2 + num4 + 3, num3 + 1);
        num2 += -1;
        num3 += 2;
        num4 += 2;
      }
      obj0.setColor(this.edge1);
      obj0.drawLine(obj1, obj2 + this.size - 3, obj1 + 1, obj2 + this.size - 3);
      obj0.setColor(this.edge2);
      obj0.drawLine(obj1 + 2, obj2 + this.size - 2, obj1 + this.size - 1, obj2 + this.size - 2);
      obj0.drawLine(obj1, obj2 + this.size - 1, obj1 + this.size, obj2 + this.size - 1);
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 119, (byte) 108, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintIcon(Component c, Graphics g, int x, int y)
    {
      int num1 = this.direction;
      int num2 = 0;
      if (num1 == num2)
      {
        this.drawUpArrow(g, x, y);
      }
      else
      {
        int num3 = 1;
        if (num1 != num3)
          return;
        this.drawDownArrow(g, x, y);
      }
    }

    public virtual int getIconWidth()
    {
      return this.size;
    }

    public virtual int getIconHeight()
    {
      return this.size;
    }
  }
}
