A simple test for performance comparsion between Lua in Unity。

**ATTENTION**: I'm a newbie to lua in fact, and this is only a simple test! If there is something wrong with my test or exists a better implemention, please contact me and I'll update ASAP! Any pull requests are welcomed!

一个针对Unity中执行Lua的简单性能测试。

**注意**: 本人对Lua是新手阶段，而且本项目旨在提供一个简单的测试比较。如果你发现我的测试代码有问题或者有更好的写法，请联系我、我会尽快改正。欢迎任何Pull Request！

## Benchmark Methods 测试方法

Based on sLua's performance_test, I ported into other Projects.

基于sLua自带的performance_test场景，我移植到其他项目中。

At the same time Lua part has a clock inside. These two mesured time may not be the same. Some seems outliers which are colored red.

同时Lua代码部分也有一个计时器。这两个测出来的时间有可能不那么一致。有些看起来是不太对的点已标红。

## Benchmark Environment 测试环境

Every test is executed five times, and then reboot App.

每个测试顺序执行五次，然后重启。

[UWA](https://www.uwa4d.com/) provided the newest test results with different devices. The original post can be found in `侑虎科技` Blog [Unity项目常见Lua解决方案性能比较](http://blog.uwa4d.com/archives/lua_perf.html).

这里感谢[侑虎科技UWA](https://www.uwa4d.com/)进行了最新版本在不同移动设备上的测试，原报告来自`侑虎科技`博客 [Unity项目常见Lua解决方案性能比较](http://blog.uwa4d.com/archives/lua_perf.html)。

### Android

以下为UWA在 Android上对高、中、低配置的三款设备进行测试后得到的平均数据，图中下方的表格部分为柱状图的准确数值，而其数值表示的是完成测试用例所需的时间，单位为毫秒。

- 低端设备：三星 S3 (Android OS 4.3)
![android_1](images/android_1.png)
- 中端设备：红米 Note2 (Android OS 5.0.2)
![android_2](images/android_2.png)
- 高端设备：三星S6 (Android OS 6.0.1)
![android_3](images/android_3.png)

### iOS

以下为UWA在 iOS上对armv7和arm64的两款设备进行测试后得到的平均数据，测试中使用了il2cpp＋Universal的发布方式，同时禁用了bitcode。图中下方的表格部分为柱状图的准确数值，而其数值表示的是完成测试用例所需的时间，单位为毫秒。

- armv7设备：iPhone 4s (OS 7.1.2)
![ios_1](images/ios_1.png)
- arm64设备：iPhone 5s (OS 9.3.5)
![ios_2](images/ios_2.png)

## Changelog

[uLua](https://github.com/jarjin/uLua), [commit #dbe98bc](https://github.com/jarjin/uLua/commit/dbe98bce0a3fd169935617dec9e9fe129de8832b)

[sLua](https://github.com/pangweiwei/slua), [commit #ef57252](https://github.com/pangweiwei/slua/commit/ef572524e5b95ff5305bd33d0f7a2725716f6ae5)

[toLua](https://github.com/topameng/tolua),  [commit #710dedc](https://github.com/topameng/tolua/commit/710dedccb151cd7066fd1f6ec27902867c8f09fc)

### 1.04 (20160928)

- new data from UWA

### 1.03 (20160814)

- new data with new test methods (five times execution, which providing more details)

### 1.02 (20160403)

- upgrade to Unity 5.3.4
- mono version added
- new normalized graph

### 1.01 (20160221)

- toLua added

### 1.0 (20160221)

- some modification for Unity 5 API change
- port sLua benchmark to uLua
- use Profiler
