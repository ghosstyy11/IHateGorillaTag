using BepInEx;
using UnityEngine;

namespace IHateGorillaTag
{
    [BepInPlugin("com.ghosty.ihategorillatag", "IHateGorillaTag", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            // you would never guess what this mod does
            Application.Quit();
        }
    }
}
