// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.DateChooserPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.@event;
using java.lang;
using java.text;
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
  public class DateChooserPanel : JPanel, ActionListener, EventListener
  {
    private Calendar chosenDate;
    private Color chosenDateButtonColor;
    private Color chosenMonthButtonColor;
    private Color chosenOtherButtonColor;
    private int firstDayOfWeek;
    private int yearSelectionRange;
    private Font dateFont;
    private JComboBox monthSelector;
    private JComboBox yearSelector;
    private JButton todayButton;
    private JButton[] buttons;
    private bool refreshing;
    private int[] WEEK_DAYS;

    [HideFromJava]
    static DateChooserPanel()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 102, (byte) 130, (byte) 237, (byte) 7, (byte) 232, (byte) 69, (byte) 243, (byte) 90, (byte) 231, (byte) 92, (byte) 112, (byte) 112, (byte) 176, (byte) 103, (byte) 108, (byte) 108, (byte) 102, (byte) 63, (byte) 0, (byte) 198, (byte) 113, (byte) 113, (byte) 99, (byte) 145, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateChooserPanel(Calendar calendar, bool controlPanel)
    {
      int num1 = controlPanel ? 1 : 0;
      base.\u002Ector((LayoutManager) new BorderLayout());
      DateChooserPanel dateChooserPanel = this;
      this.yearSelectionRange = 20;
      this.dateFont = new Font("SansSerif", 0, 10);
      this.refreshing = false;
      this.chosenDateButtonColor = UIManager.getColor((object) "textHighlight");
      this.chosenMonthButtonColor = UIManager.getColor((object) "control");
      this.chosenOtherButtonColor = UIManager.getColor((object) "controlShadow");
      this.chosenDate = calendar;
      this.firstDayOfWeek = calendar.getFirstDayOfWeek();
      this.WEEK_DAYS = new int[7];
      for (int index1 = 0; index1 < 7; ++index1)
      {
        int[] numArray = this.WEEK_DAYS;
        int index2 = index1;
        int num2 = this.firstDayOfWeek + index1 - 1;
        int num3 = 7;
        int num4 = -1;
        int num5 = (num3 != num4 ? num2 % num3 : 0) + 1;
        numArray[index2] = num5;
      }
      ((Container) this).add((Component) this.constructSelectionPanel(), (object) "North");
      ((Container) this).add((Component) this.getCalendarPanel(), (object) "Center");
      if (num1 != 0)
        ((Container) this).add((Component) this.constructControlPanel(), (object) "South");
      this.setDate(calendar.getTime());
    }

    [LineNumberTable(new byte[] {(byte) 99, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateChooserPanel()
      : this(Calendar.getInstance(), false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DateChooserPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 48, (byte) 134, (byte) 109, (byte) 109, (byte) 107, (byte) 175, (byte) 108, (byte) 108, (byte) 112, (byte) 141, (byte) 119, (byte) 108, (byte) 112, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JPanel constructSelectionPanel()
    {
      JPanel jpanel = new JPanel();
      int minimum = this.chosenDate.getMinimum(2);
      string[] strArray = new string[this.chosenDate.getMaximum(2) - minimum + 1];
      ByteCodeHelper.arraycopy_fast((Array) SerialDate.getMonths(), minimum, (Array) strArray, 0, strArray.Length);
      this.monthSelector = new JComboBox((object[]) strArray);
      this.monthSelector.addActionListener((ActionListener) this);
      this.monthSelector.setActionCommand("monthSelectionChanged");
      ((Container) jpanel).add((Component) this.monthSelector);
      JComboBox.__\u003Cclinit\u003E();
      this.yearSelector = new JComboBox((object[]) this.getYears(0));
      this.yearSelector.addActionListener((ActionListener) this);
      this.yearSelector.setActionCommand("yearSelectionChanged");
      ((Container) jpanel).add((Component) this.yearSelector);
      return jpanel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 157, (byte) 114, (byte) 102, (byte) 135, (byte) 108, (byte) 60, (byte) 230, (byte) 69, (byte) 109, (byte) 106, (byte) 108, (byte) 112, (byte) 109, (byte) 109, (byte) 104, (byte) 108, (byte) 104, (byte) 106, (byte) 233, (byte) 55, (byte) 233, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JPanel getCalendarPanel()
    {
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new GridLayout(7, 7));
      string[] shortWeekdays = new DateFormatSymbols().getShortWeekdays();
      for (int index = 0; index < this.WEEK_DAYS.Length; ++index)
      {
        JPanel jpanel2 = jpanel1;
        JLabel.__\u003Cclinit\u003E();
        JLabel jlabel = new JLabel(shortWeekdays[this.WEEK_DAYS[index]], 0);
        ((Container) jpanel2).add((Component) jlabel);
      }
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
        ((Container) jpanel1).add((Component) jbutton);
      }
      return jpanel1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 77, (byte) 102, (byte) 111, (byte) 112, (byte) 108, (byte) 112, (byte) 109})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 108, (byte) 151, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDate(Date theDate)
    {
      this.chosenDate.setTime(theDate);
      this.monthSelector.setSelectedIndex(this.chosenDate.get(2));
      this.refreshYearSelector();
      this.refreshButtons();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 8, (byte) 107, (byte) 103, (byte) 107, (byte) 147, (byte) 103, (byte) 46, (byte) 166, (byte) 159, (byte) 2, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void refreshYearSelector()
    {
      if (this.refreshing)
        return;
      this.refreshing = true;
      this.yearSelector.removeAllItems();
      foreach (object obj in this.getYears(this.chosenDate.get(1)))
        this.yearSelector.addItem(obj);
      JComboBox jcomboBox = this.yearSelector;
      Integer.__\u003Cclinit\u003E();
      Integer integer = new Integer(this.chosenDate.get(1));
      jcomboBox.setSelectedItem((object) integer);
      this.refreshing = false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 250, (byte) 103, (byte) 103, (byte) 105, (byte) 114, (byte) 109, (byte) 232, (byte) 60, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void refreshButtons()
    {
      Calendar firstVisibleDate = this.getFirstVisibleDate();
      for (int index = 0; index < 42; ++index)
      {
        JButton jbutton = this.buttons[index];
        ((AbstractButton) jbutton).setText(Integer.toString(firstVisibleDate.get(5)));
        ((JComponent) jbutton).setBackground(this.getButtonColor(firstVisibleDate));
        firstVisibleDate.add(5, 1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 226, (byte) 102, (byte) 159, (byte) 0, (byte) 104, (byte) 111, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Calendar getFirstVisibleDate()
    {
      Calendar instance = Calendar.getInstance();
      instance.set(this.chosenDate.get(1), this.chosenDate.get(2), 1);
      instance.add(5, -1);
      while (instance.get(7) != this.getFirstDayOfWeek())
        instance.add(5, -1);
      return instance;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 209, (byte) 191, (byte) 17, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool equalDates([In] Calendar obj0, [In] Calendar obj1)
    {
      return obj0.get(5) == obj1.get(5) && obj0.get(2) == obj1.get(2) && obj0.get(1) == obj1.get(1);
    }

    private int getFirstDayOfWeek()
    {
      return this.firstDayOfWeek;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 189, (byte) 111, (byte) 135, (byte) 149, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color getButtonColor([In] Calendar obj0)
    {
      if (this.equalDates(obj0, this.chosenDate))
        return this.chosenDateButtonColor;
      if (obj0.get(2) == this.chosenDate.get(2))
        return this.chosenMonthButtonColor;
      else
        return this.chosenOtherButtonColor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 31, (byte) 107, (byte) 137, (byte) 103, (byte) 102, (byte) 43, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Integer[] getYears([In] int obj0)
    {
      int length = this.yearSelectionRange * 2 + 1;
      int num = obj0 - this.yearSelectionRange;
      Integer[] integerArray = new Integer[length];
      for (int index = 0; index < length; ++index)
        integerArray[index] = new Integer(index + num);
      return integerArray;
    }

    [LineNumberTable((ushort) 205)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getDate()
    {
      return this.chosenDate.getTime();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 114, (byte) 236, (byte) 70, (byte) 109, (byte) 109, (byte) 114, (byte) 141, (byte) 147, (byte) 102, (byte) 101, (byte) 117, (byte) 107, (byte) 108, (byte) 236, (byte) 70, (byte) 109, (byte) 109, (byte) 114, (byte) 142, (byte) 148, (byte) 102, (byte) 102, (byte) 133, (byte) 114, (byte) 141, (byte) 114, (byte) 109, (byte) 109, (byte) 104, (byte) 105, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed(ActionEvent e)
    {
      if (String.instancehelper_equals(e.getActionCommand(), (object) "monthSelectionChanged"))
      {
        JComboBox jcomboBox = (JComboBox) ((EventObject) e).getSource();
        int num = this.chosenDate.get(5);
        this.chosenDate.set(5, 1);
        this.chosenDate.set(2, jcomboBox.getSelectedIndex());
        int actualMaximum = this.chosenDate.getActualMaximum(5);
        this.chosenDate.set(5, Math.min(num, actualMaximum));
        this.refreshButtons();
      }
      else if (String.instancehelper_equals(e.getActionCommand(), (object) "yearSelectionChanged"))
      {
        if (this.refreshing)
          return;
        Integer integer = (Integer) ((JComboBox) ((EventObject) e).getSource()).getSelectedItem();
        int num = this.chosenDate.get(5);
        this.chosenDate.set(5, 1);
        this.chosenDate.set(1, integer.intValue());
        int actualMaximum = this.chosenDate.getActualMaximum(5);
        this.chosenDate.set(5, Math.min(num, actualMaximum));
        this.refreshYearSelector();
        this.refreshButtons();
      }
      else if (String.instancehelper_equals(e.getActionCommand(), (object) "todayButtonClicked"))
      {
        this.setDate(new Date());
      }
      else
      {
        if (!String.instancehelper_equals(e.getActionCommand(), (object) "dateButtonClicked"))
          return;
        int num = Integer.parseInt(((Component) ((EventObject) e).getSource()).getName());
        Calendar firstVisibleDate = this.getFirstVisibleDate();
        firstVisibleDate.add(5, num);
        this.setDate(firstVisibleDate.getTime());
      }
    }

    public virtual Color getChosenDateButtonColor()
    {
      return this.chosenDateButtonColor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 102, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 102, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setChosenDateButtonColor(Color chosenDateButtonColor)
    {
      if (chosenDateButtonColor == null)
      {
        string str = "UIColor must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        Color color = this.chosenDateButtonColor;
        this.chosenDateButtonColor = chosenDateButtonColor;
        this.refreshButtons();
        ((Component) this).firePropertyChange("chosenDateButtonColor", (object) color, (object) chosenDateButtonColor);
      }
    }

    public virtual Color getChosenMonthButtonColor()
    {
      return this.chosenMonthButtonColor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 127, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 102, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setChosenMonthButtonColor(Color chosenMonthButtonColor)
    {
      if (chosenMonthButtonColor == null)
      {
        string str = "UIColor must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        Color color = this.chosenMonthButtonColor;
        this.chosenMonthButtonColor = chosenMonthButtonColor;
        this.refreshButtons();
        ((Component) this).firePropertyChange("chosenMonthButtonColor", (object) color, (object) chosenMonthButtonColor);
      }
    }

    public virtual Color getChosenOtherButtonColor()
    {
      return this.chosenOtherButtonColor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 152, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 102, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setChosenOtherButtonColor(Color chosenOtherButtonColor)
    {
      if (chosenOtherButtonColor == null)
      {
        string str = "UIColor must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        Color color = this.chosenOtherButtonColor;
        this.chosenOtherButtonColor = chosenOtherButtonColor;
        this.refreshButtons();
        ((Component) this).firePropertyChange("chosenOtherButtonColor", (object) color, (object) chosenOtherButtonColor);
      }
    }

    public virtual int getYearSelectionRange()
    {
      return this.yearSelectionRange;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 177, (byte) 103, (byte) 103, (byte) 102, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setYearSelectionRange(int yearSelectionRange)
    {
      int num = this.yearSelectionRange;
      this.yearSelectionRange = yearSelectionRange;
      this.refreshYearSelector();
      ((JComponent) this).firePropertyChange("yearSelectionRange", num, yearSelectionRange);
    }
  }
}
