using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOutManager : MonoBehaviour {

    public Animator animator;
	
    void Start()
    {
        
    }

	// Update is called once per frame
	void Update () {
		
	}

    public void FadeOut()
    {
        animator.SetTrigger("FadeInToOut");
    }

    public void FadeIn()
    {
        animator.SetTrigger("TriggerFadeIn");
    }


}
