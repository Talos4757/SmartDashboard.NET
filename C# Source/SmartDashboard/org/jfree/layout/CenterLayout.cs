// Decompiled with JetBrains decompiler
// Type: org.jfree.layout.CenterLayout
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
using System.Threading;

namespace org.jfree.layout
{
  [Implements(new string[] {"java.awt.LayoutManager", "java.io.Serializable"})]
  [Serializable]
  public class CenterLayout : Object, LayoutManager, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 469319532333015042L;

    [LineNumberTable(new byte[] {(byte) 17, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CenterLayout()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CenterLayout([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CenterLayout obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 109, (byte) 103, (byte) 105, (byte) 104, (byte) 103, (byte) 255, (byte) 39, (byte) 70, (byte) 223, (byte) 19})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension preferredLayoutSize(Container parent)
    {
      object treeLock;
      Monitor.Enter(treeLock = ((Component) parent).getTreeLock());
      Dimension dimension1;
      // ISSUE: fault handler
      try
      {
        Insets insets = parent.getInsets();
        if (parent.getComponentCount() > 0)
        {
          Dimension preferredSize = parent.getComponent(0).getPreferredSize();
          Dimension.__\u003Cclinit\u003E();
          Dimension dimension2 = new Dimension(ByteCodeHelper.d2i(preferredSize.getWidth()) + insets.left + insets.right, ByteCodeHelper.d2i(preferredSize.getHeight()) + insets.top + insets.bottom);
          Monitor.Exit(treeLock);
          dimension1 = dimension2;
          return dimension1;
        }
        else
        {
          Dimension.__\u003Cclinit\u003E();
          Dimension dimension2 = new Dimension((int) (insets.left + insets.right), (int) (insets.top + insets.bottom));
          Monitor.Exit(treeLock);
          dimension1 = dimension2;
        }
      }
      __fault
      {
        Monitor.Exit(treeLock);
      }
      return dimension1;
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 109, (byte) 103, (byte) 105, (byte) 104, (byte) 103, (byte) 223, (byte) 29, (byte) 191, (byte) 19})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension minimumLayoutSize(Container parent)
    {
      object treeLock;
      Monitor.Enter(treeLock = ((Component) parent).getTreeLock());
      Dimension dimension1;
      // ISSUE: fault handler
      try
      {
        Insets insets = parent.getInsets();
        if (parent.getComponentCount() > 0)
        {
          Dimension minimumSize = parent.getComponent(0).getMinimumSize();
          Dimension.__\u003Cclinit\u003E();
          Dimension dimension2 = new Dimension((int) (minimumSize.width + insets.left + insets.right), (int) (minimumSize.height + insets.top + insets.bottom));
          Monitor.Exit(treeLock);
          dimension1 = dimension2;
          return dimension1;
        }
        else
        {
          Dimension.__\u003Cclinit\u003E();
          Dimension dimension2 = new Dimension((int) (insets.left + insets.right), (int) (insets.top + insets.bottom));
          Monitor.Exit(treeLock);
          dimension1 = dimension2;
        }
      }
      __fault
      {
        Monitor.Exit(treeLock);
      }
      return dimension1;
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 109, (byte) 108, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 223, (byte) 14, (byte) 191, (byte) 14, (byte) 184, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void layoutContainer(Container parent)
    {
      lock (((Component) parent).getTreeLock())
      {
        if (parent.getComponentCount() <= 0)
          return;
        Insets local_1 = parent.getInsets();
        Dimension local_2 = ((Component) parent).getSize();
        Component local_3 = parent.getComponent(0);
        Dimension local_4 = local_3.getPreferredSize();
        int local_5 = local_1.left + Math.max((local_2.width - local_1.left - local_1.right - local_4.width) / 2, 0);
        int local_6 = local_1.top + Math.max((local_2.height - local_1.top - local_1.bottom - local_4.height) / 2, 0);
        local_3.setBounds(local_5, local_6, (int) local_4.width, (int) local_4.height);
      }
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

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
