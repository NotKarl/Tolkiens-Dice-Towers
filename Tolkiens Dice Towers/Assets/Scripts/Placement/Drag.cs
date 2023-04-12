using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    //[SerializeField] public GameObject _towerObj;
    [SerializeField] public Camera _camera;
    //[SerializeField] private CircleCollider2D _placeCollider;
    //[SerializeField] private GameObject _placeMat;
    //[SerializeField] private SpriteRenderer _sprite;

    private bool _collidesPath;
    private bool _collidesTower;    
    
    private bool dragging = false;
    private bool _placed = false;
    private Vector3 offset;

    private void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }
    
    private void OnMouseDown()
    {
        if(!_placed)
        {
            offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dragging = true;
        }   
    }

    private void OnMouseUp()
    {
        if(!_placed && !_collidesPath && !_collidesTower)
        {
            dragging = false;
            _placed = true;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tower")
        {
            Debug.Log("Collision Detected");
        }
    }

    public Vector2 GetMousePosition()
    {
        return _camera.ScreenToWorldPoint(Input.mousePosition);
    }
}
