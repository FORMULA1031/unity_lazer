using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            Debug.Log(hit.collider.gameObject.transform.position);
        }
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 1);
    }
}