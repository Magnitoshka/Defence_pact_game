using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] GameObject toSpawm;
    [SerializeField][Range(0f, 1f)] float probability;

    public void Spawn()
    {
        if (Random.value<probability)
        {
            GameObject go = Instantiate(toSpawm, transform.position, Quaternion.identity);  
        }
    }
}
