using UnityEngine;

public class Mover : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0.001f;
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue, yValue, zValue);
    }
}
