using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game.player;

public class BlinkRoutine {
    private MonoBehaviour controller;
    private SpriteRenderer spriteRenderer;
    private Collider2D collider;

    public BlinkRoutine(MonoBehaviour controller) {
        this.controller = controller;
        this.spriteRenderer = controller.GetComponent<SpriteRenderer>();
        this.collider = controller.GetComponent<Collider2D>();
    }

    public void start(int nTimes, float interval) {
        controller.StartCoroutine(blink(nTimes, interval));        
        controller.StartCoroutine(ethereal(nTimes * interval));
    }
    
    private IEnumerator blink(int nTimes, float interval) {
        while (nTimes > 0) {
            spriteRenderer.enabled = false;
            yield return new WaitForSeconds(interval);
            spriteRenderer.enabled = true;
            yield return new WaitForSeconds(interval);
            nTimes--;
        }
    }

    private IEnumerator ethereal(float duration) {
            collider.enabled = false;
            yield return new WaitForSeconds(duration);
            collider.enabled = true;
    }
}
