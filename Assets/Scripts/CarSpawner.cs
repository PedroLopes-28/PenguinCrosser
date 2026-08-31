using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarSpawner : MonoBehaviour

    
{
    
     private List<GameObject> SpawnP;
     [SerializeField] private List<GameObject> carPrefabs;

    private void Awake()
    {
        SpawnP = new List<GameObject>();
        foreach (Transform child in transform)
        {
            SpawnP.Add(child.gameObject);
            
        }
    }

    private void Start()
    {
        InvokeRepeating("SpawnCar", 0, 1);
    }

    void SpawnCar()
    {
        int randomC = Random.Range(0, carPrefabs.Count);
        Instantiate( carPrefabs[randomC],SpawnP[randomC].transform.position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
