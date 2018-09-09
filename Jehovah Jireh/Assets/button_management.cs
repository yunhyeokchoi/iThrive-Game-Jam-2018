using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_management : MonoBehaviour {

    public GameObject[] button;
    public float y_offset;

	// Use this for initialization
	void Start () {
        //hide the sprite which is only for visual cue
        if (this.GetComponent<SpriteRenderer>() != null)
            this.GetComponent<SpriteRenderer>().enabled = false;

        Vector3 nxtbutpos = new Vector3(0f, 0f, 0f);
        if (this.GetComponent<Transform>() != null)
            nxtbutpos = this.GetComponent<Transform>().position;
        else
            return;

        Vector3 firstbutscale = new Vector3(0f, 0f, 0f);
        int bqty = button.Length;
        if (bqty > 0)
            for(int i = 0; i < bqty; ++i)
            {
                if (button[i] != null)
                {
                    Transform transform = button[i].GetComponent<Transform>();
                    //09/08/2018
                    //TODO(yunhyeok): Check if each of the elements in array
                    //are unique elements; no duplicated buttons
                    if (transform != null)
                    {
                        if (i == 0)
                            firstbutscale = transform.lossyScale;

                        transform.position = nxtbutpos;
                        //09/08/2018
                        //TODO(yunhyeok): probably better to let y_offset be only positive
                        nxtbutpos.y -= (firstbutscale.y + y_offset);
                    }

                }
            }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
