using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionscontroller : MonoBehaviour
{
    [SerializeField] Slider volume_slider;
    [SerializeField] float defaultvolume=0.8f;

    [SerializeField] Slider difficult_slider;
    [SerializeField] float default_difficult = 0f;
    // Start is called before the first frame update
    void Start()
    {
       
        volume_slider.value = playerprefbs.getMasterVolume();
        difficult_slider.value = playerprefbs.getDifficult();
    }

    // Update is called once per frame
    void Update()
    {
        var musicPlayer = FindObjectOfType<MUSÝCPLAYER>();
        if (musicPlayer)
        {
            musicPlayer.setvolume(volume_slider.value);
        }

        
    }
    public void saveAndExit()
    {
        playerprefbs.setMasterVolume(volume_slider.value);
        playerprefbs.setDifficult(difficult_slider.value);
        FindObjectOfType<levelloader>().mainmenu();
    }
    public void default_all()
    {
        volume_slider.value = defaultvolume;
        difficult_slider.value = default_difficult;
    }

}
