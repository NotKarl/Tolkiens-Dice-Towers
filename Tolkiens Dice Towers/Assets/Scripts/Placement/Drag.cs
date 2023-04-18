using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    //Positioning Variables
    [SerializeField] public Camera _camera;
    private Vector3 offset;

    //Placement Checks
    public bool dragging = false;
    public bool _placed = false;

    //Collision Checks
    private bool _collPath = false;

    //Color + Sprite to Color
    public Color defCol;
    public Color placeCol;
    public Color nonPlaceCol;
    private SpriteRenderer towSprite;

    //Tower Range indicator
    private bool createdRange = false;
    public GameObject hitRange;

    private void Start()
    {
        towSprite = GetComponent<SpriteRenderer>();

        defCol = towSprite.color;
    }
    
    private void Update()
    {
        //Object position to Mouse position
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            hitRange.transform.position = transform.position;
        }

        //Color on start
        if (!_placed && !dragging)
        {
            towSprite.color = defCol;
        }
        
        //Color on collision
        if (_collPath && !_placed && dragging)
        {
            towSprite.color = nonPlaceCol;
        }
        
        //Color on non collision
        if (!_collPath && !_placed && dragging)
        {
            towSprite.color = placeCol;
        }
        
        //Color on placing
        if (_placed && !dragging)
        {
            towSprite.color = defCol;
        }
    }
    
    private void OnMouseDown()
    {
        if (!_placed)
        {
            offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dragging = true;

            //Create a range indicator once
            if (!createdRange)
            {
                hitRange = Instantiate(hitRange, transform.position, transform.rotation);

                createdRange = true;
            }
        }   
    }

    private void OnMouseUp()
    {
        if (!_placed && !_collPath)
        {
            dragging = false;
            _placed = true;

            towSprite.color = defCol;
        }
        
        if (_placed && createdRange)
        {
            Destroy(hitRange);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        _collPath = true;

    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        _collPath = true;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        _collPath = false;

    }

    public Vector2 GetMousePosition()
    {
        return _camera.ScreenToWorldPoint(Input.mousePosition);
    }
}
