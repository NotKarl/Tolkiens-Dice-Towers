using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GridGameManager : MonoBehaviour
{
    private GridSys<bool> grid;

    private void Awake()
    {
        grid = new GridSys<bool>(18, 10, 6f, new Vector3(-54, -30));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = UtilsClass.GetMouseWorldPosition();
        }
    }
}
