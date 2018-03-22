using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TransformEasing : MonoBehaviour
{
    public enum Value { position, rotation, scale }
    public Value value;
    public enum Type { EXPO, CIRC, QUINT, QUART, QUAD, SINE, BACK, BOUNCE, ELASTIC }
    public Type type;

    public Vector3 iniValue;
    public Vector3 finalValue;
    Vector3 deltaValue;
    public float currentTime;
    public float timeDuration;
    public float timeDelay;

    public bool pinpong;
    public bool restart;
    private bool timeForward = true;



    void Start()
    {
        deltaValue = finalValue - iniValue;
        currentTime = 0;
    }

    void Update()
    {
        if(currentTime <= timeDuration)
        {
            Vector3 easingValue = new Vector3();
            switch(type)
            {
                case Type.EXPO:
                    easingValue = new Vector3(
                        Easing.ExpoEaseInOut(currentTime, iniValue.x, deltaValue.x, timeDuration),
                        Easing.ExpoEaseInOut(currentTime, iniValue.y, deltaValue.y, timeDuration),
                        Easing.ExpoEaseInOut(currentTime, iniValue.z, deltaValue.z, timeDuration));
                    break;

                case Type.CIRC:
                    easingValue = new Vector3(
                        Easing.CircEaseInOut(currentTime, iniValue.x, deltaValue.x, timeDuration),
                        Easing.CircEaseInOut(currentTime, iniValue.y, deltaValue.y, timeDuration),
                        Easing.CircEaseInOut(currentTime, iniValue.z, deltaValue.z, timeDuration));
                    break;

                case Type.QUINT:
                    easingValue = new Vector3(
                        Easing.QuintEaseInOut(currentTime, iniValue.x, deltaValue.x, timeDuration),
                        Easing.QuintEaseInOut(currentTime, iniValue.y, deltaValue.y, timeDuration),
                        Easing.QuintEaseInOut(currentTime, iniValue.z, deltaValue.z, timeDuration));
                    break;

                case Type.QUART:
                    easingValue = new Vector3(
                        Easing.QuartEaseInOut(currentTime, iniValue.x, deltaValue.x, timeDuration),
                        Easing.QuartEaseInOut(currentTime, iniValue.y, deltaValue.y, timeDuration),
                        Easing.QuartEaseInOut(currentTime, iniValue.z, deltaValue.z, timeDuration));
                    break;

                case Type.QUAD:
                    easingValue = new Vector3(
                        Easing.QuadEaseInOut(currentTime, iniValue.x, deltaValue.x, timeDuration),
                        Easing.QuadEaseInOut(currentTime, iniValue.y, deltaValue.y, timeDuration),
                        Easing.QuadEaseInOut(currentTime, iniValue.z, deltaValue.z, timeDuration));
                    break;

                case Type.SINE:
                    easingValue = new Vector3(
                        Easing.SineEaseInOut(currentTime, iniValue.x, deltaValue.x, timeDuration),
                        Easing.SineEaseInOut(currentTime, iniValue.y, deltaValue.y, timeDuration),
                        Easing.SineEaseInOut(currentTime, iniValue.z, deltaValue.z, timeDuration));
                    break;

                case Type.BACK:
                    easingValue = new Vector3(
                        Easing.BackEaseInOut(currentTime, iniValue.x, deltaValue.x, timeDuration),
                        Easing.BackEaseInOut(currentTime, iniValue.y, deltaValue.y, timeDuration),
                        Easing.BackEaseInOut(currentTime, iniValue.z, deltaValue.z, timeDuration));
                    break;

                case Type.BOUNCE:
                    easingValue = new Vector3(
                        Easing.BounceEaseInOut(currentTime, iniValue.x, deltaValue.x, timeDuration),
                        Easing.BounceEaseInOut(currentTime, iniValue.y, deltaValue.y, timeDuration),
                        Easing.BounceEaseInOut(currentTime, iniValue.z, deltaValue.z, timeDuration));
                    break;

                case Type.ELASTIC:
                    easingValue = new Vector3(
                        Easing.ElasticEaseInOut(currentTime, iniValue.x, deltaValue.x, timeDuration),
                        Easing.ElasticEaseInOut(currentTime, iniValue.y, deltaValue.y, timeDuration),
                        Easing.ElasticEaseInOut(currentTime, iniValue.z, deltaValue.z, timeDuration));
                    break;
            }

            switch(value)
            {
                case Value.position:
                    transform.localPosition = easingValue;
                    break;
                case Value.rotation:
                    transform.localRotation = Quaternion.Euler(easingValue);
                    break;
                case Value.scale:
                    transform.localScale = easingValue;
                    break;
                default:
                    break;
            }

            currentTime += Time.deltaTime;

            if(currentTime > timeDuration)
            {
                switch(value)
                {
                    case Value.position:
                        transform.localPosition = finalValue;
                        break;
                    case Value.rotation:
                        transform.localRotation = Quaternion.Euler(finalValue);
                        break;
                    case Value.scale:
                        transform.localScale = finalValue;
                        break;
                    default:
                        break;
                }

                Debug.Log("El easing ha acabado");

                if(restart) currentTime = 0;

                else if(pinpong)
                {
                    currentTime = 0;
                    Vector3 ini = iniValue;
                    iniValue = finalValue;
                    finalValue = ini;
                    deltaValue = finalValue - iniValue;
                }
            }
        }

        else
        {
            Debug.Log("El easing hace un rato que ha acabado");
        }
    }

}