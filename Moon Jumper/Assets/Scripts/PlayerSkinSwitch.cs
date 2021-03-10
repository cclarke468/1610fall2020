using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerSkinSwitch : MonoBehaviour
{
    public enum SkinTextures
    {
        Astronaut,
        Worker,
        Farmer,
        Businessman
    }
    public SkinTextures currentSkinTexture = SkinTextures.Astronaut;

    public void RunCurrentSkinTexture()
    {
        switch (currentSkinTexture)
        {
            case SkinTextures.Astronaut:
                print("Astronaut");
                //add png for astronaut
                break;
            case SkinTextures.Worker:
                print("Worker");
                //png for worker
                break;
            case SkinTextures.Farmer:
                print("Farmer");
                //png for farmer
                break;
            case SkinTextures.Businessman:
                print("Businessman");
                break;
        }
    }
    public void ChangeSkinTexture(SkinTextures textureChange)
    {
        switch (currentSkinTexture) //if textureChange = Astronaut or Worker or Farmer or Businessman, change
        {
            case SkinTextures.Astronaut:
                print("Astronaut");
                currentSkinTexture = textureChange;
                RunCurrentSkinTexture();
                break;
            case SkinTextures.Worker:
                print("Worker");
                break;
            case SkinTextures.Farmer:
                print("Farmer");
                break;
            case SkinTextures.Businessman:
                print("Businessman");
                break;
        }
    }
}
