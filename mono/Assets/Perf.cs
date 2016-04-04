using UnityEngine;
using System.Collections;
using System;

public class Perf : MonoBehaviour
{
	void Start()
	{
        //Screen.SetResolution(800, 480, true);
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
		if (GUI.Button(new Rect(10, 10, 120, 50), "Test1"))
		{
            Profiler.BeginSample("test1");
			var t1 = DateTime.Now;
			for(int i=1; i <= 200000; i++)
			{
				transform.position = transform.position;
			}
			var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
			log("test1 "+t.ToString(), "", LogType.Log);
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 100, 120, 50), "Test2"))
		{
			Profiler.BeginSample("test2");
			var t1 = DateTime.Now;
			for(int i=1; i <= 200000; i++)
			{
				transform.Rotate(Vector3.up, 90);
			}
			var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
			log("test2 "+t.ToString(), "", LogType.Log);
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 200, 120, 50), "Test3"))
		{
			Profiler.BeginSample("test3");
			var t1 = DateTime.Now;
			for(int i=1; i <= 2000000; i++)
			{
				Vector3 v = new Vector3(i,i,i);
				Vector3.Normalize(v);
			}
			var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
			log("test3 "+t.ToString(), "", LogType.Log);
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(10, 300, 120, 50), "Test4"))
		{
			Profiler.BeginSample("test4");
			var t1 = DateTime.Now;
			for(int i=1; i <= 200000; i++)
			{
				var v = new GameObject();
			}
			var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
			log("test4 "+t.ToString(), "", LogType.Log);
            Profiler.EndSample();
        }

		if (GUI.Button(new Rect(200, 10, 120, 50), "Test5"))
		{
			Profiler.BeginSample("test5");
			var t1 = DateTime.Now;
			for(int i=1; i <= 20000; i++)
			{
				var v = new GameObject();
				v.AddComponent<SkinnedMeshRenderer>();
				var c = v.GetComponent<SkinnedMeshRenderer>();
				c.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
				c.receiveShadows = false;
			}
			var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
			log("test5 "+t.ToString(), "", LogType.Log);
            Profiler.EndSample();
        }

        if (GUI.Button(new Rect(200, 100, 120, 50), "Test6"))
        {
			Profiler.BeginSample("test6");
			var t1 = DateTime.Now;
			for(int i=1; i <= 200000; i++)
			{
				var p = Quaternion.Euler(100,100,100);
				var q = Quaternion.Slerp(Quaternion.identity,p,0.5f);
			}
			var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
			log("test6 "+t.ToString(), "", LogType.Log);
            Profiler.EndSample();
        }

		GUI.Label(new Rect(400, 200, 300, 150), logText);
	}
}
