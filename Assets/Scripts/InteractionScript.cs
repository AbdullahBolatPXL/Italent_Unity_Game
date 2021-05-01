using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    public DialogManager dialogManager;
    public Dialog dialog;
    public Canvas canvas;
    
    void Start()
    {
        canvas.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
               
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        canvas.GetComponent<Canvas>().enabled = true;
        dialogManager.StartDialog(dialog);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        canvas.GetComponent<Canvas>().enabled = false;
    }


}
