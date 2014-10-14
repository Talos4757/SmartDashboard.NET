// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.livewindow.elements;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.wpilibj.tables;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui
{
  [Serializable]
  public class DashboardPanel : JPanel
  {
    private GlassPane glassPane;
    private JPanel backPane;
    [Signature("Ljava/util/LinkedList<Ledu/wpi/first/smartdashboard/gui/DisplayElement;>;")]
    private LinkedList elements;
    [Signature("Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/gui/Widget;>;")]
    private Map fields;
    [Signature("Ljava/util/Set<Ljava/lang/String;>;")]
    private Set hiddenFields;
    private bool editable;
    [Modifiers]
    private DashboardPanel.RobotListener listener;
    [Modifiers]
    [Signature("Ljava/util/ArrayList<Ledu/wpi/first/smartdashboard/livewindow/elements/LWSubsystem;>;")]
    private ArrayList subsystems;
    [Modifiers]
    private DashboardFrame frame;
    [Modifiers]
    private ITable table;
    [Modifiers]
    private static Random random;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable((ushort) 426)]
    static DashboardPanel()
    {
      JPanel.__\u003Cclinit\u003E();
      DashboardPanel.random = new Random();
    }

    [LineNumberTable(new byte[] {(byte) 8, (byte) 232, (byte) 36, (byte) 203, (byte) 203, (byte) 203, (byte) 203, (byte) 199, (byte) 109, (byte) 235, (byte) 72, (byte) 103, (byte) 103, (byte) 109, (byte) 109, (byte) 141, (byte) 114, (byte) 140, (byte) 141, (byte) 140, (byte) 109, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DashboardPanel(DashboardFrame frame, ITable table)
    {
      base.\u002Ector();
      DashboardPanel dashboardPanel = this;
      this.backPane = new JPanel();
      this.elements = new LinkedList();
      this.fields = (Map) new HashMap();
      this.hiddenFields = (Set) new HashSet();
      this.editable = false;
      this.listener = new DashboardPanel.RobotListener(this, (DashboardPanel.\u0031) null);
      this.subsystems = new ArrayList();
      this.frame = frame;
      this.table = table;
      this.glassPane = new GlassPane(frame, this);
      ((Container) this).add((Component) this.glassPane);
      ((Container) this).add((Component) this.backPane);
      ((Container) this.backPane).setLayout((LayoutManager) new DashboardPanel.DashboardLayout(this, (DashboardPanel.\u0031) null));
      ((Component) this.backPane).setFocusable(true);
      ((Container) this).setLayout((LayoutManager) new DashboardPanel.DashboardLayout(this, (DashboardPanel.\u0031) null));
      this.setEditable(this.editable);
      table.addTableListener((ITableListener) this.listener, true);
      table.addSubTableListener((ITableListener) this.listener);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DashboardPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addMouseListener(MouseListener l)
    {
      ((Component) this.glassPane).addMouseListener(l);
      ((Component) this.backPane).addMouseListener(l);
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addMouseMotionListener(MouseMotionListener l)
    {
      ((Component) this.glassPane).addMouseMotionListener(l);
      ((Component) this.backPane).addMouseMotionListener(l);
    }

    [Signature("()Ljava/lang/Iterable<Ljava/lang/String;>;")]
    public virtual Iterable getHiddenFields()
    {
      return (Iterable) this.hiddenFields;
    }

    [Signature("()Ljava/lang/Iterable<Ledu/wpi/first/smartdashboard/gui/DisplayElement;>;")]
    public virtual Iterable getElements()
    {
      return (Iterable) this.elements;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 200, (byte) 135, (byte) 141, (byte) 139, (byte) 103, (byte) 99, (byte) 167, (byte) 142, (byte) 137, (byte) 100, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setField(string key, Widget element, DataType type, object value, Point point)
    {
      this.removeField(key);
      this.hiddenFields.remove((object) key);
      value = this.verifyValue(type, value);
      element.setFieldName(key);
      if (type != null)
        element.setType(type);
      this.fields.put((object) key, (object) element);
      this.addElement((DisplayElement) element, point);
      if (value == null)
        return;
      element.setValue(value);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 166, (byte) 99, (byte) 103, (byte) 103, (byte) 105, (byte) 140, (byte) 105, (byte) 140, (byte) 103, (byte) 105, (byte) 141, (byte) 135, (byte) 173, (byte) 98, (byte) 127, (byte) 2, (byte) 148, (byte) 141, (byte) 172, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addElement(DisplayElement element, Point point)
    {
      element.init();
      if (point == null)
      {
        Dimension savedSize = element.getSavedSize();
        Dimension preferredSize = ((JComponent) element).getPreferredSize();
        if (savedSize.width > 0)
          preferredSize.width = savedSize.width;
        if (savedSize.height > 0)
          preferredSize.height = savedSize.height;
        ((Component) element).setSize(preferredSize);
        point = this.findSpace(element);
        ((Component) element).setBounds(new Rectangle(point, preferredSize));
      }
      element.setSavedLocation(point);
      ((Container) this.backPane).add((Component) element);
      int num1 = 1;
      Iterator iterator = ((AbstractSequentialList) this.elements).iterator();
      while (iterator.hasNext())
      {
        DisplayElement displayElement1 = (DisplayElement) iterator.next();
        JPanel jpanel = this.backPane;
        DisplayElement displayElement2 = displayElement1;
        int num2 = num1;
        ++num1;
        ((Container) jpanel).setComponentZOrder((Component) displayElement2, num2);
      }
      ((Container) this.backPane).setComponentZOrder((Component) element, 0);
      this.elements.addFirst((object) element);
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 114, (byte) 109, (byte) 99, (byte) 103, (byte) 108, (byte) 109, (byte) 109, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeField(string field)
    {
      Widget widget = (Widget) this.fields.get((object) field);
      this.hiddenFields.add((object) field);
      if (widget == null)
        return;
      this.disconnect((DisplayElement) widget);
      ((Container) this.backPane).remove((Component) widget);
      this.fields.remove((object) field);
      this.elements.remove((object) widget);
      ((JComponent) this).repaint(((Component) widget).getBounds());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 228, (byte) 127, (byte) 9})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addField(string key)
    {
      this.setField(key, (Class) null, !this.table.containsKey(key) ? (object) null : this.table.getValue(key), (Point) null);
    }

    public virtual ITable getTable()
    {
      return this.table;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 78, (byte) 102, (byte) 127, (byte) 6, (byte) 124, (byte) 170, (byte) 123, (byte) 103, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeUnusedFields()
    {
      ArrayList arrayList = new ArrayList();
      Iterator iterator1 = this.fields.keySet().iterator();
      while (iterator1.hasNext())
      {
        string str = (string) iterator1.next();
        if (!this.table.containsKey(str) && !this.table.containsSubTable(str))
          arrayList.add((object) str);
      }
      Iterator iterator2 = arrayList.iterator();
      while (iterator2.hasNext())
      {
        string field = (string) iterator2.next();
        this.removeField(field);
        this.hiddenFields.remove((object) field);
      }
    }

    [LineNumberTable(new byte[] {(byte) 121, (byte) 107, (byte) 107, (byte) 127, (byte) 1, (byte) 103, (byte) 142, (byte) 203, (byte) 113, (byte) 114, (byte) 145, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.hiddenFields.clear();
      this.fields.clear();
      Iterator iterator = ((AbstractSequentialList) this.elements).iterator();
      while (iterator.hasNext())
      {
        DisplayElement displayElement = (DisplayElement) iterator.next();
        this.disconnect(displayElement);
        ((Container) this.backPane).remove((Component) displayElement);
      }
      this.elements.clear();
      this.table.removeTableListener((ITableListener) this.listener);
      this.table.addTableListener((ITableListener) this.listener, true);
      this.table.addSubTableListener((ITableListener) this.listener);
      ((Component) this).repaint();
    }

    public virtual bool isEditable()
    {
      return this.editable;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 116, (byte) 130, (byte) 135, (byte) 108, (byte) 99, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setEditable(bool editable)
    {
      int num = editable ? 1 : 0;
      this.editable = num != 0;
      ((JComponent) this.glassPane).setVisible(num != 0);
      if (num == 0)
        return;
      ((JComponent) this.glassPane).requestFocus();
    }

    [Signature("()Ljava/util/ArrayList<Ledu/wpi/first/smartdashboard/livewindow/elements/LWSubsystem;>;")]
    public virtual ArrayList getSubsystems()
    {
      return this.subsystems;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 121, (byte) 253, (byte) 77, (byte) 229, (byte) 52, (byte) 97, (byte) 255, (byte) 58, (byte) 69, (byte) 122, (byte) 63, (byte) 8, (byte) 168, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void disconnect([In] DisplayElement obj0)
    {
      Exception exception1;
      try
      {
        obj0.disconnect();
        return;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception1 = (Exception) m0;
      }
      Exception exception2 = exception1;
      string str = new StringBuilder().append("An exception occurred while removing the ").append(DisplayElement.getName(Object.instancehelper_getClass((object) obj0))).append(" of type ").append((object) Object.instancehelper_getClass((object) exception2)).append(".\nThe message is:\n").append(Throwable.instancehelper_getMessage((Exception) exception2)).append("\nThe stack trace is:\n").toString();
      StackTraceElement[] stackTrace = Throwable.instancehelper_getStackTrace((Exception) exception2);
      int length = stackTrace.Length;
      for (int index = 0; index < length; ++index)
      {
        StackTraceElement stackTraceElement = stackTrace[index];
        str = new StringBuilder().append(str).append(stackTraceElement.toString()).append("\n").toString();
      }
      JOptionPane.showMessageDialog((Component) this.frame, (object) str, "Exception When Removing Element", 0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 102, (byte) 142, (byte) 103, (byte) 167, (byte) 107, (byte) 108, (byte) 137, (byte) 191, (byte) 35, (byte) 165, (byte) 127, (byte) 8, (byte) 116, (byte) 137, (byte) 223, (byte) 77, (byte) 126, (byte) 104, (byte) 105, (byte) 131, (byte) 127, (byte) 4, (byte) 127, (byte) 10, (byte) 206, (byte) 165, (byte) 127, (byte) 41, (byte) 194})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Point findSpace([In] DisplayElement obj0)
    {
      Stack stack = new Stack();
      ((Vector) stack).add((object) new Point(0, 0));
      Dimension size1 = ((Component) obj0).getSize();
      Dimension size2 = ((Component) this).getSize();
label_1:
      while (!((Vector) stack).isEmpty())
      {
        Point point1 = (Point) stack.pop();
        Rectangle rectangle = new Rectangle(point1, size1);
        if (rectangle.x >= 0 && rectangle.y >= 0 && (rectangle.x + rectangle.width <= size2.width && rectangle.y + rectangle.height <= size2.height))
        {
          Iterator iterator = ((AbstractSequentialList) this.elements).iterator();
          while (iterator.hasNext())
          {
            DisplayElement displayElement = (DisplayElement) iterator.next();
            if (displayElement != obj0 && displayElement.isObstruction())
            {
              Rectangle bounds = ((Component) displayElement).getBounds();
              if (bounds.x <= rectangle.x + rectangle.width && bounds.x + bounds.width >= rectangle.x && (bounds.y <= rectangle.y + rectangle.height && bounds.y + bounds.height >= rectangle.y))
              {
                Point point2 = new Point(bounds.x + bounds.width + 1, (int) point1.y);
                if (((Vector) stack).isEmpty())
                {
                  ((Vector) stack).add((object) point2);
                  point2 = (Point) null;
                }
                ((Vector) stack).add((object) new Point((int) point1.x, bounds.y + bounds.height + 1));
                if (point2 != null && Math.abs((int) (point2.x - rectangle.x)) < rectangle.width / 3)
                {
                  ((Vector) stack).add((object) point2);
                  goto label_1;
                }
                else
                  goto label_1;
              }
            }
          }
          System.get_out().println(new StringBuilder().append("Adding an element at [").append((int) point1.x).append(",").append((int) point1.y).append("]").toString());
          return point1;
        }
      }
      return new Point(DashboardPanel.random.nextInt(32), DashboardPanel.random.nextInt(32));
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 102, (byte) 98, (byte) 104, (byte) 130})]
    private object verifyValue([In] DataType obj0, [In] object obj1)
    {
      if (obj0 == null || obj1 == null)
        return (object) null;
      if (obj0 is NamedDataType)
        return obj1;
      else
        return obj1;
    }

    [Signature("(Ljava/lang/String;Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;Ljava/lang/Object;Ljava/awt/Point;)V")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 240, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setField(string key, Class preferred, object value, Point point)
    {
      this.setField(key, preferred, DataType.getType(value), value, point);
    }

    [Signature("(Ljava/lang/String;Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;Ledu/wpi/first/smartdashboard/types/DataType;Ljava/lang/Object;Ljava/awt/Point;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 50, (byte) 67, (byte) 146, (byte) 99, (byte) 127, (byte) 15, (byte) 108, (byte) 120, (byte) 105, (byte) 167, (byte) 107, (byte) 103, (byte) 173, (byte) 141, (byte) 99, (byte) 135, (byte) 104, (byte) 127, (byte) 5, (byte) 129, (byte) 238, (byte) 69, (byte) 145, (byte) 253, (byte) 69, (byte) 226, (byte) 60, (byte) 97, (byte) 191, (byte) 20, (byte) 2, (byte) 97, (byte) 191, (byte) 20})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setField(string key, Class preferred, DataType type, object value, Point point)
    {
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      object& local = @value;
      Widget widget = (Widget) this.fields.get((object) key);
      if (type == null)
      {
        System.get_out().println(new StringBuilder().append("WARNING: has no way of handling data at field \"").append(key).append("\"").toString());
        this.removeField(key);
      }
      else if (widget != null && preferred == null && (widget.getType() == type || widget.supportsType(type)))
      {
        if (widget.getType() != type)
          widget.setType(type);
        value = this.verifyValue(type, value);
        if (value == null)
          return;
        widget.setValue(value);
      }
      else
      {
        Class @class = preferred != null ? preferred : type.getDefault();
        if (@class == null)
        {
          Set widgetsForType = DisplayElementRegistry.getWidgetsForType(type);
          if (widgetsForType.isEmpty())
          {
            System.get_out().println(new StringBuilder().append("WARNING: has no way of handling type ").append((object) type).toString());
            return;
          }
          else
            @class = (Class) widgetsForType.toArray()[0];
        }
        try
        {
          try
          {
            Widget element = (Widget) @class.newInstance(DashboardPanel.__\u003CGetCallerID\u003E());
            this.setField(key, element, type, value, point);
            return;
          }
          catch (InstantiationException ex)
          {
          }
        }
        catch (IllegalAccessException ex)
        {
          goto label_16;
        }
        System.get_out().println(new StringBuilder().append("ERROR: ").append(@class.getName()).append(" has no default constructor!").toString());
        return;
label_16:
        System.get_out().println(new StringBuilder().append("ERROR: ").append(@class.getName()).append(" has no public default constructor!").toString());
      }
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void revalidateBacking()
    {
      ((JComponent) this.backPane).revalidate();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 116, (byte) 103, (byte) 108, (byte) 109, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeElement(StaticWidget widget)
    {
      this.disconnect((DisplayElement) widget);
      ((Container) this.backPane).remove((Component) widget);
      this.elements.remove((object) widget);
      ((JComponent) this).repaint(((Component) widget).getBounds());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 129, (byte) 130, (byte) 141, (byte) 127, (byte) 1, (byte) 147, (byte) 141, (byte) 141, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void shiftToBack(DisplayElement element)
    {
      int num1 = 0;
      this.elements.remove((object) element);
      Iterator iterator = ((AbstractSequentialList) this.elements).iterator();
      while (iterator.hasNext())
      {
        DisplayElement displayElement1 = (DisplayElement) iterator.next();
        JPanel jpanel = this.backPane;
        DisplayElement displayElement2 = displayElement1;
        int num2 = num1;
        ++num1;
        ((Container) jpanel).setComponentZOrder((Component) displayElement2, num2);
      }
      ((Container) this.backPane).setComponentZOrder((Component) element, num1);
      this.elements.add((object) element);
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 46, (byte) 127, (byte) 1, (byte) 110, (byte) 164})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DisplayElement findElementContaining(Point point)
    {
      Iterator iterator = ((AbstractSequentialList) this.elements).iterator();
      while (iterator.hasNext())
      {
        DisplayElement displayElement = (DisplayElement) iterator.next();
        if (((Component) displayElement).getBounds().contains(point))
          return displayElement;
      }
      return (DisplayElement) null;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 183, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubsystem(LWSubsystem subsystem)
    {
      this.subsystems.add((object) subsystem);
    }

    [Modifiers]
    [LineNumberTable((ushort) 21)]
    internal static DashboardFrame access\u0024200([In] DashboardPanel obj0)
    {
      return obj0.frame;
    }

    [Modifiers]
    [LineNumberTable((ushort) 21)]
    internal static Map access\u0024300([In] DashboardPanel obj0)
    {
      return obj0.fields;
    }

    [Modifiers]
    [LineNumberTable((ushort) 21)]
    internal static Set access\u0024400([In] DashboardPanel obj0)
    {
      return obj0.hiddenFields;
    }

    [Modifiers]
    [LineNumberTable((ushort) 21)]
    internal static GlassPane access\u0024500([In] DashboardPanel obj0)
    {
      return obj0.glassPane;
    }

    [Modifiers]
    [LineNumberTable((ushort) 21)]
    internal static JPanel access\u0024600([In] DashboardPanel obj0)
    {
      return obj0.backPane;
    }

    [Modifiers]
    [LineNumberTable((ushort) 21)]
    internal static LinkedList access\u0024700([In] DashboardPanel obj0)
    {
      return obj0.elements;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (DashboardPanel.__\u003CcallerID\u003E == null)
        DashboardPanel.__\u003CcallerID\u003E = (CallerID) new DashboardPanel.__\u003CCallerID\u003E();
      return DashboardPanel.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardPanel", null, null)]
    [SourceFile("DashboardPanel.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      \u0031()
      {
        throw null;
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.awt.LayoutManager"})]
    [SourceFile("DashboardPanel.java")]
    [Modifiers]
    internal sealed class DashboardLayout : Object, LayoutManager
    {
      [Modifiers]
      internal DashboardPanel this\u00240;

      [Modifiers]
      [LineNumberTable((ushort) 556)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal DashboardLayout([In] DashboardPanel obj0, [In] DashboardPanel.\u0031 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable((ushort) 556)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private DashboardLayout([In] DashboardPanel obj0)
      {
        base.\u002Ector();
      }

      public virtual void addLayoutComponent([In] string obj0, [In] Component obj1)
      {
      }

      public virtual void removeLayoutComponent([In] Component obj0)
      {
      }

      [LineNumberTable((ushort) 565)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Dimension preferredLayoutSize([In] Container obj0)
      {
        return new Dimension(640, 480);
      }

      [LineNumberTable((ushort) 569)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Dimension minimumLayoutSize([In] Container obj0)
      {
        return new Dimension(0, 0);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 203, (byte) 105, (byte) 108, (byte) 126, (byte) 126, (byte) 101, (byte) 127, (byte) 9, (byte) 140, (byte) 103, (byte) 104, (byte) 105, (byte) 108, (byte) 141, (byte) 108, (byte) 173, (byte) 104, (byte) 133})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void layoutContainer([In] Container obj0)
      {
        if (obj0 == this.this\u00240)
        {
          Dimension size = ((Component) this.this\u00240).getSize();
          ((Component) DashboardPanel.access\u0024500(this.this\u00240)).setBounds(0, 0, (int) size.width, (int) size.height);
          ((Component) DashboardPanel.access\u0024600(this.this\u00240)).setBounds(0, 0, (int) size.width, (int) size.height);
        }
        else
        {
          Iterator iterator = ((AbstractSequentialList) DashboardPanel.access\u0024700(this.this\u00240)).iterator();
          while (iterator.hasNext())
          {
            DisplayElement displayElement = (DisplayElement) iterator.next();
            ((Component) displayElement).setLocation(displayElement.getSavedLocation());
            Dimension savedSize = displayElement.getSavedSize();
            Dimension dimension = new Dimension(((JComponent) displayElement).getPreferredSize());
            if (savedSize != null && savedSize.width != -1)
              dimension.width = savedSize.width;
            if (savedSize != null && savedSize.height != -1)
              dimension.height = savedSize.height;
            ((Component) displayElement).setSize(dimension);
          }
        }
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
    [SourceFile("DashboardPanel.java")]
    [Modifiers]
    internal sealed class RobotListener : Object, ITableListener
    {
      [Modifiers]
      internal DashboardPanel this\u00240;

      [Modifiers]
      [LineNumberTable((ushort) 507)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal RobotListener([In] DashboardPanel obj0, [In] DashboardPanel.\u0031 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable((ushort) 507)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private RobotListener([In] DashboardPanel obj0)
      {
        base.\u002Ector();
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 15, (byte) 163, (byte) 127, (byte) 29, (byte) 148, (byte) 115, (byte) 104, (byte) 103, (byte) 245, (byte) 74, (byte) 98, (byte) 239, (byte) 73})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void valueChanged([In] ITable obj0, [In] string obj1, [In] object obj2, [In] bool obj3)
      {
        if (obj3 && !((Boolean) DashboardPanel.access\u0024200(this.this\u00240).getPrefs().__\u003C\u003EautoShowWidgets.getValue()).booleanValue() && !DashboardPanel.access\u0024300(this.this\u00240).containsKey((object) obj1))
        {
          DashboardPanel.access\u0024400(this.this\u00240).add((object) obj1);
        }
        else
        {
          if (DashboardPanel.access\u0024400(this.this\u00240).contains((object) obj1))
            return;
          if (obj2 is ITable)
          {
            ITable table = (ITable) obj2;
            table.addTableListener("~TYPE~", (ITableListener) new DashboardPanel\u0024RobotListener\u00241(this, table, obj1, obj2), true);
          }
          else
            SwingUtilities.invokeLater((Runnable) new DashboardPanel\u0024RobotListener\u00242(this, obj1, obj2));
        }
      }
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
