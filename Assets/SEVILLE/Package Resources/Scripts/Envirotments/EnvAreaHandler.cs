using UnityEditor;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Seville
{
    public class EnvAreaHandler : MonoBehaviour
    {
        [Tooltip("Insert components contained in the area (ex: canvas and object interaction)")]
        public List<GameObject> areaObjsList;
        public GameObject NPC;
        public Texture2D areaTexture;
        public bool isRestartOnExitArea = false;

        [Space]
        public float firstCamLookRotationValue;

        [Space]
        public AudioClip backsound;

        private void AddNPC()
        {
            try
            {
                areaObjsList.Add(NPC);
            }
            catch
            {
                Debug.Log("There is no NPC");
            }
        }
        public void SetActiveObjsState(bool state)
        {
            AddNPC();
            foreach (var item in areaObjsList)
            {
                item.SetActive(state);
            }
        }
    }
}