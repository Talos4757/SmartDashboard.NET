// Decompiled with JetBrains decompiler
// Type: org.jfree.layout.RadialLayout
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.layout
{
  [Implements(new string[] {"java.awt.LayoutManager", "java.io.Serializable"})]
  [Serializable]
  public class RadialLayout : Object, LayoutManager, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -7582156799248315534L;
    private int minWidth;
    private int minHeight;
    private int maxCompWidth;
    private int maxCompHeight;
    private int preferredWidth;
    private int preferredHeight;
    private bool sizeUnknown;

    [LineNumberTable(new byte[] {(byte) 48, (byte) 232, (byte) 40, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 231, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RadialLayout()
    {
      base.\u002Ector();
      RadialLayout radialLayout = this;
      this.minWidth = 0;
      this.minHeight = 0;
      this.maxCompWidth = 0;
      this.maxCompHeight = 0;
      this.preferredWidth = 0;
      this.preferredHeight = 0;
      this.sizeUnknown = true;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RadialLayout([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] RadialLayout obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 135, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 105, (byte) 104, (byte) 107, (byte) 103, (byte) 110, (byte) 140, (byte) 110, (byte) 140, (byte) 115, (byte) 243, (byte) 53, (byte) 233, (byte) 78, (byte) 110, (byte) 110, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void setSizes([In] Container obj0)
    {
      int componentCount = obj0.getComponentCount();
      this.preferredWidth = 0;
      this.preferredHeight = 0;
      this.minWidth = 0;
      this.minHeight = 0;
      for (int index = 0; index < componentCount; ++index)
      {
        Component component = obj0.getComponent(index);
        if (component.isVisible())
        {
          Dimension preferredSize = component.getPreferredSize();
          if (this.maxCompWidth < preferredSize.width)
            this.maxCompWidth = (int) preferredSize.width;
          if (this.maxCompHeight < preferredSize.height)
            this.maxCompHeight = (int) preferredSize.height;
          this.preferredWidth += (int) preferredSize.width;
          this.preferredHeight += (int) preferredSize.height;
        }
      }
      this.preferredWidth = this.preferredWidth / 2;
      this.preferredHeight = this.preferredHeight / 2;
      this.minWidth = this.preferredWidth;
      this.minHeight = this.preferredHeight;
    }

    public virtual void addLayoutComponent(Component comp)
    {
    }

    public virtual void removeLayoutComponent(Component comp)
    {
    }

    public virtual void addLayoutComponent(string name, Component comp)
    {
    }

    public virtual void removeLayoutComponent(string name, Component comp)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 104, (byte) 167, (byte) 103, (byte) 122, (byte) 154, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension preferredLayoutSize(Container parent)
    {
      Dimension dimension = new Dimension(0, 0);
      this.setSizes(parent);
      Insets insets = parent.getInsets();
      dimension.width = (__Null) (this.preferredWidth + insets.left + insets.right);
      dimension.height = (__Null) (this.preferredHeight + insets.top + insets.bottom);
      this.sizeUnknown = false;
      return dimension;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 168, (byte) 103, (byte) 122, (byte) 154, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension minimumLayoutSize(Container parent)
    {
      Dimension dimension = new Dimension(0, 0);
      Insets insets = parent.getInsets();
      dimension.width = (__Null) (this.minWidth + insets.left + insets.right);
      dimension.height = (__Null) (this.minHeight + insets.top + insets.bottom);
      this.sizeUnknown = false;
      return dimension;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 103, (byte) 154, (byte) 154, (byte) 103, (byte) 99, (byte) 195, (byte) 104, (byte) 167, (byte) 100, (byte) 105, (byte) 105, (byte) 105, (byte) 153, (byte) 133, (byte) 113, (byte) 111, (byte) 101, (byte) 101, (byte) 107, (byte) 107, (byte) 107, (byte) 106, (byte) 108, (byte) 105, (byte) 223, (byte) 17, (byte) 255, (byte) 17, (byte) 70, (byte) 153, (byte) 232, (byte) 48, (byte) 235, (byte) 83})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void layoutContainer(Container parent)
    {
      Insets insets = parent.getInsets();
      int num1 = (int) (((Component) parent).getSize().width - (insets.left + insets.right));
      int num2 = (int) (((Component) parent).getSize().height - (insets.top + insets.bottom));
      int componentCount = parent.getComponentCount();
      int num3 = 0;
      int num4 = 0;
      if (this.sizeUnknown)
        this.setSizes(parent);
      if (componentCount < 2)
      {
        Component component = parent.getComponent(0);
        if (!component.isVisible())
          return;
        Dimension preferredSize = component.getPreferredSize();
        component.setBounds(num3, num4, (int) preferredSize.width, (int) preferredSize.height);
      }
      else
      {
        double num5 = Math.toRadians(90.0);
        double num6 = 2.0 * Math.PI / (double) componentCount;
        int num7 = num1 / 2;
        int num8 = num2 / 2;
        int num9 = num7 - this.maxCompWidth;
        int num10 = num8 - this.maxCompHeight;
        for (int index = 0; index < componentCount; ++index)
        {
          Component component = parent.getComponent(index);
          if (component.isVisible())
          {
            Dimension preferredSize = component.getPreferredSize();
            int num11 = ByteCodeHelper.d2i((double) num7 - (double) num9 * Math.cos(num5) - preferredSize.getWidth() / 2.0 + (double) insets.left);
            int num12 = ByteCodeHelper.d2i((double) num8 - (double) num10 * Math.sin(num5) - preferredSize.getHeight() / 2.0 + (double) insets.top);
            component.setBounds(num11, num12, (int) preferredSize.width, (int) preferredSize.height);
          }
          num5 += num6;
        }
      }
    }

    [LineNumberTable((ushort) 280)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return Object.instancehelper_getClass((object) this).getName();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 177, (byte) 102, (byte) 102, (byte) 139, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 145, (byte) 104, (byte) 112, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      Frame frame = new Frame();
      Panel panel = new Panel();
      ((Container) panel).setLayout((LayoutManager) new RadialLayout());
      ((Container) panel).add((Component) new Checkbox("One"));
      ((Container) panel).add((Component) new Checkbox("Two"));
      ((Container) panel).add((Component) new Checkbox("Three"));
      ((Container) panel).add((Component) new Checkbox("Four"));
      ((Container) panel).add((Component) new Checkbox("Five"));
      ((Container) panel).add((Component) new Checkbox("One"));
      ((Container) panel).add((Component) new Checkbox("Two"));
      ((Container) panel).add((Component) new Checkbox("Three"));
      ((Container) panel).add((Component) new Checkbox("Four"));
      ((Container) panel).add((Component) new Checkbox("Five"));
      ((Container) frame).add((Component) panel);
      ((Window) frame).setSize(300, 500);
      ((Window) frame).setVisible(true);
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
