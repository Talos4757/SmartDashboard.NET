// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.ColorPalette
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.axis;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Obsolete]
  [Serializable]
  public abstract class ColorPalette : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    internal static double __\u003C\u003Elog10 = Math.log(10.0);
    private const long serialVersionUID = -9029901853079622051L;
    protected internal double minZ;
    protected internal double maxZ;
    protected internal int[] r;
    protected internal int[] g;
    protected internal int[] b;
    protected internal double[] tickValues;
    protected internal bool logscale;
    protected internal bool inverse;
    protected internal string paletteName;
    protected internal bool stepped;

    [Modifiers]
    protected internal static double log10
    {
      [HideFromJava] get
      {
        return ColorPalette.__\u003C\u003Elog10;
      }
    }

    [LineNumberTable((ushort) 98)]
    static ColorPalette()
    {
    }

    [LineNumberTable(new byte[] {(byte) 54, (byte) 232, (byte) 28, (byte) 176, (byte) 240, (byte) 76, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 231, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorPalette()
    {
      base.\u002Ector();
      ColorPalette colorPalette = this;
      this.minZ = -1.0;
      this.maxZ = -1.0;
      this.tickValues = (double[]) null;
      this.logscale = false;
      this.inverse = false;
      this.paletteName = (string) null;
      this.stepped = false;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ColorPalette([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ColorPalette obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ColorPalette obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static void __\u003Cclinit\u003E()
    {
    }

    public virtual void setMinZ(double newMinZ)
    {
      this.minZ = newMinZ;
    }

    public virtual void setMaxZ(double newMaxZ)
    {
      this.maxZ = newMaxZ;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 113, (byte) 104, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getPaint(double value)
    {
      if (this.isLogscale())
        return (Paint) this.getColorLog(value);
      else
        return (Paint) this.getColorLinear(value);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 27, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 135, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 191, (byte) 6, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      if (this == o)
        return true;
      if (!(o is ColorPalette))
        return false;
      ColorPalette colorPalette = (ColorPalette) o;
      if (this.inverse != colorPalette.inverse || this.logscale != colorPalette.logscale || (this.maxZ != colorPalette.maxZ || this.minZ != colorPalette.minZ) || (this.stepped != colorPalette.stepped || !Arrays.equals(this.b, colorPalette.b) || !Arrays.equals(this.g, colorPalette.g)))
        return false;
      if (this.paletteName != null)
      {
        if (String.instancehelper_equals(this.paletteName, (object) colorPalette.paletteName))
          goto label_10;
      }
      else if (colorPalette.paletteName == null)
        goto label_10;
      return false;
label_10:
      return Arrays.equals(this.r, colorPalette.r) && Arrays.equals(this.tickValues, colorPalette.tickValues);
    }

    public virtual bool isInverse()
    {
      return this.inverse;
    }

    public virtual bool isStepped()
    {
      return this.stepped;
    }

    public virtual double getMinZ()
    {
      return this.minZ;
    }

    public virtual double getMaxZ()
    {
      return this.maxZ;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 64, (byte) 66, (byte) 103, (byte) 102, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInverse(bool inverse)
    {
      int num = inverse ? 1 : 0;
      this.inverse = num != 0;
      this.initialize();
      if (num == 0)
        return;
      this.invertPalette();
    }

    public virtual void setStepped(bool stepped)
    {
      this.stepped = stepped;
    }

    [LineNumberTable((ushort) 128)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Color getColor(int izV)
    {
      Color.__\u003Cclinit\u003E();
      return new Color(this.r[izV], this.g[izV], this.b[izV]);
    }

    public virtual bool isLogscale()
    {
      return this.logscale;
    }

    [LineNumberTable(new byte[] {(byte) 118, (byte) 98, (byte) 103, (byte) 103, (byte) 141, (byte) 112, (byte) 108, (byte) 141, (byte) 115, (byte) 115, (byte) 144, (byte) 104, (byte) 105, (byte) 116, (byte) 184, (byte) 130, (byte) 155, (byte) 110, (byte) 138, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Color getColorLog(double value)
    {
      double num1 = this.minZ;
      double num2 = this.maxZ;
      if (this.minZ <= 0.0)
      {
        this.maxZ = num2 - num1 + 1.0;
        this.minZ = 1.0;
        value = value - num1 + 1.0;
      }
      double num3 = Math.log(this.minZ) / ColorPalette.__\u003C\u003Elog10;
      double num4 = Math.log(this.maxZ) / ColorPalette.__\u003C\u003Elog10;
      value = Math.log(value) / ColorPalette.__\u003C\u003Elog10;
      int num5;
      if (this.stepped)
      {
        int length = this.tickValues.Length;
        int num6 = 256;
        int num7 = length - 1;
        int num8 = -1;
        num5 = (num7 != num8 ? num6 / num7 : -num6) * ByteCodeHelper.d2i((double) length * (value - num3) / (num4 - num3)) + 2;
      }
      else
        num5 = ByteCodeHelper.d2i(253.0 * (value - num3) / (num4 - num3)) + 2;
      int izV = Math.max(Math.min(num5, (int) byte.MaxValue), 2);
      this.minZ = num1;
      this.maxZ = num2;
      return this.getColor(izV);
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 98, (byte) 104, (byte) 110, (byte) 100, (byte) 166, (byte) 132, (byte) 170, (byte) 170, (byte) 127, (byte) 10, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Color getColorLinear(double value)
    {
      if (this.stepped)
      {
        int index = Arrays.binarySearch(this.tickValues, value);
        if (index < 0)
          index = -1 * index - 2;
        value = index >= 0 ? this.tickValues[index] : this.minZ;
      }
      return this.getColor(Math.max(Math.min(ByteCodeHelper.d2i(253.0 * (value - this.minZ) / (this.maxZ - this.minZ)) + 2, (int) byte.MaxValue), 2));
    }

    public abstract void initialize();

    [LineNumberTable(new byte[] {(byte) 160, (byte) 149, (byte) 107, (byte) 107, (byte) 107, (byte) 106, (byte) 107, (byte) 107, (byte) 235, (byte) 61, (byte) 230, (byte) 70, (byte) 106, (byte) 113, (byte) 113, (byte) 241, (byte) 61, (byte) 230, (byte) 69})]
    public virtual void invertPalette()
    {
      int[] numArray1 = new int[256];
      int[] numArray2 = new int[256];
      int[] numArray3 = new int[256];
      for (int index = 0; index < 256; ++index)
      {
        numArray1[index] = this.r[index];
        numArray2[index] = this.g[index];
        numArray3[index] = this.b[index];
      }
      for (int index = 2; index < 256; ++index)
      {
        this.r[index] = numArray1[257 - index];
        this.g[index] = numArray2[257 - index];
        this.b[index] = numArray3[257 - index];
      }
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 159, (byte) 10})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getColor(double value)
    {
      int index = ByteCodeHelper.d2i(253.0 * (value - this.minZ) / (this.maxZ - this.minZ)) + 2;
      Color.__\u003Cclinit\u003E();
      return (Paint) new Color(this.r[index], this.g[index], this.b[index]);
    }

    public virtual string getPaletteName()
    {
      return this.paletteName;
    }

    public virtual double[] getTickValues()
    {
      return this.tickValues;
    }

    public virtual void setLogscale(bool logscale)
    {
      this.logscale = logscale;
    }

    public virtual void setPaletteName(string paletteName)
    {
      this.paletteName = paletteName;
    }

    public virtual void setTickValues(double[] newTickValues)
    {
      this.tickValues = newTickValues;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 13, (byte) 113, (byte) 108, (byte) 58, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickValues(List ticks)
    {
      this.tickValues = new double[ticks.size()];
      for (int index = 0; index < this.tickValues.Length; ++index)
        this.tickValues[index] = ((ValueTick) ticks.get(index)).getValue();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 80, (byte) 108, (byte) 104, (byte) 108, (byte) 109, (byte) 114, (byte) 114, (byte) 156, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      long num1 = Double.doubleToLongBits(this.minZ);
      int num2 = (int) (num1 ^ (long) ((ulong) num1 >> 32));
      long num3 = Double.doubleToLongBits(this.maxZ);
      return 29 * (29 * (29 * (29 * (29 * num2 + (int) (num3 ^ (long) ((ulong) num3 >> 32))) + (!this.logscale ? 0 : 1)) + (!this.inverse ? 0 : 1)) + (this.paletteName == null ? 0 : String.instancehelper_hashCode(this.paletteName))) + (!this.stepped ? 0 : 1);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 101, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return (object) (ColorPalette) base.clone();
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
