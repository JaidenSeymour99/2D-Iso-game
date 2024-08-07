﻿using System;
using Boomerang2DFramework.Framework.StateManagement;

namespace Boomerang2DFramework.Framework.Actors.TriggerSystem.Triggers {
	[Serializable]
	public class FacingDirectionChanged : ActorTrigger {
		public override bool IsTriggered(Actor actor, State state) {
			return actor.FacingDirection != actor.PreviousFacingDirection;
		}
	}
}