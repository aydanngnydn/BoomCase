using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{
    void Update()
    {
    Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
    float midPoint = (transform.position - Camera.main.transform.position).magnitude * 1f;
    transform.LookAt(mouseRay.origin + mouseRay.direction * midPoint);
    }
}
