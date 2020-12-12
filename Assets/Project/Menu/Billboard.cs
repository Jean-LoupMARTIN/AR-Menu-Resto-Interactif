

using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform camTransform;

    Quaternion originalRotation;

    void Start() { originalRotation = transform.rotation; }

    void Update() { transform.rotation = camTransform.rotation * originalRotation; }
}