﻿using System;

namespace Component
{
	[AttributeUsage(AttributeTargets.Class)]
	public class HandlerAttribute : Attribute
	{
		public short Opcode { get; set; }
	}
}
