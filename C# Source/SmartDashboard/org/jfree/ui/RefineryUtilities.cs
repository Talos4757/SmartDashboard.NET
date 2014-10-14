// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.RefineryUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.lang;
using javax.swing;
using javax.swing.table;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.ui
{
  public class RefineryUtilities : Object
  {
    internal static Class class\u0024java\u0024awt\u0024GraphicsEnvironment;
    internal static Class class\u0024java\u0024lang\u0024Number;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 45, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private RefineryUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 112)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, RefineryUtilities.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 102, (byte) 103, (byte) 116, (byte) 116, (byte) 115, (byte) 115, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void positionFrameOnScreen(Window frame, double horizontalPercent, double verticalPercent)
    {
      Rectangle maximumWindowBounds = RefineryUtilities.getMaximumWindowBounds();
      Dimension size = ((Component) frame).getSize();
      int num1 = Math.max((int) (maximumWindowBounds.width - size.width), 0);
      int num2 = Math.max((int) (maximumWindowBounds.height - size.height), 0);
      int num3 = ByteCodeHelper.d2i(horizontalPercent * (double) num1) + maximumWindowBounds.x;
      int num4 = ByteCodeHelper.d2i(verticalPercent * (double) num2) + maximumWindowBounds.y;
      frame.setBounds(num3, num4, (int) size.width, (int) size.height);
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 166, (byte) 127, (byte) 21, (byte) 159, (byte) 17, (byte) 225, (byte) 69, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rectangle getMaximumWindowBounds()
    {
      GraphicsEnvironment graphicsEnvironment = GraphicsEnvironment.getLocalGraphicsEnvironment();
      Rectangle rectangle;
      try
      {
        rectangle = (Rectangle) (RefineryUtilities.class\u0024java\u0024awt\u0024GraphicsEnvironment != null ? RefineryUtilities.class\u0024java\u0024awt\u0024GraphicsEnvironment : (RefineryUtilities.class\u0024java\u0024awt\u0024GraphicsEnvironment = RefineryUtilities.class\u0024("java.awt.GraphicsEnvironment"))).getMethod("getMaximumWindowBounds", (Class[]) null, RefineryUtilities.__\u003CGetCallerID\u003E()).invoke((object) graphicsEnvironment, (object[]) null, RefineryUtilities.__\u003CGetCallerID\u003E());
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_5;
      }
      return rectangle;
label_5:
      Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
      Rectangle.__\u003Cclinit\u003E();
      return new Rectangle(0, 0, (int) screenSize.width, (int) screenSize.height);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 103, (byte) 103, (byte) 135, (byte) 110, (byte) 111, (byte) 111, (byte) 111, (byte) 111, (byte) 176, (byte) 103, (byte) 119, (byte) 106, (byte) 119, (byte) 138, (byte) 159, (byte) 9})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void positionDialogRelativeToParent(Dialog dialog, double horizontalPercent, double verticalPercent)
    {
      Dimension size1 = ((Component) dialog).getSize();
      Container parent = ((Component) dialog).getParent();
      Dimension size2 = ((Component) parent).getSize();
      int num1 = ((Component) parent).getX() - size1.width;
      int num2 = ((Component) parent).getY() - size1.height;
      int num3 = (int) (size1.width + size2.width);
      int num4 = (int) (size1.height + size2.height);
      int num5 = num1 + ByteCodeHelper.d2i(horizontalPercent * (double) num3);
      int num6 = num2 + ByteCodeHelper.d2i(verticalPercent * (double) num4);
      Rectangle maximumWindowBounds = RefineryUtilities.getMaximumWindowBounds();
      int num7 = Math.max(Math.min(num5, (int) (maximumWindowBounds.width - size1.width)), 0);
      int num8 = Math.max(Math.min(num6, (int) (maximumWindowBounds.height - size1.height)), 0);
      ((Window) dialog).setBounds(num7 + maximumWindowBounds.x, num8 + maximumWindowBounds.y, (int) size1.width, (int) size1.height);
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 166, (byte) 127, (byte) 21, (byte) 159, (byte) 17, (byte) 225, (byte) 69, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Point getCenterPoint()
    {
      GraphicsEnvironment graphicsEnvironment = GraphicsEnvironment.getLocalGraphicsEnvironment();
      Point point;
      try
      {
        point = (Point) (RefineryUtilities.class\u0024java\u0024awt\u0024GraphicsEnvironment != null ? RefineryUtilities.class\u0024java\u0024awt\u0024GraphicsEnvironment : (RefineryUtilities.class\u0024java\u0024awt\u0024GraphicsEnvironment = RefineryUtilities.class\u0024("java.awt.GraphicsEnvironment"))).getMethod("getCenterPoint", (Class[]) null, RefineryUtilities.__\u003CGetCallerID\u003E()).invoke((object) graphicsEnvironment, (object[]) null, RefineryUtilities.__\u003CGetCallerID\u003E());
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_5;
      }
      return point;
label_5:
      Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
      return new Point(screenSize.width / 2, screenSize.height / 2);
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void centerFrameOnScreen(Window frame)
    {
      RefineryUtilities.positionFrameOnScreen(frame, 0.5, 0.5);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 73, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void positionFrameRandomly(Window frame)
    {
      RefineryUtilities.positionFrameOnScreen(frame, Math.random(), Math.random());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 82, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void centerDialogInParent(Dialog dialog)
    {
      RefineryUtilities.positionDialogRelativeToParent(dialog, 0.5, 0.5);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 112, (byte) 103, (byte) 107, (byte) 109, (byte) 105, (byte) 127, (byte) 8, (byte) 235, (byte) 60, (byte) 230, (byte) 71, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JPanel createTablePanel(TableModel model)
    {
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel = new JPanel((LayoutManager) new BorderLayout());
      JTable jtable = new JTable(model);
      for (int index = 0; index < model.getColumnCount(); ++index)
      {
        TableColumn column = jtable.getColumnModel().getColumn(index);
        if (Object.instancehelper_equals((object) model.getColumnClass(index), RefineryUtilities.class\u0024java\u0024lang\u0024Number != null ? (object) RefineryUtilities.class\u0024java\u0024lang\u0024Number : (object) (RefineryUtilities.class\u0024java\u0024lang\u0024Number = RefineryUtilities.class\u0024("java.lang.Number"))))
          column.setCellRenderer((TableCellRenderer) new NumberCellRenderer());
      }
      ((Container) jpanel).add((Component) new JScrollPane((Component) jtable));
      return jpanel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 150, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JLabel createJLabel(string text, Font font)
    {
      JLabel jlabel = new JLabel(text);
      ((JComponent) jlabel).setFont(font);
      return jlabel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 167, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JLabel createJLabel(string text, Font font, Color color)
    {
      JLabel jlabel = new JLabel(text);
      ((JComponent) jlabel).setFont(font);
      ((JComponent) jlabel).setForeground(color);
      return jlabel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JButton createJButton(string label, Font font)
    {
      JButton jbutton = new JButton(label);
      ((JComponent) jbutton).setFont(font);
      return jbutton;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (RefineryUtilities.__\u003CcallerID\u003E == null)
        RefineryUtilities.__\u003CcallerID\u003E = (CallerID) new RefineryUtilities.__\u003CCallerID\u003E();
      return RefineryUtilities.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
