﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoConnect
{
  public Vector3 node1;
  public Vector3 node2;
  public Vector3 direction;

  public GizmoConnect(Node node1, Node node2)
  {
    this.node1 = node1.transform.position;
    this.node2 = node2.transform.position;

    this.node1.y = 1;
    this.node2.y = 1;

    direction = this.node1 - this.node2;

  }
}
