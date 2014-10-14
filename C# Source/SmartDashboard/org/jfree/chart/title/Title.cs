// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.title.Title
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using javax.swing.@event;
using org.jfree.chart.@event;
using org.jfree.chart.block;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.title
{
  [Implements(new string[] {"org.jfree.chart.block.Block", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class Title : AbstractBlock, Block, Drawable, Cloneable.__Interface, Serializable.__Interface
  {
    internal static RectangleEdge __\u003C\u003EDEFAULT_POSITION = RectangleEdge.__\u003C\u003ETOP;
    internal static HorizontalAlignment __\u003C\u003EDEFAULT_HORIZONTAL_ALIGNMENT = HorizontalAlignment.__\u003C\u003ECENTER;
    internal static VerticalAlignment __\u003C\u003EDEFAULT_VERTICAL_ALIGNMENT = VerticalAlignment.__\u003C\u003ECENTER;
    internal static RectangleInsets __\u003C\u003EDEFAULT_PADDING = new RectangleInsets(1.0, 1.0, 1.0, 1.0);
    private const long serialVersionUID = -6675162505277817221L;
    public bool visible;
    private RectangleEdge position;
    private HorizontalAlignment horizontalAlignment;
    private VerticalAlignment verticalAlignment;
    [NonSerialized]
    private EventListenerList listenerList;
    private bool notify;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024event\u0024TitleChangeListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static RectangleEdge DEFAULT_POSITION
    {
      [HideFromJava] get
      {
        return Title.__\u003C\u003EDEFAULT_POSITION;
      }
    }

    [Modifiers]
    public static HorizontalAlignment DEFAULT_HORIZONTAL_ALIGNMENT
    {
      [HideFromJava] get
      {
        return Title.__\u003C\u003EDEFAULT_HORIZONTAL_ALIGNMENT;
      }
    }

    [Modifiers]
    public static VerticalAlignment DEFAULT_VERTICAL_ALIGNMENT
    {
      [HideFromJava] get
      {
        return Title.__\u003C\u003EDEFAULT_VERTICAL_ALIGNMENT;
      }
    }

    [Modifiers]
    public static RectangleInsets DEFAULT_PADDING
    {
      [HideFromJava] get
      {
        return Title.__\u003C\u003EDEFAULT_PADDING;
      }
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 202, (byte) 202, (byte) 170})]
    static Title()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 168, (byte) 99, (byte) 144, (byte) 99, (byte) 208, (byte) 99, (byte) 176, (byte) 100, (byte) 176, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 107, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Title(RectangleEdge position, HorizontalAlignment horizontalAlignment, VerticalAlignment verticalAlignment, RectangleInsets padding)
    {
      Title title = this;
      if (position == null)
      {
        string str = "Null 'position' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (horizontalAlignment == null)
      {
        string str = "Null 'horizontalAlignment' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (verticalAlignment == null)
      {
        string str = "Null 'verticalAlignment' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (padding == null)
      {
        string str = "Null 'spacer' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.visible = true;
        this.position = position;
        this.horizontalAlignment = horizontalAlignment;
        this.verticalAlignment = verticalAlignment;
        this.setPadding(padding);
        this.listenerList = new EventListenerList();
        this.notify = true;
      }
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Title()
      : this(Title.__\u003C\u003EDEFAULT_POSITION, Title.__\u003C\u003EDEFAULT_HORIZONTAL_ALIGNMENT, Title.__\u003C\u003EDEFAULT_VERTICAL_ALIGNMENT, Title.__\u003C\u003EDEFAULT_PADDING)
    {
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Title(RectangleEdge position, HorizontalAlignment horizontalAlignment, VerticalAlignment verticalAlignment)
      : this(position, horizontalAlignment, verticalAlignment, Title.__\u003C\u003EDEFAULT_PADDING)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Title([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] Title obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Title obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 139, (byte) 99, (byte) 144, (byte) 105, (byte) 103, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPosition(RectangleEdge position)
    {
      if (position == null)
      {
        string str = "Null 'position' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.position == position)
          return;
        this.position = position;
        this.notifyListeners(new TitleChangeEvent(this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 3, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChangeListener(TitleChangeListener listener)
    {
      this.listenerList.add(Title.class\u0024org\u0024jfree\u0024chart\u0024event\u0024TitleChangeListener != null ? Title.class\u0024org\u0024jfree\u0024chart\u0024event\u0024TitleChangeListener : (Title.class\u0024org\u0024jfree\u0024chart\u0024event\u0024TitleChangeListener = Title.class\u0024("org.jfree.chart.event.TitleChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 12, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChangeListener(TitleChangeListener listener)
    {
      this.listenerList.remove(Title.class\u0024org\u0024jfree\u0024chart\u0024event\u0024TitleChangeListener != null ? Title.class\u0024org\u0024jfree\u0024chart\u0024event\u0024TitleChangeListener : (Title.class\u0024org\u0024jfree\u0024chart\u0024event\u0024TitleChangeListener = Title.class\u0024("org.jfree.chart.event.TitleChangeListener")), (EventListener) listener);
    }

    public virtual bool isVisible()
    {
      return this.visible;
    }

    public virtual RectangleEdge getPosition()
    {
      return this.position;
    }

    public virtual HorizontalAlignment getHorizontalAlignment()
    {
      return this.horizontalAlignment;
    }

    [HideFromReflection]
    public abstract object draw([In] Graphics2D obj0, [In] Rectangle2D obj1, [In] object obj2);

    public virtual VerticalAlignment getVerticalAlignment()
    {
      return this.verticalAlignment;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 247, (byte) 108, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      Title title = (Title) base.clone();
      title.listenerList = new EventListenerList();
      return (object) title;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Title))
        return false;
      Title title = (Title) obj;
      if (this.visible != title.visible || this.position != title.position || (this.horizontalAlignment != title.horizontalAlignment || this.verticalAlignment != title.verticalAlignment) || this.notify != title.notify)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 23, (byte) 104, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void notifyListeners(TitleChangeEvent @event)
    {
      if (!this.notify)
        return;
      object[] listenerList = this.listenerList.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (Title.class\u0024org\u0024jfree\u0024chart\u0024event\u0024TitleChangeListener != null ? Title.class\u0024org\u0024jfree\u0024chart\u0024event\u0024TitleChangeListener : (Title.class\u0024org\u0024jfree\u0024chart\u0024event\u0024TitleChangeListener = Title.class\u0024("org.jfree.chart.event.TitleChangeListener"))))
          ((TitleChangeListener) listenerList[index + 1]).titleChanged(@event);
        index += -2;
      }
    }

    [LineNumberTable((ushort) 373)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, Title.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 84, (byte) 98, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setVisible(bool visible)
    {
      this.visible = visible;
      this.notifyListeners(new TitleChangeEvent(this));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 99, (byte) 144, (byte) 105, (byte) 103, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setHorizontalAlignment(HorizontalAlignment alignment)
    {
      if (alignment == null)
      {
        string str = "Null 'alignment' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.horizontalAlignment == alignment)
          return;
        this.horizontalAlignment = alignment;
        this.notifyListeners(new TitleChangeEvent(this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 99, (byte) 144, (byte) 105, (byte) 103, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setVerticalAlignment(VerticalAlignment alignment)
    {
      if (alignment == null)
      {
        string str = "Null 'alignment' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.verticalAlignment == alignment)
          return;
        this.verticalAlignment = alignment;
        this.notifyListeners(new TitleChangeEvent(this));
      }
    }

    public virtual bool getNotify()
    {
      return this.notify;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 59, (byte) 66, (byte) 103, (byte) 99, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNotify(bool flag)
    {
      int num = flag ? 1 : 0;
      this.notify = num != 0;
      if (num == 0)
        return;
      this.notifyListeners(new TitleChangeEvent(this));
    }

    public abstract void draw(Graphics2D gd, Rectangle2D rd);

    [LineNumberTable(new byte[] {(byte) 161, (byte) 73, (byte) 102, (byte) 113, (byte) 145, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * (37 * (37 * 193 + ObjectUtilities.hashCode((object) this.position)) + ObjectUtilities.hashCode((object) this.horizontalAlignment)) + ObjectUtilities.hashCode((object) this.verticalAlignment);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 89, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 102, (byte) 102, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.listenerList = new EventListenerList();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Title.__\u003CcallerID\u003E == null)
        Title.__\u003CcallerID\u003E = (CallerID) new Title.__\u003CCallerID\u003E();
      return Title.__\u003CcallerID\u003E;
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
