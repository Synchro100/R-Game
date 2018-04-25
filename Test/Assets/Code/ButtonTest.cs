using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour {
    public Text m_Text;
    Button m_Button;
    public GameObject m_Gameobj;
	// Use this for initialization
	void Start () {
        m_Button = this.GetComponent<Button>();
        m_Button = m_
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickEvent()
    {
        m_Text.text = "text";
        m_Button.colors = ColorBlock.defaultColorBlock;
    }
}
