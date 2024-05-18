using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TouchUI : MonoBehaviour
{
    public UnityEvent onHandInter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            onHandInter.Invoke();
        }
    }
}

