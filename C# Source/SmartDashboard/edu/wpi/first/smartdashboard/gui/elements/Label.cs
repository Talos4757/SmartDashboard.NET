// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Label
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.properties;
using IKVM.Attributes;
using java.awt;
using java.lang;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class Label : StaticWidget
  {
    internal StringProperty __\u003C\u003Etext;
    internal MultiProperty __\u003C\u003Ehorizontal;
    internal MultiProperty __\u003C\u003Evertical;
    private JLabel label;

    [Modifiers]
    public StringProperty text
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Etext;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Etext = value;
      }
    }

    [Modifiers]
    public MultiProperty horizontal
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Ehorizontal;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Ehorizontal = value;
      }
    }

    [Modifiers]
    public MultiProperty vertical
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Evertical;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Evertical = value;
      }
    }

    [HideFromJava]
    static Label()
    {
      StaticWidget.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 232, (byte) 58, (byte) 118, (byte) 113, (byte) 241, (byte) 69, (byte) 118, (byte) 118, (byte) 118, (byte) 145, (byte) 118, (byte) 118, (byte) 118, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Label()
    {
      Label label = this;
      this.__\u003C\u003Etext = new StringProperty((PropertyHolder) this, "Text", "Label");
      this.__\u003C\u003Ehorizontal = new MultiProperty((PropertyHolder) this, "Horizontal Alignment");
      this.__\u003C\u003Evertical = new MultiProperty((PropertyHolder) this, "Vertical Alignment");
      this.__\u003C\u003Ehorizontal.add("Left", (object) Integer.valueOf(2));
      this.__\u003C\u003Ehorizontal.add("Center", (object) Integer.valueOf(0));
      this.__\u003C\u003Ehorizontal.add("Right", (object) Integer.valueOf(4));
      this.__\u003C\u003Ehorizontal.setDefault((object) "Center");
      this.__\u003C\u003Evertical.add("Up", (object) Integer.valueOf(1));
      this.__\u003C\u003Evertical.add("Center", (object) Integer.valueOf(0));
      this.__\u003C\u003Evertical.add("Down", (object) Integer.valueOf(3));
      this.__\u003C\u003Evertical.setDefault((object) "Center");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Label([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 139, (byte) 159, (byte) 1, (byte) 127, (byte) 1, (byte) 159, (byte) 1, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      JLabel.__\u003Cclinit\u003E();
      this.label = new JLabel((string) this.__\u003C\u003Etext.getValue());
      this.label.setHorizontalAlignment(((Integer) this.__\u003C\u003Ehorizontal.getValue()).intValue());
      this.label.setVerticalAlignment(((Integer) this.__\u003C\u003Evertical.getValue()).intValue());
      ((Container) this).add((Component) this.label, (object) "Center");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 105, (byte) 125, (byte) 105, (byte) 127, (byte) 3, (byte) 105, (byte) 159, (byte) 3})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property == this.__\u003C\u003Etext)
        this.label.setText((string) this.__\u003C\u003Etext.getValue());
      else if (property == this.__\u003C\u003Ehorizontal)
      {
        this.label.setHorizontalAlignment(((Integer) this.__\u003C\u003Ehorizontal.getValue()).intValue());
      }
      else
      {
        if (property != this.__\u003C\u003Evertical)
          return;
        this.label.setVerticalAlignment(((Integer) this.__\u003C\u003Evertical.getValue()).intValue());
      }
    }
  }
}
