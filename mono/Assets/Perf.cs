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
			var t1 = DateTime.Now;
            Profiler.BeginSample("test1");
            for (int i=1; i <= 200000; i++)
			{
				transform.position = transform.position;
            }
            Profiler.EndSample();
            var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
			Debug.Log("test1 " + t.ToString());
        }

		if (GUI.Button(new Rect(10, 100, 120, 50), "Test2"))
		{
			var t1 = DateTime.Now;
            Profiler.BeginSample("test2");
            for (int i=1; i <= 200000; i++)
			{
				transform.Rotate(Vector3.up, 90);
            }
            Profiler.EndSample();
            var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
            Debug.Log("test2 " + t.ToString());
        }

		if (GUI.Button(new Rect(10, 200, 120, 50), "Test3"))
		{
			var t1 = DateTime.Now;
            Profiler.BeginSample("test3");
            for (int i=1; i <= 2000000; i++)
			{
				Vector3 v = new Vector3(i,i,i);
				Vector3.Normalize(v);
            }
            Profiler.EndSample();
            var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
            Debug.Log("test3 " + t.ToString());
        }

		if (GUI.Button(new Rect(10, 300, 120, 50), "Test4"))
		{
			var t1 = DateTime.Now;
            Profiler.BeginSample("test4");
            for (int i=1; i <= 200000; i++)
			{
				var v = new GameObject();
            }
            Profiler.EndSample();
            var t2 = DateTime.Now;
            double t = (t2 - t1).TotalMilliseconds;
            Debug.Log("test4 " + t.ToString());
        }

		if (GUI.Button(new Rect(200, 10, 120, 50), "Test5"))
		{
			var t1 = DateTime.Now;
            Profiler.BeginSample("test5");
            for (int i=1; i <= 20000; i++)
			{
				var v = new GameObject();
				v.AddComponent<SkinnedMeshRenderer>();
				var c = v.GetComponent<SkinnedMeshRenderer>();
				c.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
				c.receiveShadows = false;
            }
            Profiler.EndSample();
            var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
            Debug.Log("test5 " + t.ToString());
        }

        if (GUI.Button(new Rect(200, 100, 120, 50), "Test6"))
        {
			var t1 = DateTime.Now;
            Profiler.BeginSample("test6");
            for (int i=1; i <= 200000; i++)
			{
				var p = Quaternion.Euler(100,100,100);
				var q = Quaternion.Slerp(Quaternion.identity,p,0.5f);
            }
            Profiler.EndSample();
            var t2 = DateTime.Now;
			double t = (t2-t1).TotalMilliseconds;
            Debug.Log("test6 " + t.ToString());
        }

        if (GUI.Button(new Rect(200, 200, 120, 50), "Clear"))
        {
            logText = "";
        }

		GUI.Label(new Rect(400, 200, 300, 150), logText);
	}
}
