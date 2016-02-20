using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class AudioClipWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("LoadAudioData", LoadAudioData),
			new LuaMethod("UnloadAudioData", UnloadAudioData),
			new LuaMethod("GetData", GetData),
			new LuaMethod("SetData", SetData),
			new LuaMethod("Create", Create),
			new LuaMethod("New", _CreateAudioClip),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("length", get_length, null),
			new LuaField("samples", get_samples, null),
			new LuaField("channels", get_channels, null),
			new LuaField("frequency", get_frequency, null),
			new LuaField("loadType", get_loadType, null),
			new LuaField("preloadAudioData", get_preloadAudioData, null),
			new LuaField("loadState", get_loadState, null),
			new LuaField("loadInBackground", get_loadInBackground, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AudioClip", typeof(AudioClip), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAudioClip(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			AudioClip obj = new AudioClip();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: AudioClip.New");
		}

		return 0;
	}

	static Type classType = typeof(AudioClip);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_length(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name length");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index length on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.length);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_samples(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name samples");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index samples on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.samples);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_channels(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name channels");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index channels on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.channels);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_frequency(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name frequency");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index frequency on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.frequency);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loadType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name loadType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index loadType on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.loadType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_preloadAudioData(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name preloadAudioData");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index preloadAudioData on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.preloadAudioData);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loadState(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name loadState");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index loadState on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.loadState);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loadInBackground(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name loadInBackground");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index loadInBackground on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.loadInBackground);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAudioData(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		AudioClip obj = (AudioClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AudioClip");
		bool o = obj.LoadAudioData();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnloadAudioData(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		AudioClip obj = (AudioClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AudioClip");
		bool o = obj.UnloadAudioData();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetData(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		AudioClip obj = (AudioClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AudioClip");
		float[] objs0 = LuaScriptMgr.GetArrayNumber<float>(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		bool o = obj.GetData(objs0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetData(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		AudioClip obj = (AudioClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AudioClip");
		float[] objs0 = LuaScriptMgr.GetArrayNumber<float>(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		bool o = obj.SetData(objs0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Create(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 5)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			bool arg4 = LuaScriptMgr.GetBoolean(L, 5);
			AudioClip o = AudioClip.Create(arg0,arg1,arg2,arg3,arg4);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 6)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			bool arg4 = LuaScriptMgr.GetBoolean(L, 5);
			AudioClip.PCMReaderCallback arg5 = null;
			LuaTypes funcType6 = LuaDLL.lua_type(L, 6);

			if (funcType6 != LuaTypes.LUA_TFUNCTION)
			{
				 arg5 = (AudioClip.PCMReaderCallback)LuaScriptMgr.GetNetObject(L, 6, typeof(AudioClip.PCMReaderCallback));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 6);
				arg5 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushArray(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			AudioClip o = AudioClip.Create(arg0,arg1,arg2,arg3,arg4,arg5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 7)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			bool arg4 = LuaScriptMgr.GetBoolean(L, 5);
			AudioClip.PCMReaderCallback arg5 = null;
			LuaTypes funcType6 = LuaDLL.lua_type(L, 6);

			if (funcType6 != LuaTypes.LUA_TFUNCTION)
			{
				 arg5 = (AudioClip.PCMReaderCallback)LuaScriptMgr.GetNetObject(L, 6, typeof(AudioClip.PCMReaderCallback));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 6);
				arg5 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushArray(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			AudioClip.PCMSetPositionCallback arg6 = null;
			LuaTypes funcType7 = LuaDLL.lua_type(L, 7);

			if (funcType7 != LuaTypes.LUA_TFUNCTION)
			{
				 arg6 = (AudioClip.PCMSetPositionCallback)LuaScriptMgr.GetNetObject(L, 7, typeof(AudioClip.PCMSetPositionCallback));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 7);
				arg6 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			AudioClip o = AudioClip.Create(arg0,arg1,arg2,arg3,arg4,arg5,arg6);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: AudioClip.Create");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

