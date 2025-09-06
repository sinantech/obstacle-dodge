using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;

    void Start()
    {

    }

    void Update()
    {
        // Left and right movement input x axis
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        // Y axis upo and down input y axis 
        float yValue = 0.001f;
        // Forward and backward input z axis
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
