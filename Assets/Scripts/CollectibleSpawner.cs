using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public GameObject collectibleParent;

    private void Start()
    {
        for(int i =0; i<10; i++)
        {
            Instantiate(collectiblePrefab, new Vector3(Random.Range(-8, 8), 0.5f, Random.Range(-8, 8)), Quaternion.identity, collectibleParent.transform);
        }
    }
}
