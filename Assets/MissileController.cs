using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour {
  public float Speed = 2;

  private Vector2 _targetPoisition;

  // Start is called before the first frame update
  void Start() {
    _targetPoisition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector2 dir = _targetPoisition - (Vector2)this.transform.position;
    transform.up = dir;
  }

  // Update is called once per frame
  void Update() {
    float step = Speed * Time.deltaTime;

    transform.position = Vector2.MoveTowards(transform.position, _targetPoisition, step);
  }
}
