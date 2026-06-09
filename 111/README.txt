Wrapper111 initial skeleton

- driver/111.cpp - minimal WDM driver skeleton with IOCTL to set/get watermark status
- gui/Wrapper111.Gui - simple WPF app to toggle watermark and generate test log

Build notes:
- Driver project 111.vcxproj is configured as WDM driver (PlatformToolset WindowsKernelModeDriver10.0).
- To build driver you need WDK and appropriate SDK installed.
- GUI targets .NET Framework 4.8 and requires Visual Studio with WPF support.

This is a starting prototype per user's request. Next steps: implement PS/2 emulation, touchpad handling, device enumeration, logging to game folder, unit tests, installer and signing.