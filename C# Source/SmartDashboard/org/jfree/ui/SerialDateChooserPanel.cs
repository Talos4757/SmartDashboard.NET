// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.SerialDateChooserPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using org.jfree.date;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [Serializable]
  public class SerialDateChooserPanel : JPanel, ActionListener, EventListener
  {
    internal static Color __\u003C\u003EDEFAULT_DATE_BUTTON_COLOR;
    internal static Color __\u003C\u003EDEFAULT_MONTH_BUTTON_COLOR;
    private SerialDate date;
    private Color dateButtonColor;
    private Color monthButtonColor;
    private Color chosenOtherButtonColor;
    private int firstDayOfWeek;
    private int yearSelectionRange;
    private Font dateFont;
    private JComboBox monthSelector;
    private JComboBox yearSelector;
    private JButton todayButton;
    private JButton[] buttons;
    private bool refreshing;

    [Modifiers]
    public static Color DEFAULT_DATE_BUTTON_COLOR
    {
      [HideFromJava] get
      {
        return SerialDateChooserPanel.__\u003C\u003EDEFAULT_DATE_BUTTON_COLOR;
      }
    }

    [Modifiers]
    public static Color DEFAULT_MONTH_BUTTON_COLOR
    {
      [HideFromJava] get
      {
        return SerialDateChooserPanel.__\u003C\u003EDEFAULT_MONTH_BUTTON_COLOR;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 123, (byte) 69, (byte) 170})]
    static SerialDateChooserPanel()
    {
      JPanel.__\u003Cclinit\u003E();
      SerialDateChooserPanel.__\u003C\u003EDEFAULT_DATE_BUTTON_COLOR = (Color) Color.red;
      SerialDateChooserPanel.__\u003C\u003EDEFAULT_MONTH_BUTTON_COLOR = (Color) Color.lightGray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 104, (byte) 130, (byte) 237, (byte) 1, (byte) 171, (byte) 167, (byte) 168, (byte) 179, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 231, (byte) 105, (byte) 103, (byte) 103, (byte) 136, (byte) 113, (byte) 113, (byte) 99, (byte) 179})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerialDateChooserPanel(SerialDate date, bool controlPanel, Color dateButtonColor, Color monthButtonColor)
    {
      int num = controlPanel ? 1 : 0;
      base.\u002Ector((LayoutManager) new BorderLayout());
      SerialDateChooserPanel dateChooserPanel = this;
      this.chosenOtherButtonColor = (Color) Color.darkGray;
      this.firstDayOfWeek = 1;
      this.yearSelectionRange = 20;
      this.dateFont = new Font("SansSerif", 0, 10);
      this.monthSelector = (JComboBox) null;
      this.yearSelector = (JComboBox) null;
      this.todayButton = (JButton) null;
      this.buttons = (JButton[]) null;
      this.refreshing = false;
      this.date = date;
      this.dateButtonColor = dateButtonColor;
      this.monthButtonColor = monthButtonColor;
      ((Container) this).add((Component) this.constructSelectionPanel(), (object) "North");
      ((Container) this).add((Component) this.getCalendarPanel(), (object) "Center");
      if (num == 0)
        return;
      ((Container) this).add((Component) this.constructControlPanel(), (object) "South");
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 221})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerialDateChooserPanel()
      : this(SerialDate.createInstance(new Date()), false, SerialDateChooserPanel.__\u003C\u003EDEFAULT_DATE_BUTTON_COLOR, SerialDateChooserPanel.__\u003C\u003EDEFAULT_MONTH_BUTTON_COLOR)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 108, (byte) 98, (byte) 212})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerialDateChooserPanel(SerialDate date, bool controlPanel)
    {
      int num = controlPanel ? 1 : 0;
      // ISSUE: explicit constructor call
      this.\u002Ector(date, num != 0, SerialDateChooserPanel.__\u003C\u003EDEFAULT_DATE_BUTTON_COLOR, SerialDateChooserPanel.__\u003C\u003EDEFAULT_MONTH_BUTTON_COLOR);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SerialDateChooserPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 102, (byte) 117, (byte) 108, (byte) 112, (byte) 141, (byte) 119, (byte) 108, (byte) 112, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JPanel constructSelectionPanel()
    {
      JPanel jpanel = new JPanel();
      JComboBox.__\u003Cclinit\u003E();
      this.monthSelector = new JComboBox((object[]) SerialDate.getMonths());
      this.monthSelector.addActionListener((ActionListener) this);
      this.monthSelector.setActionCommand("monthSelectionChanged");
      ((Container) jpanel).add((Component) this.monthSelector);
      JComboBox.__\u003Cclinit\u003E();
      this.yearSelector = new JComboBox(this.getYears(0));
      this.yearSelector.addActionListener((ActionListener) this);
      this.yearSelector.setActionCommand("yearSelectionChanged");
      ((Container) jpanel).add((Component) this.yearSelector);
      return jpanel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 123, (byte) 114, (byte) 114, (byte) 114, (byte) 114, (byte) 114, (byte) 114, (byte) 114, (byte) 146, (byte) 109, (byte) 106, (byte) 107, (byte) 111, (byte) 108, (byte) 108, (byte) 103, (byte) 107, (byte) 103, (byte) 105, (byte) 232, (byte) 55, (byte) 233, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JPanel getCalendarPanel()
    {
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel = new JPanel((LayoutManager) new GridLayout(7, 7));
      ((Container) jpanel).add((Component) new JLabel("Sun", 0));
      ((Container) jpanel).add((Component) new JLabel("Mon", 0));
      ((Container) jpanel).add((Component) new JLabel("Tue", 0));
      ((Container) jpanel).add((Component) new JLabel("Wed", 0));
      ((Container) jpanel).add((Component) new JLabel("Thu", 0));
      ((Container) jpanel).add((Component) new JLabel("Fri", 0));
      ((Container) jpanel).add((Component) new JLabel("Sat", 0));
      this.buttons = new JButton[42];
      for (int index = 0; index < 42; ++index)
      {
        JButton jbutton = new JButton("");
        ((AbstractButton) jbutton).setMargin(new Insets(1, 1, 1, 1));
        ((Component) jbutton).setName(Integer.toString(index));
        ((JComponent) jbutton).setFont(this.dateFont);
        ((AbstractButton) jbutton).setFocusPainted(false);
        ((AbstractButton) jbutton).setActionCommand("dateButtonClicked");
        ((AbstractButton) jbutton).addActionListener((ActionListener) this);
        this.buttons[index] = jbutton;
        ((Container) jpanel).add((Component) jbutton);
      }
      return jpanel;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 17, (byte) 102, (byte) 111, (byte) 112, (byte) 108, (byte) 112, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JPanel constructControlPanel()
    {
      JPanel jpanel = new JPanel();
      ((JComponent) jpanel).setBorder(BorderFactory.createEmptyBorder(2, 5, 2, 5));
      this.todayButton = new JButton("Today");
      ((AbstractButton) this.todayButton).addActionListener((ActionListener) this);
      ((AbstractButton) this.todayButton).setActionCommand("todayButtonClicked");
      ((Container) jpanel).add((Component) this.todayButton);
      return jpanel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 215, (byte) 107, (byte) 103, (byte) 107, (byte) 114, (byte) 111, (byte) 147, (byte) 127, (byte) 1, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void refreshYearSelector()
    {
      if (this.refreshing)
        return;
      this.refreshing = true;
      this.yearSelector.removeAllItems();
      Enumeration enumeration = this.getYears(this.date.getYYYY()).elements();
      while (enumeration.hasMoreElements())
        this.yearSelector.addItem(enumeration.nextElement());
      JComboBox jcomboBox = this.yearSelector;
      Integer.__\u003Cclinit\u003E();
      Integer integer = new Integer(this.date.getYYYY());
      jcomboBox.setSelectedItem((object) integer);
      this.refreshing = false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 200, (byte) 103, (byte) 103, (byte) 105, (byte) 113, (byte) 109, (byte) 232, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void refreshButtons()
    {
      SerialDate serialDate = this.getFirstVisibleDate();
      for (int index = 0; index < 42; ++index)
      {
        JButton jbutton = this.buttons[index];
        ((AbstractButton) jbutton).setText(String.valueOf(serialDate.getDayOfWeek()));
        ((JComponent) jbutton).setBackground(this.getButtonColor(serialDate));
        serialDate = SerialDate.addDays(1, serialDate);
      }
    }

    [LineNumberTable(new byte[] {(byte) 125, (byte) 103, (byte) 115, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDate(SerialDate date)
    {
      this.date = date;
      this.monthSelector.setSelectedIndex(date.getMonth() - 1);
      this.refreshYearSelector();
      this.refreshButtons();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 177, (byte) 125, (byte) 104, (byte) 110, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual SerialDate getFirstVisibleDate()
    {
      SerialDate @base = SerialDate.addDays(-1, SerialDate.createInstance(1, this.date.getMonth(), this.date.getYYYY()));
      while (@base.getDayOfWeek() != this.getFirstDayOfWeek())
        @base = SerialDate.addDays(-1, @base);
      return @base;
    }

    private int getFirstDayOfWeek()
    {
      return this.firstDayOfWeek;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 157, (byte) 115, (byte) 135, (byte) 115, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Color getButtonColor(SerialDate targetDate)
    {
      if (Object.instancehelper_equals((object) this.date, (object) this.date))
        return this.dateButtonColor;
      if (targetDate.getMonth() == this.date.getMonth())
        return this.monthButtonColor;
      else
        return this.chosenOtherButtonColor;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 102, (byte) 105, (byte) 107, (byte) 44, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector getYears([In] int obj0)
    {
      Vector vector = new Vector();
      for (int index = obj0 - this.yearSelectionRange; index <= obj0 + this.yearSelectionRange; ++index)
        vector.addElement((object) new Integer(index));
      return vector;
    }

    public virtual SerialDate getDate()
    {
      return this.date;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 114, (byte) 108, (byte) 191, (byte) 10, (byte) 102, (byte) 101, (byte) 114, (byte) 107, (byte) 108, (byte) 108, (byte) 191, (byte) 8, (byte) 102, (byte) 102, (byte) 133, (byte) 114, (byte) 146, (byte) 114, (byte) 108, (byte) 108, (byte) 104, (byte) 106, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed(ActionEvent e)
    {
      if (String.instancehelper_equals(e.getActionCommand(), (object) "monthSelectionChanged"))
      {
        this.date = SerialDate.createInstance(this.date.getDayOfMonth(), ((JComboBox) ((EventObject) e).getSource()).getSelectedIndex() + 1, this.date.getYYYY());
        this.refreshButtons();
      }
      else if (String.instancehelper_equals(e.getActionCommand(), (object) "yearSelectionChanged"))
      {
        if (this.refreshing)
          return;
        this.date = SerialDate.createInstance(this.date.getDayOfMonth(), this.date.getMonth(), ((Integer) ((JComboBox) ((EventObject) e).getSource()).getSelectedItem()).intValue());
        this.refreshYearSelector();
        this.refreshButtons();
      }
      else if (String.instancehelper_equals(e.getActionCommand(), (object) "todayButtonClicked"))
      {
        this.setDate(SerialDate.createInstance(new Date()));
      }
      else
      {
        if (!String.instancehelper_equals(e.getActionCommand(), (object) "dateButtonClicked"))
          return;
        this.setDate(SerialDate.addDays(Integer.parseInt(((Component) ((EventObject) e).getSource()).getName()), this.getFirstVisibleDate()));
      }
    }
  }
}
