using UnityEngine;
using UnityEngine.UI;

public class DaytoNight : MonoBehaviour
{
    public GameObject lightSwitcher;
    bool enabledDisabled = false;

    public void changeLight() {
        if(enabledDisabled == false) {
            lightSwitcher.SetActive(false);
            enabledDisabled = false;
        }
        else if(enabledDisabled == true) {
            lightSwitcher.SetActive(true);
            enabledDisabled = true;
        }
    }
}
