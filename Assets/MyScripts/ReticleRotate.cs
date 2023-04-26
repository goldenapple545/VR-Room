using UnityEngine;

public class ReticleRotate : MonoBehaviour
{
    void Update()
    {
        Quaternion rotationY = Quaternion.AngleAxis(1, Vector3.up);
        transform.rotation *= rotationY;
    }
}
