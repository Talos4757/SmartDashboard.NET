// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.GlassPane
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using ikvm.@internal;
using IKVM.Attributes;
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
  public class GlassPane : JPanel
  {
    private const int DRAG_BUFFER = 5;
    private bool dragging;
    private Rectangle dragStartBounds;
    private Dimension dragMinSizeDelta;
    private Dimension dragMaxSizeDelta;
    private Point dragStartPoint;
    private int dragType;
    [Signature("Ljava/util/Map<Ljava/lang/Integer;Ljava/awt/Rectangle;>;")]
    private Map areas;
    private JPopupMenu elementMenu;
    private JMenuItem resizeMenu;
    private JMenu changeToMenu;
    private DisplayElement selectedElement;
    private DisplayElement menuElement;
    private bool showGrid;
    [Modifiers]
    private DashboardPanel panel;
    [Modifiers]
    private DashboardFrame frame;
    [Modifiers]
    private static Color GRID_COLOR;

    [LineNumberTable((ushort) 169)]
    static GlassPane()
    {
      JPanel.__\u003Cclinit\u003E();
      GlassPane.GRID_COLOR = new Color(0, 0, 0, 40);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 232, (byte) 52, (byte) 103, (byte) 235, (byte) 70, (byte) 231, (byte) 70, (byte) 103, (byte) 103, (byte) 107, (byte) 127, (byte) 2, (byte) 127, (byte) 3, (byte) 127, (byte) 3, (byte) 127, (byte) 9, (byte) 156, (byte) 236, (byte) 73, (byte) 236, (byte) 81, (byte) 103, (byte) 135, (byte) 104, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal GlassPane([In] DashboardFrame obj0, [In] DashboardPanel obj1)
    {
      base.\u002Ector();
      GlassPane glassPane1 = this;
      this.dragType = -1;
      this.areas = (Map) new HashMap();
      this.showGrid = false;
      this.frame = obj0;
      this.panel = obj1;
      this.elementMenu = new JPopupMenu();
      JPopupMenu jpopupMenu1 = this.elementMenu;
      GlassPane glassPane2 = this;
      JMenu jmenu1 = new JMenu("Change to...");
      JMenu jmenu2 = jmenu1;
      this.changeToMenu = jmenu1;
      jpopupMenu1.add((JMenuItem) jmenu2);
      JPopupMenu jpopupMenu2 = this.elementMenu;
      JMenuItem.__\u003Cclinit\u003E();
      JMenuItem jmenuItem1 = new JMenuItem((Action) new GlassPane.PropertiesItemAction(this, "Properties...", (GlassPane\u00241) null));
      jpopupMenu2.add(jmenuItem1);
      JPopupMenu jpopupMenu3 = this.elementMenu;
      JMenuItem.__\u003Cclinit\u003E();
      JMenuItem jmenuItem2 = new JMenuItem((Action) new GlassPane.MoveToBackAction(this, "Send to Back", (GlassPane\u00241) null));
      jpopupMenu3.add(jmenuItem2);
      JPopupMenu jpopupMenu4 = this.elementMenu;
      GlassPane glassPane3 = this;
      JMenuItem.__\u003Cclinit\u003E();
      JMenuItem jmenuItem3 = new JMenuItem((Action) new GlassPane.ResetSizeAction(this, (GlassPane\u00241) null));
      JMenuItem jmenuItem4 = jmenuItem3;
      this.resizeMenu = jmenuItem3;
      jpopupMenu4.add(jmenuItem4);
      JPopupMenu jpopupMenu5 = this.elementMenu;
      JMenuItem.__\u003Cclinit\u003E();
      JMenuItem jmenuItem5 = new JMenuItem((Action) new GlassPane.DeleteItemAction(this));
      jpopupMenu5.add(jmenuItem5);
      ((Component) this).addComponentListener((ComponentListener) new GlassPane\u00241(this));
      ((Component) this).addKeyListener((KeyListener) new GlassPane\u00242(this));
      ((JComponent) this).setOpaque(false);
      ((Component) this).setFocusable(true);
      GlassPane.GlassMouseListener glassMouseListener = new GlassPane.GlassMouseListener(this, (GlassPane\u00241) null);
      ((Component) this).addMouseListener((MouseListener) glassMouseListener);
      ((Component) this).addMouseMotionListener((MouseMotionListener) glassMouseListener);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected GlassPane([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 122, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShowingGrid(bool showGrid)
    {
      int num = showGrid ? 1 : 0;
      if ((this.showGrid ? 1 : 0) == num)
        return;
      this.showGrid = num != 0;
      ((Component) this).repaint();
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static DisplayElement access\u00242200([In] GlassPane obj0)
    {
      return obj0.menuElement;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static DashboardPanel access\u00241700([In] GlassPane obj0)
    {
      return obj0.panel;
    }

    [LineNumberTable((ushort) 87)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private DisplayElement findElementContaining([In] Point obj0)
    {
      return this.panel.findElementContaining(obj0);
    }

    [LineNumberTable(new byte[] {(byte) 74, (byte) 108, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void showEditor([In] DisplayElement obj0)
    {
      PropertyEditor propertyEditor = this.frame.getPropertyEditor();
      propertyEditor.setPropertyHolder((PropertyHolder) obj0);
      ((Dialog) propertyEditor).setVisible(true);
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 140, (byte) 117, (byte) 149, (byte) 139, (byte) 112, (byte) 127, (byte) 2, (byte) 147, (byte) 127, (byte) 9, (byte) 147, (byte) 127, (byte) 9, (byte) 147, (byte) 127, (byte) 16, (byte) 147, (byte) 127, (byte) 16, (byte) 147, (byte) 127, (byte) 16, (byte) 147, (byte) 127, (byte) 9, (byte) 147, (byte) 127, (byte) 9, (byte) 147, (byte) 127, (byte) 16, (byte) 115, (byte) 98, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void defineBounds()
    {
      Rectangle bounds = ((Component) this.selectedElement).getBounds();
      int num1 = Math.max(Math.min(bounds.height / 5, 5), 1);
      int num2 = Math.max(Math.min(bounds.width / 5, 5), 1);
      this.areas.clear();
      if (this.selectedElement.isResizable())
      {
        Rectangle.__\u003Cclinit\u003E();
        this.areas.put((object) Integer.valueOf(8), (object) new Rectangle(bounds.x - num2, bounds.y - num1, 2 * num2, 2 * num1));
        Rectangle.__\u003Cclinit\u003E();
        this.areas.put((object) Integer.valueOf(1), (object) new Rectangle(bounds.x + num2, bounds.y - num1, bounds.width - 2 * num2, 2 * num1));
        Rectangle.__\u003Cclinit\u003E();
        this.areas.put((object) Integer.valueOf(2), (object) new Rectangle(bounds.x + bounds.width - num2, bounds.y - num1, 2 * num2, 2 * num1));
        Rectangle.__\u003Cclinit\u003E();
        this.areas.put((object) Integer.valueOf(3), (object) new Rectangle(bounds.x + bounds.width - num2, bounds.y + num1, 2 * num2, bounds.height - 2 * num1));
        Rectangle.__\u003Cclinit\u003E();
        this.areas.put((object) Integer.valueOf(4), (object) new Rectangle(bounds.x + bounds.width - num2, bounds.y + bounds.height - num1, 2 * num2, 2 * num1));
        Rectangle.__\u003Cclinit\u003E();
        this.areas.put((object) Integer.valueOf(5), (object) new Rectangle(bounds.x + num2, bounds.y + bounds.height - num1, bounds.width - 2 * num2, 2 * num1));
        Rectangle.__\u003Cclinit\u003E();
        this.areas.put((object) Integer.valueOf(6), (object) new Rectangle(bounds.x - num2, bounds.y + bounds.height - num1, 2 * num2, 2 * num1));
        Rectangle.__\u003Cclinit\u003E();
        this.areas.put((object) Integer.valueOf(7), (object) new Rectangle(bounds.x - num2, bounds.y + num1, 2 * num2, bounds.height - 2 * num1));
        Rectangle.__\u003Cclinit\u003E();
        this.areas.put((object) Integer.valueOf(0), (object) new Rectangle(bounds.x + num2, bounds.y + num1, bounds.width - 2 * num2, bounds.height - 2 * num1));
      }
      else
        this.areas.put((object) Integer.valueOf(0), (object) bounds);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 88, (byte) 105, (byte) 103, (byte) 104, (byte) 141, (byte) 134, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void setSelected([In] DisplayElement obj0)
    {
      if (this.selectedElement == obj0)
        return;
      this.selectedElement = obj0;
      if (this.selectedElement == null)
        this.areas.clear();
      else
        this.defineBounds();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 135, (byte) 108, (byte) 159, (byte) 2, (byte) 107, (byte) 140, (byte) 99, (byte) 145, (byte) 140, (byte) 135, (byte) 107, (byte) 98, (byte) 127, (byte) 0, (byte) 111, (byte) 100, (byte) 190, (byte) 99, (byte) 172, (byte) 98, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void prepareElementMenu([In] DisplayElement obj0)
    {
      this.menuElement = obj0;
      Dimension savedSize = this.menuElement.getSavedSize();
      this.resizeMenu.setEnabled(savedSize.width != -1 || savedSize.height != -1);
      if (obj0 is Widget)
      {
        DataType type = ((Widget) obj0).getType();
        if (type == null)
        {
          ((JMenuItem) this.changeToMenu).setEnabled(false);
        }
        else
        {
          ((JMenuItem) this.changeToMenu).setEnabled(true);
          Set widgetsForType = DisplayElementRegistry.getWidgetsForType(type);
          this.changeToMenu.removeAll();
          int num = 0;
          Iterator iterator = widgetsForType.iterator();
          while (iterator.hasNext())
          {
            Class clazz = (Class) iterator.next();
            if (!Object.instancehelper_equals((object) clazz, (object) Object.instancehelper_getClass((object) obj0)))
            {
              ++num;
              this.changeToMenu.add((Action) new GlassPane.ChangeToAction(this, DisplayElement.getName(clazz), clazz, (GlassPane\u00241) null));
            }
          }
          if (num != 0)
            return;
          ((JMenuItem) this.changeToMenu).setEnabled(false);
        }
      }
      else
        ((JMenuItem) this.changeToMenu).setEnabled(false);
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 135, (byte) 104, (byte) 140, (byte) 107, (byte) 191, (byte) 9, (byte) 107, (byte) 139, (byte) 108, (byte) 108, (byte) 141, (byte) 99, (byte) 109, (byte) 49, (byte) 220, (byte) 99, (byte) 109, (byte) 49, (byte) 222})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void paintComponent(Graphics g)
    {
      Rectangle bounds1 = ((Component) this).getBounds();
      if (this.selectedElement != null)
      {
        Rectangle bounds2 = ((Component) this.selectedElement).getBounds();
        g.setColor((Color) Color.GRAY);
        g.drawRoundRect(bounds2.x - 1, bounds2.y - 1, bounds2.width + 1, bounds2.height + 1, 8, 8);
      }
      if (!this.showGrid)
        return;
      g.setColor(GlassPane.GRID_COLOR);
      DashboardPrefs prefs = this.frame.getPrefs();
      int[] numArray1 = prefs.__\u003C\u003Egrid_widths.getValue();
      int[] numArray2 = prefs.__\u003C\u003Egrid_heights.getValue();
      int num1 = -1;
      for (int index1 = 0; index1 < bounds1.width; {
        int num2;
        int num3;
        index1 = num2 + num3;
      }
      )
      {
        g.drawLine(index1, 0, index1, (int) bounds1.height);
        num2 = index1;
        int[] numArray3 = numArray1;
        int num2 = num1 + 1;
        int length = numArray1.Length;
        int num3 = -1;
        int index2;
        num1 = index2 = length != num3 ? num2 % length : 0;
        num3 = numArray3[index2];
      }
      int num4 = -1;
      for (int index1 = 0; index1 < bounds1.height; {
        int num2;
        int num3;
        index1 = num2 + num3;
      }
      )
      {
        g.drawLine(0, index1, (int) bounds1.width, index1);
        num2 = index1;
        int[] numArray3 = numArray2;
        int num2 = num4 + 1;
        int length = numArray2.Length;
        int num3 = -1;
        int index2;
        num4 = index2 = length != num3 ? num2 % length : 0;
        num3 = numArray3[index2];
      }
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static bool access\u0024500([In] GlassPane obj0)
    {
      return obj0.showGrid;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static Rectangle access\u0024600([In] GlassPane obj0)
    {
      return obj0.dragStartBounds;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static DashboardFrame access\u0024700([In] GlassPane obj0)
    {
      return obj0.frame;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static Dimension access\u0024800([In] GlassPane obj0)
    {
      return obj0.dragMinSizeDelta;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static Dimension access\u0024900([In] GlassPane obj0)
    {
      return obj0.dragMaxSizeDelta;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static int access\u00241002([In] GlassPane obj0, [In] int obj1)
    {
      GlassPane glassPane1 = obj0;
      int num1 = obj1;
      GlassPane glassPane2 = glassPane1;
      int num2 = num1;
      glassPane2.dragType = num1;
      return num2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static DisplayElement access\u00241100([In] GlassPane obj0)
    {
      return obj0.selectedElement;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void access\u00241200([In] GlassPane obj0, [In] DisplayElement obj1)
    {
      obj0.prepareElementMenu(obj1);
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static JPopupMenu access\u00241300([In] GlassPane obj0)
    {
      return obj0.elementMenu;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static Map access\u00241400([In] GlassPane obj0)
    {
      return obj0.areas;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static int access\u00241000([In] GlassPane obj0)
    {
      return obj0.dragType;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static bool access\u00241500([In] GlassPane obj0)
    {
      return obj0.dragging;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static bool access\u00241502([In] GlassPane obj0, [In] bool obj1)
    {
      int num1 = obj1 ? 1 : 0;
      GlassPane glassPane1 = obj0;
      int num2 = num1;
      GlassPane glassPane2 = glassPane1;
      int num3 = num2;
      glassPane2.dragging = num2 != 0;
      return num3 != 0;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static Rectangle access\u0024602([In] GlassPane obj0, [In] Rectangle obj1)
    {
      GlassPane glassPane1 = obj0;
      Rectangle rectangle1 = obj1;
      GlassPane glassPane2 = glassPane1;
      Rectangle rectangle2 = rectangle1;
      glassPane2.dragStartBounds = rectangle1;
      return rectangle2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static Dimension access\u0024802([In] GlassPane obj0, [In] Dimension obj1)
    {
      GlassPane glassPane1 = obj0;
      Dimension dimension1 = obj1;
      GlassPane glassPane2 = glassPane1;
      Dimension dimension2 = dimension1;
      glassPane2.dragMinSizeDelta = dimension1;
      return dimension2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static Dimension access\u0024902([In] GlassPane obj0, [In] Dimension obj1)
    {
      GlassPane glassPane1 = obj0;
      Dimension dimension1 = obj1;
      GlassPane glassPane2 = glassPane1;
      Dimension dimension2 = dimension1;
      glassPane2.dragMaxSizeDelta = dimension1;
      return dimension2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static Point access\u00241602([In] GlassPane obj0, [In] Point obj1)
    {
      GlassPane glassPane1 = obj0;
      Point point1 = obj1;
      GlassPane glassPane2 = glassPane1;
      Point point2 = point1;
      glassPane2.dragStartPoint = point1;
      return point2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    internal static Point access\u00241600([In] GlassPane obj0)
    {
      return obj0.dragStartPoint;
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void access\u00241800([In] GlassPane obj0, [In] DisplayElement obj1)
    {
      obj0.setSelected(obj1);
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void access\u00241900([In] GlassPane obj0)
    {
      obj0.defineBounds();
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void access\u00242000([In] GlassPane obj0, [In] DisplayElement obj1)
    {
      obj0.showEditor(obj1);
    }

    [Modifiers]
    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DisplayElement access\u00242100([In] GlassPane obj0, [In] Point obj1)
    {
      return obj0.findElementContaining(obj1);
    }

    [InnerClass]
    [SourceFile("GlassPane.java")]
    [Modifiers]
    [Serializable]
    internal sealed class ChangeToAction : AbstractAction
    {
      [Signature("Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;")]
      internal Class elementClass;
      [Modifiers]
      internal GlassPane this\u00240;

      [Signature("(Ljava/lang/String;Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;)V")]
      [LineNumberTable(new byte[] {(byte) 161, (byte) 111, (byte) 103, (byte) 105, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private ChangeToAction([In] GlassPane obj0, [In] string obj1, [In] Class obj2)
      {
        base.\u002Ector(obj1);
        GlassPane.ChangeToAction changeToAction = this;
        this.elementClass = obj2;
      }

      [Modifiers]
      [LineNumberTable((ushort) 477)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal ChangeToAction([In] GlassPane obj0, [In] string obj1, [In] Class obj2, [In] GlassPane\u00241 obj3)
        : this(obj0, obj1, obj2)
      {
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected ChangeToAction([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 117, (byte) 117, (byte) 145, (byte) 125, (byte) 124, (byte) 127, (byte) 4, (byte) 98, (byte) 191, (byte) 12})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void actionPerformed([In] ActionEvent obj0)
      {
        if (!(GlassPane.access\u00242200(this.this\u00240) is Widget))
          return;
        Widget widget = (Widget) GlassPane.access\u00242200(this.this\u00240);
        if (GlassPane.access\u00241700(this.this\u00240).getTable().containsKey(widget.getFieldName()))
        {
          object obj = GlassPane.access\u00241700(this.this\u00240).getTable().getValue(widget.getFieldName());
          GlassPane.access\u00241700(this.this\u00240).setField(widget.getFieldName(), this.elementClass, obj, ((Component) widget).getLocation());
        }
        else
          GlassPane.access\u00241700(this.this\u00240).setField(widget.getFieldName(), this.elementClass, widget.getType(), (object) null, ((Component) widget).getLocation());
      }
    }

    [InnerClass]
    [SourceFile("GlassPane.java")]
    [Modifiers]
    [Serializable]
    internal sealed class DeleteItemAction : AbstractAction
    {
      [Modifiers]
      internal GlassPane this\u00240;

      [LineNumberTable(new byte[] {(byte) 161, (byte) 170, (byte) 103, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public DeleteItemAction([In] GlassPane obj0)
      {
        base.\u002Ector("Remove");
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected DeleteItemAction([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 175, (byte) 114, (byte) 127, (byte) 3, (byte) 114, (byte) 159, (byte) 8})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void actionPerformed([In] ActionEvent obj0)
      {
        if (GlassPane.access\u00242200(this.this\u00240) is StaticWidget)
        {
          GlassPane.access\u00241700(this.this\u00240).removeElement((StaticWidget) GlassPane.access\u00242200(this.this\u00240));
        }
        else
        {
          if (!(GlassPane.access\u00242200(this.this\u00240) is Widget))
            return;
          GlassPane.access\u00241700(this.this\u00240).removeField(((Widget) GlassPane.access\u00242200(this.this\u00240)).getFieldName());
        }
      }
    }

    [InnerClass]
    [SourceFile("GlassPane.java")]
    [Modifiers]
    internal sealed class GlassMouseListener : MouseAdapter
    {
      [Modifiers]
      internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<GlassPane>.Value).desiredAssertionStatus();
      private int lastDW;
      private int lastDH;
      private int lastDX;
      private int lastDY;
      [Modifiers]
      internal GlassPane this\u00240;

      [LineNumberTable((ushort) 213)]
      static GlassMouseListener()
      {
      }

      [Modifiers]
      [LineNumberTable((ushort) 213)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal GlassMouseListener([In] GlassPane obj0, [In] GlassPane\u00241 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable((ushort) 213)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private GlassMouseListener([In] GlassPane obj0)
      {
        base.\u002Ector();
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 112, (byte) 98, (byte) 112, (byte) 37, (byte) 198, (byte) 112, (byte) 101, (byte) 166, (byte) 105, (byte) 107, (byte) 7, (byte) 236, (byte) 70, (byte) 135})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private int adjust([In] int obj0, [In] int obj1, [In] int[] obj2)
      {
        if (!GlassPane.access\u0024500(this.this\u00240))
          return obj0;
        int num1 = 0;
        int[] numArray1 = obj2;
        int length = numArray1.Length;
        for (int index = 0; index < length; ++index)
        {
          int num2 = numArray1[index];
          num1 += num2;
        }
        int num3 = obj0 + obj1;
        int num4 = num1;
        int num5 = -1;
        int num6 = num4 != num5 ? num3 % num4 : 0;
        if (num6 < 0)
          num6 += num1;
        int index1 = 0;
        int num7 = 0;
        while (index1 < obj2.Length)
        {
          if (num6 < num7 + obj2[index1] / 2)
            return obj0 - num6 + num7;
          int num2 = num7;
          int[] numArray2 = obj2;
          int index2 = index1;
          ++index1;
          int num8 = numArray2[index2];
          num7 = num2 + num8;
        }
        return obj0 - num6 + num1;
      }

      [LineNumberTable((ushort) 249)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private int adjustY([In] int obj0)
      {
        return this.adjust(obj0, (int) GlassPane.access\u0024600(this.this\u00240).y, GlassPane.access\u0024700(this.this\u00240).getPrefs().__\u003C\u003Egrid_heights.getValue());
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 77, (byte) 98, (byte) 127, (byte) 7, (byte) 127, (byte) 7})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private int inRange([In] bool obj0, [In] int obj1)
      {
        int num1 = obj0 ? 1 : 0;
        int num2 = num1 == 0 ? (int) GlassPane.access\u0024800(this.this\u00240).height : (int) GlassPane.access\u0024800(this.this\u00240).width;
        int num3 = num1 == 0 ? (int) GlassPane.access\u0024900(this.this\u00240).height : (int) GlassPane.access\u0024900(this.this\u00240).width;
        if (obj1 > num3)
          return num3;
        if (obj1 < num2)
          return num2;
        else
          return obj1;
      }

      [LineNumberTable((ushort) 253)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private int adjustW([In] int obj0)
      {
        return this.adjust(obj0, (int) (GlassPane.access\u0024600(this.this\u00240).x + GlassPane.access\u0024600(this.this\u00240).width), GlassPane.access\u0024700(this.this\u00240).getPrefs().__\u003C\u003Egrid_widths.getValue());
      }

      [LineNumberTable((ushort) 257)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private int adjustH([In] int obj0)
      {
        return this.adjust(obj0, (int) (GlassPane.access\u0024600(this.this\u00240).y + GlassPane.access\u0024600(this.this\u00240).height), GlassPane.access\u0024700(this.this\u00240).getPrefs().__\u003C\u003Egrid_heights.getValue());
      }

      [LineNumberTable((ushort) 245)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private int adjustX([In] int obj0)
      {
        return this.adjust(obj0, (int) GlassPane.access\u0024600(this.this\u00240).x, GlassPane.access\u0024700(this.this\u00240).getPrefs().__\u003C\u003Egrid_widths.getValue());
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 46, (byte) 114, (byte) 113, (byte) 99, (byte) 98, (byte) 127, (byte) 11, (byte) 110, (byte) 98, (byte) 164, (byte) 99, (byte) 140, (byte) 98, (byte) 204, (byte) 117, (byte) 127, (byte) 18, (byte) 109, (byte) 113, (byte) 159, (byte) 32, (byte) 113, (byte) 133, (byte) 113, (byte) 133, (byte) 114, (byte) 133, (byte) 113, (byte) 133, (byte) 114, (byte) 133, (byte) 113, (byte) 130, (byte) 114, (byte) 130, (byte) 113, (byte) 130, (byte) 112, (byte) 130, (byte) 178, (byte) 135, (byte) 146})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void mouseMoved([In] MouseEvent obj0)
      {
        DisplayElement displayElement = GlassPane.access\u00242100(this.this\u00240, obj0.getPoint());
        if (displayElement != GlassPane.access\u00241100(this.this\u00240))
        {
          if (displayElement == null)
          {
            int num = 0;
            Iterator iterator = GlassPane.access\u00241400(this.this\u00240).values().iterator();
            while (iterator.hasNext())
            {
              if (((Rectangle) iterator.next()).contains(obj0.getPoint()))
              {
                num = 1;
                break;
              }
            }
            if (num == 0)
              GlassPane.access\u00241800(this.this\u00240, (DisplayElement) null);
          }
          else
            GlassPane.access\u00241800(this.this\u00240, displayElement);
        }
        if (!GlassPane.access\u00241400(this.this\u00240).isEmpty())
        {
          Iterator iterator = GlassPane.access\u00241400(this.this\u00240).entrySet().iterator();
          while (iterator.hasNext())
          {
            Map.Entry entry = (Map.Entry) iterator.next();
            if (((Rectangle) entry.getValue()).contains(obj0.getPoint()))
            {
              switch (((Integer) entry.getKey()).intValue())
              {
                case 0:
                  ((Component) this.this\u00240).setCursor(Cursor.getDefaultCursor());
                  return;
                case 1:
                  ((Component) this.this\u00240).setCursor(Cursor.getPredefinedCursor(8));
                  return;
                case 2:
                  ((Component) this.this\u00240).setCursor(Cursor.getPredefinedCursor(7));
                  return;
                case 3:
                  ((Component) this.this\u00240).setCursor(Cursor.getPredefinedCursor(11));
                  return;
                case 4:
                  ((Component) this.this\u00240).setCursor(Cursor.getPredefinedCursor(5));
                  return;
                case 5:
                  ((Component) this.this\u00240).setCursor(Cursor.getPredefinedCursor(9));
                  return;
                case 6:
                  ((Component) this.this\u00240).setCursor(Cursor.getPredefinedCursor(4));
                  return;
                case 7:
                  ((Component) this.this\u00240).setCursor(Cursor.getPredefinedCursor(10));
                  return;
                case 8:
                  ((Component) this.this\u00240).setCursor(Cursor.getPredefinedCursor(6));
                  return;
                default:
                  if (!GlassPane.GlassMouseListener.\u0024assertionsDisabled)
                  {
                    Throwable.__\u003CsuppressFillInStackTrace\u003E();
                    throw new AssertionError();
                  }
                  else
                    continue;
              }
            }
          }
        }
        else
          ((Component) this.this\u00240).setCursor(Cursor.getDefaultCursor());
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 141, (byte) 112, (byte) 104, (byte) 118, (byte) 159, (byte) 18, (byte) 127, (byte) 11, (byte) 120, (byte) 124, (byte) 228, (byte) 69})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void mousePressed([In] MouseEvent obj0)
      {
        GlassPane.access\u00241002(this.this\u00240, -1);
        if (GlassPane.access\u00241100(this.this\u00240) == null)
          return;
        if (obj0.isPopupTrigger())
        {
          GlassPane.access\u00241200(this.this\u00240, GlassPane.access\u00241100(this.this\u00240));
          GlassPane.access\u00241300(this.this\u00240).show((Component) this.this\u00240, (int) obj0.getPoint().x, (int) obj0.getPoint().y);
        }
        else
        {
          Iterator iterator = GlassPane.access\u00241400(this.this\u00240).entrySet().iterator();
          while (iterator.hasNext())
          {
            Map.Entry entry = (Map.Entry) iterator.next();
            if (((Rectangle) entry.getValue()).contains(obj0.getPoint()))
            {
              GlassPane.access\u00241002(this.this\u00240, ((Integer) entry.getKey()).intValue());
              break;
            }
          }
        }
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 173, (byte) 104, (byte) 161, (byte) 127, (byte) 2, (byte) 112, (byte) 141, (byte) 124, (byte) 124, (byte) 127, (byte) 8, (byte) 127, (byte) 8, (byte) 124, (byte) 127, (byte) 8, (byte) 127, (byte) 8, (byte) 146, (byte) 223, (byte) 9, (byte) 137, (byte) 159, (byte) 26, (byte) 127, (byte) 12, (byte) 99, (byte) 133, (byte) 127, (byte) 12, (byte) 99, (byte) 127, (byte) 11, (byte) 133, (byte) 127, (byte) 11, (byte) 133, (byte) 127, (byte) 11, (byte) 127, (byte) 11, (byte) 133, (byte) 127, (byte) 11, (byte) 133, (byte) 127, (byte) 11, (byte) 127, (byte) 12, (byte) 100, (byte) 133, (byte) 127, (byte) 12, (byte) 100, (byte) 133, (byte) 127, (byte) 12, (byte) 99, (byte) 127, (byte) 12, (byte) 100, (byte) 133, (byte) 114, (byte) 127, (byte) 33, (byte) 127, (byte) 50, (byte) 120, (byte) 127, (byte) 33, (byte) 127, (byte) 50, (byte) 119, (byte) 130, (byte) 178, (byte) 131, (byte) 117, (byte) 99, (byte) 114, (byte) 105, (byte) 121, (byte) 135, (byte) 105, (byte) 121, (byte) 135, (byte) 146, (byte) 115, (byte) 99, (byte) 114, (byte) 106, (byte) 114, (byte) 104, (byte) 167, (byte) 100, (byte) 112, (byte) 178})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void mouseDragged([In] MouseEvent obj0)
      {
        if (((InputEvent) obj0).isMetaDown() || GlassPane.access\u00241100(this.this\u00240) == null || GlassPane.access\u00241000(this.this\u00240) == -1)
          return;
        if (!GlassPane.access\u00241500(this.this\u00240))
        {
          GlassPane.access\u00241502(this.this\u00240, true);
          GlassPane.access\u0024602(this.this\u00240, ((Component) GlassPane.access\u00241100(this.this\u00240)).getBounds());
          GlassPane.access\u0024802(this.this\u00240, ((JComponent) GlassPane.access\u00241100(this.this\u00240)).getMinimumSize());
          Dimension dimension1 = GlassPane.access\u0024800(this.this\u00240);
          // ISSUE: variable of the null type
          __Null local1 = dimension1.width - GlassPane.access\u0024600(this.this\u00240).width;
          dimension1.width = local1;
          Dimension dimension2 = GlassPane.access\u0024800(this.this\u00240);
          // ISSUE: variable of the null type
          __Null local2 = dimension2.height - GlassPane.access\u0024600(this.this\u00240).height;
          dimension2.height = local2;
          GlassPane.access\u0024902(this.this\u00240, ((JComponent) GlassPane.access\u00241100(this.this\u00240)).getMaximumSize());
          Dimension dimension3 = GlassPane.access\u0024900(this.this\u00240);
          // ISSUE: variable of the null type
          __Null local3 = dimension3.width - GlassPane.access\u0024600(this.this\u00240).width;
          dimension3.width = local3;
          Dimension dimension4 = GlassPane.access\u0024900(this.this\u00240);
          // ISSUE: variable of the null type
          __Null local4 = dimension4.height - GlassPane.access\u0024600(this.this\u00240).height;
          dimension4.height = local4;
          GlassPane.access\u00241602(this.this\u00240, obj0.getPoint());
          GlassPane.GlassMouseListener glassMouseListener1 = this;
          GlassPane.GlassMouseListener glassMouseListener2 = this;
          GlassPane.GlassMouseListener glassMouseListener3 = this;
          int num1 = 0;
          int num2 = num1;
          this.lastDY = num1;
          int num3 = num2;
          int num4 = num3;
          this.lastDX = num3;
          int num5 = num4;
          int num6 = num5;
          this.lastDW = num5;
          this.lastDH = num6;
        }
        int num7;
        int num8 = num7 = 0;
        int num9 = num7;
        int num10 = num7;
        int num11 = num7;
        switch (GlassPane.access\u00241000(this.this\u00240))
        {
          case 0:
            DashboardPrefs prefs = GlassPane.access\u0024700(this.this\u00240).getPrefs();
            int num12 = this.adjust((int) (obj0.getPoint().x - GlassPane.access\u00241600(this.this\u00240).x), (int) GlassPane.access\u0024600(this.this\u00240).x, prefs.__\u003C\u003Egrid_widths.getValue());
            int num13 = this.adjust((int) (obj0.getPoint().x - GlassPane.access\u00241600(this.this\u00240).x), (int) (GlassPane.access\u0024600(this.this\u00240).x + GlassPane.access\u0024600(this.this\u00240).width), prefs.__\u003C\u003Egrid_widths.getValue());
            num11 = Math.abs(num12) >= Math.abs(num13) ? num13 : num12;
            int num14 = this.adjust((int) (obj0.getPoint().y - GlassPane.access\u00241600(this.this\u00240).y), (int) GlassPane.access\u0024600(this.this\u00240).y, prefs.__\u003C\u003Egrid_heights.getValue());
            int num15 = this.adjust((int) (obj0.getPoint().y - GlassPane.access\u00241600(this.this\u00240).y), (int) (GlassPane.access\u0024600(this.this\u00240).y + GlassPane.access\u0024600(this.this\u00240).height), prefs.__\u003C\u003Egrid_heights.getValue());
            num10 = Math.abs(num14) >= Math.abs(num15) ? num15 : num14;
            break;
          case 1:
            num8 = this.inRange(false, -this.adjustY((int) (obj0.getPoint().y - GlassPane.access\u00241600(this.this\u00240).y)));
            num10 = -num8;
            break;
          case 2:
            num8 = this.inRange(false, -this.adjustY((int) (obj0.getPoint().y - GlassPane.access\u00241600(this.this\u00240).y)));
            num10 = -num8;
            num9 = this.inRange(true, this.adjustW((int) (obj0.getPoint().x - GlassPane.access\u00241600(this.this\u00240).x)));
            break;
          case 3:
            num9 = this.inRange(true, this.adjustW((int) (obj0.getPoint().x - GlassPane.access\u00241600(this.this\u00240).x)));
            break;
          case 4:
            num9 = this.inRange(true, this.adjustW((int) (obj0.getPoint().x - GlassPane.access\u00241600(this.this\u00240).x)));
            num8 = this.inRange(false, this.adjustH((int) (obj0.getPoint().y - GlassPane.access\u00241600(this.this\u00240).y)));
            break;
          case 5:
            num8 = this.inRange(false, this.adjustH((int) (obj0.getPoint().y - GlassPane.access\u00241600(this.this\u00240).y)));
            break;
          case 6:
            num8 = this.inRange(false, this.adjustH((int) (obj0.getPoint().y - GlassPane.access\u00241600(this.this\u00240).y)));
            num9 = this.inRange(true, -this.adjustX((int) (obj0.getPoint().x - GlassPane.access\u00241600(this.this\u00240).x)));
            num11 = -num9;
            break;
          case 7:
            num9 = this.inRange(true, -this.adjustX((int) (obj0.getPoint().x - GlassPane.access\u00241600(this.this\u00240).x)));
            num11 = -num9;
            break;
          case 8:
            num8 = this.inRange(false, -this.adjustY((int) (obj0.getPoint().y - GlassPane.access\u00241600(this.this\u00240).y)));
            num10 = -num8;
            num9 = this.inRange(true, -this.adjustX((int) (obj0.getPoint().x - GlassPane.access\u00241600(this.this\u00240).x)));
            num11 = -num9;
            break;
          default:
            if (!GlassPane.GlassMouseListener.\u0024assertionsDisabled)
            {
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new AssertionError();
            }
            else
              break;
        }
        int num16 = 0;
        if (num9 != this.lastDW || num8 != this.lastDH)
        {
          num16 = 1;
          Dimension savedSize = GlassPane.access\u00241100(this.this\u00240).getSavedSize();
          if (num9 != this.lastDW)
          {
            savedSize.width = (__Null) (GlassPane.access\u0024600(this.this\u00240).width + num9);
            this.lastDW = num9;
          }
          if (num8 != this.lastDH)
          {
            savedSize.height = (__Null) (GlassPane.access\u0024600(this.this\u00240).height + num8);
            this.lastDH = num8;
          }
          GlassPane.access\u00241100(this.this\u00240).setSavedSize(savedSize);
        }
        if (num11 != this.lastDX || num10 != this.lastDY)
        {
          num16 = 1;
          Point location = GlassPane.access\u0024600(this.this\u00240).getLocation();
          location.translate(num11, num10);
          GlassPane.access\u00241100(this.this\u00240).setSavedLocation(location);
          this.lastDX = num11;
          this.lastDY = num10;
        }
        if (num16 == 0)
          return;
        GlassPane.access\u00241700(this.this\u00240).revalidateBacking();
        ((Component) GlassPane.access\u0024700(this.this\u00240)).repaint();
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 21, (byte) 109, (byte) 109, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void mouseExited([In] MouseEvent obj0)
      {
        GlassPane.access\u00241002(this.this\u00240, -1);
        GlassPane.access\u00241502(this.this\u00240, false);
        GlassPane.access\u00241800(this.this\u00240, (DisplayElement) null);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 28, (byte) 110, (byte) 109, (byte) 107, (byte) 140, (byte) 109, (byte) 104, (byte) 118, (byte) 127, (byte) 15, (byte) 105, (byte) 216})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void mouseReleased([In] MouseEvent obj0)
      {
        if (GlassPane.access\u00241500(this.this\u00240))
        {
          GlassPane.access\u00241502(this.this\u00240, false);
          GlassPane.access\u00241900(this.this\u00240);
          this.mouseMoved(obj0);
        }
        else
        {
          if (GlassPane.access\u00241100(this.this\u00240) == null)
            return;
          if (obj0.isPopupTrigger())
          {
            GlassPane.access\u00241200(this.this\u00240, GlassPane.access\u00241100(this.this\u00240));
            GlassPane.access\u00241300(this.this\u00240).show((Component) this.this\u00240, (int) obj0.getPoint().x, (int) obj0.getPoint().y);
          }
          else
          {
            if (obj0.getClickCount() != 2)
              return;
            GlassPane.access\u00242000(this.this\u00240, GlassPane.access\u00241100(this.this\u00240));
          }
        }
      }
    }

    [InnerClass]
    [SourceFile("GlassPane.java")]
    [Modifiers]
    [Serializable]
    internal sealed class MoveToBackAction : AbstractAction
    {
      [Modifiers]
      internal GlassPane this\u00240;

      [Modifiers]
      [LineNumberTable((ushort) 500)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal MoveToBackAction([In] GlassPane obj0, [In] string obj1, [In] GlassPane\u00241 obj2)
        : this(obj0, obj1)
      {
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 132, (byte) 103, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private MoveToBackAction([In] GlassPane obj0, [In] string obj1)
      {
        base.\u002Ector(obj1);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected MoveToBackAction([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 137, (byte) 125})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void actionPerformed([In] ActionEvent obj0)
      {
        GlassPane.access\u00241700(this.this\u00240).shiftToBack(GlassPane.access\u00242200(this.this\u00240));
      }
    }

    [InnerClass]
    [SourceFile("GlassPane.java")]
    [Modifiers]
    [Serializable]
    internal sealed class PropertiesItemAction : AbstractAction
    {
      [Modifiers]
      internal GlassPane this\u00240;

      [Modifiers]
      [LineNumberTable((ushort) 527)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal PropertiesItemAction([In] GlassPane obj0, [In] string obj1, [In] GlassPane\u00241 obj2)
        : this(obj0, obj1)
      {
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 159, (byte) 103, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private PropertiesItemAction([In] GlassPane obj0, [In] string obj1)
      {
        base.\u002Ector(obj1);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected PropertiesItemAction([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 164, (byte) 120})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void actionPerformed([In] ActionEvent obj0)
      {
        GlassPane.access\u00242000(this.this\u00240, GlassPane.access\u00242200(this.this\u00240));
      }
    }

    [InnerClass]
    [SourceFile("GlassPane.java")]
    [Modifiers]
    [Serializable]
    internal sealed class ResetSizeAction : AbstractAction
    {
      [Modifiers]
      internal GlassPane this\u00240;

      [Modifiers]
      [LineNumberTable((ushort) 511)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal ResetSizeAction([In] GlassPane obj0, [In] GlassPane\u00241 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 143, (byte) 103, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private ResetSizeAction([In] GlassPane obj0)
      {
        base.\u002Ector("Reset Size");
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected ResetSizeAction([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 148, (byte) 119, (byte) 114})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void actionPerformed([In] ActionEvent obj0)
      {
        GlassPane.access\u00242200(this.this\u00240).setSavedSize(new Dimension(-1, -1));
        GlassPane.access\u00241700(this.this\u00240).revalidateBacking();
      }
    }
  }
}
