// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.ConnectionIndicator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.robot;
using edu.wpi.first.wpilibj.tables;
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
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.IRemoteConnectionListener"})]
  [Serializable]
  public class ConnectionIndicator : StaticWidget, IRemoteConnectionListener
  {
    public const string NAME = "Connection Indicator";
    private const int DRAW_EMBOSSED = 0;
    private const int DRAW_ENGRAVED = 1;
    private const int DRAW_ROUNDED = 2;
    private const int DRAW_PLAIN = 3;
    internal ColorProperty __\u003C\u003Epositive;
    internal ColorProperty __\u003C\u003Enegative;
    internal MultiProperty __\u003C\u003Edisplay;
    private bool firstRun;
    private bool connected;
    private Runnable repainter;

    [Modifiers]
    public ColorProperty positive
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Epositive;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Epositive = value;
      }
    }

    [Modifiers]
    public ColorProperty negative
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Enegative;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Enegative = value;
      }
    }

    [Modifiers]
    public MultiProperty display
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Edisplay;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Edisplay = value;
      }
    }

    [HideFromJava]
    static ConnectionIndicator()
    {
      StaticWidget.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 232, (byte) 52, (byte) 118, (byte) 118, (byte) 113, (byte) 103, (byte) 103, (byte) 236, (byte) 72, (byte) 143, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConnectionIndicator()
    {
      ConnectionIndicator connectionIndicator = this;
      this.__\u003C\u003Epositive = new ColorProperty((PropertyHolder) this, "Connection Color", (Color) Color.GREEN);
      this.__\u003C\u003Enegative = new ColorProperty((PropertyHolder) this, "No Connection Color", (Color) Color.RED);
      this.__\u003C\u003Edisplay = new MultiProperty((PropertyHolder) this, "Graphics");
      this.firstRun = true;
      this.connected = false;
      this.repainter = (Runnable) new ConnectionIndicator\u00241(this);
      ((JComponent) this).setPreferredSize(new Dimension(32, 32));
      this.__\u003C\u003Edisplay.add("Embossed", (object) Integer.valueOf(0));
      this.__\u003C\u003Edisplay.add("Engraved", (object) Integer.valueOf(1));
      this.__\u003C\u003Edisplay.add("Rounded", (object) Integer.valueOf(2));
      this.__\u003C\u003Edisplay.add("Simple", (object) Integer.valueOf(3));
      this.__\u003C\u003Edisplay.setDefault((object) "Embossed");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ConnectionIndicator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      Robot.addConnectionListener((IRemoteConnectionListener) this, true);
    }

    [LineNumberTable(new byte[] {(byte) 2, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void disconnect()
    {
      Robot.removeConnectionListener((IRemoteConnectionListener) this);
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 113, (byte) 104, (byte) 113, (byte) 104, (byte) 105, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property == this.__\u003C\u003Epositive && this.connected)
        ((Component) this).repaint();
      else if (property == this.__\u003C\u003Enegative && !this.connected)
      {
        ((Component) this).repaint();
      }
      else
      {
        if (property != this.__\u003C\u003Edisplay)
          return;
        ((Component) this).repaint();
      }
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 135, (byte) 159, (byte) 16, (byte) 127, (byte) 17, (byte) 117, (byte) 133, (byte) 127, (byte) 17, (byte) 117, (byte) 133, (byte) 108, (byte) 116, (byte) 127, (byte) 17, (byte) 118, (byte) 162, (byte) 127, (byte) 17, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void paintComponent(Graphics g)
    {
      Dimension size = ((Component) this).getSize();
      switch (((Integer) this.__\u003C\u003Edisplay.getValue()).intValue())
      {
        case 0:
          g.setColor(!this.connected ? (Color) this.__\u003C\u003Enegative.getValue() : (Color) this.__\u003C\u003Epositive.getValue());
          g.fill3DRect(0, 0, (int) size.width, (int) size.height, true);
          break;
        case 1:
          g.setColor(!this.connected ? (Color) this.__\u003C\u003Enegative.getValue() : (Color) this.__\u003C\u003Epositive.getValue());
          g.fill3DRect(0, 0, (int) size.width, (int) size.height, false);
          break;
        case 2:
          g.setColor(((Component) this).getBackground());
          g.fillRect(0, 0, (int) size.width, (int) size.height);
          g.setColor(!this.connected ? (Color) this.__\u003C\u003Enegative.getValue() : (Color) this.__\u003C\u003Epositive.getValue());
          g.fillRoundRect(0, 0, (int) size.width, (int) size.height, 8, 8);
          break;
        default:
          g.setColor(!this.connected ? (Color) this.__\u003C\u003Enegative.getValue() : (Color) this.__\u003C\u003Epositive.getValue());
          g.fillRect(0, 0, (int) size.width, (int) size.height);
          break;
      }
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 104, (byte) 103, (byte) 104, (byte) 171, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void connected(IRemote remote)
    {
      if (!this.connected)
      {
        this.connected = true;
        if (!this.firstRun)
          SwingUtilities.invokeLater(this.repainter);
      }
      this.firstRun = false;
    }

    [LineNumberTable(new byte[] {(byte) 55, (byte) 104, (byte) 103, (byte) 104, (byte) 171, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void disconnected(IRemote remote)
    {
      if (this.connected)
      {
        this.connected = false;
        if (!this.firstRun)
          SwingUtilities.invokeLater(this.repainter);
      }
      this.firstRun = false;
    }
  }
}
