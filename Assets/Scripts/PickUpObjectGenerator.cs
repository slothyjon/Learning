using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjectGenerator : MonoBehaviour {

    public GameObject PickUpPrefabReference = null;

    private const float SPAWN_RANGE = 9.5f;
    private const float HEIGHT = 1f;

    // Use this for initialization
    void Start ()
    {
        GeneratePickUpObjects(12);		
	}

    private void GeneratePickUpObjects(int num)
    {
        for (int i=0; i < num; i++)
        {
            GameObject temp = Instantiate(PickUpPrefabReference, transform);
            temp.transform.localPosition = new Vector3(Random.Range(-SPAWN_RANGE, SPAWN_RANGE), HEIGHT, Random.Range(-SPAWN_RANGE, SPAWN_RANGE));
        }
    }
}
