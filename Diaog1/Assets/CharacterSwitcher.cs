using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterSwitcher : MonoBehaviour {
    [SerializeField]
    public Dropdown Switcher;
    [SerializeField]
    private Image NpcImg;

    [SerializeField]
    private Sprite character1;
    [SerializeField]
    private Sprite character2;
    [SerializeField]
    private Sprite character3;
    private string Character1Name = "Pingu";
    private string Character2Name = "Cleaning Liquid";
    [SerializeField]
    private Text characterName;
    void Start ()
    {
        
	}
	
	
	void Update ()
    {
        Debug.Log(Switcher.value);
        if (Switcher.value == 0)
        {
            NpcImg.sprite = character1;
            characterName.text = Character1Name;
        }
        else if (Switcher.value == 1)
        {
            NpcImg.sprite = character2;
            characterName.text = Character2Name;
        }
	}

}
