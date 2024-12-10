using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPositionManager : MonoBehaviour
{
    [Serializable]
    public struct ObjectOffset
    {
        public GameObject obj;
        public Vector3 offset;
    }
    [SerializeField]
    public List<ObjectOffset> objectsToAlign;
    // Start is called before the first frame update
    void Start()
    {
        InitializePositions();
    }
    void InitializePositions()
    {
        foreach (ObjectOffset item in objectsToAlign)
        {
            if (item.obj != null)
            {
                Vector3 cameraPosition = Camera.main.transform.position;
                Vector3 newPosition = new Vector3(cameraPosition.x + item.offset.x, cameraPosition.y + item.offset.y, cameraPosition.z + item.offset.z);
                item.obj.transform.position = newPosition;
            }
        }
    }
}
