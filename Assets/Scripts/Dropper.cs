using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    [SerializeField] float timeToWait = 2f;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
