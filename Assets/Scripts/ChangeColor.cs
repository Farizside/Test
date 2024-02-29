using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color newColor;

    private SpriteRenderer _sprite;
    private bool _beingHandled = false;
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _sprite.color = newColor;
    }
    void Update()
    {
        if (!_beingHandled)
        {
            StartCoroutine(ChangesColor());
        }
    }

    IEnumerator ChangesColor()
    {
        _beingHandled = true;
        _sprite.color = Random.ColorHSV();
        yield return new WaitForSeconds(1);
        _beingHandled = false;
    }
}
