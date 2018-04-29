using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBuildable  {

	void InstantiateObject(Vector3 position, GameObject parent);
}
