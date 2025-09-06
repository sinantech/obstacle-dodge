using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        Debug.Log("Something Hit Me");
    }
}
