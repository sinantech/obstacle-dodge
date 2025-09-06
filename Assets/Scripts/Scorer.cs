using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You have bumoed into a thing to many times: " + hits);
    }
}
