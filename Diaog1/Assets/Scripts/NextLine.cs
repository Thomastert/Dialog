using UnityEngine;
using System.Collections;

public class NextLine : MonoBehaviour {
    LineReader linereader;
    CharacterSwitcher charswitch;

	void Start ()
    {
        charswitch = GetComponent<CharacterSwitcher>();
        linereader = GetComponent<LineReader>();
	}
       
       public void NextButton()
    {
        if (charswitch.Switcher.value == 0)
        {
            linereader.lineNumberNpc1++;
        }
        if (charswitch.Switcher.value == 1)
        {
            linereader.lineNumberNpc2++;
        }
    }
}
