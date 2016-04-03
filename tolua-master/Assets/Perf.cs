using UnityEngine;
using System.Collections;
using LuaInterface;
public class Perf : MonoBehaviour
{
    LuaState l = null;
    // Use this for initialization
    void Start()
    {
        Screen.SetResolution(800, 480, true);

        new LuaResLoader();
        l = new LuaState();
        l.Start();
        LuaBinder.Bind(l);
        l.DoFile("perf.lua");
        l.LuaGC(LuaGCOptions.LUA_GCCOLLECT);
        l.LogGC = false;

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
		if (GUI.Button(new Rect(10, 10, 120, 50), "Test1"))
		{
            Profiler.BeginSample("test1");
            LuaFunction func = l.GetFunction("test1");
            func.BeginPCall();
            func.Push(transform);
            func.PCall();
            func.EndPCall();
            func.Dispose();
            func = null;
            Profiler.EndSample();
		}

		if (GUI.Button(new Rect(10, 100, 120, 50), "Test2"))
		{
            Profiler.BeginSample("test2");
            LuaFunction func = l.GetFunction("test2");
            func.BeginPCall();
            func.Push(transform);
            func.PCall();
            func.EndPCall();
            func.Dispose();
            func = null;
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 200, 120, 50), "Test3"))
		{
            Profiler.BeginSample("test3");
            LuaFunction func = l.GetFunction("test3");
            func.BeginPCall();
            func.Push(transform);
            func.PCall();
            func.EndPCall();
            func.Dispose();
            func = null;
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 300, 120, 50), "Test4"))
		{
            Profiler.BeginSample("test4");
            LuaFunction func = l.GetFunction("test4");
            func.BeginPCall();
            func.Push(transform);
            func.PCall();
            func.EndPCall();
            func.Dispose();
            func = null;
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(200, 10, 120, 50), "Test5"))
		{
            Profiler.BeginSample("test5");
            LuaFunction func = l.GetFunction("test5");
            func.BeginPCall();
            func.Push(transform);
            func.PCall();
            func.EndPCall();
            func.Dispose();
            func = null;
            Profiler.EndSample();
        }

        if (GUI.Button(new Rect(200, 100, 120, 50), "Test6 jit"))
        {
            Profiler.BeginSample("test6");
            LuaFunction func = l.GetFunction("test6");
            func.BeginPCall();
            func.Push(transform);
            func.PCall();
            func.EndPCall();
            func.Dispose();
            func = null;
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(200, 200, 120, 50), "Test6 non-jit"))
		{
            LuaFunction func = l.GetFunction("test7");
            func.BeginPCall();
            func.Push(transform);
            func.PCall();
            func.EndPCall();
            func.Dispose();
            func = null;
            Profiler.EndSample();
        }
        
		GUI.Label(new Rect(400, 200, 300, 150), logText);
	}
}
