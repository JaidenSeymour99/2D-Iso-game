﻿using Boomerang2DFramework.Framework.Actors.ActorFloatValues;

namespace Boomerang2DFramework.Framework.Actors.ActorFinderFilters.Filters {
	[System.Serializable]
	public class PositionXProperties : ActorFinderFilterProperties {
		public ValueComparison Comparison;
		public ActorFloatValueConstructor Value;
	}
}