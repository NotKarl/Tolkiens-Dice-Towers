using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    //Dead Code, used for collision based tower placement
    /*
    [SerializeField] private CircleCollider2D _placeCollider;
    [SerializeField] private CircleCollider2D _enemyCollider;
    [SerializeField] private GameObject _placeMat;
    [SerializeField] private SpriteRenderer _sprite;

    private bool _collidesPath;
    private bool _collidesTower;

    void update()
    {
        Collider2D[] overlap = Physics2D.OverlapAreaAll(_placeCollider.bounds.min, _placeCollider.bounds.max);
        if (overlap.Length > 1)
        {
            Debug.Log(string.Format("Found {0} overlapping object(s)", overlap.Length-1));
        }
    }

    private void PathCollision()
    {
        _collidesPath = true;
    }

    private void TowerCollision()
    {
        _collidesTower = true;
    }
    */
}
