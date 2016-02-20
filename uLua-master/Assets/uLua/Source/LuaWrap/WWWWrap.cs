using System;
using UnityEngine;
using System.Collections.Generic;
using LuaInterface;

public class WWWWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Dispose", Dispose),
			new LuaMethod("InitWWW", InitWWW),
			new LuaMethod("EscapeURL", EscapeURL),
			new LuaMethod("UnEscapeURL", UnEscapeURL),
			new LuaMethod("GetAudioClip", GetAudioClip),
			new LuaMethod("GetAudioClipCompressed", GetAudioClipCompressed),
			new LuaMethod("LoadImageIntoTexture", LoadImageIntoTexture),
			new LuaMethod("LoadFromCacheOrDownload", LoadFromCacheOrDownload),
			new LuaMethod("New", _CreateWWW),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("responseHeaders", get_responseHeaders, null),
			new LuaField("text", get_text, null),
			new LuaField("bytes", get_bytes, null),
			new LuaField("size", get_size, null),
			new LuaField("error", get_error, null),
			new LuaField("texture", get_texture, null),
			new LuaField("textureNonReadable", get_textureNonReadable, null),
			new LuaField("audioClip", get_audioClip, null),
			new LuaField("isDone", get_isDone, null),
			new LuaField("progress", get_progress, null),
			new LuaField("uploadProgress", get_uploadProgress, null),
			new LuaField("bytesDownloaded", get_bytesDownloaded, null),
			new LuaField("url", get_url, null),
			new LuaField("assetBundle", get_assetBundle, null),
			new LuaField("threadPriority", get_threadPriority, set_threadPriority),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.WWW", typeof(WWW), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateWWW(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			WWW obj = new WWW(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(byte[])))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			byte[] objs1 = LuaScriptMgr.GetArrayNumber<byte>(L, 2);
			WWW obj = new WWW(arg0,objs1);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(WWWForm)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			WWWForm arg1 = (WWWForm)LuaScriptMgr.GetNetObject(L, 2, typeof(WWWForm));
			WWW obj = new WWW(arg0,arg1);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 3)
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			byte[] objs1 = LuaScriptMgr.GetArrayNumber<byte>(L, 2);
			Dictionary<string,string> arg2 = (Dictionary<string,string>)LuaScriptMgr.GetNetObject(L, 3, typeof(Dictionary<string,string>));
			WWW obj = new WWW(arg0,objs1,arg2);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: WWW.New");
		}

		return 0;
	}

	static Type classType = typeof(WWW);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_responseHeaders(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name responseHeaders");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index responseHeaders on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.responseHeaders);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_text(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name text");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index text on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.text);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bytes(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bytes");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bytes on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.bytes);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_size(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name size");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index size on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.size);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_error(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name error");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index error on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.error);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_texture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name texture");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index texture on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.texture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_textureNonReadable(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name textureNonReadable");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index textureNonReadable on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.textureNonReadable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_audioClip(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name audioClip");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index audioClip on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.audioClip);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isDone(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isDone");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isDone on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isDone);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_progress(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name progress");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index progress on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.progress);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uploadProgress(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name uploadProgress");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index uploadProgress on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.uploadProgress);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bytesDownloaded(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bytesDownloaded");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bytesDownloaded on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.bytesDownloaded);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_url(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name url");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index url on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.url);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_assetBundle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name assetBundle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index assetBundle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.assetBundle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_threadPriority(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name threadPriority");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index threadPriority on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.threadPriority);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_threadPriority(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		WWW obj = (WWW)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name threadPriority");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index threadPriority on a nil value");
			}
		}

		obj.threadPriority = (ThreadPriority)LuaScriptMgr.GetNetObject(L, 3, typeof(ThreadPriority));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		WWW obj = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, "WWW");
		obj.Dispose();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitWWW(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		WWW obj = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, "WWW");
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		byte[] objs1 = LuaScriptMgr.GetArrayNumber<byte>(L, 3);
		string[] objs2 = LuaScriptMgr.GetArrayString(L, 4);
		obj.InitWWW(arg0,objs1,objs2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EscapeURL(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			string o = WWW.EscapeURL(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			System.Text.Encoding arg1 = (System.Text.Encoding)LuaScriptMgr.GetNetObject(L, 2, typeof(System.Text.Encoding));
			string o = WWW.EscapeURL(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: WWW.EscapeURL");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnEscapeURL(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			string o = WWW.UnEscapeURL(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			System.Text.Encoding arg1 = (System.Text.Encoding)LuaScriptMgr.GetNetObject(L, 2, typeof(System.Text.Encoding));
			string o = WWW.UnEscapeURL(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: WWW.UnEscapeURL");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAudioClip(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			WWW obj = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, "WWW");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			AudioClip o = obj.GetAudioClip(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			WWW obj = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, "WWW");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
			AudioClip o = obj.GetAudioClip(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4)
		{
			WWW obj = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, "WWW");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
			AudioType arg2 = (AudioType)LuaScriptMgr.GetNetObject(L, 4, typeof(AudioType));
			AudioClip o = obj.GetAudioClip(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: WWW.GetAudioClip");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAudioClipCompressed(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			WWW obj = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, "WWW");
			AudioClip o = obj.GetAudioClipCompressed();
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			WWW obj = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, "WWW");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			AudioClip o = obj.GetAudioClipCompressed(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			WWW obj = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, "WWW");
			bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
			AudioType arg1 = (AudioType)LuaScriptMgr.GetNetObject(L, 3, typeof(AudioType));
			AudioClip o = obj.GetAudioClipCompressed(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: WWW.GetAudioClipCompressed");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadImageIntoTexture(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		WWW obj = (WWW)LuaScriptMgr.GetNetObjectSelf(L, 1, "WWW");
		Texture2D arg0 = (Texture2D)LuaScriptMgr.GetUnityObject(L, 2, typeof(Texture2D));
		obj.LoadImageIntoTexture(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadFromCacheOrDownload(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(Hash128)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			Hash128 arg1 = (Hash128)LuaScriptMgr.GetLuaObject(L, 2);
			WWW o = WWW.LoadFromCacheOrDownload(arg0,arg1);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(int)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			WWW o = WWW.LoadFromCacheOrDownload(arg0,arg1);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(Hash128), typeof(uint)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			Hash128 arg1 = (Hash128)LuaScriptMgr.GetLuaObject(L, 2);
			uint arg2 = (uint)LuaDLL.lua_tonumber(L, 3);
			WWW o = WWW.LoadFromCacheOrDownload(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(string), typeof(int), typeof(uint)))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			uint arg2 = (uint)LuaDLL.lua_tonumber(L, 3);
			WWW o = WWW.LoadFromCacheOrDownload(arg0,arg1,arg2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: WWW.LoadFromCacheOrDownload");
		}

		return 0;
	}
}

