using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    public static List<MoveToMouse> movableObjects = new List<MoveToMouse>();
    private Camera mainCamera;
    [SerializeField] private float speed;
    private Vector3 target;
    private bool selected;
    private Card card;

    // Start is called before the first frame update
    void Start()
    {
        movableObjects.Add(this);
        target = transform.position;
        mainCamera = FindObjectOfType<Camera>();
        card = GetComponent<Card>();
    }

    // Update is called once per frame
    void Update()
    {
        if(selected)
        {
            target = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            transform.position = target;// Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        this.selected = true;
        GetComponent<SpriteRenderer>().color = Color.white;
        
        foreach(MoveToMouse obj in movableObjects)
        {
            if (obj != this)
            {
                obj.selected= false;
                obj.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }

    }

    private void OnMouseUp()
    {
        selected = false;
        card.OnSpawnEvent?.Invoke(card);
    }
}
