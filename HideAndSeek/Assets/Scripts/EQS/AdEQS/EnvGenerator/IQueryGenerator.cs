﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQueryGenerator
{
	//List<AEnvQueryItem> Item();
	AEnvQueryItem[,] Item();
}
