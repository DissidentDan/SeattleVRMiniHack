using UnityEngine;
using System.Collections;
using NewtonVR;

public class DestroyThrownObject : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip DestructionSound;

	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	}

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MovableObject" || other.GetComponent<NVRInteractableItem>())
        {
            Destroy(other.gameObject);
            if (audioSource && DestructionSound)
            {
                audioSource.clip = DestructionSound;
                audioSource.Play();
            }
        }
	}
}
