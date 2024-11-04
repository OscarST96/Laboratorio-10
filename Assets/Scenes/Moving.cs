using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public int xDirection;
    public int yDirection;
    private Transform _componentTrasform;


    // Start is called before the first frame update
    void Start()
    {

    }
    // Start is called before the first frame update
    void Awake()
    {
        _componentTrasform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        _componentTrasform.position = new Vector2(_componentTrasform.position.x + xSpeed * xDirection * Time.deltaTime,
            _componentTrasform.position.y + ySpeed * yDirection * Time.deltaTime);
        if (_componentTrasform.position.x >= 8.11f)
        {
            xDirection = -1;
        }
        if (_componentTrasform.position.x <= -7.98f)
        {
            xDirection = 1;
        }
        if (_componentTrasform.position.y >= 3.88f)
        {
            yDirection = -1;
        }
        if (_componentTrasform.position.y <= -3.88f)
        {
            yDirection = 1;
        }
    }
}