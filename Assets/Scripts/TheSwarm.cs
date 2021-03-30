using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSwarm : MonoBehaviour
{

    public Fish FishPrefab;
    public static List<Fish> fishList;

    // Start is called before the first frame update
    void Start()
    {
        fishList = new List<Fish>();
        for (int f = 0; f < 20; f++)
        {
            var newFish = Instantiate(FishPrefab);
            fishList.Add(newFish);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
