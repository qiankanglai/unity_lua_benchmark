A simple test for performance comparsion between Lua in Unity。

**ATTENTION**: I'm a newbie to lua in fact, and this is only a simple test! If there is something wrong with my test or exists a better implemention, please contact me and I'll update ASAP! Any pull requests are welcomed!

一个针对Unity中执行Lua的简单性能测试。

**注意**: 本人对Lua是新手阶段，而且本项目旨在提供一个简单的测试比较。如果你发现我的测试代码有问题或者有更好的写法，请联系我、我会尽快改正。欢迎任何Pull Request！

TODO: Mesure startup consumption. sLua has a async init so I have to figure out a better way to Profiler.

Images below show test cases as vertical axis, and time or gc alloc. (GC Alloc is in LOG)

下图纵坐标为测试用例。(GC在对数坐标中进行比较)

![profiler_time](images/profiler_time.png)

![profiler_gc](images/profiler_gc.png)

![lua_clock_win](images/lua_clock_win.png)
![lua_clock_osx](images/lua_clock_osx.png)
![lua_clock_android](images/lua_clock_android.png)
![lua_clock_ios](images/lua_clock_ios.png)

More details can be found in [benchmark.xlsx](benchmark.xlsx).

更多数据见[benchmark.xlsx](benchmark.xlsx)。

## Benchmark Methods 测试方法

Based on sLua's performance_test, I modified C# part to take advantage of **Profiler**, and ported into other Projects.

基于sLua自带的performance_test场景，我主要是修改了C#部分，利用**Profiler**来监控信息，并移植到其他项目中。

    Profiler.BeginSample("test1");
    l.luaState.getFunction("test1").call();
    Profiler.EndSample();

![profiler](images/profiler.png)

At the same time Lua part has a clock inside. These two mesured time may not be the same. Some seems outliers which are colored red.

同时Lua代码部分也有一个计时器。这两个测出来的时间有可能不那么一致。有些看起来是不太对的点已标红。

## Benchmark Environment 测试环境

- Windows(Editor)
	- Intel i5-3470 @ 3.20GHz, 16G RAM, NVIDIA GeForce GTX 660
	- Windows 10 64bit, Unity 5.3.4f1
- OSX(Editor)
	- Intel i7-3615QM @ 2.30GHz, 8G RAM, NVIDIA GeForce GT 650M
	- OSX 10.11.3, Unity 5.3.4f1
- Android(Release)
	- Nexus 6
	- Android 6.0.1
- iOS(Release, IL2CPP)
	- iPad 3
	- iOS 9.2.1

Every test is executed five times, and then reboot App.

每个测试顺序执行五次，然后重启。

## Changelog

[uLua](https://github.com/jarjin/uLua), [commit #dbe98bc](https://github.com/jarjin/uLua/commit/dbe98bce0a3fd169935617dec9e9fe129de8832b)

[sLua](https://github.com/pangweiwei/slua), [commit #ef57252](https://github.com/pangweiwei/slua/commit/ef572524e5b95ff5305bd33d0f7a2725716f6ae5)

[toLua](https://github.com/topameng/tolua),  [commit #710dedc](https://github.com/topameng/tolua/commit/710dedccb151cd7066fd1f6ec27902867c8f09fc)

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
