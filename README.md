SmartDashboard.NET
==================

A .NET implementation of FIRST FRC's SmartDashboard, using [ikvm](http://www.ikvm.net/).

I have simply converted the jar files from [SmartDashboard 1.0.5](http://firstforge.wpi.edu/sf/frs/do/listReleases/projects.smartdashboard/frs.installer) to .dll using ikvmc.
Then, I have used [JetBrains dotPeek](https://www.jetbrains.com/decompiler/) to decompile them to C#.
The decompiled code includes, unfortunately, some unreadable code which is basically used by the compiler.

**WARNING:** Any of the above is not guaranteed to work, *at all*. Sorry for that, guys.
