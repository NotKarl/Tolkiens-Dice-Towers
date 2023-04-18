using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField] public Camera _camera;
    
    public bool dragging = false;
    public bool _placed = false;
    private Vector3 offset;
    private bool _collPath = false;
    private bool _collTower = false;

    private SpriteRenderer _collColor;

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
        if(!_placed && !_collPath && !_collTower)
        {
            dragging = false;
            _placed = true;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Trigger Entered!");
        _collPath = true;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("Trigger Exited!");
        _collPath = false;
    }

    public Vector2 GetMousePosition()
    {
        return _camera.ScreenToWorldPoint(Input.mousePosition);
    }
}
