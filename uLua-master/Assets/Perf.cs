using UnityEngine;
using System.Collections;
using LuaInterface;
public class Perf : MonoBehaviour
{
    LuaScriptMgr l = null;
    // Use this for initialization
    void Start()
    {
        Screen.SetResolution(800, 480, true);

        TextAsset asset = Resources.Load<TextAsset>("perf");
        Profiler.BeginSample("init");
        l = new LuaScriptMgr();
        l.Start();
        l.DoString(asset.ToString());
        Profiler.EndSample();
        l.GetLuaFunction("main").Call();

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
			logText = "";
            Profiler.BeginSample("test1");
            l.GetLuaFunction("test1").Call();
            Profiler.EndSample();
		}

		if (GUI.Button(new Rect(10, 100, 120, 50), "Test2"))
		{
			logText = "";
            Profiler.BeginSample("test2");
            l.GetLuaFunction("test2").Call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 200, 120, 50), "Test3"))
		{
			logText = "";
            Profiler.BeginSample("test3");
            l.GetLuaFunction("test3").Call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 300, 120, 50), "Test4"))
		{
			logText = "";
            Profiler.BeginSample("test4");
            l.GetLuaFunction("test4").Call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(200, 10, 120, 50), "Test5"))
		{
			logText = "";
            Profiler.BeginSample("test5");
            l.GetLuaFunction("test5").Call();
            Profiler.EndSample();
        }

        if (GUI.Button(new Rect(200, 100, 120, 50), "Test6 jit"))
        {
            logText = "";
            Profiler.BeginSample("test6");
            l.GetLuaFunction("test6").Call();
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(200, 200, 120, 50), "Test6 non-jit"))
		{
			logText = "";
            l.GetLuaFunction("test7").Call();
            Profiler.EndSample();
        }
        
		GUI.Label(new Rect(400, 200, 300, 50), logText);
	}
}
