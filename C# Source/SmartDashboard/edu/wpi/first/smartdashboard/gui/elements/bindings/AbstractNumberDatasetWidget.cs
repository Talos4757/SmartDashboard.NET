// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.bindings.AbstractNumberDatasetWidget
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using IKVM.Attributes;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements.bindings
{
  [Serializable]
  public abstract class AbstractNumberDatasetWidget : AbstractValueWidget
  {
    [Modifiers]
    private Widget.NumberDatasetDisplayer data;

    [HideFromJava]
    static AbstractNumberDatasetWidget()
    {
      AbstractValueWidget.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 151, (byte) 104, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractNumberDatasetWidget(double defaultValue)
    {
      AbstractNumberDatasetWidget numberDatasetWidget1 = this;
      AbstractNumberDatasetWidget numberDatasetWidget2 = this;
      Widget.NumberDatasetDisplayer datasetDisplayer1 = new Widget.NumberDatasetDisplayer(defaultValue);
      Widget.NumberDatasetDisplayer datasetDisplayer2 = datasetDisplayer1;
      this.data = datasetDisplayer1;
      this.setNumberBinding((NumberBindable) datasetDisplayer2);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractNumberDatasetWidget([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal new static void __\u003Cclinit\u003E()
    {
    }

    protected internal virtual DefaultValueDataset getDataset()
    {
      return (DefaultValueDataset) this.data;
    }
  }
}
