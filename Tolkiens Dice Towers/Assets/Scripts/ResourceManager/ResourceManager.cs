using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public int stoneCount = 20; // starting amount of stone resources
    public int magicCount = 69; // starting amount of magic resources

    public void SubtractResources(int stoneCost, int magicCost)
    {
        stoneCount -= stoneCost;
        magicCount -= magicCost;
    }

    public void AddResources(int stoneAmount, int magicAmount)
    {
        stoneCount += stoneAmount;
        magicCount += magicAmount;
    }

    public void OnWaveCompleted()
    {
        AddResources(Random.Range(0, 11), Random.Range(0, 11)); // add a random amount of stone and magic resources after each wave
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
