// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.AbstractDialLayer
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
using org.jfree.chart;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.chart.plot.dial
{
  [Implements(new string[] {"org.jfree.chart.plot.dial.DialLayer"})]
  public abstract class AbstractDialLayer : Object, DialLayer
  {
    private bool visible;
    [NonSerialized]
    private EventListenerList listenerList;
    internal static Class class\u0024org\u0024jfree\u0024chart\u0024plot\u0024dial\u0024DialLayerChangeListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractDialLayer()
    {
      base.\u002Ector();
      AbstractDialLayer abstractDialLayer = this;
      this.visible = true;
      this.listenerList = new EventListenerList();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void notifyListeners(DialLayerChangeEvent @event)
    {
      object[] listenerList = this.listenerList.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (AbstractDialLayer.class\u0024org\u0024jfree\u0024chart\u0024plot\u0024dial\u0024DialLayerChangeListener != null ? AbstractDialLayer.class\u0024org\u0024jfree\u0024chart\u0024plot\u0024dial\u0024DialLayerChangeListener : (AbstractDialLayer.class\u0024org\u0024jfree\u0024chart\u0024plot\u0024dial\u0024DialLayerChangeListener = AbstractDialLayer.class\u0024("org.jfree.chart.plot.dial.DialLayerChangeListener"))))
          ((DialLayerChangeListener) listenerList[index + 1]).dialLayerChanged(@event);
        index += -2;
      }
    }

    [LineNumberTable((ushort) 155)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, AbstractDialLayer.__\u003CGetCallerID\u003E());
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

    public virtual bool isVisible()
    {
      return this.visible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 118, (byte) 162, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setVisible(bool visible)
    {
      this.visible = visible;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AbstractDialLayer))
        return false;
      else
        return this.visible == ((AbstractDialLayer) obj).visible;
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 99, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(23, this.visible);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 91, (byte) 140, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      AbstractDialLayer abstractDialLayer = (AbstractDialLayer) base.clone();
      abstractDialLayer.listenerList = new EventListenerList();
      return (object) abstractDialLayer;
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChangeListener(DialLayerChangeListener listener)
    {
      this.listenerList.add(AbstractDialLayer.class\u0024org\u0024jfree\u0024chart\u0024plot\u0024dial\u0024DialLayerChangeListener != null ? AbstractDialLayer.class\u0024org\u0024jfree\u0024chart\u0024plot\u0024dial\u0024DialLayerChangeListener : (AbstractDialLayer.class\u0024org\u0024jfree\u0024chart\u0024plot\u0024dial\u0024DialLayerChangeListener = AbstractDialLayer.class\u0024("org.jfree.chart.plot.dial.DialLayerChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChangeListener(DialLayerChangeListener listener)
    {
      this.listenerList.remove(AbstractDialLayer.class\u0024org\u0024jfree\u0024chart\u0024plot\u0024dial\u0024DialLayerChangeListener != null ? AbstractDialLayer.class\u0024org\u0024jfree\u0024chart\u0024plot\u0024dial\u0024DialLayerChangeListener : (AbstractDialLayer.class\u0024org\u0024jfree\u0024chart\u0024plot\u0024dial\u0024DialLayerChangeListener = AbstractDialLayer.class\u0024("org.jfree.chart.plot.dial.DialLayerChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasListener(EventListener listener)
    {
      return (Arrays.asList(this.listenerList.getListenerList()).contains((object) listener) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 102, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.listenerList = new EventListenerList();
    }

    [HideFromReflection]
    public abstract bool isClippedToWindow();

    [HideFromReflection]
    public abstract void draw([In] Graphics2D obj0, [In] DialPlot obj1, [In] Rectangle2D obj2, [In] Rectangle2D obj3);

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (AbstractDialLayer.__\u003CcallerID\u003E == null)
        AbstractDialLayer.__\u003CcallerID\u003E = (CallerID) new AbstractDialLayer.__\u003CCallerID\u003E();
      return AbstractDialLayer.__\u003CcallerID\u003E;
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
