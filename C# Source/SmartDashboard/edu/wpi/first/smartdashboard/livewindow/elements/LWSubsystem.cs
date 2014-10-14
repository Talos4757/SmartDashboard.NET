// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.LWSubsystem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.smartdashboard.types.named;
using edu.wpi.first.smartdashboard.xml;
using edu.wpi.first.wpilibj.tables;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using java.util.logging;
using javax.swing;
using javax.swing.border;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  [Serializable]
  public class LWSubsystem : AbstractTableWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    private BoxLayout layout;
    private Dimension preferredSize;
    private LWSubsystem.Mouse mouse;
    private static bool editable;
    private Widget selected;
    [Modifiers]
    [Signature("Ljava/util/ArrayList<Ledu/wpi/first/smartdashboard/gui/Widget;>;")]
    private ArrayList widgets;
    private static SmartDashboardXMLReader reader;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return LWSubsystem.__\u003C\u003ETYPES;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 134, (byte) 101, (byte) 243, (byte) 75})]
    static LWSubsystem()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      NamedDataType namedDataType = LWSubsystemType.get();
      dataTypeArray[index] = (DataType) namedDataType;
      LWSubsystem.__\u003C\u003ETYPES = dataTypeArray;
      LWSubsystem.editable = false;
    }

    [LineNumberTable(new byte[] {(byte) 9, (byte) 233, (byte) 40, (byte) 239, (byte) 77, (byte) 199, (byte) 237, (byte) 72, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LWSubsystem()
      : base(true)
    {
      LWSubsystem lwSubsystem = this;
      this.preferredSize = new Dimension(100, 100);
      this.selected = (Widget) null;
      this.widgets = new ArrayList(20);
      MainPanel.getPanel("LiveWindow").addSubsystem(this);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LWSubsystem([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Signature("()Ljava/util/ArrayList<Ledu/wpi/first/smartdashboard/gui/Widget;>;")]
    public virtual ArrayList getWidgets()
    {
      return this.widgets;
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addWidget(Widget widget)
    {
      this.widgets.add((object) widget);
    }

    public static bool isEditable()
    {
      return LWSubsystem.editable;
    }

    public static void setEditable(bool editable)
    {
      LWSubsystem.editable = editable;
    }

    [Modifiers]
    [LineNumberTable((ushort) 31)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void access\u0024000([In] LWSubsystem obj0, [In] string obj1, [In] ITable obj2)
    {
      obj0.addSubsystemElement(obj1, obj2);
    }

    [Modifiers]
    internal static bool access\u0024100()
    {
      return LWSubsystem.editable;
    }

    [Modifiers]
    [LineNumberTable((ushort) 31)]
    internal static Widget access\u0024200([In] LWSubsystem obj0)
    {
      return obj0.selected;
    }

    [LineNumberTable(new byte[] {(byte) 102, (byte) 110, (byte) 109, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Widget getWidgetAt(Point p)
    {
      if (((Container) this).getComponentAt(p) is Widget)
        return (Widget) ((Container) this).getComponentAt(p);
      else
        return (Widget) null;
    }

    [Modifiers]
    [LineNumberTable((ushort) 31)]
    internal static Widget access\u0024202([In] LWSubsystem obj0, [In] Widget obj1)
    {
      LWSubsystem lwSubsystem1 = obj0;
      Widget widget1 = obj1;
      LWSubsystem lwSubsystem2 = lwSubsystem1;
      Widget widget2 = widget1;
      lwSubsystem2.selected = widget1;
      return widget2;
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 127, (byte) 36, (byte) 127, (byte) 5, (byte) 127, (byte) 15, (byte) 127, (byte) 26, (byte) 108, (byte) 113, (byte) 103, (byte) 108, (byte) 102, (byte) 103, (byte) 109, (byte) 104, (byte) 114, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 127, (byte) 51, (byte) 102, (byte) 102, (byte) 255, (byte) 9, (byte) 69, (byte) 226, (byte) 60, (byte) 98, (byte) 188, (byte) 2, (byte) 98, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addSubsystemElement([In] string obj0, [In] ITable obj1)
    {
      InstantiationException instantiationException1;
      IllegalAccessException illegalAccessException1;
      try
      {
        try
        {
          System.get_out().println(new StringBuilder().append("\nSubsystem \"").append(this.getFieldName()).append("\" does not contain widget \"").append(obj0).append("\"").toString());
          System.get_out().println(new StringBuilder().append("Table: ").append((object) obj1).toString());
          System.get_out().println(new StringBuilder().append("Type: ").append(obj1.getString("~TYPE~")).toString());
          System.get_out().println(new StringBuilder().append("Trying to add a widget of type \"").append((object) DataType.getType((object) obj1)).append("\" and key ").append(obj0).toString());
          Widget widget = (Widget) DataType.getType((object) obj1).getDefault().newInstance(LWSubsystem.__\u003CGetCallerID\u003E());
          widget.setFieldName(obj0);
          widget.setType(DataType.getType((object) obj1));
          widget.init();
          widget.setValue((object) obj1);
          this.widgets.add((object) widget);
          ((Container) this).add((Component) widget);
          this.preferredSize = this.layout.preferredLayoutSize((Container) this);
          ((JComponent) this).setPreferredSize(this.preferredSize);
          ((JComponent) this).setMinimumSize(this.preferredSize);
          this.setSavedSize(this.preferredSize);
          ((Component) this).setSize(this.preferredSize);
          System.get_out().println(new StringBuilder().append("New size [").append((int) this.preferredSize.width).append(", ").append((int) this.preferredSize.height).append("]").toString());
          ((JComponent) this).revalidate();
          ((Component) this).repaint();
          System.get_out().println();
          return;
        }
        catch (InstantiationException ex)
        {
          int num = 1;
          instantiationException1 = (InstantiationException) ByteCodeHelper.MapException<InstantiationException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (IllegalAccessException ex)
      {
        int num = 1;
        illegalAccessException1 = (IllegalAccessException) ByteCodeHelper.MapException<IllegalAccessException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_4;
      }
      InstantiationException instantiationException2 = instantiationException1;
      Logger.getLogger(((Class) ClassLiteral<LWSubsystem>.Value).getName()).log((Level) Level.SEVERE, (string) null, (Exception) instantiationException2);
      return;
label_4:
      IllegalAccessException illegalAccessException2 = illegalAccessException1;
      Logger.getLogger(((Class) ClassLiteral<LWSubsystem>.Value).getName()).log((Level) Level.SEVERE, (string) null, (Exception) illegalAccessException2);
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 109, (byte) 108, (byte) 103, (byte) 103, (byte) 103, (byte) 113, (byte) 109, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      this.layout = new BoxLayout((Container) this, 1);
      ((Container) this).setLayout((LayoutManager) this.layout);
      this.setObstruction(true);
      ((JComponent) this).setOpaque(true);
      ((JComponent) this).setVisible(true);
      ((JComponent) this).setBorder((Border) BorderFactory.createTitledBorder(this.getFieldName()));
      this.mouse = new LWSubsystem.Mouse(this, this);
      ((Component) this).addMouseListener((MouseListener) this.mouse);
      ((Component) this).addMouseMotionListener((MouseMotionListener) this.mouse);
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 98, (byte) 103, (byte) 173, (byte) 99, (byte) 246, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void tableChanged(ITable source, string key, ITable table, bool isNew)
    {
      int num = 0;
      if (LWSubsystem.reader != null)
        num = LWSubsystem.reader.containsWidgetOfName(this, key) ? 1 : 0;
      if (num != 0)
        return;
      table.addTableListener("~TYPE~", (ITableListener) new LWSubsystem\u00241(this, table, key), true);
    }

    public static void setLoaded(SmartDashboardXMLReader XMLreader)
    {
      LWSubsystem.reader = XMLreader;
    }

    public override void propertyChanged(Property property)
    {
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (LWSubsystem.__\u003CcallerID\u003E == null)
        LWSubsystem.__\u003CcallerID\u003E = (CallerID) new LWSubsystem.__\u003CCallerID\u003E();
      return LWSubsystem.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [SourceFile("LWSubsystem.java")]
    [Modifiers]
    internal sealed class Mouse : MouseAdapter
    {
      internal int yclick;
      [Modifiers]
      private LWSubsystem subsystem;
      [Modifiers]
      internal LWSubsystem this\u00240;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 239, (byte) 61, (byte) 199, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Mouse([In] LWSubsystem obj0, [In] LWSubsystem obj1)
      {
        base.\u002Ector();
        LWSubsystem.Mouse mouse = this;
        this.yclick = 0;
        this.subsystem = obj1;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 106, (byte) 109, (byte) 157, (byte) 144, (byte) 103, (byte) 119, (byte) 144, (byte) 98, (byte) 163, (byte) 114, (byte) 101, (byte) 166, (byte) 106, (byte) 174, (byte) 159, (byte) 4, (byte) 118, (byte) 184, (byte) 107, (byte) 205})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void mouseDragged([In] MouseEvent obj0)
      {
        if (!LWSubsystem.access\u0024100())
          return;
        if (LWSubsystem.access\u0024200(this.this\u00240) == null)
          LWSubsystem.access\u0024202(this.this\u00240, this.this\u00240.getWidgetAt(obj0.getPoint()));
        if (LWSubsystem.access\u0024200(this.this\u00240) == null)
          return;
        int y = obj0.getY();
        int componentZorder = ((Container) this.subsystem).getComponentZOrder((Component) LWSubsystem.access\u0024200(this.this\u00240));
        int num1 = componentZorder + (y >= this.yclick ? 1 : -1);
        int num2 = 0;
        int num3 = 0;
        if (num1 >= 0 && num1 < ((Container) this.subsystem).getComponentCount())
        {
          num2 = num1 < componentZorder ? 1 : 0;
          num3 = num1 > componentZorder ? 1 : 0;
        }
        if (num2 == 0 && num3 == 0)
          return;
        Component component = ((Container) this.subsystem).getComponent(num1);
        if (num3 != 0 && y > component.getY() + component.getHeight() || num2 != 0 && y < component.getY())
        {
          ((Container) this.subsystem).remove((Component) LWSubsystem.access\u0024200(this.this\u00240));
          ((Container) this.subsystem).add((Component) LWSubsystem.access\u0024200(this.this\u00240), num1);
        }
        ((JComponent) this.subsystem).revalidate();
        ((Component) this.subsystem).repaint();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 128, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void mousePressed([In] MouseEvent obj0)
      {
        this.yclick = obj0.getY();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 109, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void mouseReleased([In] MouseEvent obj0)
      {
        LWSubsystem.access\u0024202(this.this\u00240, (Widget) null);
        this.yclick = 0;
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
