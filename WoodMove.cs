using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodMove : MonoBehaviour
{
    public static WoodMove instance;
    public float speed;
    public Transform target;

    [HideInInspector]
    public TrailRenderer line;

    private Vector3 zAxis = new Vector3(0, 0, 1);
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        line = GameObject.FindGameObjectWithTag("Line").GetComponent<TrailRenderer>();
        //line.gameObject.SetActive(false);
        line.emitting = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.RotateAround(target.position, -zAxis, speed);
            //line.gameObject.SetActive(true);
            line.emitting = true;
        }
        else if (Input.GetKey(KeyCode.X))
        {
            transform.RotateAround(target.position, zAxis, speed);
            //line.gameObject.SetActive(true);
            line.emitting = true;
        }
        if (Input.GetAxisRaw("Horizontal") > 0f && !ButtonController.instance.locked)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
            //line.gameObject.SetActive(false);
            line.emitting = false;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0f && !ButtonController.instance.locked)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;
            //line.gameObject.SetActive(false);
            line.emitting = false;
        }

        if (Input.GetAxisRaw("Vertical") > 0f && !ButtonController.instance.locked)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            transform.position = temp;
            //line.gameObject.SetActive(false);
            line.emitting = false;
        }
        else if (Input.GetAxisRaw("Vertical") < 0f && !ButtonController.instance.locked)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;
            transform.position = temp;
            //line.gameObject.SetActive(false);
            line.emitting = false;
        }
    }
}
