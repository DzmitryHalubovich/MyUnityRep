using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    void FixedUpdate()
    {
        Quaternion rotationZ = Quaternion.AngleAxis(15,Vector3.forward);
        transform.rotation *= rotationZ;
    }
}
