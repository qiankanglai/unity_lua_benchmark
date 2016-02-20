using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class RenderSettingsWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateRenderSettings),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("fog", get_fog, set_fog),
			new LuaField("fogMode", get_fogMode, set_fogMode),
			new LuaField("fogColor", get_fogColor, set_fogColor),
			new LuaField("fogDensity", get_fogDensity, set_fogDensity),
			new LuaField("fogStartDistance", get_fogStartDistance, set_fogStartDistance),
			new LuaField("fogEndDistance", get_fogEndDistance, set_fogEndDistance),
			new LuaField("ambientMode", get_ambientMode, set_ambientMode),
			new LuaField("ambientSkyColor", get_ambientSkyColor, set_ambientSkyColor),
			new LuaField("ambientEquatorColor", get_ambientEquatorColor, set_ambientEquatorColor),
			new LuaField("ambientGroundColor", get_ambientGroundColor, set_ambientGroundColor),
			new LuaField("ambientLight", get_ambientLight, set_ambientLight),
			new LuaField("ambientIntensity", get_ambientIntensity, set_ambientIntensity),
			new LuaField("ambientProbe", get_ambientProbe, set_ambientProbe),
			new LuaField("reflectionIntensity", get_reflectionIntensity, set_reflectionIntensity),
			new LuaField("reflectionBounces", get_reflectionBounces, set_reflectionBounces),
			new LuaField("haloStrength", get_haloStrength, set_haloStrength),
			new LuaField("flareStrength", get_flareStrength, set_flareStrength),
			new LuaField("flareFadeSpeed", get_flareFadeSpeed, set_flareFadeSpeed),
			new LuaField("skybox", get_skybox, set_skybox),
			new LuaField("defaultReflectionMode", get_defaultReflectionMode, set_defaultReflectionMode),
			new LuaField("defaultReflectionResolution", get_defaultReflectionResolution, set_defaultReflectionResolution),
			new LuaField("customReflection", get_customReflection, set_customReflection),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.RenderSettings", typeof(RenderSettings), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateRenderSettings(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			RenderSettings obj = new RenderSettings();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: RenderSettings.New");
		}

		return 0;
	}

	static Type classType = typeof(RenderSettings);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fog(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.fog);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fogMode(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.fogMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fogColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.fogColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fogDensity(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.fogDensity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fogStartDistance(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.fogStartDistance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fogEndDistance(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.fogEndDistance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientMode(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.ambientMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientSkyColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.ambientSkyColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientEquatorColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.ambientEquatorColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientGroundColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.ambientGroundColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientLight(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.ambientLight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientIntensity(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.ambientIntensity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambientProbe(IntPtr L)
	{
		LuaScriptMgr.PushValue(L, RenderSettings.ambientProbe);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_reflectionIntensity(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.reflectionIntensity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_reflectionBounces(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.reflectionBounces);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_haloStrength(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.haloStrength);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flareStrength(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.flareStrength);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flareFadeSpeed(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.flareFadeSpeed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_skybox(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.skybox);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultReflectionMode(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.defaultReflectionMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultReflectionResolution(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.defaultReflectionResolution);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_customReflection(IntPtr L)
	{
		LuaScriptMgr.Push(L, RenderSettings.customReflection);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fog(IntPtr L)
	{
		RenderSettings.fog = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fogMode(IntPtr L)
	{
		RenderSettings.fogMode = (FogMode)LuaScriptMgr.GetNetObject(L, 3, typeof(FogMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fogColor(IntPtr L)
	{
		RenderSettings.fogColor = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fogDensity(IntPtr L)
	{
		RenderSettings.fogDensity = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fogStartDistance(IntPtr L)
	{
		RenderSettings.fogStartDistance = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fogEndDistance(IntPtr L)
	{
		RenderSettings.fogEndDistance = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientMode(IntPtr L)
	{
		RenderSettings.ambientMode = (UnityEngine.Rendering.AmbientMode)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.AmbientMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientSkyColor(IntPtr L)
	{
		RenderSettings.ambientSkyColor = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientEquatorColor(IntPtr L)
	{
		RenderSettings.ambientEquatorColor = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientGroundColor(IntPtr L)
	{
		RenderSettings.ambientGroundColor = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientLight(IntPtr L)
	{
		RenderSettings.ambientLight = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientIntensity(IntPtr L)
	{
		RenderSettings.ambientIntensity = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambientProbe(IntPtr L)
	{
		RenderSettings.ambientProbe = (UnityEngine.Rendering.SphericalHarmonicsL2)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.SphericalHarmonicsL2));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_reflectionIntensity(IntPtr L)
	{
		RenderSettings.reflectionIntensity = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_reflectionBounces(IntPtr L)
	{
		RenderSettings.reflectionBounces = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_haloStrength(IntPtr L)
	{
		RenderSettings.haloStrength = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_flareStrength(IntPtr L)
	{
		RenderSettings.flareStrength = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_flareFadeSpeed(IntPtr L)
	{
		RenderSettings.flareFadeSpeed = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_skybox(IntPtr L)
	{
		RenderSettings.skybox = (Material)LuaScriptMgr.GetUnityObject(L, 3, typeof(Material));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultReflectionMode(IntPtr L)
	{
		RenderSettings.defaultReflectionMode = (UnityEngine.Rendering.DefaultReflectionMode)LuaScriptMgr.GetNetObject(L, 3, typeof(UnityEngine.Rendering.DefaultReflectionMode));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultReflectionResolution(IntPtr L)
	{
		RenderSettings.defaultReflectionResolution = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_customReflection(IntPtr L)
	{
		RenderSettings.customReflection = (Cubemap)LuaScriptMgr.GetUnityObject(L, 3, typeof(Cubemap));
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

