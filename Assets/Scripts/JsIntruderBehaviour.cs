using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JsIntruderBehaviour : MonoBehaviour
{
    public Text persText;

    public void UpdatePersText(string newText){
    	persText.text = newText;
    }
}
