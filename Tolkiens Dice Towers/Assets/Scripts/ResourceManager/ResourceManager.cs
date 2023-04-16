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
        // Code for testing purposes
        // Check if the "s" key is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Subtract 10 from resource 1 and 5 from resource 2
            SubtractResources(10, 5);
        }

        // Check if the "a" key is pressed
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Add 10 to resource 1 and 5 to resource 2
            AddResources(10, 5);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            OnWaveCompleted();
        }
    }
}
