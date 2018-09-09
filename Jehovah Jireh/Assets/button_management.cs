using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_management : MonoBehaviour {

    public GameObject[] menubutton;
    //public float y_offset;

    public TextAsset[] path;

    public GameObject dialoguebox;

    private int depth;

    private string[] pm_lines;

    void UpdateLines()
    {
        //Clear
        pm_lines = null;

        if (path[depth] != null)
            //Split the whole thing whenever pointer encounters '\n';
            //count the number of lines.
            pm_lines = path[depth].text.Split('\n');
        else
            return;
    }

    void UpdateButtons()
    {
        int mbqty = 0;

        for (int i = 0; i < menubutton.Length; ++i)
            if (menubutton[i] != null) ++mbqty;

        int linesqty = pm_lines.Length;

        if ((pm_lines == null) || (linesqty == 0))
            return;

        int lineitr = 0;

        if (mbqty > 0)
        {
            for (int i = 0; i < mbqty; ++i)
            {
                if (menubutton[i] != null)
                {
                    Text buttontext = menubutton[i].GetComponentInChildren<Text>();

                    if(buttontext != null)
                    {
                        Button buttoncomp = menubutton[i].GetComponent<Button>();

                        if (buttoncomp != null)
                        {
                            if ((lineitr * 2) < linesqty)
                            {
                                print(lineitr * 2);
                                buttoncomp.interactable = true;
                                buttontext.text = pm_lines[(lineitr * 2)];
                                ++lineitr;
                            }
                            else
                            {
                                Image imagecomp = menubutton[i].GetComponent<Image>();
                                if(imagecomp != null)
                                    imagecomp.enabled = false;

                                buttoncomp.interactable = false;
                            }
                        }
                    }
                }
            }
        }
    }

    void UpdateDialogue()
    {
        if((dialoguebox != null) && (menubutton != null))
        {
            int lineitr = 0;
            int mbqty = menubutton.Length;
            for(int i = 0; i < mbqty; ++i)
            {
                if (menubutton[i] != null)
                {
                    Button buttoncomp = menubutton[i].GetComponent<Button>();

                    if (buttoncomp != null)
                    {

                    }
                }
            }

            Text dialoguetext = dialoguebox.GetComponent<Text>();
            if (dialoguetext != null)
                dialoguetext.text = pm_lines[(lineitr * 2) + 1];
        }
    }
    // Use this for initialization
    void Start ()
    {
        if(menubutton[0] != null)
        {
            Button button = menubutton[0].GetComponent<Button>();
            if(button != null)
            {
                button.Select();
            }
        }
        //hide the sprite which is only for visual cue
        //if (this.GetComponent<SpriteRenderer>() != null)
        //    this.GetComponent<SpriteRenderer>().enabled = false;

        depth = 0;

        ////verify content of every txt files
        //int txtqty = path.Length;
        //if (txtqty > 0)
        //{
        //    for (int i = 0; i < txtqty; ++i)
        //    {
        //        if (path[i] != null)
        //        {
        //            string text = path[i].text;
        //            //Split the whole thing whenever pointer encounters '\n';
        //            //count the number of lines.
        //            string[] lines = text.Split('\n');
        //            print(lines.Length);
        //        }

        //    }
        //}

        Vector3 nxtbutpos = new Vector3(0f, 0f, 0f);
        if (this.GetComponent<Transform>() != null)
            nxtbutpos = this.GetComponent<Transform>().position;
        else
            return;

        //Vector3 firstbutscale = new Vector3(0f, 0f, 0f);
        //if (mbqty > 0)
        //{
        //    for (int i = 0; i < mbqty; ++i)
        //    {
        //        if (menubutton[i] != null)
        //        {
        //            Transform transform = menubutton[i].GetComponent<Transform>();
        //            //09/08/2018
        //            //TODO(yunhyeok): Check if each of the elements in array
        //            //are unique elements; no duplicated buttons
        //            if (transform != null)
        //            {
        //                if (i == 0)
        //                    firstbutscale = transform.lossyScale;

        //                transform.position = nxtbutpos;
        //                //09/08/2018
        //                //TODO(yunhyeok): probably better to let y_offset be only positive
        //                nxtbutpos.y -= (firstbutscale.y + y_offset);
        //            }

        //        }
        //    }
        //}

        UpdateLines();

        UpdateButtons();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
