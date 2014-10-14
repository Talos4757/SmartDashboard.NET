// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.panel.AbstractOverlay
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javax.swing.@event;
using org.jfree.chart.@event;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.chart.panel
{
  public class AbstractOverlay : Object
  {
    [NonSerialized]
    private EventListenerList changeListeners;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024event\u0024OverlayChangeListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 12, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractOverlay()
    {
      base.\u002Ector();
      AbstractOverlay abstractOverlay = this;
      this.changeListeners = new EventListenerList();
    }

    [LineNumberTable((ushort) 77)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, AbstractOverlay.__\u003CGetCallerID\u003E());
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

    [LineNumberTable(new byte[] {(byte) 61, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void notifyListeners(OverlayChangeEvent @event)
    {
      object[] listenerList = this.changeListeners.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (AbstractOverlay.class\u0024org\u0024jfree\u0024chart\u0024event\u0024OverlayChangeListener != null ? AbstractOverlay.class\u0024org\u0024jfree\u0024chart\u0024event\u0024OverlayChangeListener : (AbstractOverlay.class\u0024org\u0024jfree\u0024chart\u0024event\u0024OverlayChangeListener = AbstractOverlay.class\u0024("org.jfree.chart.event.OverlayChangeListener"))))
          ((OverlayChangeListener) listenerList[index + 1]).overlayChanged(@event);
        index += -2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 99, (byte) 144, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChangeListener(OverlayChangeListener listener)
    {
      if (listener == null)
      {
        string str = "Null 'listener' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.changeListeners.add(AbstractOverlay.class\u0024org\u0024jfree\u0024chart\u0024event\u0024OverlayChangeListener != null ? AbstractOverlay.class\u0024org\u0024jfree\u0024chart\u0024event\u0024OverlayChangeListener : (AbstractOverlay.class\u0024org\u0024jfree\u0024chart\u0024event\u0024OverlayChangeListener = AbstractOverlay.class\u0024("org.jfree.chart.event.OverlayChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 99, (byte) 144, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChangeListener(OverlayChangeListener listener)
    {
      if (listener == null)
      {
        string str = "Null 'listener' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.changeListeners.remove(AbstractOverlay.class\u0024org\u0024jfree\u0024chart\u0024event\u0024OverlayChangeListener != null ? AbstractOverlay.class\u0024org\u0024jfree\u0024chart\u0024event\u0024OverlayChangeListener : (AbstractOverlay.class\u0024org\u0024jfree\u0024chart\u0024event\u0024OverlayChangeListener = AbstractOverlay.class\u0024("org.jfree.chart.event.OverlayChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireOverlayChanged()
    {
      this.notifyListeners(new OverlayChangeEvent((object) this));
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (AbstractOverlay.__\u003CcallerID\u003E == null)
        AbstractOverlay.__\u003CcallerID\u003E = (CallerID) new AbstractOverlay.__\u003CCallerID\u003E();
      return AbstractOverlay.__\u003CcallerID\u003E;
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
