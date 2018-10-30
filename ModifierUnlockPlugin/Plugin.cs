using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IllusionPlugin;
using UnityEngine;


namespace ModifierUnlockPlugin
{
    public class Plugin : IPlugin
    {

        private int _currentLevelId = 0;
        private int[] _modifierButtons =
        {
            18,19,20,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38
        };

        public string Name
        {
            get { return "Modifier Unlock"; }
        }
        public string Version
        {
            get { return "0.91"; }
        }

        public void OnApplicationQuit()
        {
        }

        public void OnApplicationStart()
        {
        }

        public void OnFixedUpdate()
        {
        }

        public void OnLevelWasInitialized(int level)
        {
            _currentLevelId = level;
        }

        public void OnLevelWasLoaded(int level)
        {
            _currentLevelId = level;
        }

        public void OnUpdate()
        {
            if (_currentLevelId == -1 || _currentLevelId == 0)
            {
                try
                {
                    GameObject modifierMenu = GameObject.Find("Select Modifier");
                    if (modifierMenu == null)
                        return;

                    for(int i = 0; i < _modifierButtons.Length; i++)
                    {
                        modifierMenu.transform.Find("BackButton (" + _modifierButtons[i].ToString() + ")").GetComponent<HologramButtonScript>().locked = false;
                    }
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
    }
}
