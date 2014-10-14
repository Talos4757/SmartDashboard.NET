// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.ProgressBar
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using IKVM.Attributes;
using java.awt;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class ProgressBar : AbstractValueWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    internal ColorProperty __\u003C\u003Eforeground;
    internal ColorProperty __\u003C\u003Ebackground;
    internal DoubleProperty __\u003C\u003Emax;
    internal DoubleProperty __\u003C\u003Emin;
    private Widget.NumberProgressBar progressBar;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return ProgressBar.__\u003C\u003ETYPES;
      }
    }

    [Modifiers]
    public ColorProperty foreground
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Eforeground;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Eforeground = value;
      }
    }

    [Modifiers]
    public ColorProperty background
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Ebackground;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Ebackground = value;
      }
    }

    [Modifiers]
    public DoubleProperty max
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Emax;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Emax = value;
      }
    }

    [Modifiers]
    public DoubleProperty min
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Emin;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Emin = value;
      }
    }

    [LineNumberTable((ushort) 16)]
    static ProgressBar()
    {
      AbstractValueWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      DataType dataType = DataType.__\u003C\u003ENUMBER;
      dataTypeArray[index] = dataType;
      ProgressBar.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 168, (byte) 113, (byte) 113, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProgressBar()
    {
      ProgressBar progressBar = this;
      this.__\u003C\u003Eforeground = new ColorProperty((PropertyHolder) this, "Foreground");
      this.__\u003C\u003Ebackground = new ColorProperty((PropertyHolder) this, "Background");
      this.__\u003C\u003Emax = new DoubleProperty((PropertyHolder) this, "Maximum", 100.0);
      this.__\u003C\u003Emin = new DoubleProperty((PropertyHolder) this, "Minimum", 0.0);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ProgressBar([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 107, (byte) 123, (byte) 123, (byte) 108, (byte) 159, (byte) 33, (byte) 140, (byte) 107, (byte) 123, (byte) 177, (byte) 119, (byte) 151, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      this.progressBar = new Widget.NumberProgressBar();
      this.progressBar.setMin(this.__\u003C\u003Emin.getValue().doubleValue());
      this.progressBar.setMax(this.__\u003C\u003Emax.getValue().doubleValue());
      this.progressBar.setBorderPainted(false);
      ((Component) this.progressBar).setBounds(((JComponent) this.progressBar).getX(), ((JComponent) this.progressBar).getY(), ((JComponent) this.progressBar).getX() + 200, ((JComponent) this.progressBar).getY() + 40);
      this.setNumberBinding((NumberBindable) this.progressBar);
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      JLabel.__\u003Cclinit\u003E();
      ((Container) this).add((Component) new JLabel(this.getFieldName()), (object) "First");
      ((Container) this).add((Component) this.progressBar, (object) "Center");
      this.update((Property) this.__\u003C\u003Eforeground, (object) ((Component) this.progressBar).getForeground());
      this.update((Property) this.__\u003C\u003Ebackground, (object) ((Component) this.progressBar).getBackground());
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 105, (byte) 127, (byte) 1, (byte) 105, (byte) 125, (byte) 105, (byte) 125, (byte) 105, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property == this.__\u003C\u003Eforeground)
        ((JComponent) this.progressBar).setForeground((Color) this.__\u003C\u003Eforeground.getValue());
      else if (property == this.__\u003C\u003Ebackground)
        ((JComponent) this.progressBar).setBackground((Color) this.__\u003C\u003Ebackground.getValue());
      else if (property == this.__\u003C\u003Emin)
      {
        this.progressBar.setMin(this.__\u003C\u003Emin.getValue().doubleValue());
      }
      else
      {
        if (property != this.__\u003C\u003Emax)
          return;
        this.progressBar.setMax(this.__\u003C\u003Emax.getValue().doubleValue());
      }
    }
  }
}
