using UnityEngine;
using System.Collections;
using SLua;
public class Perf : MonoBehaviour
{

	LuaSvr l;
	void Start()
	{
        //Screen.SetResolution(800, 480, true);
		l = new LuaSvr();
		l.init(null, () =>
		{
			l.start("perf");
		});
		
		Application.logMessageReceived += this.log;
	}

	string logText = "";
	void log(string cond, string trace, LogType lt)
	{
		logText += cond;
		logText += "\n";
	}

	void OnGUI()
	{
		if (!l.inited)
			return;

		if (GUI.Button(new Rect(10, 10, 120, 50), "Test1"))
		{
            Profiler.BeginSample("test1");
            l.luaState.getFunction("test1").call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 100, 120, 50), "Test2"))
		{
            Profiler.BeginSample("test2");
            l.luaState.getFunction("test2").call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 200, 120, 50), "Test3"))
		{
            Profiler.BeginSample("test3");
            l.luaState.getFunction("test3").call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 300, 120, 50), "Test4"))
		{
            Profiler.BeginSample("test4");
            l.luaState.getFunction("test4").call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(200, 10, 120, 50), "Test5"))
		{
            Profiler.BeginSample("test5");
            l.luaState.getFunction("test5").call();
            Profiler.EndSample();
        }

        if (GUI.Button(new Rect(200, 100, 120, 50), "Test6 jit"))
        {
            Profiler.BeginSample("test6");
            l.luaState.getFunction("test6").call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(200, 200, 120, 50), "Test6 non-jit"))
		{
            Profiler.BeginSample("test7");
            l.luaState.getFunction("test7").call();
            Profiler.EndSample();
		}

        if (GUI.Button(new Rect(200, 300, 120, 50), "Clear"))
        {
            logText = "";
        }

        GUI.Label(new Rect(400, 200, 300, 150), logText);
	}
}
