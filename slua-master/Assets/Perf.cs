using UnityEngine;
using System.Collections;
using SLua;
public class Perf : MonoBehaviour
{

	LuaSvr l;
	// Use this for initialization
	void Start()
	{
        Screen.SetResolution(800, 480, true);
        //Profiler.BeginSample("start");
		l = new LuaSvr();
		l.init(null, () =>
		{
			l.start("perf");
            //Profiler.EndSample();
		});

#if UNITY_5
		Application.logMessageReceived += this.log;
#else
		Application.RegisterLogCallback(this.log);
#endif
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
			logText = "";
            Profiler.BeginSample("test1");
            l.luaState.getFunction("test1").call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 100, 120, 50), "Test2"))
		{
			logText = "";
            Profiler.BeginSample("test2");
            l.luaState.getFunction("test2").call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 200, 120, 50), "Test3"))
		{
			logText = "";
            Profiler.BeginSample("test3");
            l.luaState.getFunction("test3").call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 300, 120, 50), "Test4"))
		{
			logText = "";
            Profiler.BeginSample("test4");
            l.luaState.getFunction("test4").call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(200, 10, 120, 50), "Test5"))
		{
			logText = "";
            Profiler.BeginSample("test5");
            l.luaState.getFunction("test5").call();
            Profiler.EndSample();
        }

        if (GUI.Button(new Rect(200, 100, 120, 50), "Test6 jit"))
        {
            logText = "";
            Profiler.BeginSample("test6");
            l.luaState.getFunction("test6").call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(200, 200, 120, 50), "Test6 non-jit"))
		{
			logText = "";
            Profiler.BeginSample("test7");
            l.luaState.getFunction("test7").call();
            Profiler.EndSample();
		}

        if (GUI.Button(new Rect(10, 400, 300, 50), "Click here for detail(in Chinese)"))
		{
			Application.OpenURL("http://www.sineysoft.com/post/164");
		}

		GUI.Label(new Rect(400, 200, 300, 50), logText);
	}
}
