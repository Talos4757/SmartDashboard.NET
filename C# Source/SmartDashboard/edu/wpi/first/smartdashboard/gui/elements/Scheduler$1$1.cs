// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Scheduler$1$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.Scheduler$1", "valueChanged", "(Ledu.wpi.first.wpilibj.tables.ITable;Ljava.lang.String;Ljava.lang.Object;Z)V")]
  [SourceFile("Scheduler.java")]
  [Modifiers]
  internal sealed class Scheduler\u00241\u00241 : Object, Runnable
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<Scheduler>.Value).desiredAssertionStatus();
    [Modifiers]
    internal Scheduler\u00241 this\u00241;

    [LineNumberTable((ushort) 53)]
    static Scheduler\u00241\u00241()
    {
    }

    [LineNumberTable((ushort) 53)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Scheduler\u00241\u00241([In] Scheduler\u00241 obj0)
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 119, (byte) 127, (byte) 11, (byte) 127, (byte) 11, (byte) 191, (byte) 31, (byte) 125, (byte) 120, (byte) 155, (byte) 124, (byte) 156, (byte) 120, (byte) 107, (byte) 99, (byte) 238, (byte) 72, (byte) 151, (byte) 156, (byte) 117, (byte) 119, (byte) 247, (byte) 40, (byte) 233, (byte) 91, (byte) 175, (byte) 127, (byte) 11, (byte) 127, (byte) 12, (byte) 127, (byte) 18, (byte) 31, (byte) 18, (byte) 235, (byte) 70, (byte) 159, (byte) 7, (byte) 159, (byte) 31, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      lock (Scheduler.access\u0024000(this.this\u00241.this\u00240))
      {
        Scheduler.access\u0024000(this.this\u00241.this\u00240).retrieveValue("Names", (object) Scheduler.access\u0024100(this.this\u00241.this\u00240));
        Scheduler.access\u0024000(this.this\u00241.this\u00240).retrieveValue("Ids", (object) Scheduler.access\u0024200(this.this\u00241.this\u00240));
        if (!Scheduler\u00241\u00241.\u0024assertionsDisabled && Scheduler.access\u0024100(this.this\u00241.this\u00240).size() != Scheduler.access\u0024200(this.this\u00241.this\u00240).size())
        {
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new AssertionError();
        }
        else
        {
          for (int local_1 = 0; local_1 < Scheduler.access\u0024100(this.this\u00241.this\u00240).size(); ++local_1)
          {
            if (local_1 >= Scheduler.access\u0024300(this.this\u00241.this\u00240).size())
              Scheduler.access\u0024300(this.this\u00241.this\u00240).add((object) new JLabel());
            JLabel local_2 = (JLabel) Scheduler.access\u0024300(this.this\u00241.this\u00240).get(local_1);
            local_2.setText(Scheduler.access\u0024100(this.this\u00241.this\u00240).get(local_1));
            if (local_1 >= Scheduler.access\u0024400(this.this\u00241.this\u00240).size())
            {
              JButton local_3 = new JButton("cancel");
              int local_4 = local_1;
              ((AbstractButton) local_3).addActionListener((ActionListener) new Scheduler\u00241\u00241\u00241(this, local_4));
              Scheduler.access\u0024400(this.this\u00241.this\u00240).add((object) local_3);
            }
            JButton local_3_1 = (JButton) Scheduler.access\u0024400(this.this\u00241.this\u00240).get(local_1);
            if (local_1 > Scheduler.access\u0024600(this.this\u00241.this\u00240) - 1)
            {
              ((Container) Scheduler.access\u0024700(this.this\u00241.this\u00240)).add((Component) local_2);
              ((Container) Scheduler.access\u0024800(this.this\u00241.this\u00240)).add((Component) local_3_1);
            }
          }
        }
      }
      if (Scheduler.access\u0024600(this.this\u00241.this\u00240) > Scheduler.access\u0024100(this.this\u00241.this\u00240).size())
      {
        for (int index = Scheduler.access\u0024100(this.this\u00241.this\u00240).size(); index < Scheduler.access\u0024600(this.this\u00241.this\u00240); ++index)
        {
          ((Container) Scheduler.access\u0024700(this.this\u00241.this\u00240)).remove((Component) Scheduler.access\u0024300(this.this\u00241.this\u00240).get(index));
          ((Container) Scheduler.access\u0024800(this.this\u00241.this\u00240)).remove((Component) Scheduler.access\u0024400(this.this\u00241.this\u00240).get(index));
        }
      }
      Scheduler.access\u0024602(this.this\u00241.this\u00240, Scheduler.access\u0024100(this.this\u00241.this\u00240).size());
      Scheduler.access\u0024900(this.this\u00241.this\u00240).show((Container) this.this\u00241.this\u00240, Scheduler.access\u0024600(this.this\u00241.this\u00240) != 0 ? "Commands" : "No Command");
      this.this\u00241.running = false;
    }
  }
}
