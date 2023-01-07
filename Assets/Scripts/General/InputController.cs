using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class InputController : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        this.mainCamera = FindObjectOfType<Camera>();
    }
    private void Update()
    {
        //Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = transform.position.z;
        transform.position = mouseWorldPosition;    
    }
}
