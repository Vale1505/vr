using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject handle;
    [SerializeField] GameObject key;
    private bool locked;

    // Start is called before the first frame update
    void Start()
    {
        locked = true;
        door.GetComponent<Rigidbody>().isKinematic = true;
        handle.GetComponent<BoxCollider>().enabled = false;
    }

    // Unity Message
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key" && locked)
        {
            UnlockDoor();
        }
    }

    private void UnlockDoor()
    {
        door.GetComponent<Rigidbody>().isKinematic = false;
        handle.GetComponent<BoxCollider>().enabled = true;
        this.GetComponent<Rigidbody>().isKinematic = false;
        locked = false;
    }
}
