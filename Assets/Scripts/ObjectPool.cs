﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    /// <summary>
    /// An array of prefabs used to create an object in the gameworld
    /// </summary>
    [SerializeField]
    private GameObject[] objectPrefabs;

    private List<GameObject> pooledObjects = new List<GameObject>();

    /// <summary>
    /// Gets an object from the pool
    /// </summary>
    /// <param name="type">The type of object that we request</param>
    /// <returns>A GameObject of specific type</returns>
    public GameObject GetObject(string type)
    {
        foreach (GameObject go in pooledObjects)
        {
            if (go.name == type && !go.activeInHierarchy)
            {
                go.SetActive(true);
                return go;
            }
        }

        //If the pool didn't contain the object, that we needed then we need to create a new one
        for (int i = 0; i < objectPrefabs.Length; i++)
        {
            //If we have a prefab for creating the object
            if (objectPrefabs[i].name == type)
            {
                //We instantiate the prefab of the correct type
                GameObject newObject = Instantiate(objectPrefabs[i]);
                pooledObjects.Add(newObject);
                newObject.name = type;
                return newObject;
            }
        }

        return null;
    }

    public void ReleaseObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

}
