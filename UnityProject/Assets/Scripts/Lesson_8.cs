﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 01:30:28
 * Version: 1.0.4
 */

using UnityEngine;
using UnityEngine.UI;

/*
 * События OnCollision и OnTrigger 
 * проявляющееся на объекте Cube 
 * после соприкосновения с Wall 
 * и GameObject.Find
 */
public class Lesson_8 : MonoBehaviour
{
    public GameObject instObj;
    private int count = 0;
    [SerializeField]
    private float speed = 4f;
    private Text text;
    private float ZPos = .0f;

    private void Awake()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        text.text = $"{other.gameObject.name}  {count++}";
    }

    private void Update()
    {
        ZPos = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        instObj.transform.Translate(Vector3.forward * speed * ZPos);
    }
}
