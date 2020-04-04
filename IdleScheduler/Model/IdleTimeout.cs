﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IdleScheduler
{
	class IdleTimeout : IDisposable
	{
		Action _disposeHandle;
		public IdleTimeout(Action disposeHandle) => _disposeHandle = disposeHandle;
		public void Dispose() => _disposeHandle?.Invoke();
	}
}
