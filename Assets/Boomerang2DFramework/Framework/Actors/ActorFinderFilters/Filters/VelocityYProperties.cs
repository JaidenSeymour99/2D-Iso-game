﻿using Boomerang2DFramework.Framework.Actors.ActorFloatValues;

namespace Boomerang2DFramework.Framework.Actors.ActorFinderFilters.Filters {
	[System.Serializable]
	public class VelocityYProperties : ActorFinderFilterProperties {
		public ValueComparison Comparison;
		public ActorFloatValueConstructor Value;
	}
}