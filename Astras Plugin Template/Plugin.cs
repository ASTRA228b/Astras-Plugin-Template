using UnityEngine;
using BepInEx;
using Astras_Plugin_Template.Core;
using Astras_Plugin_Template.Stuff;
using Astras_Plugin_Template.Libraries;

namespace Astras_Plugin_Template.Plugin;

[BepInPlugin(Constantss.GUID, Constantss.Name, Constantss.Version)]
public class Plugin : BaseUnityPlugin
{
    void Start()
    {
        PatchLoader.Apply();
    }

    void Awake()
    {
        GameObject Plugin = new GameObject(Constantss.ObjectName);
        Plugin.AddComponent<Main>();
        Plugin.AddComponent<OnScreenNotify>();
        DontDestroyOnLoad(Plugin);
    }
}