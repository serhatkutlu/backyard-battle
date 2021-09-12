using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefbs : MonoBehaviour
{
    const string master_volume_key = "master volume";
    const string difficult_key = "difficult";
    const float maxvolume=1,minvolume=0;
    const float maxdifficult = 2f, mindifficult= 0f;
    const string level = "level index";

    public static void setMasterVolume(float volume)
    {
        if (volume<=maxvolume&&volume>minvolume)
        {
            PlayerPrefs.SetFloat(master_volume_key, volume);
        }
    }
    public static float getMasterVolume()
    {
        return PlayerPrefs.GetFloat(master_volume_key);
    }
    public static void setDifficult(float value)
    {
        if (value <= maxdifficult && value >= mindifficult)
        {
            print(true);
            PlayerPrefs.SetFloat(difficult_key, value);
        }
    }
    public static float getDifficult()
    {
        return PlayerPrefs.GetFloat(difficult_key);
    }
    public static int setLevel()
    {
        if (!PlayerPrefs.HasKey(level))
        {
            PlayerPrefs.SetInt(level, 1);
        }
        int level›ndex= PlayerPrefs.GetInt(level);
        PlayerPrefs.SetInt(level,level›ndex+1);
        return PlayerPrefs.GetInt(level);
        
    }
    public static int getLevel()
    {
        if (!PlayerPrefs.HasKey(level))
        {
            PlayerPrefs.SetInt(level, 1);
        }
        return PlayerPrefs.GetInt(level);
    }
    public static int returnBeginLevel()
    {
        PlayerPrefs.SetInt(level, 1);
        return PlayerPrefs.GetInt(level);
    }
 

}
